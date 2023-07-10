using DGVPrinterHelper;
using GonpaPasaportOtomasyonu;
using GonpaPasaportOtomasyonu.Models;
using GonpaPasaportOtomasyonu.Properties;
using GonpaPasaportOtomasyonu.Services;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.IdentityModel.Tokens;
using Modbus.Device;
using SATOPrinterAPI;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Main : Form
    {

        #region DEFINITIONS
        byte slaveAddress = 17;

        PassportDBContext context = new PassportDBContext();

        Printer SATOPrinter = new Printer();
        Printer.InterfaceType tCPIP = Printer.InterfaceType.TCPIP;

        private ModbusSerialMaster modbusMaster;

        SerialPort serialPort = new SerialPort();

        string data, dataOutBarcode;
        string label;

        //Input Barcode Reader
        private readonly int portNumber = 10004;

        //Output Barcode Reader
        private readonly int portNumberOutBarcode = 10004;

        //Printer
        private readonly int printerPort = 9100;

        private Socket clientSocket;
        private Socket clientSocket2;

        BackgroundWorker MachineConnectWorker;
        BackgroundWorker PassportTrackingThread;

        #region Check flags
        bool isEmergencyStop = false;
        bool isDoorOpen = false;
        bool isDrawerTopDoorOpen = false;
        bool isDrawer1Open = false;
        bool isDrawer2Open = false;
        bool isDrawer1Full = false;
        bool isDrawer2Full = false;
        bool isHWStop = false;
        bool isPLCConnected = false;
        bool isPrinterOnline = false;
        bool isMachineWorking = false;
        bool isLostProduct1 = false;
        bool isLostProduct2 = false;
        bool isSentPassport = false;
        bool isCrossCheck = false;
        #endregion

        public int PackMaxCount { get; set; }
        public int SucceedPassportCount { get; set; }
        private string sqlConnectionstring = "Server=localhost; Uid=sa; Password=Sb123456; Database=PassportDB; TrustServerCertificate=True";
        //private string sqlConnectionstring = @"Server=DESKTOP-HSU933P\SQLEXPRESS; Uid=sa; Password=Sb123456; Database=PassportDB; TrustServerCertificate=True";
        BlockingCollection<PassTrackDTO> ProcessPassportList = new BlockingCollection<PassTrackDTO>();
        ConcurrentQueue<PassTrackDTO> PassportTrackList = new ConcurrentQueue<PassTrackDTO>();
        public long LastSucceedPttBarcode { get; set; }
        #region Logger
        Logger log = new LoggerConfiguration().WriteTo.File(
        "logs\\Log.txt",
        rollingInterval: RollingInterval.Day,
        fileSizeLimitBytes: 20000000,
        rollOnFileSizeLimit: true,
        retainedFileCountLimit: null,
        shared: true,
        flushToDiskInterval: TimeSpan.FromSeconds(1),
        outputTemplate: "[{Timestamp:dd.MM.yyyy HH:mm:ss.fffff} {Level:u3}] {Message:lj}{NewLine}{Exception}").CreateLogger();
        #endregion

        long OutputEncoderLastPosition = 0;
        long EncoderThreshhold = 50;
        long OutputEncoderStepCount = 1100;
        int OutEncoderReadTimeSpan = 300; 
        int _ConveyourLongStep = 1000;
        int _ConveyourShortStep = 300;
        bool _StopMachineOnFinishPack = false;
        #endregion
        public Main()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //label1.Width= this.Width;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            Thread splashThread = new Thread(new ThreadStart(StartSplashForm));
            FormUserLogin loginForm = new FormUserLogin();
            var result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                int userType = loginForm.SelectedOption;

                if (userType == 0)
                {
                    buttonAyarlar.Visible = false;
                    tabControl1.TabPages.Remove(tabPage4);
                }
                else if (userType == 1)
                {
                    buttonAyarlar.Visible = true;
                }
            }
            splashThread.Start();

            CheckForIllegalCrossThreadCalls = false;

            sqlConnectionstring = Settings.Default.DBConnectionString;
            txtDbConnectionString.Text = sqlConnectionstring;
            ConnectToPlc();

            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += worker_DoWork;
            backgroundWorker1.WorkerSupportsCancellation = true;
            
            backgroundWorker2 = new BackgroundWorker();
            backgroundWorker2.DoWork += worker_DoWork2;
            backgroundWorker2.WorkerSupportsCancellation = true;

            MachineConnectWorker = new BackgroundWorker();
            MachineConnectWorker.DoWork += MachineReadWork;
            MachineConnectWorker.WorkerSupportsCancellation = true;

            PassportTrackingThread = new BackgroundWorker();
            PassportTrackingThread.DoWork += PassportTrackStart;
            PassportTrackingThread.WorkerSupportsCancellation = true;

            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.RunWorkerAsync();
            MachineConnectWorker.RunWorkerAsync();
            PassportTrackingThread.RunWorkerAsync();

            string ipAddress = Settings.Default.PrinterIpAddress;

            checkBoxPistonRunOption.Checked = Settings.Default.PistonRunOption; // piston run option saves to setting fil
            checkBoxConveyorVaccuum.Checked = Settings.Default.ConveyorVaccuum;
            textBoxBlowOffset.Text =    Settings.Default.BlowOffset.ToString(); // blow offset saves to setting file
            textBoxRejectInputTime.Text = Settings.Default.RejectInputTime.ToString(); // reject input time saves to setting file
            textBoxRejectOutTime.Text = Settings.Default.RejectOutputTime.ToString(); // reject out time saves to setting file
            textBoxDrawer1Mask.Text = Settings.Default.Drawer1SensorMask.ToString(); // drawer 1 mask saves to setting file
            textBoxDrawer2Mask.Text = Settings.Default.Drawer2SensorMask.ToString(); // drawer 2 mask saves to setting file
            textBoxPrinterIpAddress.Text = Settings.Default.PrinterIpAddress.ToString(); // printer ip address saves to setting file
            textBoxInputBarcodeIP.Text = Settings.Default.InputBarcodeIP.ToString(); // input barcode ip address saves to setting file
            textBoxOutputBarcodeIP.Text = Settings.Default.OutputBarcodeIP.ToString(); // output barcode ip address saves to setting file
            textBoxReject1BlowTime.Text = Settings.Default.Reject1BlowTime.ToString(); // reject 1 blow time saves to setting file
            textBoxReject2BlowTime.Text = Settings.Default.Reject2BlowTime.ToString(); // reject 2 blow time saves to setting file
            numericUpDownExternalConvStop.Text=Settings.Default.ExtConveyorStop.ToString(); // External conveyor stop pulse saves to setting file
            numericUpDownProductCount.Text=Settings.Default.ProductCount.ToString();
            nudEncoderReadTimeSpan.Value=Settings.Default.EncoderReadTimeSpan;
            nudEncoderStepCount.Value=Settings.Default.OutputEncoderStepCount;
            nudEncoderThreshold.Value=Settings.Default.EncoderStepThreshold;
            EncoderThreshhold = Settings.Default.EncoderStepThreshold;
            OutputEncoderStepCount = Settings.Default.OutputEncoderStepCount;
            OutEncoderReadTimeSpan = Settings.Default.EncoderReadTimeSpan;
            nudConveyourShortStep.Value = _ConveyourShortStep = Settings.Default.ConveyourShortStepSpan;
            nudConveyourLongStep.Value = _ConveyourLongStep = Settings.Default.ConveyourLongStepSpan;
            chkStopMachineOnFinish.Checked = _StopMachineOnFinishPack = Settings.Default.StopMachineOnFinishPack;
            PackMaxCount = Settings.Default.ProductCount;
            nudConveyorSpeed.Value = Settings.Default.ConveyorSpeed;
            nudVaccuumSpeed.Value = Settings.Default.VaccuumSpeed;

            #region is plc ready(M2 set)
            SendReadyToMachine();
            #endregion

            #region Drawer Top Door Status Control
            bool İsDrawerOpen = modbusMaster.ReadCoils(slaveAddress, 2068, 1)[0];
            if (İsDrawerOpen)
            {
                checkBoxDrawerDoor.Checked = true;
            } 
            else
            {
                checkBoxDrawerDoor.Checked = false;
            }
            #endregion

            CallDBProcedures();
            ConnectPrinter();
            FullCheckMachine();
            splashThread.Abort();
        }
        public void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            backgroundWorker1.CancelAsync();
            backgroundWorker2.CancelAsync();
            MachineConnectWorker.CancelAsync();
            PassportTrackingThread.CancelAsync();

            try
            {
                StopMachine();
                modbusMaster.WriteSingleCoil(slaveAddress, 2050, false); // M2 set send info of Program Online to plc 
            }
            catch (Exception)
            {
            }
        }

        bool isClearMachine= false;
        private void ClearLists()
        {
            ProcessPassportList.Take(ProcessPassportList.Count);
            PassportTrackList.Take(PassportTrackList.Count);
        }
        string GetPassportData()
        {
            var passNo = textBoxBarkodM.Text = textBoxBarkodM.Text.ToUpper();
            long lPttBarkod = 0;
            var isPttNo = Int64.TryParse(textBoxBarkodM.Text, out lPttBarkod);
            if (passNo.IsNullOrEmpty() || passNo.Length < 9)
            {
                MessageBox.Show("en az 9 karakter giriniz", "Pasaport No veya PTT Barkod uzunuluk hatası", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return string.Empty;
            }
            var ManuelPrint = context.PassportDetails.FirstOrDefault(p => p.PasaportNo == passNo || (isPttNo ? p.PttBarkod == lPttBarkod : false));

            string dataLabel = label;
            if (ManuelPrint != null)
            {
                dataLabel = System.IO.File.ReadAllText(@"C:\PHASE.txt");

                dataLabel = dataLabel.Replace("PttBarkod", ManuelPrint.PttBarkod.ToString());
                dataLabel = dataLabel.Replace("AliciAdSoyad1", ManuelPrint.AliciAdSoyad1);
                dataLabel = dataLabel.Replace("Alici2AdSoyad1", ManuelPrint.Alici2AdSoyad1);
                dataLabel = dataLabel.Replace("AliciAdres1", ManuelPrint.AliciAdres1);
                dataLabel = dataLabel.Replace("AliciAdres2", ManuelPrint.AliciAdres2);
                dataLabel = dataLabel.Replace("AliciAdres3", ManuelPrint.AliciAdres3);
                dataLabel = dataLabel.Replace("AliciCepTelefonu", ManuelPrint.AliciCepTelefonu);
                dataLabel = dataLabel.Replace("TeslimAlacakKisi1", ManuelPrint.TeslimAlacakKisi1);
                dataLabel = dataLabel.Replace("IadeAdresi1", ManuelPrint.IadeAdresi1);
                dataLabel = dataLabel.Replace("IadeAdresi2", ManuelPrint.IadeAdresi2);
                dataLabel = dataLabel.Replace("IadeAdresi3", ManuelPrint.IadeAdresi3);

                textBoxPTTBarkodM.Text = ManuelPrint.PttBarkod.ToString();
                textBoxAliciAdres1M.Text = ManuelPrint.AliciAdSoyad1;
                textBoxAliciAdSoyad1M.Text = ManuelPrint.AliciAdSoyad1;
                textBoxAliciAdSoyad2M.Text = ManuelPrint.Alici2AdSoyad1;
                textBoxAliciAdres1M.Text = ManuelPrint.AliciAdres1;
                textBoxAliciAdres2M.Text = ManuelPrint.AliciAdres2;
                textBoxAliciAdres3M.Text = ManuelPrint.AliciAdres3;
                textBoxTelM.Text = ManuelPrint.AliciCepTelefonu;
                textBoxTeslimAlacakKisiM.Text = ManuelPrint.TeslimAlacakKisi1;
                textBoxIadeAdresi1M.Text = ManuelPrint.IadeAdresi1;
                textBoxIadeAdresi2M.Text = ManuelPrint.IadeAdresi2;
                textBoxIadeAdresi3M.Text = ManuelPrint.IadeAdresi3;
                textBoxAliciAdres1M.Text = ManuelPrint.AliciAdres1;
                textBoxAliciAdres2M.Text = ManuelPrint.AliciAdres2;
                textBoxAliciAdres3M.Text = ManuelPrint.AliciAdres3;

                return dataLabel;

            }
            else
            {
                MessageBox.Show("Girilen barkod bulunamadı!");
                textBoxBarkodM.Text = "";
                return "";
            }
        }

        #region MACHINE COMMANDS
            bool StopMachine()
            {
                try
                {
                modbusMaster.WriteSingleCoil(slaveAddress, 1305, false); //Y31 reset

                modbusMaster.WriteSingleCoil(slaveAddress, 2064, true); //M16 set
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            private void ConnectToPlc()
            {
                try
                {
                    comboBoxPlcPort.Text = GonpaPasaportOtomasyonu.Properties.Settings.Default.PLCPort.ToString(); // plc port saves to setting file
                    serialPort = new SerialPort();
                    serialPort.PortName = comboBoxPlcPort.Text;
                    serialPort.BaudRate = 9600;
                    serialPort.Parity = System.IO.Ports.Parity.Even;
                    serialPort.StopBits = System.IO.Ports.StopBits.One;
                    serialPort.DataBits = 7;
                    serialPort.Handshake = System.IO.Ports.Handshake.None;
                    serialPort.ReadTimeout = 300;
                    serialPort.WriteTimeout = 300;
                    serialPort.Open();
                    modbusMaster = ModbusSerialMaster.CreateAscii(serialPort);
                }
                catch (Exception)
                {
                }
            }
            void SendReadyToMachine()
            {
                try
                {
                    modbusMaster.WriteSingleCoil(slaveAddress, 2050, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Makine bağlantısı kurulamadı, Lütfen bağlantıları kontrol edip 'Alarmları Temizle' butonuna basınız.");
                }
            }
            private void DataNo()
            {
                try
                {
                    modbusMaster.WriteSingleCoil(slaveAddress, 2054, true); //M6 set
                    log.Information("No read komutu gönderildi");
                }
                catch
                {
                }
            }
            private void Printlabel(string labelData)
            {
                try
                {
                    byte[] labelBytes = Encoding.UTF8.GetBytes(labelData);
                    SATOPrinter.Send(labelBytes);
                }
                catch (Exception ex)
                {
                    AddLog($"Yazıcıya veri gönderim hatası");
                    StopMachine();
                }
            }

        private void PrintManuellabel(string labelData)
        {
            try
            {
                byte[] labelBytes = Encoding.UTF8.GetBytes(labelData);
                SATOPrinter.Send(labelBytes);
            }
            catch (Exception ex)
            {
                AddLog($"Yazıcıya veri gönderim hatası");
                StopMachine();
            }
        }
            private void DriveOutputConveyourShort()
            {
                //Harici konveyör kısa adım çalıştırma
                modbusMaster.WriteSingleCoil(slaveAddress, 2067, true);// M19 set(ExternalConveyorShortStep)
            }
        #endregion

        #region Kontrol Methodları

        //Giriş barkod okuyucu
        bool CheckInputBarcodeReader()
        {
            if (clientSocket == null)
            {
                InvokeDefine(() => stsInputBarcodeReader.BackColor = Color.LightCoral);
                AddLog("Giriş barkod okuyucu ile bağlantı kurulamadı.");
                return false;
            }

            var connection = clientSocket.IsBound;
            if (connection)
            {
                // Giriş barkod okuyucu bağlantısı var
                InvokeDefine(() => stsInputBarcodeReader.BackColor = Color.YellowGreen);
                return true;
            }
            else
            {
                // Giriş barkod okuyucu bağlantısı yok
                InvokeDefine(() => stsInputBarcodeReader.BackColor = Color.LightCoral);
                AddLog("Giriş barkod okuyucu ile bağlantı kurulamadı.");
                return false;
            }
        }

        // Yazıcı
        bool CheckPrinter()
        {
            try
            {
                // SATOPrinter.Connect();
                isPrinterOnline = SATOPrinter.GetPrinterStatus().IsOnline;
                if (!isPrinterOnline)
                {
                    InvokeDefine(() => stsPrinter.BackColor = Color.LightCoral);
                    AddLog("Yazıcı şuanda aktif değil");
                    modbusMaster.WriteSingleCoil(slaveAddress, 2052, false);
                    return false;
                }
                else
                {
                    InvokeDefine(() => stsPrinter.BackColor = Color.YellowGreen);
                    modbusMaster.WriteSingleCoil(slaveAddress, 2052, true);
                    return true;
                }
            }
            catch (Exception ex)
            {
                InvokeDefine(() => stsPrinter.BackColor = Color.LightCoral);
                AddLog("Yazıcı bağlantısı kurulamıyor");
                modbusMaster.WriteSingleCoil(slaveAddress, 2052, false);
                return false;
            }
        }

        bool ConnectPrinter()
        {
            try
            {
                SATOPrinter.TCPIPAddress = Settings.Default.PrinterIpAddress;
                SATOPrinter.TCPIPPort = "9100";
                SATOPrinter.Interface = Printer.InterfaceType.TCPIP;
                SATOPrinter.Connect();
                var status = SATOPrinter.GetPrinterStatus();
                if (status.IsOnline)
                {
                    InvokeDefine(() => stsPrinter.BackColor = Color.YellowGreen);
                    return true;

                }
                InvokeDefine(() => stsPrinter.BackColor = Color.LightCoral);
                return false;
            }
            catch (Exception ex)
            {
                InvokeDefine(() => stsPrinter.BackColor = Color.LightCoral);
                AddLog("Yazıcı bağlantısı kurulamıyor");
                return false;
            }
        }
        // Çıkış barkod okuyucu
        bool CheckOutputBarcodeReader()
        {
            if (clientSocket2 == null)
            {
                InvokeDefine(() => stsInputBarcodeReader.BackColor = Color.LightCoral);
                AddLog("Çıkış barkod okuyucu ile bağlantı kurulamadı.");
                return false;
            }
            var connection = clientSocket2.IsBound;
            if (connection)
            {
                // Giriş barkod okuyucu bağlantısı var
                InvokeDefine(() => stsInputBarcodeReader.BackColor = Color.YellowGreen);
                return true;
            }
            else
            {
                // Giriş barkod okuyucu bağlantısı yok
                InvokeDefine(() => stsInputBarcodeReader.BackColor = Color.LightCoral);
                AddLog("Çıkış barkod okuyucu ile bağlantı kurulamadı.");
                return false;
            }

        }
        // Makine Bağlantısı (PLC)
        bool CheckPLCConnection()
        {
            try
            {
                bool status = modbusMaster.ReadCoils(slaveAddress, 3048, 1)[0];//M1000 kontrol ediliyor


                if (!status)
                {
                    InvokeDefine(() =>
                    {
                        stsDoors.BackColor = Color.LightCoral;
                        stsDrawerTopDoor.BackColor = Color.LightCoral;
                        stsDrawer1.BackColor = Color.LightCoral;
                        stsDrawer2.BackColor = Color.LightCoral;
                        stsLine.BackColor = Color.LightCoral;
                        stsOutput.BackColor = Color.LightCoral;
                        stsInputBarcodeReader.BackColor = Color.LightCoral;
                        stsOutputBarcodereader.BackColor = Color.LightCoral;
                        stsPackMac.BackColor = Color.LightCoral;
                        ledBulbPLCOepn.Color = Color.Red;
                    });

                    AddLog("Makine bağlantısı yoktur.");
                    isPLCConnected = false;
                    return false;
                }
                else
                {
                    isPLCConnected = true;
                    ledBulbPLCOepn.Color = Color.Green;
                    return true;
                }
            }
            catch (Exception)
            {
                InvokeDefine(() =>
                {
                    stsDoors.BackColor = Color.LightCoral;
                    stsDrawerTopDoor.BackColor= Color.LightCoral;
                    stsDrawer1.BackColor = Color.LightCoral;
                    stsDrawer2.BackColor = Color.LightCoral;
                    stsLine.BackColor = Color.LightCoral;
                    stsOutput.BackColor = Color.LightCoral;
                    stsInputBarcodeReader.BackColor = Color.LightCoral;
                    stsOutputBarcodereader.BackColor = Color.LightCoral;
                    stsPackMac.BackColor = Color.LightCoral;
                    ledBulbPLCOepn.Color = Color.Red;
                });

                AddLog("Makine ile bağlantı kurulamadı.");
                isPLCConnected = false;
                return false;
            }
        }

        // Kapaklar
        private void sorgu()
        {
            if (isPLCConnected)
            {
                try
                {
                    bool M1000 = modbusMaster.ReadCoils(slaveAddress, 3048, 1)[0];
                    if (M1000)
                    {
                        InvokeDefine(()=> ledBulbPLCOepn.Color = Color.Green);
                    }
                    else
                    {
                        InvokeDefine(() => ledBulbPLCOepn.Color = Color.Red);

                        return;
                    }

                    #region Encoder Value
                    var c251 = modbusMaster.ReadHoldingRegisters(slaveAddress, 4096, 4); //C251 encoder değeri için D0 okunuyor
                    var encC251Byte = BitConverter.GetBytes(c251[0]);
                    var encC251Byte2 = BitConverter.GetBytes(c251[1]);
                    byte[] lenghtArrayC251 = new byte[8];
                    Array.Copy(encC251Byte, 0, lenghtArrayC251, 0, 2);
                    Array.Copy(encC251Byte2, 0, lenghtArrayC251, 2, 2);
                    var encoderPositionC251 = BitConverter.ToInt64(lenghtArrayC251, 0);
                    InvokeDefine(() => { textBoxEncoderC251.Text = encoderPositionC251.ToString(); });
                    #endregion

                    #region Counter
                    var D600 = modbusMaster.ReadHoldingRegisters(slaveAddress, 4696, 4); //D600 sayaç değeri okunuyor
                    var D600Byte = BitConverter.GetBytes(D600[0]);
                    var D600Byte2 = BitConverter.GetBytes(D600[1]);
                    byte[] lenghtArrayD600 = new byte[8];
                    Array.Copy(D600Byte, 0, lenghtArrayD600, 0, 2);
                    Array.Copy(D600Byte2, 0, lenghtArrayD600, 2, 2);
                    var counterD600 = BitConverter.ToInt64(lenghtArrayD600, 0);
                    InvokeDefine(() => { textBoxCounter.Text = counterD600.ToString(); });
                    #endregion

                    //Makine Çalışıyor mu
                    bool M0 = modbusMaster.ReadCoils(slaveAddress, 2048, 1)[0];
                    if (M0)
                    {
                        // Çalışıyor
                        if (!isMachineWorking)
                        {
                            isMachineWorking = true;
                            MachineWorkingStateChanged(true);
                        }
                    }
                    else
                    {
                        // çalışmıyor
                        if (isMachineWorking)
                        {
                            isMachineWorking = false;
                            MachineWorkingStateChanged(false);
                        }
                    }

                    bool X23 = modbusMaster.ReadInputs(slaveAddress, 1043, 1)[0];
                    if (!X23)
                    {   //"acil stop basılı"
                        if (!isEmergencyStop)
                        {
                            //textBoxEmergencyStopActive.Visible = true;
                            InvokeDefine(() =>
                            {
                                stsDoors.BackColor = Color.LightCoral;
                                stsDrawerTopDoor.BackColor = Color.LightCoral;
                                stsDrawer1.BackColor = Color.LightCoral;
                                stsDrawer2.BackColor = Color.LightCoral;
                                stsLine.BackColor = Color.LightCoral;
                                stsOutput.BackColor = Color.LightCoral;
                                stsInputBarcodeReader.BackColor = Color.LightCoral;
                                stsOutputBarcodereader.BackColor = Color.LightCoral;
                                stsPackMac.BackColor = Color.LightCoral;
                            });
                            AddLog("Acil Stop butonuna basıldı.");
                            isEmergencyStop = true;
                        }
                    }   

                    bool M209 = modbusMaster.ReadInputs(slaveAddress, 2257, 1)[0];
                    if (M209)
                    {   //"ön kapı açık"
                        if (!isDoorOpen)
                        {
                            InvokeDefine(() => stsDoors.BackColor = Color.LightCoral);
                            AddLog("Ön kapak açıldı.");
                            isDoorOpen = true;
                        }

                    }

                    bool M211 = modbusMaster.ReadInputs(slaveAddress, 2259, 1)[0];
                    if (M211)
                    {   //"Tahliye çekmecesi üst kapı açık"
                        if (!isDrawerTopDoorOpen)
                        {
                            InvokeDefine(() => stsDrawerTopDoor.BackColor = Color.LightCoral);
                            AddLog("Tahliye çekmecesi üst kapağı açıldı.");
                            isDrawerTopDoorOpen = true;
                        }

                    }

                    bool M203 = modbusMaster.ReadInputs(slaveAddress, 2251, 1)[0];
                    if (M203)
                    {
                        //"1. çekmece açık";
                        if (!isDrawer1Open)
                        {
                            InvokeDefine(() => stsDrawer1.BackColor = Color.LightCoral);
                            AddLog("1. Tahliye Çekmecesi açıldı.");
                            isDrawer1Open = true;
                        }

                    }

                    bool M204 = modbusMaster.ReadInputs(slaveAddress, 2252, 1)[0];
                    if (M204)
                    {
                        //"2. çekmece açık";
                        if (!isDrawer2Open)
                        {
                            InvokeDefine(() => stsDrawer2.BackColor = Color.LightCoral);
                            AddLog("2. Tahliye Çekmecesi açıldı.");
                            isDrawer2Open = true;
                        }

                    }

                    bool M201 = modbusMaster.ReadCoils(slaveAddress, 2249, 1)[0];
                    if (M201)
                    {
                        //"1. çekmece dolu";
                        if (!isDrawer1Full)
                        {
                            InvokeDefine(() => stsDrawer1.BackColor = Color.LightYellow);
                            AddLog("1. Tahliye çekmecesi dolu.");
                            isDrawer1Full = true;
                        }

                    }
                    bool M202 = modbusMaster.ReadCoils(slaveAddress, 2250, 1)[0];
                    if (M202)
                    {
                        //"2. çekmece dolu";
                        if (!isDrawer2Full)
                        {
                            InvokeDefine(() => stsDrawer2.BackColor = Color.LightYellow);
                            AddLog("2. Tahliye çekmecesi dolu.");
                            isDrawer2Full = true;
                        }
                    }

                    bool M205 = modbusMaster.ReadCoils(slaveAddress, 2253, 1)[0];
                    if (M205) 
                    {
                        //Kayıp ürün 1
                        if (!isLostProduct1)
                        {
                            AddLog("Makine üzerinde 1. ürün kayıp.");
                            isLostProduct1 = true; 
                        }
                    }

                    bool M206 = modbusMaster.ReadCoils(slaveAddress, 2254, 1)[0];
                    if (M206)
                    {
                        //Kayıp ürün 2
                        if (isLostProduct2)
                        {
                            AddLog("Makine üzerinde 2. ürün kayıp.");
                            isLostProduct2 = true;
                        }
                    }

                    bool M9 = modbusMaster.ReadCoils(slaveAddress, 2057, 1)[0];
                    if (M9)
                    {
                        SetCurrentPassportToRejected();
                    }

                    bool X21 = modbusMaster.ReadInputs(slaveAddress, 1041, 1)[0];
                    if (!X21)
                    {
                        //stop butonuna basıldı
                        if (isHWStop)
                        {
                            InvokeDefine(() => stsDrawer2.BackColor = Color.LightYellow);
                            AddLog("Makinenin Durdurma (Stop) Butonuna basıldı");
                            isHWStop = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    isPLCConnected = false;
                    CheckPLCConnection();
                }
            }
        }

        private void MachineWorkingStateChanged(bool v)
        {
            // makinenin çalışma durumu değişti.
            if (v)
            {
                // Çalışıyor
                InvokeDefine(() => { ledBulbWorkState.Color = Color.Green;
                    labelMachineWorkingState.Text = "Makine Çalışıyor";
                });
            }
            else
            {
                // Çalışmıyor
                InvokeDefine(() => { ledBulbWorkState.Color = Color.Red;
                    labelMachineWorkingState.Text = "Makine Durdu";
                    buttonElilePasaportGirisi.Enabled = true;
                    buttonDatabaseProcess.Enabled = true;
                    buttonAyarlar.Enabled = true;
                });
            }
        }

        // FULL CHECK

        void FullCheckMachine()
        {
            if (CheckPLCConnection())
            {
                CheckInputBarcodeReader();
                CheckOutputBarcodeReader();
                CheckPrinter();
            }
            else
            {
                InvokeDefine(() =>
                {
                    ledBulbWorkState.Color = Color.Red;
                    buttonElilePasaportGirisi.Enabled = true;
                    buttonDatabaseProcess.Enabled = true;
                    buttonAyarlar.Enabled = true;
                });
            }
        }
        #endregion

        #region Paket işlemleri

        private void Listing(PassTrackDTO dto)
        {
            try
            {
                PassportTrackList.Enqueue(dto);

                bool res = ProcessPassportList.TryAdd(dto);
                if (!res)
                {
                    AddLog($"Pasaport listeye eklenemedi: {dto.PassportNo}");
                }
            }
            catch (Exception)
            {
                AddLog("Pasaport listeye eklenemedi");
            }
            // ProcessPassportList.CompleteAdding();
        }

        private void CheckPackEnd()
        {
            if (SucceedPassportCount >= PackMaxCount)
            {
                FinishPack();
            }
        }

        private void FinishPack()
        {
            try
            {
                
                Task.Run(() => {
                    if (_StopMachineOnFinishPack)
                    {
                        StopMachine();
                    }
                    // TODO: Makineye paketin bittiğini gönder
                    // TODO: Takip sayısı resetlenecek
                    // ExternalConveyor();
                    // Veri tabanında paket kodunu işle
                    var batchCode = Guid.NewGuid().ToString();
                    var BatchDate = DateTime.Now;
                    var batchCount = SucceedPassportCount;
                    UpdateOutputPassCount(0);

                    log.Warning($"Paket Bitirildi");
                    // Ekrana uyarı
                    AddLog($"Paket bitirildi, Sayı:{batchCount}, Paket Kodu {batchCode}");


                    #region OLEDB Test
                    using (var con = new SqlConnection(sqlConnectionstring))
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.Connection = con;
                        cmd.CommandText = $"Update PassportDetails Set BatchCode = '{batchCode}' Where Sent =1 and BatchCode is null";

                        var reader = cmd.ExecuteNonQuery();
                        if (reader == 0)
                        {
                            if (!isSentPassport)
                            {
                                log.Warning($" Gönderime hazır Pasaport bulunamadı");
                                // Ekrana uyarı
                                AddLog("Gönderime hazır Pasaport bulunamadı");
                                isSentPassport = true;
                            }
                            return;
                        }
                        log.Information($" Gönderime hazır Pasaportlar BatchCode ile işaretlendi");
                        var comCreateBatch = $"INSERT INTO [dbo].[Batches] " +
                       "([BatchCode]     " +
                       ",[PassportCount] " +
                       ",[State]         " +
                       ",[CreationDate]  " +
                       ",[CreateDate]    " +
                       ",[UpdateDate])    " +
                  "VALUES " +
                       $" ('{batchCode}' " +
                       $" ,{reader} " +
                       " ,3 " +
                       $" ,'{BatchDate.ToString("yyyy-MM-dd HH:mm:ss.fff")}'" +
                       $" ,'{BatchDate.ToString("yyyy-MM-dd HH:mm:ss.fff")}'" +
                       $" ,'{BatchDate.ToString("yyyy-MM-dd HH:mm:ss.fff")}')";

                        SqlCommand cmdBatch = con.CreateCommand();
                        cmdBatch.Connection = con;
                        cmdBatch.CommandText = comCreateBatch;

                        var crBatch = cmdBatch.ExecuteNonQuery();
                        if (crBatch == 0)
                        {
                            log.Warning($" Pasaportlara ait batch oluşturulamadı");
                            // Ekrana uyarı
                            AddLog("Pasaportlara ait batch oluşturulamadı");
                            return;
                        }
                    }
                    var reportPath = $"C:/BitenIsler/{DateTime.Now.ToString("dd.MM.yyyy")}/{DateTime.Now.ToString("ddMMyyyyHHmmss")}.xlsx";
                    ReportService.ExportBatch("Paket_Bilgi", new Batches()
                    {
                        BatchCode = batchCode,
                        CreationDate = BatchDate,
                        PassportCount = batchCount,
                        CreateDate = BatchDate
                    }, reportPath);
                    SendToPrinter(reportPath);
                    #endregion
                });
            }
            catch (Exception ex)
            {
                log.Error(ex,$" Paket bitirilirken hata alındı");

            }
        }
        private void SendToPrinter(string filepath)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = filepath;
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(3000);
            if (false == p.CloseMainWindow())
                p.Kill();
        }
        bool DriveOutputConveyourLong()
        {
            //2.hızda harici konveyörü çalıştırarak pasaportların arasını aç
            try
            {
                    modbusMaster.WriteSingleCoil(slaveAddress,2066, true);//M18 set(ExternalConveyorLongStep) 

                    return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void UpdateOutputPassCount(int? v = null)
        {
            if (v != null)
            {
                SucceedPassportCount = v.Value;
            }
            else
            {
                SucceedPassportCount++;
            }
            if(SucceedPassportCount >= PackMaxCount)
            {
                // Paket Bitimi
                DriveOutputConveyourLong();
            }

            InvokeDefine(() => {
                txtOutPassCount.Text = SucceedPassportCount.ToString();
            });
        }

        void SetCurrentPassportToRejected()
        {
            // Son başarılı ptt barkodlu pasaportu veri tabanında Sent = 0 yap
            try
            {
                using (var con = new SqlConnection(sqlConnectionstring))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.Connection = con;
                    cmd.CommandText = $"Update PassportDetails Set Sent = 0 Where PttBarkod = '{LastSucceedPttBarcode}'";

                    var reader = cmd.ExecuteNonQuery();
                    if (reader == 0)
                    {
                        log.Error($"{LastSucceedPttBarcode} PTT barkodlu pasaport hatalı olarak işaretlendi.");
                        AddLog($"{LastSucceedPttBarcode} PTT barkodlu pasaport hatalı olarak işaretlendi,beklenmedik ürün.");
                    }
                }
            }
            catch (Exception ex)
            {
                // kayıt güncelleme başarısız
                log.Error(ex,$"{LastSucceedPttBarcode} PTT barkodlu pasaport hatalı olarak işaretlenirken hata alındı.");
            }
        }
        #endregion

        #region Utils
        private void InvokeDefine(Action a)
        {
            this.BeginInvoke(new MethodInvoker(a));

        }
        void AddLog(string logtxt)
        {
            InvokeDefine(() => { 
                lstLog.BackColor = Color.LightCoral;
                lstLog.ForeColor = Color.White;
                lstLog.Items.Insert(0,logtxt);});
        }
        void AddInfoLog(string logtxt)
        {
            InvokeDefine(() => {
                lstLog.Items.Insert(0,logtxt);
            });
        }      

        void CallDBProcedures()
        {
            try
            {
                using (var con = new SqlConnection(sqlConnectionstring))
                {
                    con.Open();
                    using (var command = new SqlCommand("SP_ClearDbBatches", con) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        var eff1 = command.ExecuteNonQuery();
                    }
                    using (var command = new SqlCommand("SP_ClearDbDaily", con) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        var eff2 = command.ExecuteNonQuery();
                    }
                    using (var command = new SqlCommand("SP_ClearDbArchive", con) { CommandType = System.Data.CommandType.StoredProcedure })
                    {
                        var eff3 = command.ExecuteNonQuery();
                    }

                    //MessageBox.Show("Veri tabanı temizleme işlemi tamamlandı", "Başarılı ışlem",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    AddLog("Veri tabanı temizleme işlemi tamamlandı");
                }
            }
            catch (Exception ex)
            {
                log.Error(ex,"Veri tabanı temizleme işleminde hata alındı");
                AddLog("Veri tabanı temizleme işleminde hata alındı");
                MessageBox.Show("Veri tabanı temizleme işleminde hata alındı", "Başarısız işlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearProcessList()
        {
            try
            {
                while (ProcessPassportList.Count > 0)
                {
                    var x = ProcessPassportList.Take();
                }
            }
            catch (Exception)
            {
            }
        }

        private void StartSplashForm()
        {
            Application.Run(new SplashForm());
        }
        private void comboBoxPlcPort_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPlcPort.Items.Clear();
            foreach (string comport in ports)
            {
                comboBoxPlcPort.Items.Add(comport);
            }
        }

        private void txtSearchBatchCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearchDb_Click(sender, e);
            }
        }

        private void txtSearchSinglePassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearchSinglePassport_Click(sender, e);
            }
        }

        private void txtSearchBatchList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearchBatchCode_Click(sender, e);
            }
        }

        void ClearLog()
        {
            // Kontrol flagleri resetleniyor
            isEmergencyStop = false;
            isDoorOpen = false;
            isDrawerTopDoorOpen = false;
            isDrawer1Open = false;
            isDrawer2Open = false;
            isDrawer1Full = false;
            isDrawer2Full = false;
            isHWStop = false;
            isLostProduct1=false;
            isLostProduct2=false;
            isSentPassport = false;
            InvokeDefine(() => {
                lstLog.BackColor = Color.White;
                lstLog.ForeColor = Color.Black;
                lstLog.Items.Clear();
                lstLog.Refresh();
            });
        }
        #endregion

        #region WORKER THREADS
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {

            log.Information("////////////////////////////// Yeni ış ////////////////////////////////");

            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.NoDelay = true;
            string ipAddressInputBarcode = GonpaPasaportOtomasyonu.Properties.Settings.Default.InputBarcodeIP;

            IPAddress ipAddressObj = IPAddress.Parse(ipAddressInputBarcode);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddressObj, portNumber);
            clientSocket.Connect(ipEndPoint);

            byte[] buffer = new byte[1024];

            label = File.ReadAllText(@"C:\PHASE.txt");
            #region OLEDB Test
            //SqlConnection con = new SqlConnection(sqlConnectionstring);

            //con.Open();
            #endregion
            while (!backgroundWorker1.CancellationPending)
            {
                try
                {
                    log.Information("bekliyor");
                    int bytesRead = clientSocket.Receive(buffer);
                    log.Information(" Mesaj alındı");

                    // Encoder değeri Al 
                    #region Giriş Encoder Değeri
                    long EncoderPosition = 0;
                    var InputEncoderValues = modbusMaster.ReadHoldingRegisters(slaveAddress, 4796, 4); //D700 encoder değeri alınıyor

                    var encByte = BitConverter.GetBytes(InputEncoderValues[0]);
                    var encByte2 = BitConverter.GetBytes(InputEncoderValues[1]);
                    byte[] lenghtArray = new byte[8];
                    Array.Copy(encByte, 0, lenghtArray, 0, 2);
                    Array.Copy(encByte2, 0, lenghtArray, 2, 2);
                    EncoderPosition = BitConverter.ToInt64(lenghtArray, 0); 
                    #endregion

                    data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    string dataSubs = data.TrimEnd('\r', '\n');
                    string dataIndex = dataSubs.Split('>', '<')[8];

                    byte[] dataConvert = Convert.FromBase64String(dataIndex);
                    string decodedData = Encoding.UTF8.GetString(dataConvert);
                    log.Information($"- Barkoddan okunan - {decodedData}");

                    if (decodedData.IsNullOrEmpty())
                    {
                        InvokeDefine(() => {
                            txtInputBReader.Text = "-";
                        });
                        Listing(new PassTrackDTO() { EncoderPosition = EncoderPosition, PassportNo = "No Read", PttBarcode = 0 });
                        log.Information($" - Barkod okunamadı - {decodedData}-{EncoderPosition}");
                        InvokeDefine(() => lstLog.Items.Insert(0, $" - Barkod okunamadı"));
                    }
                    else
                    {
                        InvokeDefine(() => lstLog.Items.Insert(0, $" - Barkod okundu - {decodedData}-{EncoderPosition}"));
                        InvokeDefine(() => {
                            txtInputBReader.Text = decodedData;
                        });
                        log.Information($" -  Barkod okundu - {decodedData}");

                        var input = new PassportDetails();
                        // input = context.PassportDetails.AsNoTracking().FirstOrDefault(p => p.PasaportNo == decodedData);

                        #region OLEDB TEST
                        using (var con = new SqlConnection(sqlConnectionstring))
                        {
                            con.Open(); 
                            //if (!(con.State == System.Data.ConnectionState.Open))
                            //{
                            //    switch (con.State)
                            //    {
                            //        case System.Data.ConnectionState.Closed:
                            //            con.Open();

                            //            break;
                            //        case System.Data.ConnectionState.Connecting:
                            //        case System.Data.ConnectionState.Executing:
                            //        case System.Data.ConnectionState.Fetching:
                            //            con.Close();
                            //            con.Open();
                            //            break;
                            //        case System.Data.ConnectionState.Broken:
                            //            con.Open();

                            //            break;
                            //        default:
                            //            break;
                            //    }
                            //}
                            SqlCommand cmd = con.CreateCommand();
                            cmd.Connection = con;
                            cmd.CommandText = $"Select * from PassportDetails Where PasaportNo = '{decodedData}'";

                            var reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                input.AliciAdSoyad1 = Convert.ToString(reader["AliciAdSoyad1"]);
                                input.Alici2AdSoyad1 = Convert.ToString(reader["Alici2AdSoyad1"]);
                                input.AliciAdres1 = Convert.ToString(reader["AliciAdres1"]);
                                input.AliciAdres2 = Convert.ToString(reader["AliciAdres2"]);
                                input.AliciAdres3 = Convert.ToString(reader["AliciAdres3"]);
                                input.AliciCepTelefonu = Convert.ToString(reader["AliciCepTelefonu"]);
                                input.TeslimAlacakKisi1 = Convert.ToString(reader["TeslimAlacakKisi1"]);
                                input.IadeAdresi1 = Convert.ToString(reader["IadeAdresi1"]);
                                input.IadeAdresi2 = Convert.ToString(reader["IadeAdresi2"]);
                                input.IadeAdresi3 = Convert.ToString(reader["IadeAdresi3"]);
                                long ptt = 0;
                                var conres = Int64.TryParse(reader["PttBarkod"].ToString(), out ptt);
                                if (conres)
                                input.PttBarkod = ptt;
                            }
                            reader.Close();
                        }
                        #endregion

                        log.Information($" - Data alındı  - {decodedData}-{EncoderPosition}");


                        string labData = label;
                        if (input.PttBarkod != null && input.PttBarkod != 0)
                        {
                            log.Information($" - Veri işleniyor  - {decodedData}-{EncoderPosition}");


                            labData = labData.Replace("PttBarkod", input.PttBarkod.ToString())
                                             .Replace("AliciAdSoyad1", input.AliciAdSoyad1)
                                             .Replace("Alici2AdSoyad1", input.Alici2AdSoyad1)
                                             .Replace("AliciAdres1", input.AliciAdres1)
                                             .Replace("AliciAdres2", input.AliciAdres2)
                                             .Replace("AliciAdres3", input.AliciAdres3)
                                             .Replace("AliciCepTelefonu", input.AliciCepTelefonu)
                                             .Replace("TeslimAlacakKisi1", input.TeslimAlacakKisi1)
                                             .Replace("IadeAdresi1", input.IadeAdresi1)
                                             .Replace("IadeAdresi2", input.IadeAdresi2)
                                             .Replace("IadeAdresi3", input.IadeAdresi3);

                            log.Information($" - Veri işlendi  - {decodedData}-{EncoderPosition}");


                            Listing(new PassTrackDTO() { PassportNo = input.PasaportNo, PttBarcode = input.PttBarkod.Value, EncoderPosition = EncoderPosition });
                            log.Information($" - Etiket basılıyor - {decodedData}-{EncoderPosition}");

                            Printlabel(labData);
                            InvokeDefine(() => {
                                txtPrinterBox.Text = decodedData;
                            });
                            log.Information($" - Etiket basıldı- {decodedData}-{EncoderPosition}");
                        }
                        else
                        {
                            InvokeDefine(() => {
                                txtInputBReader.Text = "-";
                            });
                            Listing(new PassTrackDTO() { PassportNo = "No Read", PttBarcode = 0, EncoderPosition = EncoderPosition });

                            log.Information($" - Pasaport veritabanında yok, pasaport atıldı - {decodedData}-{EncoderPosition}");
                            AddLog("Pasaport verisi veritabanında bulunamadı");
                            DataNo();
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex, "Ana döngüde hata alındı");
                    AddLog("Ana döngüde hata alındı");
                }
            }
        }
        private void worker_DoWork2(object sender, DoWorkEventArgs e)
        {
            clientSocket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            string ipAddressOutBarcode = Settings.Default.OutputBarcodeIP;

            IPAddress ipAddressObj = IPAddress.Parse(ipAddressOutBarcode);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddressObj, portNumberOutBarcode);
            clientSocket2.Connect(ipEndPoint);

            byte[] buffer = new byte[1024];
            var sad = context.Database.CanConnect();// ilk pasaportu yazdırırken gecikme yaşanıyordu boş query çalıştırıp önceden yüklenmesini 

            while (!backgroundWorker2.CancellationPending)
            {
                try
                {
                    int bytesRead = clientSocket2.Receive(buffer);

                    dataOutBarcode = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    string dataSubs2 = dataOutBarcode.TrimEnd('\r', '\n');
                    string dataIndex2 = dataSubs2.Split('>', '<')[8];

                    byte[] dataConvert2 = Convert.FromBase64String(dataIndex2);
                    string decodedData2 = Encoding.UTF8.GetString(dataConvert2).TrimEnd();

                    long pttbarcode = 0;

                    // NO READ
                    if (dataConvert2.IsNullOrEmpty() || dataConvert2.Length < 8)
                    {
                        log.Warning($" PTT Barkodu okunamadı- {decodedData2}");
                        // continue;
                    }
                    else
                    {
                        log.Warning($" PTT Barkodu okundu. okunan- {decodedData2}");

                        var resConvert = Int64.TryParse(decodedData2, out pttbarcode);
                        if (!resConvert)
                        {
                            AddLog($"Barkod değeri istenen formatta değil:{decodedData2}");
                        }
                        else
                        {
                            log.Error($" PTT Barkodu dönüştürme işlemi başarılı {decodedData2}");
                        }
                    }

                    #region BlockedList
                    bool isNextExist = ProcessPassportList.TryTake(out var readedpassport);

                    if (!isNextExist)
                    {
                        // Listede pasaport yok
                        InvokeDefine(() => {
                            txtOutputBReader.Text = "-";
                        });
                        AddLog($"Çıkış Barkod okuyucusundan okunan değer pasaport takip listesinde bulunamadı. Liste boş:{decodedData2}");
                        log.Error($"Çıkış Barkod okuyucusundan okunan değer pasaport takip listesinde bulunamadı. Liste boş:{decodedData2}");

                    }
                    else if (readedpassport.PttBarcode == 0 || pttbarcode == 0)
                    {
                        log.Error($"Sıradaki pasaportun bilgileri okunamamıştır.{decodedData2}");
                    }
                    else if (readedpassport.PttBarcode == pttbarcode)
                    {
                        // Pasaport Doğrulama başarılı
                        log.Warning($"Paspaort ve PTT barkod eşleşti {readedpassport}-{pttbarcode}");

                        InvokeDefine(() => {
                            txtOutputBReader.Text = decodedData2;
                        });
                        // Veri tabanına başarılı tamamlandı
                    }
                    else
                    {
                        // Pasaport Doğrulama başarısız
                        InvokeDefine(() => {
                            txtOutputBReader.Text = "-";
                        });
                        StopMachine();

                        AddLog($"Çıkış Barkod okuyucusundan okunan pasaport takip listesinde :{readedpassport} - {decodedData2} eşleşmemektedir.");
                        AddLog("Lütfen makineyi temizleyiniz!");
                        log.Error($"Çıkış Barkod okuyucusundan okunan pasaport takip listesinde :{readedpassport} - {decodedData2} eşleşmemektedir.");
                        modbusMaster.WriteSingleCoil(slaveAddress, 2063, true);//M15 crossCheck set
                        isClearMachine = true;

                        var crossCheck = MessageBox.Show("Eşleşme hatası algılandı.Lütfen Makineyi temizleyiniz. Makine temizlendikten sonra alarmları siliniz.", "Eşleşme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    #endregion
                }
                catch (Exception ex)
                {
                    log.Error(ex, $" PTT Barkodu okunamadı.");
                }
            }
        }
        private void PassportTrackStart(object sender, DoWorkEventArgs e)
        {
            // Çıkış Encoder Pozisyonunu oku
            
            while (true)
            {
                Thread.Sleep(OutEncoderReadTimeSpan);
                try
                {
                    if (!isPLCConnected)
                        continue;

                    long encoderPosition = 0;
                    var InputEncoderValues = modbusMaster.ReadHoldingRegisters(slaveAddress, 4800, 4);
                    var encByte = BitConverter.GetBytes(InputEncoderValues[0]);
                    var encByte2 = BitConverter.GetBytes(InputEncoderValues[1]);
                    byte[] lenghtArray = new byte[8];
                    Array.Copy(encByte, 0, lenghtArray, 0, 2);
                    Array.Copy(encByte2, 0, lenghtArray, 2, 2);
                    encoderPosition = BitConverter.ToInt64(lenghtArray, 0);
                    // pozisyon değiştiyse listeyi kontrol et 
                    if (OutputEncoderLastPosition == encoderPosition)
                        continue;

                    log.Information($"Çıkış Encoder Posizyonu {encoderPosition}");

                    OutputEncoderLastPosition = encoderPosition;
                    // Doğrulama başarılı ise veri tabanında pasaportun durmunu gönderildi olarak işaretle 
                    var findPassport = PassportTrackList.FirstOrDefault(t =>
                    t.EncoderPosition > encoderPosition - (EncoderThreshhold + OutputEncoderStepCount) &&
                    t.EncoderPosition < encoderPosition + (EncoderThreshhold + OutputEncoderStepCount)
                    );

                    if (findPassport == null)
                    {
                        AddLog($"Pasaport pozisyonu eşleşmedi");
                        log.Error($"Pasaport pozisyonu eşleşmedi");
                        continue;
                    }
                        
                    log.Information($"Çıkışta Pasaport bulundu {findPassport.PttBarcode}");

                    //Veri tabanı güncellemesi
                    #region Passaport Finished Procedure

                    using (var con = new SqlConnection(sqlConnectionstring))
                    {
                        using (SqlCommand cmd = new SqlCommand("SP_SET_PASSPORT_FINISHED", con))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            SqlParameter param = new SqlParameter("@Pttbarkod", System.Data.SqlDbType.BigInt);
                            param.Value = findPassport.PttBarcode;
                            cmd.Parameters.Add(param);
                            //cmd.CommandText = $"Update PassportDetails Set Sent = 1,MachineRecordDate = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff")}' Where PttBarkod = '{findPassport.PttBarcode}'";
                            con.Open();
                            var reader = cmd.ExecuteNonQuery();
                            //if (reader == 0)
                            //{
                            //    // kayıt güncelleme başarısız
                            //    AddLog($"Pasaport barkodu veri tabanında bulunamadı:{findPassport.PassportNo}");
                            //    log.Error($"Pasaport barkodu veri tabanında bulunamadı:{findPassport.PassportNo}");

                            //    //continue;
                            //}
                            //con.Close();
                        }
                    }
                        
                    log.Debug($"Paspaort ve PTT barkod eşleşme işlemi tamamlandı {findPassport.PassportNo}-{findPassport.PttBarcode}");
                    LastSucceedPttBarcode = findPassport.PttBarcode.Value;
                    UpdateOutputPassCount(null);
                    CheckPackEnd();
                    log.Information($"pasaport çıktı olarak işaretlendi {findPassport.PttBarcode}");

                    #endregion
                    // Doğrulanan pasaportu listeden çıkar
                    // listeden fazla olanları çıkar.
                    if (PassportTrackList.Count > 11)
                        PassportTrackList.TryDequeue(out var remove);
                }
                catch (Exception ex)
                {
                    log.Error(ex, $"çıkış encoder okumada hata alındı");
                }
            }
        }
        private void MachineReadWork(object sender, DoWorkEventArgs e)
        {
            while (!MachineConnectWorker.CancellationPending)
            {
                try
                {
                    sorgu();
                    Thread.Sleep(400);
                }
                catch (Exception)
                {
                }
            }
        }

        #endregion

        #region BUTTONS
        private void stsPrinter_Click(object sender, EventArgs e)
        {
            var res = ConnectPrinter();
            if (res)
            {
                MessageBox.Show("Yazıcı bağlantısı başarılı");
            }
            else
            {
                MessageBox.Show("Yazıcı bağlantısı başarısız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataNo();
        }

        private void buttonProductCount_Click(object sender, EventArgs e)
        {
            try
            {
                var maxvalue = Convert.ToInt32(numericUpDownProductCount.Value);
                Settings.Default.ProductCount = maxvalue;
                if (maxvalue == 0)
                {
                    MessageBox.Show("Paket sayısı 0 olamaz");
                    return;
                }
                PackMaxCount = maxvalue;
                AddInfoLog($"Pasaport Paketi için Maximum sayı  {PackMaxCount} olarak değiştirildi");
            }
            catch (Exception ex)
            {
                AddLog($"Pasaport Paketi için Maximum sayı  kaydedilemedi");
                log.Error(ex, "Paket sayısı kaydedilirken hata alındı");
            }
        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopMachine();
        }

        private void btnSaveDbSettings_Click(object sender, EventArgs e)
        {
            var conString = txtDbConnectionString.Text;
            if (conString.IsNullOrEmpty())
            {
                MessageBox.Show("'Bağlantı Cümlesi' boş olamaz");
                return;
            }

            Settings.Default.DBConnectionString = conString;
            Settings.Default.Save();
            MessageBox.Show("'Bağlantı Cümlesi' kaydedildi");
        }

        private void btnTestDBConnection_Click(object sender, EventArgs e)
        {
            var conString = txtDbConnectionString.Text;
            if (conString.IsNullOrEmpty())
            {
                MessageBox.Show("'Bağlantı Cümlesi' boş iken test Yapılamaz");
                return;
            }

            try
            {
                using (var con = new SqlConnection(conString))
                {
                    con.Open();
                    con.Close();
                    MessageBox.Show("Bağlantı başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı başarısız");
                log.Error(ex, "Veri tabanı bağlantı testinde hata alındı");
            }
        }

        private void btnFabricSettings_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Fabrika ayalarına dönmek istediğinizden emin misiniz?", "Fabrika Ayarları", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No)
                return;

            Settings.Default.Reset();


            textBoxPrinterIpAddress.Text = Settings.Default.PrinterIpAddress;
            textBoxInputBarcodeIP.Text = Settings.Default.InputBarcodeIP;
            textBoxOutputBarcodeIP.Text = Settings.Default.OutputBarcodeIP;

            #region D522 setting
            textBoxReject1BlowTime.Text = Settings.Default.Reject1BlowTime;
            #endregion

            #region D524 setting
            textBoxReject2BlowTime.Text = Settings.Default.Reject2BlowTime;
            #endregion

            #region D540 setting
            textBoxRejectInputTime.Text = Settings.Default.RejectInputTime;
            #endregion

            #region D550 setting
            textBoxRejectOutTime.Text = Settings.Default.RejectOutputTime;
            #endregion

            #region D560 setting
            textBoxDrawer1Mask.Text = Settings.Default.Drawer1SensorMask;
            #endregion

            #region D570 setting
            textBoxDrawer2Mask.Text = Settings.Default.Drawer2SensorMask;
            #endregion

            #region D504 setting
            textBoxBlowOffset.Text = Settings.Default.BlowOffset;
            #endregion

            #region D574 setting
            numericUpDownExternalConvStop.Text = Settings.Default.ExtConveyorStop;
            #endregion

            #region D2000 setting
            nudConveyorSpeed.Value = Settings.Default.ConveyorSpeed;
            #endregion

            #region D2002 setting
            nudVaccuumSpeed.Value = Settings.Default.VaccuumSpeed;
            #endregion

            txtDbConnectionString.Text = Settings.Default.DBConnectionString;

            #region PLC address
            comboBoxPlcPort.Text = Settings.Default.PLCPort;
            #endregion
            MessageBox.Show("Fabrika ayarlarına dönüldü");
        }

        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            if (isClearMachine)
            {
                ClearProcessList();
                SATOPrinter.ClearBuffer();
                ClearLists();

                isClearMachine = false;
            }
            modbusMaster.WriteSingleCoil(slaveAddress, 2063, false);//M15 crossCheck reset

            InvokeDefine(() => {
                stsDoors.BackColor = Color.YellowGreen;
                stsDrawer1.BackColor = Color.YellowGreen;
                stsDrawer2.BackColor = Color.YellowGreen;
                stsLine.BackColor = Color.YellowGreen;
                stsOutput.BackColor = Color.YellowGreen;
                stsInputBarcodeReader.BackColor = Color.YellowGreen;
                stsOutputBarcodereader.BackColor = Color.YellowGreen;
                stsPackMac.BackColor = Color.YellowGreen;
                stsDrawerTopDoor.BackColor = Color.YellowGreen;
            });
            try
            {
                if (isPLCConnected)
                {
                    modbusMaster.WriteSingleCoil(slaveAddress, 2053, true); //M5 read AlarmReset
                    bool M5 = modbusMaster.ReadCoils(slaveAddress, 2053, 1)[0];
                    if (M5)
                    {
                        modbusMaster.WriteSingleCoil(slaveAddress, 2053, false);
                    }
                }
            }
            catch (Exception)
            {
            }

            ClearLog();
            SendReadyToMachine();
            FullCheckMachine();
        }

        private void buttonbuttonSettingsApply_Click(object sender, EventArgs e)
        {

            var PrinterIp = textBoxPrinterIpAddress.Text;
            var BarcodeInputIp = textBoxInputBarcodeIP.Text;
            var BarcodeOutputIp = textBoxOutputBarcodeIP.Text;

            if (PrinterIp.IsNullOrEmpty())
            {
                MessageBox.Show("Lütfen Yazıcı bağlantı Ip Adresini doğru formatta giriniz.", "Format Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BarcodeInputIp.IsNullOrEmpty())
            {
                MessageBox.Show("Lütfen Giriş Barkod okuyucu bağlantı Ip Adresini doğru formatta giriniz.", "Format Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (BarcodeOutputIp.IsNullOrEmpty())
            {
                MessageBox.Show("Lütfen Çıkış barkod okuyucu bağlantı Ip Adresini doğru formatta giriniz.", "Format Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Settings.Default.PrinterIpAddress = textBoxPrinterIpAddress.Text;
            Settings.Default.InputBarcodeIP = textBoxInputBarcodeIP.Text;
            Settings.Default.OutputBarcodeIP = textBoxOutputBarcodeIP.Text;
            Settings.Default.PistonRunOption = checkBoxPistonRunOption.Checked;
            Settings.Default.ConveyorVaccuum = checkBoxConveyorVaccuum.Checked;

            Settings.Default.PLCPort = comboBoxPlcPort.SelectedItem.ToString();
            Settings.Default.BlowOffset = textBoxBlowOffset.Text;
            Settings.Default.Reject1BlowTime = textBoxReject1BlowTime.Text;
            Settings.Default.Reject2BlowTime = textBoxReject2BlowTime.Text;
            Settings.Default.RejectInputTime = textBoxRejectInputTime.Text;
            Settings.Default.RejectOutputTime = textBoxRejectOutTime.Text;
            Settings.Default.ExtConveyorStop = numericUpDownExternalConvStop.Text;
            Settings.Default.ConveyorSpeed=Convert.ToInt16(nudConveyorSpeed.Value);
            Settings.Default.VaccuumSpeed = Convert.ToInt16(nudVaccuumSpeed.Value);

            Settings.Default.Drawer1SensorMask = textBoxDrawer1Mask.Text;
            Settings.Default.Drawer2SensorMask = textBoxDrawer2Mask.Text;


            Settings.Default.EncoderReadTimeSpan = Convert.ToInt32(nudEncoderReadTimeSpan.Value);
            Settings.Default.EncoderStepThreshold = Convert.ToInt64(nudEncoderThreshold.Value);
            Settings.Default.OutputEncoderStepCount = Convert.ToInt64(nudEncoderStepCount.Value);
            //Settings.Default.EncoderStepThreshold = Out;
            //Settings.Default.OutputEncoderStepCount = OutputEncoderStepCount;
            //Settings.Default.EncoderReadTimeSpan = OutEncoderReadTimeSpan;
            Settings.Default.ConveyourShortStepSpan = Convert.ToInt32(nudConveyourShortStep.Value);
            Settings.Default.ConveyourLongStepSpan = Convert.ToInt32(nudConveyourLongStep.Value);
            Settings.Default.StopMachineOnFinishPack = chkStopMachineOnFinish.Checked;

            #region Drawer Top Door
            if (checkBoxDrawerDoor.Checked)
            {
                modbusMaster.WriteSingleCoil(slaveAddress, 2068, true);//M20 set
            } 
            else
            {
                modbusMaster.WriteSingleCoil(slaveAddress, 2068, false);//M20 reset
            }
            #endregion

            Settings.Default.Save();
            MessageBox.Show("Ayarlar kaydedildi.");

            ConnectToPlc();
            try
            {
                #region D522 setting
                modbusMaster.WriteSingleRegister(slaveAddress, 4618, (ushort)Convert.ToInt32(textBoxReject1BlowTime.Text));
                #endregion

                #region D524 setting
                modbusMaster.WriteSingleRegister(slaveAddress, 4620, (ushort)Convert.ToInt32(textBoxReject2BlowTime.Text));
                #endregion

                #region D540 setting
                modbusMaster.WriteSingleRegister(slaveAddress, 4636, (ushort)Convert.ToInt32(textBoxRejectInputTime.Text));
                #endregion

                #region D550 setting
                modbusMaster.WriteSingleRegister(slaveAddress, 4646, (ushort)Convert.ToInt32(textBoxRejectOutTime.Text));
                #endregion

                #region D560 setting
                modbusMaster.WriteSingleRegister(slaveAddress, 4656, (ushort)Convert.ToInt32(textBoxDrawer1Mask.Text));
                #endregion

                #region D570 setting
                modbusMaster.WriteSingleRegister(slaveAddress, 4666, (ushort)Convert.ToInt32(textBoxDrawer2Mask.Text));
                #endregion

                #region D504 setting
                modbusMaster.WriteSingleRegister(slaveAddress, 4600, Convert.ToUInt16(textBoxBlowOffset.Text));
                #endregion

                #region D574 setting
                modbusMaster.WriteSingleRegister(slaveAddress, 4670, Convert.ToUInt16(numericUpDownExternalConvStop.Text));
                #endregion

                #region D2000 setting
                modbusMaster.WriteSingleRegister(slaveAddress, 6096, Convert.ToUInt16(nudConveyorSpeed.Value));
                #endregion

                #region D2002 setting
                modbusMaster.WriteSingleRegister(slaveAddress, 6098, Convert.ToUInt16(nudVaccuumSpeed.Value));
                #endregion

                #region M450 set printer piston checkbox
                if (checkBoxPistonRunOption.Checked == true)
                {
                    modbusMaster.WriteSingleCoil(slaveAddress, 2498, true);
                }
                else
                {
                    modbusMaster.WriteSingleCoil(slaveAddress, 2498, false);
                }
                #endregion

                #region M451 set conveyor vaccuum checkbox
                if (checkBoxConveyorVaccuum.Checked == true)
                {
                    modbusMaster.WriteSingleCoil(slaveAddress, 2499, true);
                }
                else
                {
                    modbusMaster.WriteSingleCoil(slaveAddress, 2499, false);
                }
                #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("Ayarlar uygulanırken hata alındı.");
            }
        }

        private void btnSearchDb_Click(object sender, EventArgs e)
        {
            var batchCode = txtSearchBatchCode.Text.Trim();
            if (batchCode.IsNullOrEmpty() || batchCode.Length < 4)
            {
                MessageBox.Show("Lütfen paket kodu alanına en az 5 karakter giriniz");
                dgwPassports.DataSource = null;

                return;
            }
            var passes = context.PassportDetails.Where(t => t.BatchCode.StartsWith(batchCode)).Select(a => new
            {
                TeslimAlacak = a.TeslimAlacakKisi1,
                PttBarkod = a.PttBarkod,
                PasaportNo = a.PasaportNo,
                PaketKodu = a.BatchCode,
                Durum = ((PassportState)a.State).GetDescription<PassportState>(),

            }).ToList();
            if (passes.IsNullOrEmpty())
            {
                MessageBox.Show("Arama kriterlerine uygun pasaport bulunamadı");
                dgwPassports.DataSource = null;
                return;
            }

            dgwPassports.DataSource = passes;
        }

        private void btnSearchSinglePassport_Click(object sender, EventArgs e)
        {
            var passSearch = txtSearchSinglePassport.Text.Trim();
            if (passSearch.IsNullOrEmpty() || passSearch.Length < 9)
            {
                MessageBox.Show("Lütfen pasaporta ait Pasaport numarasını veya PTT barkodunu az 9 karakter olacak şekilde giriniz");
                lblPassNo.Text = "-";
                lblBatchCode.Text = "-";
                lblPassOwner.Text = "-";
                lblPttBarcode.Text = "-";
                lblState.Text = "-";
                return;
            }
            var passes = context.PassportDetails.Where(t => t.PasaportNo.StartsWith(passSearch) || t.PttBarkod.ToString().StartsWith(passSearch)).Select(a => new
            {
                TeslimAlacak = a.TeslimAlacakKisi1,
                PttBarkod = a.PttBarkod,
                PasaportNo = a.PasaportNo,
                PaketKodu = a.BatchCode,
                Durum = ((PassportState)a.State).GetDescription<PassportState>(),

            }).FirstOrDefault();
            if (passes == null)
            {
                MessageBox.Show("Arama kriterlerine uygun pasaport bulunamadı");
                lblPassNo.Text = "-";
                lblBatchCode.Text = "-";
                lblPassOwner.Text = "-";
                lblPttBarcode.Text = "-";
                lblState.Text = "-";
                return;
            }
            lblPassNo.Text = passes.PasaportNo;
            lblBatchCode.Text = passes.PaketKodu;
            lblPassOwner.Text = passes.TeslimAlacak;
            lblPttBarcode.Text = passes.PttBarkod.ToString();
            lblState.Text = passes.Durum;
        }

        private void btnSearchBatchCode_Click(object sender, EventArgs e)
        {
            var batchCode = txtSearchBatchList.Text.Trim();
            if (batchCode.IsNullOrEmpty() || batchCode.Length < 4)
            {
                MessageBox.Show("Lütfen paket kodu alanına en az 5 karakter giriniz");
                dgwPassports.DataSource = null;

                return;
            }
            var passes = context.Batches.Where(t => t.BatchCode.StartsWith(batchCode)).Select(a => new
            {
                TeslimAlacak = a.BatchCode,
                PttBarkod = a.State,
                PasaportNo = a.PassportCount,
                Durum = ((BatchState)a.State).GetDescription<BatchState>(),

            }).ToList();
            if (passes.IsNullOrEmpty())
            {
                MessageBox.Show("Arama kriterlerine uygun 'Paket' bulunamadı");
                dgwPassports.DataSource = null;
                return;
            }

            dgwBatches.DataSource = passes;
        }

        private void buttonDatabseClear_Click_1(object sender, EventArgs e)
        {
            CallDBProcedures();
        }

        private void buttonSendPass_Click(object sender, EventArgs e)
        {

            var batchGive = new Batches();
            {
                batchGive.BatchCode = Guid.NewGuid().ToString();
                batchGive.PassportCount = context.Temporary.Count();
                batchGive.IsSent = false;
                batchGive.State = 3; //oluşturuldu
                batchGive.CreationDate = DateTime.Now;
            }
            context.Add(batchGive);
            context.SaveChanges();

            var tempRecords = context.Temporary.ToList();
            foreach (var record in tempRecords)
            {
                var passportDetail = context.PassportDetails.FirstOrDefault(pd => pd.PttBarkod.ToString().Equals(record.PttBarkod.ToString()));
                if (passportDetail != null)
                {
                    passportDetail.BatchCode = batchGive.BatchCode;
                }
            }
            context.SaveChanges();
            context.Temporary.RemoveRange(tempRecords);
            context.SaveChanges();
        }

        private void buttonPrinterClear_Click(object sender, EventArgs e)
        {
            var resPrinter = MessageBox.Show("Yazıcıdak tüm işleri silmek istediğinize emin misiniz?", "Yazıcı Temizleme", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == resPrinter)
            {
                SATOPrinter.ClearBuffer();
                MessageBox.Show("Yazıcı temizlendi.");
                modbusMaster.WriteSingleCoil(slaveAddress, 2065, false);//M17 reset LabelReady
            }
            else
            {
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void buttonDatabaseProcess_Click(object sender, EventArgs e)
        {
            tabMain.SelectTab("tbpDbSettings");
            lblPageTitle.Text = "Veri Tabanı İşlemleri";
        }

        private void buttonAyarlar_Click(object sender, EventArgs e)
        {
            comboBoxPlcPort_DropDown(null, null);
            comboBoxPlcPort.SelectedItem = Settings.Default.PLCPort;
            tabMain.SelectTab("tbpSettings");
            lblPageTitle.Text = "Ayarlar";
        }

        private void buttonElilePasaportGirisi_Click(object sender, EventArgs e)
        {
            tabMain.SelectTab("tbpManuel");
            lblPageTitle.Text = "Manuel Paketleme";
        }

        private void buttonProductReport_Click(object sender, EventArgs e)
        {
            tabMain.SelectTab("tbpHome");
            lblPageTitle.Text = "Ana Sayfa";
        }

        private void buttonManuelPrintM_Click(object sender, EventArgs e)
        {
            var label = GetPassportData();
            if (label.IsNullOrEmpty())
                return;

                PrintManuellabel(label);

            MessageBox.Show("Paspaort bilgileri bulundu ve yazıcıya gönderildi.", "Paspaort bilgileri yazıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxPTTBarkodM.Text = "";
            textBoxAliciAdres1M.Text = "";
            textBoxAliciAdSoyad1M.Text = "";
            textBoxAliciAdSoyad2M.Text = "";
            textBoxAliciAdres1M.Text = "";
            textBoxAliciAdres2M.Text = "";
            textBoxAliciAdres3M.Text = "";
            textBoxTelM.Text = "";
            textBoxTeslimAlacakKisiM.Text = "";
            textBoxIadeAdresi1M.Text = "";
            textBoxIadeAdresi2M.Text = "";
            textBoxIadeAdresi3M.Text = "";
            textBoxAliciAdres2M.Text = "";
            textBoxAliciAdres3M.Text = "";
            textBoxBarkodM.Text = "";
        }
        private void btnFinishJob_Click(object sender, EventArgs e)
        {
            if (isMachineWorking)
                return;

            FinishPack();
        }

        private void btnOutputShort_Click(object sender, EventArgs e)
        {
            DriveOutputConveyourShort();
        }

        private void btnOutputLong_Click(object sender, EventArgs e)
        {
            DriveOutputConveyourLong();
        }

        private void buttonManualCreate_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(sqlConnectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("SP_SET_PASSPORT_FINISHED", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter("@PassportNo", System.Data.SqlDbType.NVarChar);
                    param.Value = textBoxBarkodM.Text;
                    cmd.Parameters.Add(param);
                    //cmd.CommandText = $"Update PassportDetails Set Sent = 1,MachineRecordDate = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff")}' Where PttBarkod = '{findPassport.PttBarcode}'";
                    con.Open();
                    var reader = cmd.ExecuteNonQuery();
                    //if (reader == 0)
                    //{
                    //    // kayıt güncelleme başarısız
                    //    AddLog($"Pasaport barkodu veri tabanında bulunamadı:{findPassport.PassportNo}");
                    //    log.Error($"Pasaport barkodu veri tabanında bulunamadı:{findPassport.PassportNo}");

                    //    //continue;
                    //}
                    //con.Close();
                } 
            }
        }

        private void buttonPrintPassportSearch_Click(object sender, EventArgs e)
        {
            DGVPrinter dGVPrinter = new DGVPrinter();
            dGVPrinter.Title = "Pasaportlar";
            dGVPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dGVPrinter.PageNumbers = true;
            dGVPrinter.PageNumberInHeader = false;
            dGVPrinter.PorportionalColumns=true;
            dGVPrinter.HeaderCellAlignment = StringAlignment.Near;
            dGVPrinter.Footer = "snn";
            dGVPrinter.FooterSpacing = 15;
            dGVPrinter.PrintDataGridView(dgwPassports);
        }

        private void textBoxBarkodM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                GetPassportData();
            }
        }
        #endregion
    }
}
