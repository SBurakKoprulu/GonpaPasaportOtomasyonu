using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GonpaPasaportOtomasyonu;

namespace WindowsApplication1
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelIzleme = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgwPassports = new System.Windows.Forms.DataGridView();
            this.txtSearchBatchCode = new System.Windows.Forms.TextBox();
            this.btnSearchDb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblBatchCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblPttBarcode = new System.Windows.Forms.Label();
            this.lblPassNo = new System.Windows.Forms.Label();
            this.lblPassOwner = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtSearchSinglePassport = new System.Windows.Forms.TextBox();
            this.btnSearchSinglePassport = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtSearchBatchList = new System.Windows.Forms.TextBox();
            this.btnSearchBatchCode = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.dgwBatches = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxOutputBarcodeIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInputBarcodeIP = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxPrinterIpAddress = new System.Windows.Forms.TextBox();
            this.labelPrinterIpAddress = new System.Windows.Forms.Label();
            this.btnTestDBConnection = new System.Windows.Forms.Button();
            this.btnSaveDbSettings = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.txtDbConnectionString = new System.Windows.Forms.TextBox();
            this.buttonDatabseClear = new System.Windows.Forms.Button();
            this.panelAyarlar = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkBoxDrawerDoor = new System.Windows.Forms.CheckBox();
            this.label58 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label57 = new System.Windows.Forms.Label();
            this.textBoxCounter = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkStopMachineOnFinish = new System.Windows.Forms.CheckBox();
            this.label56 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudConveyourLongStep = new System.Windows.Forms.NumericUpDown();
            this.label51 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.nudVaccuumSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudConveyourShortStep = new System.Windows.Forms.NumericUpDown();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.btnOutputLong = new System.Windows.Forms.Button();
            this.btnOutputShort = new System.Windows.Forms.Button();
            this.nudConveyorSpeed = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.numericUpDownExternalConvStop = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.checkBoxConveyorVaccuum = new System.Windows.Forms.CheckBox();
            this.btnFabricSettings = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.nudEncoderReadTimeSpan = new System.Windows.Forms.NumericUpDown();
            this.label47 = new System.Windows.Forms.Label();
            this.nudEncoderThreshold = new System.Windows.Forms.NumericUpDown();
            this.label46 = new System.Windows.Forms.Label();
            this.nudEncoderStepCount = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBoxEncoderC251 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxPlcPort = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBlowOffset = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.labelBlowerOffset = new System.Windows.Forms.Label();
            this.labelPistonRunOption = new System.Windows.Forms.Label();
            this.checkBoxPistonRunOption = new System.Windows.Forms.CheckBox();
            this.buttonbuttonSettingsApply = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxReject1BlowTime = new System.Windows.Forms.NumericUpDown();
            this.textBoxDrawer2Mask = new System.Windows.Forms.NumericUpDown();
            this.textBoxDrawer1Mask = new System.Windows.Forms.NumericUpDown();
            this.textBoxReject2BlowTime = new System.Windows.Forms.NumericUpDown();
            this.textBoxRejectOutTime = new System.Windows.Forms.NumericUpDown();
            this.textBoxRejectInputTime = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxBarkodM = new System.Windows.Forms.TextBox();
            this.groupBoxPasaport = new System.Windows.Forms.GroupBox();
            this.textBoxPTTBarkodM = new System.Windows.Forms.TextBox();
            this.textBoxIadeAdresi3M = new System.Windows.Forms.TextBox();
            this.textBoxIadeAdresi2M = new System.Windows.Forms.TextBox();
            this.textBoxIadeAdresi1M = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTeslimAlacakKisiM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxTelM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAliciAdres3M = new System.Windows.Forms.TextBox();
            this.textBoxAliciAdres2M = new System.Windows.Forms.TextBox();
            this.textBoxAliciAdres1M = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAliciAdSoyad2M = new System.Windows.Forms.TextBox();
            this.textBoxAliciAdSoyad1M = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonManuelPrintM = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panelElilePasaportGirdisi = new System.Windows.Forms.Panel();
            this.buttonManualCreate = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnFinishJob = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.stsPackMac = new System.Windows.Forms.Button();
            this.stsInputBarcodeReader = new System.Windows.Forms.Button();
            this.stsPrinter = new System.Windows.Forms.Button();
            this.stsOutputBarcodereader = new System.Windows.Forms.Button();
            this.stsOutput = new System.Windows.Forms.Button();
            this.stsDrawer1 = new System.Windows.Forms.Button();
            this.stsDrawer2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelAlarm = new System.Windows.Forms.Panel();
            this.stsDrawerTopDoor = new System.Windows.Forms.Button();
            this.numericUpDownProductCount = new System.Windows.Forms.NumericUpDown();
            this.txtOutPassCount = new System.Windows.Forms.TextBox();
            this.labelMachineWorkingState = new System.Windows.Forms.Label();
            this.buttonPrinterClear = new System.Windows.Forms.Button();
            this.txtPrinterBox = new System.Windows.Forms.TextBox();
            this.buttonProductCount = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtOutputBReader = new System.Windows.Forms.TextBox();
            this.txtInputBReader = new System.Windows.Forms.TextBox();
            this.stsDoors = new System.Windows.Forms.Button();
            this.stsLine = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbpHome = new System.Windows.Forms.TabPage();
            this.tbpManuel = new System.Windows.Forms.TabPage();
            this.tbpDbSettings = new System.Windows.Forms.TabPage();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.ledBulbPLCOepn = new Bulb.LedBulb();
            this.ledBulbWorkState = new Bulb.LedBulb();
            this.label42 = new System.Windows.Forms.Label();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.buttonDatabaseProcess = new System.Windows.Forms.Button();
            this.buttonProductReport = new System.Windows.Forms.Button();
            this.buttonElilePasaportGirisi = new System.Windows.Forms.Button();
            this.buttonAyarlar = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPrintPassportSearch = new System.Windows.Forms.Button();
            this.panelIzleme.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPassports)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBatches)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panelAyarlar.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConveyourLongStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVaccuumSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConveyourShortStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConveyorSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExternalConvStop)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncoderReadTimeSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncoderThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncoderStepCount)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBlowOffset)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxReject1BlowTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDrawer2Mask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDrawer1Mask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxReject2BlowTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRejectOutTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRejectInputTime)).BeginInit();
            this.groupBoxPasaport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelElilePasaportGirdisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tbpHome.SuspendLayout();
            this.tbpManuel.SuspendLayout();
            this.tbpDbSettings.SuspendLayout();
            this.tbpSettings.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(23, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(321, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pasaport Paketleme";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSlateGray;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Location = new System.Drawing.Point(13, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1487, 54);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alarm";
            // 
            // panelIzleme
            // 
            this.panelIzleme.Controls.Add(this.tabControl1);
            this.panelIzleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIzleme.Location = new System.Drawing.Point(3, 3);
            this.panelIzleme.Margin = new System.Windows.Forms.Padding(2);
            this.panelIzleme.Name = "panelIzleme";
            this.panelIzleme.Size = new System.Drawing.Size(888, 705);
            this.panelIzleme.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 709);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonPrintPassportSearch);
            this.tabPage1.Controls.Add(this.dgwPassports);
            this.tabPage1.Controls.Add(this.txtSearchBatchCode);
            this.tabPage1.Controls.Add(this.btnSearchDb);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(859, 676);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Paket İnceleme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgwPassports
            // 
            this.dgwPassports.AllowUserToAddRows = false;
            this.dgwPassports.AllowUserToDeleteRows = false;
            this.dgwPassports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwPassports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPassports.Location = new System.Drawing.Point(6, 113);
            this.dgwPassports.Name = "dgwPassports";
            this.dgwPassports.ReadOnly = true;
            this.dgwPassports.RowHeadersWidth = 51;
            this.dgwPassports.Size = new System.Drawing.Size(853, 562);
            this.dgwPassports.TabIndex = 16;
            // 
            // txtSearchBatchCode
            // 
            this.txtSearchBatchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBatchCode.Location = new System.Drawing.Point(131, 14);
            this.txtSearchBatchCode.Name = "txtSearchBatchCode";
            this.txtSearchBatchCode.Size = new System.Drawing.Size(548, 38);
            this.txtSearchBatchCode.TabIndex = 13;
            this.txtSearchBatchCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBatchCode_KeyPress);
            // 
            // btnSearchDb
            // 
            this.btnSearchDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchDb.Location = new System.Drawing.Point(703, 14);
            this.btnSearchDb.Name = "btnSearchDb";
            this.btnSearchDb.Size = new System.Drawing.Size(134, 38);
            this.btnSearchDb.TabIndex = 15;
            this.btnSearchDb.Text = "Ara";
            this.btnSearchDb.UseVisualStyleBackColor = true;
            this.btnSearchDb.Click += new System.EventHandler(this.btnSearchDb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Paket Kodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pasaportlar";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblBatchCode);
            this.tabPage2.Controls.Add(this.lblState);
            this.tabPage2.Controls.Add(this.lblPttBarcode);
            this.tabPage2.Controls.Add(this.lblPassNo);
            this.tabPage2.Controls.Add(this.lblPassOwner);
            this.tabPage2.Controls.Add(this.label40);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.txtSearchSinglePassport);
            this.tabPage2.Controls.Add(this.btnSearchSinglePassport);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(859, 676);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pasaport Arama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblBatchCode
            // 
            this.lblBatchCode.AutoSize = true;
            this.lblBatchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBatchCode.Location = new System.Drawing.Point(201, 278);
            this.lblBatchCode.Name = "lblBatchCode";
            this.lblBatchCode.Size = new System.Drawing.Size(19, 25);
            this.lblBatchCode.TabIndex = 28;
            this.lblBatchCode.Text = "-";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblState.Location = new System.Drawing.Point(201, 239);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(19, 25);
            this.lblState.TabIndex = 27;
            this.lblState.Text = "-";
            // 
            // lblPttBarcode
            // 
            this.lblPttBarcode.AutoSize = true;
            this.lblPttBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPttBarcode.Location = new System.Drawing.Point(201, 200);
            this.lblPttBarcode.Name = "lblPttBarcode";
            this.lblPttBarcode.Size = new System.Drawing.Size(19, 25);
            this.lblPttBarcode.TabIndex = 26;
            this.lblPttBarcode.Text = "-";
            // 
            // lblPassNo
            // 
            this.lblPassNo.AutoSize = true;
            this.lblPassNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassNo.Location = new System.Drawing.Point(201, 161);
            this.lblPassNo.Name = "lblPassNo";
            this.lblPassNo.Size = new System.Drawing.Size(19, 25);
            this.lblPassNo.TabIndex = 25;
            this.lblPassNo.Text = "-";
            // 
            // lblPassOwner
            // 
            this.lblPassOwner.AutoSize = true;
            this.lblPassOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassOwner.Location = new System.Drawing.Point(201, 122);
            this.lblPassOwner.Name = "lblPassOwner";
            this.lblPassOwner.Size = new System.Drawing.Size(19, 25);
            this.lblPassOwner.TabIndex = 24;
            this.lblPassOwner.Text = "-";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.Location = new System.Drawing.Point(70, 278);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(125, 25);
            this.label40.TabIndex = 23;
            this.label40.Text = "Paket Kodu :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.Location = new System.Drawing.Point(114, 239);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(81, 25);
            this.label39.TabIndex = 22;
            this.label39.Text = "Durum :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(17, 122);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(178, 25);
            this.label38.TabIndex = 21;
            this.label38.Text = "Teslim Alacak Kişi:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.Location = new System.Drawing.Point(82, 200);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(113, 25);
            this.label37.TabIndex = 20;
            this.label37.Text = "Ptt Barkod :";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.Location = new System.Drawing.Point(64, 161);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(131, 25);
            this.label36.TabIndex = 19;
            this.label36.Text = "Pasaport No :";
            // 
            // txtSearchSinglePassport
            // 
            this.txtSearchSinglePassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchSinglePassport.Location = new System.Drawing.Point(285, 32);
            this.txtSearchSinglePassport.Name = "txtSearchSinglePassport";
            this.txtSearchSinglePassport.Size = new System.Drawing.Size(405, 38);
            this.txtSearchSinglePassport.TabIndex = 16;
            this.txtSearchSinglePassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchSinglePassport_KeyPress);
            // 
            // btnSearchSinglePassport
            // 
            this.btnSearchSinglePassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchSinglePassport.Location = new System.Drawing.Point(696, 32);
            this.btnSearchSinglePassport.Name = "btnSearchSinglePassport";
            this.btnSearchSinglePassport.Size = new System.Drawing.Size(134, 38);
            this.btnSearchSinglePassport.TabIndex = 18;
            this.btnSearchSinglePassport.Text = "Ara";
            this.btnSearchSinglePassport.UseVisualStyleBackColor = true;
            this.btnSearchSinglePassport.Click += new System.EventHandler(this.btnSearchSinglePassport_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.Location = new System.Drawing.Point(17, 41);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(262, 25);
            this.label35.TabIndex = 17;
            this.label35.Text = "Pasaport No veya Ptt Barkod";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtSearchBatchList);
            this.tabPage3.Controls.Add(this.btnSearchBatchCode);
            this.tabPage3.Controls.Add(this.label41);
            this.tabPage3.Controls.Add(this.dgwBatches);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(859, 676);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Paket Arama";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtSearchBatchList
            // 
            this.txtSearchBatchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBatchList.Location = new System.Drawing.Point(134, 9);
            this.txtSearchBatchList.Name = "txtSearchBatchList";
            this.txtSearchBatchList.Size = new System.Drawing.Size(548, 38);
            this.txtSearchBatchList.TabIndex = 16;
            this.txtSearchBatchList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBatchList_KeyPress);
            // 
            // btnSearchBatchCode
            // 
            this.btnSearchBatchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchBatchCode.Location = new System.Drawing.Point(706, 9);
            this.btnSearchBatchCode.Name = "btnSearchBatchCode";
            this.btnSearchBatchCode.Size = new System.Drawing.Size(134, 38);
            this.btnSearchBatchCode.TabIndex = 18;
            this.btnSearchBatchCode.Text = "Ara";
            this.btnSearchBatchCode.UseVisualStyleBackColor = true;
            this.btnSearchBatchCode.Click += new System.EventHandler(this.btnSearchBatchCode_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label41.Location = new System.Drawing.Point(14, 18);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(114, 25);
            this.label41.TabIndex = 17;
            this.label41.Text = "Paket Kodu";
            // 
            // dgwBatches
            // 
            this.dgwBatches.AllowUserToAddRows = false;
            this.dgwBatches.AllowUserToDeleteRows = false;
            this.dgwBatches.AllowUserToOrderColumns = true;
            this.dgwBatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBatches.Location = new System.Drawing.Point(6, 64);
            this.dgwBatches.Name = "dgwBatches";
            this.dgwBatches.ReadOnly = true;
            this.dgwBatches.RowHeadersWidth = 51;
            this.dgwBatches.Size = new System.Drawing.Size(1218, 666);
            this.dgwBatches.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxOutputBarcodeIP);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.textBoxInputBarcodeIP);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.textBoxPrinterIpAddress);
            this.tabPage4.Controls.Add(this.labelPrinterIpAddress);
            this.tabPage4.Controls.Add(this.btnTestDBConnection);
            this.tabPage4.Controls.Add(this.btnSaveDbSettings);
            this.tabPage4.Controls.Add(this.label43);
            this.tabPage4.Controls.Add(this.txtDbConnectionString);
            this.tabPage4.Controls.Add(this.buttonDatabseClear);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(859, 676);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bakım";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputBarcodeIP
            // 
            this.textBoxOutputBarcodeIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOutputBarcodeIP.Location = new System.Drawing.Point(552, 445);
            this.textBoxOutputBarcodeIP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOutputBarcodeIP.Name = "textBoxOutputBarcodeIP";
            this.textBoxOutputBarcodeIP.Size = new System.Drawing.Size(164, 26);
            this.textBoxOutputBarcodeIP.TabIndex = 46;
            this.textBoxOutputBarcodeIP.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(401, 451);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Çıkış barkod IP adresi:";
            this.label7.Visible = false;
            // 
            // textBoxInputBarcodeIP
            // 
            this.textBoxInputBarcodeIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxInputBarcodeIP.Location = new System.Drawing.Point(195, 445);
            this.textBoxInputBarcodeIP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInputBarcodeIP.Name = "textBoxInputBarcodeIP";
            this.textBoxInputBarcodeIP.Size = new System.Drawing.Size(169, 26);
            this.textBoxInputBarcodeIP.TabIndex = 44;
            this.textBoxInputBarcodeIP.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(43, 450);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 17);
            this.label19.TabIndex = 43;
            this.label19.Text = "Giriş barkod IP adresi:";
            this.label19.Visible = false;
            // 
            // textBoxPrinterIpAddress
            // 
            this.textBoxPrinterIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPrinterIpAddress.Location = new System.Drawing.Point(552, 406);
            this.textBoxPrinterIpAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrinterIpAddress.Name = "textBoxPrinterIpAddress";
            this.textBoxPrinterIpAddress.Size = new System.Drawing.Size(164, 26);
            this.textBoxPrinterIpAddress.TabIndex = 42;
            this.textBoxPrinterIpAddress.Visible = false;
            // 
            // labelPrinterIpAddress
            // 
            this.labelPrinterIpAddress.AutoSize = true;
            this.labelPrinterIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPrinterIpAddress.Location = new System.Drawing.Point(435, 411);
            this.labelPrinterIpAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrinterIpAddress.Name = "labelPrinterIpAddress";
            this.labelPrinterIpAddress.Size = new System.Drawing.Size(108, 17);
            this.labelPrinterIpAddress.TabIndex = 41;
            this.labelPrinterIpAddress.Text = "Yazıcı IP adresi:";
            this.labelPrinterIpAddress.Visible = false;
            // 
            // btnTestDBConnection
            // 
            this.btnTestDBConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTestDBConnection.Location = new System.Drawing.Point(314, 163);
            this.btnTestDBConnection.Name = "btnTestDBConnection";
            this.btnTestDBConnection.Size = new System.Drawing.Size(176, 51);
            this.btnTestDBConnection.TabIndex = 17;
            this.btnTestDBConnection.Text = "Bağlantıyı Test Et";
            this.btnTestDBConnection.UseVisualStyleBackColor = true;
            this.btnTestDBConnection.Click += new System.EventHandler(this.btnTestDBConnection_Click);
            // 
            // btnSaveDbSettings
            // 
            this.btnSaveDbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveDbSettings.Location = new System.Drawing.Point(600, 163);
            this.btnSaveDbSettings.Name = "btnSaveDbSettings";
            this.btnSaveDbSettings.Size = new System.Drawing.Size(176, 51);
            this.btnSaveDbSettings.TabIndex = 16;
            this.btnSaveDbSettings.Text = "Ayar Kaydet";
            this.btnSaveDbSettings.UseVisualStyleBackColor = true;
            this.btnSaveDbSettings.Click += new System.EventHandler(this.btnSaveDbSettings_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(52, 28);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(188, 20);
            this.label43.TabIndex = 15;
            this.label43.Text = "Veritabanı bağlantı adresi";
            // 
            // txtDbConnectionString
            // 
            this.txtDbConnectionString.Location = new System.Drawing.Point(269, 25);
            this.txtDbConnectionString.Multiline = true;
            this.txtDbConnectionString.Name = "txtDbConnectionString";
            this.txtDbConnectionString.Size = new System.Drawing.Size(568, 103);
            this.txtDbConnectionString.TabIndex = 14;
            // 
            // buttonDatabseClear
            // 
            this.buttonDatabseClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDatabseClear.Location = new System.Drawing.Point(600, 583);
            this.buttonDatabseClear.Name = "buttonDatabseClear";
            this.buttonDatabseClear.Size = new System.Drawing.Size(237, 73);
            this.buttonDatabseClear.TabIndex = 13;
            this.buttonDatabseClear.Text = "Veritabanını Temizle";
            this.buttonDatabseClear.UseVisualStyleBackColor = true;
            this.buttonDatabseClear.Click += new System.EventHandler(this.buttonDatabseClear_Click_1);
            // 
            // panelAyarlar
            // 
            this.panelAyarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelAyarlar.Controls.Add(this.groupBox8);
            this.panelAyarlar.Controls.Add(this.groupBox7);
            this.panelAyarlar.Controls.Add(this.groupBox6);
            this.panelAyarlar.Controls.Add(this.groupBox5);
            this.panelAyarlar.Controls.Add(this.btnFabricSettings);
            this.panelAyarlar.Controls.Add(this.groupBox4);
            this.panelAyarlar.Controls.Add(this.groupBox3);
            this.panelAyarlar.Controls.Add(this.groupBox2);
            this.panelAyarlar.Controls.Add(this.buttonbuttonSettingsApply);
            this.panelAyarlar.Controls.Add(this.groupBox1);
            this.panelAyarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAyarlar.Location = new System.Drawing.Point(3, 3);
            this.panelAyarlar.Margin = new System.Windows.Forms.Padding(2);
            this.panelAyarlar.Name = "panelAyarlar";
            this.panelAyarlar.Size = new System.Drawing.Size(888, 705);
            this.panelAyarlar.TabIndex = 5;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkBoxDrawerDoor);
            this.groupBox8.Controls.Add(this.label58);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.Location = new System.Drawing.Point(328, 23);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(547, 63);
            this.groupBox8.TabIndex = 67;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Kapı Ayarları";
            // 
            // checkBoxDrawerDoor
            // 
            this.checkBoxDrawerDoor.AutoSize = true;
            this.checkBoxDrawerDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxDrawerDoor.Location = new System.Drawing.Point(332, 24);
            this.checkBoxDrawerDoor.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDrawerDoor.Name = "checkBoxDrawerDoor";
            this.checkBoxDrawerDoor.Size = new System.Drawing.Size(53, 21);
            this.checkBoxDrawerDoor.TabIndex = 36;
            this.checkBoxDrawerDoor.Text = "Açık";
            this.checkBoxDrawerDoor.UseVisualStyleBackColor = true;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label58.Location = new System.Drawing.Point(33, 27);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(294, 17);
            this.label58.TabIndex = 35;
            this.label58.Text = "Tahliye çekmecesi üstü kapağı açık kullanma:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label57);
            this.groupBox7.Controls.Add(this.textBoxCounter);
            this.groupBox7.Controls.Add(this.label55);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.Location = new System.Drawing.Point(409, 534);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(466, 84);
            this.groupBox7.TabIndex = 66;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sayaç";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label57.Location = new System.Drawing.Point(267, 32);
            this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(36, 17);
            this.label57.TabIndex = 65;
            this.label57.Text = "adet";
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCounter.Location = new System.Drawing.Point(58, 26);
            this.textBoxCounter.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.ReadOnly = true;
            this.textBoxCounter.Size = new System.Drawing.Size(205, 26);
            this.textBoxCounter.TabIndex = 63;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(8, 32);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(51, 17);
            this.label55.TabIndex = 62;
            this.label55.Text = "Sayaç:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkStopMachineOnFinish);
            this.groupBox6.Controls.Add(this.label56);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(25, 534);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(378, 84);
            this.groupBox6.TabIndex = 65;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Paket Ayarları";
            // 
            // chkStopMachineOnFinish
            // 
            this.chkStopMachineOnFinish.AutoSize = true;
            this.chkStopMachineOnFinish.Location = new System.Drawing.Point(244, 30);
            this.chkStopMachineOnFinish.Margin = new System.Windows.Forms.Padding(2);
            this.chkStopMachineOnFinish.Name = "chkStopMachineOnFinish";
            this.chkStopMachineOnFinish.Size = new System.Drawing.Size(53, 21);
            this.chkStopMachineOnFinish.TabIndex = 63;
            this.chkStopMachineOnFinish.Text = "Açık";
            this.chkStopMachineOnFinish.UseVisualStyleBackColor = true;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(8, 32);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(232, 17);
            this.label56.TabIndex = 62;
            this.label56.Text = "Paket dolduğunda makineyi durdur:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nudConveyourLongStep);
            this.groupBox5.Controls.Add(this.label51);
            this.groupBox5.Controls.Add(this.label54);
            this.groupBox5.Controls.Add(this.nudVaccuumSpeed);
            this.groupBox5.Controls.Add(this.nudConveyourShortStep);
            this.groupBox5.Controls.Add(this.label52);
            this.groupBox5.Controls.Add(this.label53);
            this.groupBox5.Controls.Add(this.label50);
            this.groupBox5.Controls.Add(this.btnOutputLong);
            this.groupBox5.Controls.Add(this.btnOutputShort);
            this.groupBox5.Controls.Add(this.nudConveyorSpeed);
            this.groupBox5.Controls.Add(this.label49);
            this.groupBox5.Controls.Add(this.numericUpDownExternalConvStop);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label45);
            this.groupBox5.Controls.Add(this.checkBoxConveyorVaccuum);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(328, 92);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(547, 176);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Konveyör Ayarları";
            // 
            // nudConveyourLongStep
            // 
            this.nudConveyourLongStep.Location = new System.Drawing.Point(390, 100);
            this.nudConveyourLongStep.Margin = new System.Windows.Forms.Padding(2);
            this.nudConveyourLongStep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudConveyourLongStep.Name = "nudConveyourLongStep";
            this.nudConveyourLongStep.Size = new System.Drawing.Size(69, 23);
            this.nudConveyourLongStep.TabIndex = 69;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label51.Location = new System.Drawing.Point(191, 101);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(32, 17);
            this.label51.TabIndex = 66;
            this.label51.Text = "rpm";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(237, 104);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(141, 17);
            this.label54.TabIndex = 68;
            this.label54.Text = "Konveyor uzun adım:";
            // 
            // nudVaccuumSpeed
            // 
            this.nudVaccuumSpeed.DecimalPlaces = 1;
            this.nudVaccuumSpeed.Location = new System.Drawing.Point(117, 100);
            this.nudVaccuumSpeed.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudVaccuumSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudVaccuumSpeed.Name = "nudVaccuumSpeed";
            this.nudVaccuumSpeed.Size = new System.Drawing.Size(69, 23);
            this.nudVaccuumSpeed.TabIndex = 65;
            this.nudVaccuumSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudConveyourShortStep
            // 
            this.nudConveyourShortStep.Location = new System.Drawing.Point(390, 67);
            this.nudConveyourShortStep.Margin = new System.Windows.Forms.Padding(2);
            this.nudConveyourShortStep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudConveyourShortStep.Name = "nudConveyourShortStep";
            this.nudConveyourShortStep.Size = new System.Drawing.Size(69, 23);
            this.nudConveyourShortStep.TabIndex = 67;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label52.Location = new System.Drawing.Point(30, 102);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(80, 17);
            this.label52.TabIndex = 64;
            this.label52.Text = "Vakum hızı:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(237, 70);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(139, 17);
            this.label53.TabIndex = 66;
            this.label53.Text = "Konveyor kısa adım :";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label50.Location = new System.Drawing.Point(191, 67);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(25, 17);
            this.label50.TabIndex = 60;
            this.label50.Text = "Hz";
            // 
            // btnOutputLong
            // 
            this.btnOutputLong.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOutputLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOutputLong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOutputLong.Location = new System.Drawing.Point(464, 100);
            this.btnOutputLong.Name = "btnOutputLong";
            this.btnOutputLong.Size = new System.Drawing.Size(76, 23);
            this.btnOutputLong.TabIndex = 65;
            this.btnOutputLong.Text = "Test";
            this.btnOutputLong.UseVisualStyleBackColor = false;
            this.btnOutputLong.Click += new System.EventHandler(this.btnOutputLong_Click);
            // 
            // btnOutputShort
            // 
            this.btnOutputShort.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOutputShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOutputShort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOutputShort.Location = new System.Drawing.Point(464, 67);
            this.btnOutputShort.Name = "btnOutputShort";
            this.btnOutputShort.Size = new System.Drawing.Size(76, 23);
            this.btnOutputShort.TabIndex = 49;
            this.btnOutputShort.Text = "Test";
            this.btnOutputShort.UseVisualStyleBackColor = false;
            this.btnOutputShort.Click += new System.EventHandler(this.btnOutputShort_Click);
            // 
            // nudConveyorSpeed
            // 
            this.nudConveyorSpeed.DecimalPlaces = 1;
            this.nudConveyorSpeed.Location = new System.Drawing.Point(117, 65);
            this.nudConveyorSpeed.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudConveyorSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudConveyorSpeed.Name = "nudConveyorSpeed";
            this.nudConveyorSpeed.Size = new System.Drawing.Size(69, 23);
            this.nudConveyorSpeed.TabIndex = 59;
            this.nudConveyorSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label49.Location = new System.Drawing.Point(13, 68);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(97, 17);
            this.label49.TabIndex = 58;
            this.label49.Text = "Konveyör hızı:";
            // 
            // numericUpDownExternalConvStop
            // 
            this.numericUpDownExternalConvStop.Location = new System.Drawing.Point(227, 29);
            this.numericUpDownExternalConvStop.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownExternalConvStop.Name = "numericUpDownExternalConvStop";
            this.numericUpDownExternalConvStop.Size = new System.Drawing.Size(69, 23);
            this.numericUpDownExternalConvStop.TabIndex = 56;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(300, 32);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 17);
            this.label21.TabIndex = 57;
            this.label21.Text = "adım";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(11, 32);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(214, 17);
            this.label22.TabIndex = 55;
            this.label22.Text = "Harici konveyör durma mesafesi:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label45.Location = new System.Drawing.Point(16, 135);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(94, 17);
            this.label45.TabIndex = 16;
            this.label45.Text = "Bant vakumu:";
            // 
            // checkBoxConveyorVaccuum
            // 
            this.checkBoxConveyorVaccuum.AutoSize = true;
            this.checkBoxConveyorVaccuum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxConveyorVaccuum.Location = new System.Drawing.Point(118, 134);
            this.checkBoxConveyorVaccuum.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxConveyorVaccuum.Name = "checkBoxConveyorVaccuum";
            this.checkBoxConveyorVaccuum.Size = new System.Drawing.Size(53, 21);
            this.checkBoxConveyorVaccuum.TabIndex = 17;
            this.checkBoxConveyorVaccuum.Text = "Açık";
            this.checkBoxConveyorVaccuum.UseVisualStyleBackColor = true;
            // 
            // btnFabricSettings
            // 
            this.btnFabricSettings.BackColor = System.Drawing.Color.DarkRed;
            this.btnFabricSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFabricSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFabricSettings.Location = new System.Drawing.Point(32, 644);
            this.btnFabricSettings.Name = "btnFabricSettings";
            this.btnFabricSettings.Size = new System.Drawing.Size(198, 56);
            this.btnFabricSettings.TabIndex = 47;
            this.btnFabricSettings.Text = "Fabrika Ayarlarına Dön";
            this.btnFabricSettings.UseVisualStyleBackColor = false;
            this.btnFabricSettings.Click += new System.EventHandler(this.btnFabricSettings_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label48);
            this.groupBox4.Controls.Add(this.nudEncoderReadTimeSpan);
            this.groupBox4.Controls.Add(this.label47);
            this.groupBox4.Controls.Add(this.nudEncoderThreshold);
            this.groupBox4.Controls.Add(this.label46);
            this.groupBox4.Controls.Add(this.nudEncoderStepCount);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.textBoxEncoderC251);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(25, 431);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(850, 96);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encoder Ayarları";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label48.Location = new System.Drawing.Point(667, 55);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(26, 17);
            this.label48.TabIndex = 64;
            this.label48.Text = "ms";
            // 
            // nudEncoderReadTimeSpan
            // 
            this.nudEncoderReadTimeSpan.Location = new System.Drawing.Point(590, 52);
            this.nudEncoderReadTimeSpan.Margin = new System.Windows.Forms.Padding(2);
            this.nudEncoderReadTimeSpan.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.nudEncoderReadTimeSpan.Name = "nudEncoderReadTimeSpan";
            this.nudEncoderReadTimeSpan.Size = new System.Drawing.Size(69, 23);
            this.nudEncoderReadTimeSpan.TabIndex = 63;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(433, 55);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(153, 17);
            this.label47.TabIndex = 62;
            this.label47.Text = "Encoder okuma süresi:";
            // 
            // nudEncoderThreshold
            // 
            this.nudEncoderThreshold.Location = new System.Drawing.Point(590, 26);
            this.nudEncoderThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.nudEncoderThreshold.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudEncoderThreshold.Name = "nudEncoderThreshold";
            this.nudEncoderThreshold.Size = new System.Drawing.Size(69, 23);
            this.nudEncoderThreshold.TabIndex = 61;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(427, 29);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(163, 17);
            this.label46.TabIndex = 60;
            this.label46.Text = "Encoder düzeltme adımı:";
            // 
            // nudEncoderStepCount
            // 
            this.nudEncoderStepCount.Location = new System.Drawing.Point(167, 52);
            this.nudEncoderStepCount.Margin = new System.Windows.Forms.Padding(2);
            this.nudEncoderStepCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudEncoderStepCount.Name = "nudEncoderStepCount";
            this.nudEncoderStepCount.Size = new System.Drawing.Size(69, 23);
            this.nudEncoderStepCount.TabIndex = 59;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(9, 55);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(153, 17);
            this.label44.TabIndex = 58;
            this.label44.Text = "Çıkış encoder mesafesi";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.Location = new System.Drawing.Point(376, 26);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(38, 17);
            this.label34.TabIndex = 57;
            this.label34.Text = "adım";
            // 
            // textBoxEncoderC251
            // 
            this.textBoxEncoderC251.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxEncoderC251.Location = new System.Drawing.Point(167, 21);
            this.textBoxEncoderC251.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEncoderC251.Name = "textBoxEncoderC251";
            this.textBoxEncoderC251.ReadOnly = true;
            this.textBoxEncoderC251.Size = new System.Drawing.Size(205, 26);
            this.textBoxEncoderC251.TabIndex = 43;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(13, 26);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(148, 17);
            this.label25.TabIndex = 42;
            this.label25.Text = "Encoder sinyal sayısı :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxPlcPort);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(25, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 63);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Makine Bağlantı Ayarları";
            // 
            // comboBoxPlcPort
            // 
            this.comboBoxPlcPort.FormattingEnabled = true;
            this.comboBoxPlcPort.Location = new System.Drawing.Point(178, 22);
            this.comboBoxPlcPort.Name = "comboBoxPlcPort";
            this.comboBoxPlcPort.Size = new System.Drawing.Size(91, 24);
            this.comboBoxPlcPort.TabIndex = 48;
            this.comboBoxPlcPort.DropDown += new System.EventHandler(this.comboBoxPlcPort_DropDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(33, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "PLC istasyon adresi :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBlowOffset);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.labelBlowerOffset);
            this.groupBox2.Controls.Add(this.labelPistonRunOption);
            this.groupBox2.Controls.Add(this.checkBoxPistonRunOption);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(25, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 176);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yazıcı Ayarları";
            // 
            // textBoxBlowOffset
            // 
            this.textBoxBlowOffset.Location = new System.Drawing.Point(136, 30);
            this.textBoxBlowOffset.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.textBoxBlowOffset.Name = "textBoxBlowOffset";
            this.textBoxBlowOffset.Size = new System.Drawing.Size(69, 23);
            this.textBoxBlowOffset.TabIndex = 45;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(212, 34);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(26, 17);
            this.label27.TabIndex = 44;
            this.label27.Text = "ms";
            // 
            // labelBlowerOffset
            // 
            this.labelBlowerOffset.AutoSize = true;
            this.labelBlowerOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBlowerOffset.Location = new System.Drawing.Point(18, 32);
            this.labelBlowerOffset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBlowerOffset.Name = "labelBlowerOffset";
            this.labelBlowerOffset.Size = new System.Drawing.Size(115, 17);
            this.labelBlowerOffset.TabIndex = 14;
            this.labelBlowerOffset.Text = "Etiket pozisyonu:";
            // 
            // labelPistonRunOption
            // 
            this.labelPistonRunOption.AutoSize = true;
            this.labelPistonRunOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPistonRunOption.Location = new System.Drawing.Point(18, 67);
            this.labelPistonRunOption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPistonRunOption.Name = "labelPistonRunOption";
            this.labelPistonRunOption.Size = new System.Drawing.Size(155, 17);
            this.labelPistonRunOption.TabIndex = 16;
            this.labelPistonRunOption.Text = "Piston çalışma yöntemi:";
            // 
            // checkBoxPistonRunOption
            // 
            this.checkBoxPistonRunOption.AutoSize = true;
            this.checkBoxPistonRunOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxPistonRunOption.Location = new System.Drawing.Point(186, 66);
            this.checkBoxPistonRunOption.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPistonRunOption.Name = "checkBoxPistonRunOption";
            this.checkBoxPistonRunOption.Size = new System.Drawing.Size(83, 21);
            this.checkBoxPistonRunOption.TabIndex = 17;
            this.checkBoxPistonRunOption.Text = "Hareketli";
            this.checkBoxPistonRunOption.UseVisualStyleBackColor = true;
            // 
            // buttonbuttonSettingsApply
            // 
            this.buttonbuttonSettingsApply.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonbuttonSettingsApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonbuttonSettingsApply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonbuttonSettingsApply.Location = new System.Drawing.Point(578, 638);
            this.buttonbuttonSettingsApply.Name = "buttonbuttonSettingsApply";
            this.buttonbuttonSettingsApply.Size = new System.Drawing.Size(229, 59);
            this.buttonbuttonSettingsApply.TabIndex = 39;
            this.buttonbuttonSettingsApply.Text = "Ayarları Uygula";
            this.buttonbuttonSettingsApply.UseVisualStyleBackColor = false;
            this.buttonbuttonSettingsApply.Click += new System.EventHandler(this.buttonbuttonSettingsApply_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxReject1BlowTime);
            this.groupBox1.Controls.Add(this.textBoxDrawer2Mask);
            this.groupBox1.Controls.Add(this.textBoxDrawer1Mask);
            this.groupBox1.Controls.Add(this.textBoxReject2BlowTime);
            this.groupBox1.Controls.Add(this.textBoxRejectOutTime);
            this.groupBox1.Controls.Add(this.textBoxRejectInputTime);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(25, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 151);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çekmece ve Piston Ayarları";
            // 
            // textBoxReject1BlowTime
            // 
            this.textBoxReject1BlowTime.Location = new System.Drawing.Point(653, 38);
            this.textBoxReject1BlowTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textBoxReject1BlowTime.Name = "textBoxReject1BlowTime";
            this.textBoxReject1BlowTime.Size = new System.Drawing.Size(69, 23);
            this.textBoxReject1BlowTime.TabIndex = 58;
            // 
            // textBoxDrawer2Mask
            // 
            this.textBoxDrawer2Mask.Location = new System.Drawing.Point(719, 110);
            this.textBoxDrawer2Mask.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.textBoxDrawer2Mask.Name = "textBoxDrawer2Mask";
            this.textBoxDrawer2Mask.Size = new System.Drawing.Size(69, 23);
            this.textBoxDrawer2Mask.TabIndex = 61;
            // 
            // textBoxDrawer1Mask
            // 
            this.textBoxDrawer1Mask.Location = new System.Drawing.Point(309, 112);
            this.textBoxDrawer1Mask.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.textBoxDrawer1Mask.Name = "textBoxDrawer1Mask";
            this.textBoxDrawer1Mask.Size = new System.Drawing.Size(69, 23);
            this.textBoxDrawer1Mask.TabIndex = 60;
            // 
            // textBoxReject2BlowTime
            // 
            this.textBoxReject2BlowTime.Location = new System.Drawing.Point(653, 74);
            this.textBoxReject2BlowTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textBoxReject2BlowTime.Name = "textBoxReject2BlowTime";
            this.textBoxReject2BlowTime.Size = new System.Drawing.Size(69, 23);
            this.textBoxReject2BlowTime.TabIndex = 59;
            // 
            // textBoxRejectOutTime
            // 
            this.textBoxRejectOutTime.Location = new System.Drawing.Point(214, 75);
            this.textBoxRejectOutTime.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.textBoxRejectOutTime.Name = "textBoxRejectOutTime";
            this.textBoxRejectOutTime.Size = new System.Drawing.Size(69, 23);
            this.textBoxRejectOutTime.TabIndex = 57;
            // 
            // textBoxRejectInputTime
            // 
            this.textBoxRejectInputTime.Location = new System.Drawing.Point(214, 39);
            this.textBoxRejectInputTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.textBoxRejectInputTime.Name = "textBoxRejectInputTime";
            this.textBoxRejectInputTime.Size = new System.Drawing.Size(69, 23);
            this.textBoxRejectInputTime.TabIndex = 46;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.Location = new System.Drawing.Point(796, 114);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(26, 17);
            this.label33.TabIndex = 56;
            this.label33.Text = "ms";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(386, 117);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(26, 17);
            this.label32.TabIndex = 55;
            this.label32.Text = "ms";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(732, 77);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(26, 17);
            this.label31.TabIndex = 54;
            this.label31.Text = "ms";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(732, 41);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(26, 17);
            this.label30.TabIndex = 53;
            this.label30.Text = "ms";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(293, 77);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(38, 17);
            this.label29.TabIndex = 52;
            this.label29.Text = "adım";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(293, 39);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 17);
            this.label28.TabIndex = 51;
            this.label28.Text = "adım";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(438, 77);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(212, 17);
            this.label24.TabIndex = 49;
            this.label24.Text = "2. Tahliye pistonu üfleme süresi:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(434, 41);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(212, 17);
            this.label23.TabIndex = 47;
            this.label23.Text = "1. Tahliye pistonu üfleme süresi:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(438, 114);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(271, 17);
            this.label18.TabIndex = 46;
            this.label18.Text = "2. Çekmece dolu sensörü bekleme süresi:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(28, 115);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(271, 17);
            this.label17.TabIndex = 44;
            this.label17.Text = "1. Çekmece dolu sensörü bekleme süresi:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(28, 41);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "1. Tahliye pistonu mesafesi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(28, 77);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(184, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "2. Tahliye pistonu mesafesi:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxBarkodM
            // 
            this.textBoxBarkodM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBarkodM.Location = new System.Drawing.Point(495, 132);
            this.textBoxBarkodM.Name = "textBoxBarkodM";
            this.textBoxBarkodM.Size = new System.Drawing.Size(296, 32);
            this.textBoxBarkodM.TabIndex = 0;
            this.textBoxBarkodM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarkodM_KeyPress);
            // 
            // groupBoxPasaport
            // 
            this.groupBoxPasaport.Controls.Add(this.textBoxPTTBarkodM);
            this.groupBoxPasaport.Controls.Add(this.textBoxIadeAdresi3M);
            this.groupBoxPasaport.Controls.Add(this.textBoxIadeAdresi2M);
            this.groupBoxPasaport.Controls.Add(this.textBoxIadeAdresi1M);
            this.groupBoxPasaport.Controls.Add(this.label12);
            this.groupBoxPasaport.Controls.Add(this.textBoxTeslimAlacakKisiM);
            this.groupBoxPasaport.Controls.Add(this.label11);
            this.groupBoxPasaport.Controls.Add(this.textBoxTelM);
            this.groupBoxPasaport.Controls.Add(this.label10);
            this.groupBoxPasaport.Controls.Add(this.textBoxAliciAdres3M);
            this.groupBoxPasaport.Controls.Add(this.textBoxAliciAdres2M);
            this.groupBoxPasaport.Controls.Add(this.textBoxAliciAdres1M);
            this.groupBoxPasaport.Controls.Add(this.label9);
            this.groupBoxPasaport.Controls.Add(this.textBoxAliciAdSoyad2M);
            this.groupBoxPasaport.Controls.Add(this.textBoxAliciAdSoyad1M);
            this.groupBoxPasaport.Controls.Add(this.label8);
            this.groupBoxPasaport.Controls.Add(this.pictureBox1);
            this.groupBoxPasaport.Location = new System.Drawing.Point(90, 66);
            this.groupBoxPasaport.Name = "groupBoxPasaport";
            this.groupBoxPasaport.Size = new System.Drawing.Size(358, 531);
            this.groupBoxPasaport.TabIndex = 7;
            this.groupBoxPasaport.TabStop = false;
            // 
            // textBoxPTTBarkodM
            // 
            this.textBoxPTTBarkodM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxPTTBarkodM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPTTBarkodM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPTTBarkodM.Location = new System.Drawing.Point(141, 90);
            this.textBoxPTTBarkodM.Name = "textBoxPTTBarkodM";
            this.textBoxPTTBarkodM.ReadOnly = true;
            this.textBoxPTTBarkodM.Size = new System.Drawing.Size(100, 13);
            this.textBoxPTTBarkodM.TabIndex = 14;
            // 
            // textBoxIadeAdresi3M
            // 
            this.textBoxIadeAdresi3M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxIadeAdresi3M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIadeAdresi3M.Location = new System.Drawing.Point(76, 436);
            this.textBoxIadeAdresi3M.Name = "textBoxIadeAdresi3M";
            this.textBoxIadeAdresi3M.ReadOnly = true;
            this.textBoxIadeAdresi3M.Size = new System.Drawing.Size(216, 13);
            this.textBoxIadeAdresi3M.TabIndex = 15;
            // 
            // textBoxIadeAdresi2M
            // 
            this.textBoxIadeAdresi2M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxIadeAdresi2M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIadeAdresi2M.Location = new System.Drawing.Point(76, 412);
            this.textBoxIadeAdresi2M.Name = "textBoxIadeAdresi2M";
            this.textBoxIadeAdresi2M.ReadOnly = true;
            this.textBoxIadeAdresi2M.Size = new System.Drawing.Size(216, 13);
            this.textBoxIadeAdresi2M.TabIndex = 14;
            // 
            // textBoxIadeAdresi1M
            // 
            this.textBoxIadeAdresi1M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxIadeAdresi1M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIadeAdresi1M.Location = new System.Drawing.Point(76, 387);
            this.textBoxIadeAdresi1M.Name = "textBoxIadeAdresi1M";
            this.textBoxIadeAdresi1M.ReadOnly = true;
            this.textBoxIadeAdresi1M.Size = new System.Drawing.Size(216, 13);
            this.textBoxIadeAdresi1M.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(73, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "İade Adresi :";
            // 
            // textBoxTeslimAlacakKisiM
            // 
            this.textBoxTeslimAlacakKisiM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxTeslimAlacakKisiM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTeslimAlacakKisiM.Location = new System.Drawing.Point(76, 347);
            this.textBoxTeslimAlacakKisiM.Name = "textBoxTeslimAlacakKisiM";
            this.textBoxTeslimAlacakKisiM.ReadOnly = true;
            this.textBoxTeslimAlacakKisiM.Size = new System.Drawing.Size(216, 13);
            this.textBoxTeslimAlacakKisiM.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(73, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Pasaport Sahibi:";
            // 
            // textBoxTelM
            // 
            this.textBoxTelM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxTelM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelM.Location = new System.Drawing.Point(113, 294);
            this.textBoxTelM.Name = "textBoxTelM";
            this.textBoxTelM.ReadOnly = true;
            this.textBoxTelM.Size = new System.Drawing.Size(100, 13);
            this.textBoxTelM.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(73, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "TEL:";
            // 
            // textBoxAliciAdres3M
            // 
            this.textBoxAliciAdres3M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxAliciAdres3M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAliciAdres3M.Location = new System.Drawing.Point(76, 260);
            this.textBoxAliciAdres3M.Name = "textBoxAliciAdres3M";
            this.textBoxAliciAdres3M.ReadOnly = true;
            this.textBoxAliciAdres3M.Size = new System.Drawing.Size(216, 13);
            this.textBoxAliciAdres3M.TabIndex = 7;
            // 
            // textBoxAliciAdres2M
            // 
            this.textBoxAliciAdres2M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxAliciAdres2M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAliciAdres2M.Location = new System.Drawing.Point(76, 234);
            this.textBoxAliciAdres2M.Name = "textBoxAliciAdres2M";
            this.textBoxAliciAdres2M.ReadOnly = true;
            this.textBoxAliciAdres2M.Size = new System.Drawing.Size(216, 13);
            this.textBoxAliciAdres2M.TabIndex = 6;
            // 
            // textBoxAliciAdres1M
            // 
            this.textBoxAliciAdres1M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxAliciAdres1M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAliciAdres1M.Location = new System.Drawing.Point(76, 208);
            this.textBoxAliciAdres1M.Name = "textBoxAliciAdres1M";
            this.textBoxAliciAdres1M.ReadOnly = true;
            this.textBoxAliciAdres1M.Size = new System.Drawing.Size(216, 13);
            this.textBoxAliciAdres1M.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(73, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Teslimat Adresi :";
            // 
            // textBoxAliciAdSoyad2M
            // 
            this.textBoxAliciAdSoyad2M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxAliciAdSoyad2M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAliciAdSoyad2M.Location = new System.Drawing.Point(76, 153);
            this.textBoxAliciAdSoyad2M.Name = "textBoxAliciAdSoyad2M";
            this.textBoxAliciAdSoyad2M.ReadOnly = true;
            this.textBoxAliciAdSoyad2M.Size = new System.Drawing.Size(216, 13);
            this.textBoxAliciAdSoyad2M.TabIndex = 3;
            // 
            // textBoxAliciAdSoyad1M
            // 
            this.textBoxAliciAdSoyad1M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxAliciAdSoyad1M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAliciAdSoyad1M.Location = new System.Drawing.Point(76, 127);
            this.textBoxAliciAdSoyad1M.Name = "textBoxAliciAdSoyad1M";
            this.textBoxAliciAdSoyad1M.ReadOnly = true;
            this.textBoxAliciAdSoyad1M.Size = new System.Drawing.Size(216, 13);
            this.textBoxAliciAdSoyad1M.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(73, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Alıcı Bilgileri :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonManuelPrintM
            // 
            this.buttonManuelPrintM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.buttonManuelPrintM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonManuelPrintM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonManuelPrintM.Location = new System.Drawing.Point(495, 193);
            this.buttonManuelPrintM.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManuelPrintM.Name = "buttonManuelPrintM";
            this.buttonManuelPrintM.Size = new System.Drawing.Size(153, 73);
            this.buttonManuelPrintM.TabIndex = 13;
            this.buttonManuelPrintM.Text = "Yazdır";
            this.buttonManuelPrintM.UseVisualStyleBackColor = false;
            this.buttonManuelPrintM.Click += new System.EventHandler(this.buttonManuelPrintM_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(491, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(292, 24);
            this.label13.TabIndex = 14;
            this.label13.Text = "Pasaport No veya PTT Barkod No";
            // 
            // panelElilePasaportGirdisi
            // 
            this.panelElilePasaportGirdisi.BackColor = System.Drawing.SystemColors.Control;
            this.panelElilePasaportGirdisi.Controls.Add(this.buttonManualCreate);
            this.panelElilePasaportGirdisi.Controls.Add(this.label13);
            this.panelElilePasaportGirdisi.Controls.Add(this.buttonManuelPrintM);
            this.panelElilePasaportGirdisi.Controls.Add(this.groupBoxPasaport);
            this.panelElilePasaportGirdisi.Controls.Add(this.textBoxBarkodM);
            this.panelElilePasaportGirdisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelElilePasaportGirdisi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelElilePasaportGirdisi.Location = new System.Drawing.Point(3, 3);
            this.panelElilePasaportGirdisi.Name = "panelElilePasaportGirdisi";
            this.panelElilePasaportGirdisi.Size = new System.Drawing.Size(888, 705);
            this.panelElilePasaportGirdisi.TabIndex = 18;
            // 
            // buttonManualCreate
            // 
            this.buttonManualCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.buttonManualCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonManualCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonManualCreate.Location = new System.Drawing.Point(666, 193);
            this.buttonManualCreate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManualCreate.Name = "buttonManualCreate";
            this.buttonManualCreate.Size = new System.Drawing.Size(153, 73);
            this.buttonManualCreate.TabIndex = 15;
            this.buttonManualCreate.Text = "İşle";
            this.buttonManualCreate.UseVisualStyleBackColor = false;
            this.buttonManualCreate.Click += new System.EventHandler(this.buttonManualCreate_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStop.BackgroundImage")));
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStop.Location = new System.Drawing.Point(17, 582);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(96, 110);
            this.buttonStop.TabIndex = 16;
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(9, 294);
            this.lstLog.Margin = new System.Windows.Forms.Padding(2);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(819, 277);
            this.lstLog.TabIndex = 33;
            // 
            // btnFinishJob
            // 
            this.btnFinishJob.BackColor = System.Drawing.Color.Transparent;
            this.btnFinishJob.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinishJob.BackgroundImage")));
            this.btnFinishJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFinishJob.FlatAppearance.BorderSize = 0;
            this.btnFinishJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFinishJob.Location = new System.Drawing.Point(782, 582);
            this.btnFinishJob.Name = "btnFinishJob";
            this.btnFinishJob.Size = new System.Drawing.Size(96, 110);
            this.btnFinishJob.TabIndex = 18;
            this.btnFinishJob.UseVisualStyleBackColor = false;
            this.btnFinishJob.Click += new System.EventHandler(this.btnFinishJob_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "Makine Alarmları";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsPackMac
            // 
            this.stsPackMac.BackColor = System.Drawing.Color.YellowGreen;
            this.stsPackMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsPackMac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsPackMac.Location = new System.Drawing.Point(10, 53);
            this.stsPackMac.Name = "stsPackMac";
            this.stsPackMac.Size = new System.Drawing.Size(93, 63);
            this.stsPackMac.TabIndex = 40;
            this.stsPackMac.Text = "Paketleme";
            this.stsPackMac.UseVisualStyleBackColor = false;
            // 
            // stsInputBarcodeReader
            // 
            this.stsInputBarcodeReader.BackColor = System.Drawing.Color.YellowGreen;
            this.stsInputBarcodeReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsInputBarcodeReader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsInputBarcodeReader.Location = new System.Drawing.Point(148, 53);
            this.stsInputBarcodeReader.Name = "stsInputBarcodeReader";
            this.stsInputBarcodeReader.Size = new System.Drawing.Size(93, 63);
            this.stsInputBarcodeReader.TabIndex = 41;
            this.stsInputBarcodeReader.Text = "Giriş Barkod Okuyucu";
            this.stsInputBarcodeReader.UseVisualStyleBackColor = false;
            // 
            // stsPrinter
            // 
            this.stsPrinter.BackColor = System.Drawing.Color.YellowGreen;
            this.stsPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsPrinter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsPrinter.Location = new System.Drawing.Point(287, 53);
            this.stsPrinter.Name = "stsPrinter";
            this.stsPrinter.Size = new System.Drawing.Size(93, 63);
            this.stsPrinter.TabIndex = 42;
            this.stsPrinter.Text = "Etiket Yazıcı";
            this.stsPrinter.UseVisualStyleBackColor = false;
            this.stsPrinter.Click += new System.EventHandler(this.stsPrinter_Click);
            // 
            // stsOutputBarcodereader
            // 
            this.stsOutputBarcodereader.BackColor = System.Drawing.Color.YellowGreen;
            this.stsOutputBarcodereader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsOutputBarcodereader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsOutputBarcodereader.Location = new System.Drawing.Point(426, 53);
            this.stsOutputBarcodereader.Name = "stsOutputBarcodereader";
            this.stsOutputBarcodereader.Size = new System.Drawing.Size(93, 63);
            this.stsOutputBarcodereader.TabIndex = 43;
            this.stsOutputBarcodereader.Text = "Çıkış Barkod Okuyucu";
            this.stsOutputBarcodereader.UseVisualStyleBackColor = false;
            // 
            // stsOutput
            // 
            this.stsOutput.BackColor = System.Drawing.Color.YellowGreen;
            this.stsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsOutput.Location = new System.Drawing.Point(785, 53);
            this.stsOutput.Name = "stsOutput";
            this.stsOutput.Size = new System.Drawing.Size(93, 63);
            this.stsOutput.TabIndex = 44;
            this.stsOutput.Text = "Çıkış";
            this.stsOutput.UseVisualStyleBackColor = false;
            // 
            // stsDrawer1
            // 
            this.stsDrawer1.BackColor = System.Drawing.Color.YellowGreen;
            this.stsDrawer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsDrawer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsDrawer1.Location = new System.Drawing.Point(564, 143);
            this.stsDrawer1.Name = "stsDrawer1";
            this.stsDrawer1.Size = new System.Drawing.Size(78, 63);
            this.stsDrawer1.TabIndex = 45;
            this.stsDrawer1.Text = "Çekmece 1";
            this.stsDrawer1.UseVisualStyleBackColor = false;
            // 
            // stsDrawer2
            // 
            this.stsDrawer2.BackColor = System.Drawing.Color.YellowGreen;
            this.stsDrawer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsDrawer2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsDrawer2.Location = new System.Drawing.Point(662, 143);
            this.stsDrawer2.Name = "stsDrawer2";
            this.stsDrawer2.Size = new System.Drawing.Size(78, 63);
            this.stsDrawer2.TabIndex = 46;
            this.stsDrawer2.Text = "Çekmece 2";
            this.stsDrawer2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(109, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // panelAlarm
            // 
            this.panelAlarm.Controls.Add(this.stsDrawerTopDoor);
            this.panelAlarm.Controls.Add(this.numericUpDownProductCount);
            this.panelAlarm.Controls.Add(this.txtOutPassCount);
            this.panelAlarm.Controls.Add(this.labelMachineWorkingState);
            this.panelAlarm.Controls.Add(this.buttonPrinterClear);
            this.panelAlarm.Controls.Add(this.txtPrinterBox);
            this.panelAlarm.Controls.Add(this.buttonProductCount);
            this.panelAlarm.Controls.Add(this.label20);
            this.panelAlarm.Controls.Add(this.txtOutputBReader);
            this.panelAlarm.Controls.Add(this.txtInputBReader);
            this.panelAlarm.Controls.Add(this.stsDoors);
            this.panelAlarm.Controls.Add(this.stsLine);
            this.panelAlarm.Controls.Add(this.pictureBox8);
            this.panelAlarm.Controls.Add(this.pictureBox7);
            this.panelAlarm.Controls.Add(this.pictureBox6);
            this.panelAlarm.Controls.Add(this.pictureBox5);
            this.panelAlarm.Controls.Add(this.pictureBox4);
            this.panelAlarm.Controls.Add(this.pictureBox3);
            this.panelAlarm.Controls.Add(this.pictureBox2);
            this.panelAlarm.Controls.Add(this.stsDrawer2);
            this.panelAlarm.Controls.Add(this.stsDrawer1);
            this.panelAlarm.Controls.Add(this.stsOutput);
            this.panelAlarm.Controls.Add(this.stsOutputBarcodereader);
            this.panelAlarm.Controls.Add(this.stsPrinter);
            this.panelAlarm.Controls.Add(this.stsInputBarcodeReader);
            this.panelAlarm.Controls.Add(this.stsPackMac);
            this.panelAlarm.Controls.Add(this.label5);
            this.panelAlarm.Controls.Add(this.lstLog);
            this.panelAlarm.Controls.Add(this.buttonStop);
            this.panelAlarm.Controls.Add(this.btnClearLogs);
            this.panelAlarm.Controls.Add(this.btnFinishJob);
            this.panelAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlarm.Location = new System.Drawing.Point(3, 3);
            this.panelAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.panelAlarm.Name = "panelAlarm";
            this.panelAlarm.Size = new System.Drawing.Size(888, 705);
            this.panelAlarm.TabIndex = 14;
            // 
            // stsDrawerTopDoor
            // 
            this.stsDrawerTopDoor.BackColor = System.Drawing.Color.YellowGreen;
            this.stsDrawerTopDoor.Location = new System.Drawing.Point(564, 22);
            this.stsDrawerTopDoor.Name = "stsDrawerTopDoor";
            this.stsDrawerTopDoor.Size = new System.Drawing.Size(176, 21);
            this.stsDrawerTopDoor.TabIndex = 71;
            this.stsDrawerTopDoor.UseVisualStyleBackColor = false;
            // 
            // numericUpDownProductCount
            // 
            this.numericUpDownProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownProductCount.Location = new System.Drawing.Point(729, 238);
            this.numericUpDownProductCount.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownProductCount.Name = "numericUpDownProductCount";
            this.numericUpDownProductCount.Size = new System.Drawing.Size(59, 26);
            this.numericUpDownProductCount.TabIndex = 70;
            // 
            // txtOutPassCount
            // 
            this.txtOutPassCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOutPassCount.Location = new System.Drawing.Point(785, 126);
            this.txtOutPassCount.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutPassCount.Name = "txtOutPassCount";
            this.txtOutPassCount.ReadOnly = true;
            this.txtOutPassCount.Size = new System.Drawing.Size(94, 26);
            this.txtOutPassCount.TabIndex = 69;
            // 
            // labelMachineWorkingState
            // 
            this.labelMachineWorkingState.AutoSize = true;
            this.labelMachineWorkingState.BackColor = System.Drawing.Color.Transparent;
            this.labelMachineWorkingState.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMachineWorkingState.Location = new System.Drawing.Point(447, 617);
            this.labelMachineWorkingState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMachineWorkingState.Name = "labelMachineWorkingState";
            this.labelMachineWorkingState.Size = new System.Drawing.Size(229, 39);
            this.labelMachineWorkingState.TabIndex = 68;
            this.labelMachineWorkingState.Text = "Makine Durdu";
            this.labelMachineWorkingState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPrinterClear
            // 
            this.buttonPrinterClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrinterClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrinterClear.BackgroundImage")));
            this.buttonPrinterClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrinterClear.FlatAppearance.BorderSize = 0;
            this.buttonPrinterClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrinterClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPrinterClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPrinterClear.Location = new System.Drawing.Point(245, 582);
            this.buttonPrinterClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPrinterClear.Name = "buttonPrinterClear";
            this.buttonPrinterClear.Size = new System.Drawing.Size(96, 110);
            this.buttonPrinterClear.TabIndex = 44;
            this.buttonPrinterClear.UseVisualStyleBackColor = false;
            this.buttonPrinterClear.Click += new System.EventHandler(this.buttonPrinterClear_Click);
            // 
            // txtPrinterBox
            // 
            this.txtPrinterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrinterBox.Location = new System.Drawing.Point(287, 126);
            this.txtPrinterBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrinterBox.Name = "txtPrinterBox";
            this.txtPrinterBox.ReadOnly = true;
            this.txtPrinterBox.Size = new System.Drawing.Size(94, 26);
            this.txtPrinterBox.TabIndex = 62;
            // 
            // buttonProductCount
            // 
            this.buttonProductCount.BackColor = System.Drawing.Color.Transparent;
            this.buttonProductCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProductCount.BackgroundImage")));
            this.buttonProductCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProductCount.FlatAppearance.BorderSize = 0;
            this.buttonProductCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductCount.Location = new System.Drawing.Point(786, 229);
            this.buttonProductCount.Name = "buttonProductCount";
            this.buttonProductCount.Size = new System.Drawing.Size(49, 42);
            this.buttonProductCount.TabIndex = 61;
            this.buttonProductCount.UseVisualStyleBackColor = false;
            this.buttonProductCount.Click += new System.EventHandler(this.buttonProductCount_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(626, 240);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 20);
            this.label20.TabIndex = 58;
            this.label20.Text = "Paket Sayısı :";
            // 
            // txtOutputBReader
            // 
            this.txtOutputBReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOutputBReader.Location = new System.Drawing.Point(409, 126);
            this.txtOutputBReader.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutputBReader.Name = "txtOutputBReader";
            this.txtOutputBReader.ReadOnly = true;
            this.txtOutputBReader.Size = new System.Drawing.Size(130, 26);
            this.txtOutputBReader.TabIndex = 57;
            // 
            // txtInputBReader
            // 
            this.txtInputBReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInputBReader.Location = new System.Drawing.Point(148, 126);
            this.txtInputBReader.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputBReader.Name = "txtInputBReader";
            this.txtInputBReader.ReadOnly = true;
            this.txtInputBReader.Size = new System.Drawing.Size(94, 26);
            this.txtInputBReader.TabIndex = 14;
            // 
            // stsDoors
            // 
            this.stsDoors.BackColor = System.Drawing.Color.YellowGreen;
            this.stsDoors.Location = new System.Drawing.Point(148, 22);
            this.stsDoors.Name = "stsDoors";
            this.stsDoors.Size = new System.Drawing.Size(371, 21);
            this.stsDoors.TabIndex = 56;
            this.stsDoors.UseVisualStyleBackColor = false;
            // 
            // stsLine
            // 
            this.stsLine.BackColor = System.Drawing.Color.YellowGreen;
            this.stsLine.Location = new System.Drawing.Point(564, 67);
            this.stsLine.Name = "stsLine";
            this.stsLine.Size = new System.Drawing.Size(176, 35);
            this.stsLine.TabIndex = 55;
            this.stsLine.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(690, 106);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(23, 27);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 53;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(592, 106);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(23, 27);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 52;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(746, 67);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 51;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(525, 67);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 50;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(387, 67);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(246, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.BackColor = System.Drawing.Color.Transparent;
            this.btnClearLogs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearLogs.BackgroundImage")));
            this.btnClearLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearLogs.FlatAppearance.BorderSize = 0;
            this.btnClearLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClearLogs.Location = new System.Drawing.Point(131, 582);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(96, 110);
            this.btnClearLogs.TabIndex = 63;
            this.btnClearLogs.UseVisualStyleBackColor = false;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            // 
            // tabMain
            // 
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tbpHome);
            this.tabMain.Controls.Add(this.tbpManuel);
            this.tabMain.Controls.Add(this.tbpDbSettings);
            this.tabMain.Controls.Add(this.tbpSettings);
            this.tabMain.ItemSize = new System.Drawing.Size(0, 1);
            this.tabMain.Location = new System.Drawing.Point(122, 50);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Drawing.Point(0, 0);
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(902, 720);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 35;
            // 
            // tbpHome
            // 
            this.tbpHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbpHome.Controls.Add(this.panelAlarm);
            this.tbpHome.Location = new System.Drawing.Point(4, 5);
            this.tbpHome.Name = "tbpHome";
            this.tbpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHome.Size = new System.Drawing.Size(894, 711);
            this.tbpHome.TabIndex = 0;
            this.tbpHome.UseVisualStyleBackColor = true;
            // 
            // tbpManuel
            // 
            this.tbpManuel.Controls.Add(this.panelElilePasaportGirdisi);
            this.tbpManuel.Location = new System.Drawing.Point(4, 5);
            this.tbpManuel.Name = "tbpManuel";
            this.tbpManuel.Padding = new System.Windows.Forms.Padding(3);
            this.tbpManuel.Size = new System.Drawing.Size(894, 711);
            this.tbpManuel.TabIndex = 1;
            this.tbpManuel.UseVisualStyleBackColor = true;
            // 
            // tbpDbSettings
            // 
            this.tbpDbSettings.Controls.Add(this.panelIzleme);
            this.tbpDbSettings.Location = new System.Drawing.Point(4, 5);
            this.tbpDbSettings.Name = "tbpDbSettings";
            this.tbpDbSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDbSettings.Size = new System.Drawing.Size(894, 711);
            this.tbpDbSettings.TabIndex = 2;
            this.tbpDbSettings.UseVisualStyleBackColor = true;
            // 
            // tbpSettings
            // 
            this.tbpSettings.Controls.Add(this.panelAyarlar);
            this.tbpSettings.Location = new System.Drawing.Point(4, 5);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSettings.Size = new System.Drawing.Size(894, 711);
            this.tbpSettings.TabIndex = 3;
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.ledBulbPLCOepn);
            this.panel2.Controls.Add(this.ledBulbWorkState);
            this.panel2.Controls.Add(this.label42);
            this.panel2.Controls.Add(this.lblPageTitle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 53);
            this.panel2.TabIndex = 36;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label26.Location = new System.Drawing.Point(850, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 13);
            this.label26.TabIndex = 70;
            this.label26.Text = "PLC";
            // 
            // ledBulbPLCOepn
            // 
            this.ledBulbPLCOepn.Color = System.Drawing.Color.Red;
            this.ledBulbPLCOepn.Location = new System.Drawing.Point(880, 8);
            this.ledBulbPLCOepn.Name = "ledBulbPLCOepn";
            this.ledBulbPLCOepn.On = true;
            this.ledBulbPLCOepn.Size = new System.Drawing.Size(38, 33);
            this.ledBulbPLCOepn.TabIndex = 69;
            // 
            // ledBulbWorkState
            // 
            this.ledBulbWorkState.Color = System.Drawing.Color.Red;
            this.ledBulbWorkState.Location = new System.Drawing.Point(974, 8);
            this.ledBulbWorkState.Name = "ledBulbWorkState";
            this.ledBulbWorkState.On = true;
            this.ledBulbWorkState.Size = new System.Drawing.Size(38, 33);
            this.ledBulbWorkState.TabIndex = 68;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label42.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label42.Location = new System.Drawing.Point(920, 20);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(50, 13);
            this.label42.TabIndex = 6;
            this.label42.Text = "Çalışma";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPageTitle.Location = new System.Drawing.Point(432, 10);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(128, 29);
            this.lblPageTitle.TabIndex = 4;
            this.lblPageTitle.Text = "Ana Sayfa";
            // 
            // buttonDatabaseProcess
            // 
            this.buttonDatabaseProcess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDatabaseProcess.BackgroundImage")));
            this.buttonDatabaseProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDatabaseProcess.FlatAppearance.BorderSize = 0;
            this.buttonDatabaseProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDatabaseProcess.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonDatabaseProcess.Location = new System.Drawing.Point(17, 362);
            this.buttonDatabaseProcess.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDatabaseProcess.Name = "buttonDatabaseProcess";
            this.buttonDatabaseProcess.Size = new System.Drawing.Size(87, 89);
            this.buttonDatabaseProcess.TabIndex = 5;
            this.buttonDatabaseProcess.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDatabaseProcess.UseVisualStyleBackColor = true;
            this.buttonDatabaseProcess.Click += new System.EventHandler(this.buttonDatabaseProcess_Click);
            // 
            // buttonProductReport
            // 
            this.buttonProductReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProductReport.BackgroundImage")));
            this.buttonProductReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProductReport.FlatAppearance.BorderSize = 0;
            this.buttonProductReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonProductReport.Location = new System.Drawing.Point(17, 23);
            this.buttonProductReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProductReport.Name = "buttonProductReport";
            this.buttonProductReport.Size = new System.Drawing.Size(87, 89);
            this.buttonProductReport.TabIndex = 9;
            this.buttonProductReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProductReport.UseVisualStyleBackColor = true;
            this.buttonProductReport.Click += new System.EventHandler(this.buttonProductReport_Click);
            // 
            // buttonElilePasaportGirisi
            // 
            this.buttonElilePasaportGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonElilePasaportGirisi.BackgroundImage")));
            this.buttonElilePasaportGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonElilePasaportGirisi.FlatAppearance.BorderSize = 0;
            this.buttonElilePasaportGirisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonElilePasaportGirisi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonElilePasaportGirisi.Location = new System.Drawing.Point(17, 131);
            this.buttonElilePasaportGirisi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonElilePasaportGirisi.Name = "buttonElilePasaportGirisi";
            this.buttonElilePasaportGirisi.Size = new System.Drawing.Size(87, 89);
            this.buttonElilePasaportGirisi.TabIndex = 6;
            this.buttonElilePasaportGirisi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonElilePasaportGirisi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonElilePasaportGirisi.UseVisualStyleBackColor = true;
            this.buttonElilePasaportGirisi.Click += new System.EventHandler(this.buttonElilePasaportGirisi_Click);
            // 
            // buttonAyarlar
            // 
            this.buttonAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.buttonAyarlar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAyarlar.BackgroundImage")));
            this.buttonAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAyarlar.FlatAppearance.BorderSize = 0;
            this.buttonAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyarlar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAyarlar.Location = new System.Drawing.Point(17, 244);
            this.buttonAyarlar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAyarlar.Name = "buttonAyarlar";
            this.buttonAyarlar.Size = new System.Drawing.Size(87, 89);
            this.buttonAyarlar.TabIndex = 11;
            this.buttonAyarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAyarlar.UseVisualStyleBackColor = false;
            this.buttonAyarlar.Click += new System.EventHandler(this.buttonAyarlar_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonExit.Location = new System.Drawing.Point(17, 593);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(87, 89);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonAyarlar);
            this.panel1.Controls.Add(this.buttonElilePasaportGirisi);
            this.panel1.Controls.Add(this.buttonProductReport);
            this.panel1.Controls.Add(this.buttonDatabaseProcess);
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 717);
            this.panel1.TabIndex = 4;
            // 
            // buttonPrintPassportSearch
            // 
            this.buttonPrintPassportSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPrintPassportSearch.Location = new System.Drawing.Point(703, 58);
            this.buttonPrintPassportSearch.Name = "buttonPrintPassportSearch";
            this.buttonPrintPassportSearch.Size = new System.Drawing.Size(134, 38);
            this.buttonPrintPassportSearch.TabIndex = 17;
            this.buttonPrintPassportSearch.Text = "Yazdır";
            this.buttonPrintPassportSearch.UseVisualStyleBackColor = true;
            this.buttonPrintPassportSearch.Click += new System.EventHandler(this.buttonPrintPassportSearch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Gönpa Pasaport Otomasyonu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelIzleme.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPassports)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBatches)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panelAyarlar.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConveyourLongStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVaccuumSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConveyourShortStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudConveyorSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExternalConvStop)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncoderReadTimeSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncoderThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncoderStepCount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxBlowOffset)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxReject1BlowTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDrawer2Mask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxDrawer1Mask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxReject2BlowTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRejectOutTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxRejectInputTime)).EndInit();
            this.groupBoxPasaport.ResumeLayout(false);
            this.groupBoxPasaport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelElilePasaportGirdisi.ResumeLayout(false);
            this.panelElilePasaportGirdisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelAlarm.ResumeLayout(false);
            this.panelAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tbpHome.ResumeLayout(false);
            this.tbpManuel.ResumeLayout(false);
            this.tbpDbSettings.ResumeLayout(false);
            this.tbpSettings.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BackgroundWorker backgroundWorker2;
        private Label label1;
        private Label label3;
        private Panel panelIzleme;
        private Button button1;
        private Panel panelAyarlar;
        private Label labelBlowerOffset;
        private Label label4;
        private Label labelPistonRunOption;
        private CheckBox checkBoxPistonRunOption;
        private TextBox textBoxBarkodM;
        private GroupBox groupBoxPasaport;
        private TextBox textBoxPTTBarkodM;
        private TextBox textBoxIadeAdresi3M;
        private TextBox textBoxIadeAdresi2M;
        private TextBox textBoxIadeAdresi1M;
        private Label label12;
        private TextBox textBoxTeslimAlacakKisiM;
        private Label label11;
        private TextBox textBoxTelM;
        private Label label10;
        private TextBox textBoxAliciAdres3M;
        private TextBox textBoxAliciAdres2M;
        private TextBox textBoxAliciAdres1M;
        private Label label9;
        private TextBox textBoxAliciAdSoyad2M;
        private TextBox textBoxAliciAdSoyad1M;
        private Label label8;
        private PictureBox pictureBox1;
        private Button buttonManuelPrintM;
        private Label label13;
        private Panel panelElilePasaportGirdisi;
        private Button buttonStop;
        private ListBox lstLog;
        private Button btnFinishJob;
        private Label label5;
        private Button stsPackMac;
        private Button stsInputBarcodeReader;
        private Button stsPrinter;
        private Button stsOutputBarcodereader;
        private Button stsOutput;
        private Button stsDrawer1;
        private Button stsDrawer2;
        private PictureBox pictureBox2;
        private Panel panelAlarm;
        private Button buttonProductCount;
        private Label label20;
        private TextBox txtOutputBReader;
        private TextBox txtInputBReader;
        private Button stsDoors;
        private Button stsLine;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private TextBox txtPrinterBox;
        private Button btnClearLogs;
        private Button buttonbuttonSettingsApply;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label24;
        private Label label23;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private GroupBox groupBox3;
        private Label label14;
        private Label label27;
        private GroupBox groupBox4;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label34;
        private TextBox textBoxEncoderC251;
        private Label label25;
        private TabControl tabMain;
        private TabPage tbpManuel;
        private TabPage tbpDbSettings;
        private TabPage tbpSettings;
        private TabPage tbpHome;
        private Panel panel2;
        private Label lblPageTitle;
        private Label label2;
        private TextBox txtSearchBatchCode;
        private Button btnSearchDb;
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label37;
        private Label label36;
        private TextBox txtSearchSinglePassport;
        private Button btnSearchSinglePassport;
        private Label label35;
        private TabPage tabPage3;
        private Label lblBatchCode;
        private Label lblState;
        private Label lblPttBarcode;
        private Label lblPassNo;
        private Label lblPassOwner;
        private TextBox txtSearchBatchList;
        private Button btnSearchBatchCode;
        private Label label41;
        private DataGridView dgwBatches;
        private TabPage tabPage4;
        private Button buttonDatabseClear;
        private Label label42;
        private DataGridView dgwPassports;
        private Button buttonDatabaseProcess;
        private Button buttonProductReport;
        private Button buttonElilePasaportGirisi;
        private Button buttonAyarlar;
        private Button buttonExit;
        private Panel panel1;
        private Button btnSaveDbSettings;
        private Label label43;
        private TextBox txtDbConnectionString;
        private Button btnTestDBConnection;
        private Button btnFabricSettings;
        private NumericUpDown textBoxBlowOffset;
        private NumericUpDown textBoxReject1BlowTime;
        private NumericUpDown textBoxDrawer2Mask;
        private NumericUpDown textBoxDrawer1Mask;
        private NumericUpDown textBoxReject2BlowTime;
        private NumericUpDown textBoxRejectOutTime;
        private NumericUpDown textBoxRejectInputTime;
        private Bulb.LedBulb ledBulbWorkState;
        private Bulb.LedBulb ledBulbPLCOepn;
        private ComboBox comboBoxPlcPort;
        private Label label26;
        private Button buttonPrinterClear;
        private Label labelMachineWorkingState;
        private TextBox txtOutPassCount;
        private NumericUpDown numericUpDownProductCount;
        private GroupBox groupBox5;
        private Label label45;
        private CheckBox checkBoxConveyorVaccuum;
        private NumericUpDown numericUpDownExternalConvStop;
        private Label label21;
        private Label label22;
        private NumericUpDown nudEncoderStepCount;
        private Label label44;
        private NumericUpDown nudEncoderThreshold;
        private Label label46;
        private Label label48;
        private NumericUpDown nudEncoderReadTimeSpan;
        private Label label47;
        private Label label50;
        private NumericUpDown nudConveyorSpeed;
        private Label label49;
        private Label label51;
        private NumericUpDown nudVaccuumSpeed;
        private Label label52;
        private Button btnOutputLong;
        private Button btnOutputShort;
        private NumericUpDown nudConveyourLongStep;
        private Label label54;
        private NumericUpDown nudConveyourShortStep;
        private Label label53;
        private GroupBox groupBox6;
        private CheckBox chkStopMachineOnFinish;
        private Label label56;
        private Button buttonManualCreate;
        private Button stsDrawerTopDoor;
        private GroupBox groupBox7;
        private Label label57;
        private TextBox textBoxCounter;
        private Label label55;
        private TextBox textBoxOutputBarcodeIP;
        private Label label7;
        private TextBox textBoxInputBarcodeIP;
        private Label label19;
        private TextBox textBoxPrinterIpAddress;
        private Label labelPrinterIpAddress;
        private GroupBox groupBox8;
        private Label label58;
        private CheckBox checkBoxDrawerDoor;
        private Button buttonPrintPassportSearch;
    }
}

