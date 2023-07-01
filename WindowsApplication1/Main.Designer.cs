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
            this.btnTestDBConnection = new System.Windows.Forms.Button();
            this.btnSaveDbSettings = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.txtDbConnectionString = new System.Windows.Forms.TextBox();
            this.buttonDatabseClear = new System.Windows.Forms.Button();
            this.panelAyarlar = new System.Windows.Forms.Panel();
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
            this.textBoxOutputBarcodeIP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInputBarcodeIP = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPrinterIpAddress = new System.Windows.Forms.TextBox();
            this.labelPrinterIpAddress = new System.Windows.Forms.Label();
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
            this.ledBulbM17 = new Bulb.LedBulb();
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
            this.ledBulbM19 = new Bulb.LedBulb();
            this.ledBulbM15 = new Bulb.LedBulb();
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
            this.button2 = new System.Windows.Forms.Button();
            this.panelIzleme.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPassports)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBatches)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panelAyarlar.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(31, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(428, 59);
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
            this.panelIzleme.Location = new System.Drawing.Point(4, 4);
            this.panelIzleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelIzleme.Name = "panelIzleme";
            this.panelIzleme.Size = new System.Drawing.Size(1187, 869);
            this.panelIzleme.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1156, 873);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgwPassports);
            this.tabPage1.Controls.Add(this.txtSearchBatchCode);
            this.tabPage1.Controls.Add(this.btnSearchDb);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1148, 835);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Paket ?nceleme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgwPassports
            // 
            this.dgwPassports.AllowUserToAddRows = false;
            this.dgwPassports.AllowUserToDeleteRows = false;
            this.dgwPassports.AllowUserToOrderColumns = true;
            this.dgwPassports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPassports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPassports.Location = new System.Drawing.Point(8, 139);
            this.dgwPassports.Margin = new System.Windows.Forms.Padding(4);
            this.dgwPassports.Name = "dgwPassports";
            this.dgwPassports.ReadOnly = true;
            this.dgwPassports.RowHeadersWidth = 51;
            this.dgwPassports.Size = new System.Drawing.Size(1137, 692);
            this.dgwPassports.TabIndex = 16;
            // 
            // txtSearchBatchCode
            // 
            this.txtSearchBatchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBatchCode.Location = new System.Drawing.Point(175, 17);
            this.txtSearchBatchCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBatchCode.Name = "txtSearchBatchCode";
            this.txtSearchBatchCode.Size = new System.Drawing.Size(729, 45);
            this.txtSearchBatchCode.TabIndex = 13;
            this.txtSearchBatchCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBatchCode_KeyPress);
            // 
            // btnSearchDb
            // 
            this.btnSearchDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchDb.Location = new System.Drawing.Point(937, 17);
            this.btnSearchDb.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDb.Name = "btnSearchDb";
            this.btnSearchDb.Size = new System.Drawing.Size(179, 47);
            this.btnSearchDb.TabIndex = 15;
            this.btnSearchDb.Text = "Ara";
            this.btnSearchDb.UseVisualStyleBackColor = true;
            this.btnSearchDb.Click += new System.EventHandler(this.btnSearchDb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Paket Kodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 29);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1148, 835);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pasaport Arama";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblBatchCode
            // 
            this.lblBatchCode.AutoSize = true;
            this.lblBatchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBatchCode.Location = new System.Drawing.Point(268, 342);
            this.lblBatchCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatchCode.Name = "lblBatchCode";
            this.lblBatchCode.Size = new System.Drawing.Size(21, 29);
            this.lblBatchCode.TabIndex = 28;
            this.lblBatchCode.Text = "-";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblState.Location = new System.Drawing.Point(268, 294);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(21, 29);
            this.lblState.TabIndex = 27;
            this.lblState.Text = "-";
            // 
            // lblPttBarcode
            // 
            this.lblPttBarcode.AutoSize = true;
            this.lblPttBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPttBarcode.Location = new System.Drawing.Point(268, 246);
            this.lblPttBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPttBarcode.Name = "lblPttBarcode";
            this.lblPttBarcode.Size = new System.Drawing.Size(21, 29);
            this.lblPttBarcode.TabIndex = 26;
            this.lblPttBarcode.Text = "-";
            // 
            // lblPassNo
            // 
            this.lblPassNo.AutoSize = true;
            this.lblPassNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassNo.Location = new System.Drawing.Point(268, 198);
            this.lblPassNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassNo.Name = "lblPassNo";
            this.lblPassNo.Size = new System.Drawing.Size(21, 29);
            this.lblPassNo.TabIndex = 25;
            this.lblPassNo.Text = "-";
            // 
            // lblPassOwner
            // 
            this.lblPassOwner.AutoSize = true;
            this.lblPassOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassOwner.Location = new System.Drawing.Point(268, 150);
            this.lblPassOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassOwner.Name = "lblPassOwner";
            this.lblPassOwner.Size = new System.Drawing.Size(21, 29);
            this.lblPassOwner.TabIndex = 24;
            this.lblPassOwner.Text = "-";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label40.Location = new System.Drawing.Point(93, 342);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(158, 29);
            this.label40.TabIndex = 23;
            this.label40.Text = "Paket Kodu :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label39.Location = new System.Drawing.Point(152, 294);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(103, 29);
            this.label39.TabIndex = 22;
            this.label39.Text = "Durum :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label38.Location = new System.Drawing.Point(23, 150);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(230, 29);
            this.label38.TabIndex = 21;
            this.label38.Text = "Teslim Alacak Ki?i:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label37.Location = new System.Drawing.Point(109, 246);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(145, 29);
            this.label37.TabIndex = 20;
            this.label37.Text = "Ptt Barkod :";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label36.Location = new System.Drawing.Point(85, 198);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(167, 29);
            this.label36.TabIndex = 19;
            this.label36.Text = "Pasaport No :";
            // 
            // txtSearchSinglePassport
            // 
            this.txtSearchSinglePassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchSinglePassport.Location = new System.Drawing.Point(380, 39);
            this.txtSearchSinglePassport.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchSinglePassport.Name = "txtSearchSinglePassport";
            this.txtSearchSinglePassport.Size = new System.Drawing.Size(539, 45);
            this.txtSearchSinglePassport.TabIndex = 16;
            this.txtSearchSinglePassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchSinglePassport_KeyPress);
            // 
            // btnSearchSinglePassport
            // 
            this.btnSearchSinglePassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchSinglePassport.Location = new System.Drawing.Point(928, 39);
            this.btnSearchSinglePassport.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchSinglePassport.Name = "btnSearchSinglePassport";
            this.btnSearchSinglePassport.Size = new System.Drawing.Size(179, 47);
            this.btnSearchSinglePassport.TabIndex = 18;
            this.btnSearchSinglePassport.Text = "Ara";
            this.btnSearchSinglePassport.UseVisualStyleBackColor = true;
            this.btnSearchSinglePassport.Click += new System.EventHandler(this.btnSearchSinglePassport_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.Location = new System.Drawing.Point(23, 50);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(339, 29);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1148, 835);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Paket Arama";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtSearchBatchList
            // 
            this.txtSearchBatchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchBatchList.Location = new System.Drawing.Point(179, 11);
            this.txtSearchBatchList.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBatchList.Name = "txtSearchBatchList";
            this.txtSearchBatchList.Size = new System.Drawing.Size(729, 45);
            this.txtSearchBatchList.TabIndex = 16;
            this.txtSearchBatchList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchBatchList_KeyPress);
            // 
            // btnSearchBatchCode
            // 
            this.btnSearchBatchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchBatchCode.Location = new System.Drawing.Point(941, 11);
            this.btnSearchBatchCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchBatchCode.Name = "btnSearchBatchCode";
            this.btnSearchBatchCode.Size = new System.Drawing.Size(179, 47);
            this.btnSearchBatchCode.TabIndex = 18;
            this.btnSearchBatchCode.Text = "Ara";
            this.btnSearchBatchCode.UseVisualStyleBackColor = true;
            this.btnSearchBatchCode.Click += new System.EventHandler(this.btnSearchBatchCode_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label41.Location = new System.Drawing.Point(19, 22);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(144, 29);
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
            this.dgwBatches.Location = new System.Drawing.Point(8, 79);
            this.dgwBatches.Margin = new System.Windows.Forms.Padding(4);
            this.dgwBatches.Name = "dgwBatches";
            this.dgwBatches.ReadOnly = true;
            this.dgwBatches.RowHeadersWidth = 51;
            this.dgwBatches.Size = new System.Drawing.Size(1624, 820);
            this.dgwBatches.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnTestDBConnection);
            this.tabPage4.Controls.Add(this.btnSaveDbSettings);
            this.tabPage4.Controls.Add(this.label43);
            this.tabPage4.Controls.Add(this.txtDbConnectionString);
            this.tabPage4.Controls.Add(this.buttonDatabseClear);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1148, 835);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bak?m";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnTestDBConnection
            // 
            this.btnTestDBConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTestDBConnection.Location = new System.Drawing.Point(419, 201);
            this.btnTestDBConnection.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDBConnection.Name = "btnTestDBConnection";
            this.btnTestDBConnection.Size = new System.Drawing.Size(235, 63);
            this.btnTestDBConnection.TabIndex = 17;
            this.btnTestDBConnection.Text = "Ba?lant?y? Test Et";
            this.btnTestDBConnection.UseVisualStyleBackColor = true;
            this.btnTestDBConnection.Click += new System.EventHandler(this.btnTestDBConnection_Click);
            // 
            // btnSaveDbSettings
            // 
            this.btnSaveDbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveDbSettings.Location = new System.Drawing.Point(800, 201);
            this.btnSaveDbSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveDbSettings.Name = "btnSaveDbSettings";
            this.btnSaveDbSettings.Size = new System.Drawing.Size(235, 63);
            this.btnSaveDbSettings.TabIndex = 16;
            this.btnSaveDbSettings.Text = "Ayar Kaydet";
            this.btnSaveDbSettings.UseVisualStyleBackColor = true;
            this.btnSaveDbSettings.Click += new System.EventHandler(this.btnSaveDbSettings_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(8, 34);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(245, 25);
            this.label43.TabIndex = 15;
            this.label43.Text = "Veritaban? ba?lant? adresi";
            // 
            // txtDbConnectionString
            // 
            this.txtDbConnectionString.Location = new System.Drawing.Point(359, 31);
            this.txtDbConnectionString.Margin = new System.Windows.Forms.Padding(4);
            this.txtDbConnectionString.Multiline = true;
            this.txtDbConnectionString.Name = "txtDbConnectionString";
            this.txtDbConnectionString.Size = new System.Drawing.Size(756, 126);
            this.txtDbConnectionString.TabIndex = 14;
            // 
            // buttonDatabseClear
            // 
            this.buttonDatabseClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDatabseClear.Location = new System.Drawing.Point(800, 718);
            this.buttonDatabseClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDatabseClear.Name = "buttonDatabseClear";
            this.buttonDatabseClear.Size = new System.Drawing.Size(316, 90);
            this.buttonDatabseClear.TabIndex = 13;
            this.buttonDatabseClear.Text = "Veritaban?n? temizle";
            this.buttonDatabseClear.UseVisualStyleBackColor = true;
            this.buttonDatabseClear.Click += new System.EventHandler(this.buttonDatabseClear_Click_1);
            // 
            // panelAyarlar
            // 
            this.panelAyarlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panelAyarlar.Controls.Add(this.groupBox6);
            this.panelAyarlar.Controls.Add(this.groupBox5);
            this.panelAyarlar.Controls.Add(this.btnFabricSettings);
            this.panelAyarlar.Controls.Add(this.groupBox4);
            this.panelAyarlar.Controls.Add(this.groupBox3);
            this.panelAyarlar.Controls.Add(this.groupBox2);
            this.panelAyarlar.Controls.Add(this.buttonbuttonSettingsApply);
            this.panelAyarlar.Controls.Add(this.groupBox1);
            this.panelAyarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAyarlar.Location = new System.Drawing.Point(4, 4);
            this.panelAyarlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAyarlar.Name = "panelAyarlar";
            this.panelAyarlar.Size = new System.Drawing.Size(1187, 869);
            this.panelAyarlar.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkStopMachineOnFinish);
            this.groupBox6.Controls.Add(this.label56);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.Location = new System.Drawing.Point(33, 657);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(1134, 104);
            this.groupBox6.TabIndex = 65;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Paket Ayarlar?";
            // 
            // chkStopMachineOnFinish
            // 
            this.chkStopMachineOnFinish.AutoSize = true;
            this.chkStopMachineOnFinish.Location = new System.Drawing.Point(297, 43);
            this.chkStopMachineOnFinish.Name = "chkStopMachineOnFinish";
            this.chkStopMachineOnFinish.Size = new System.Drawing.Size(18, 17);
            this.chkStopMachineOnFinish.TabIndex = 63;
            this.chkStopMachineOnFinish.UseVisualStyleBackColor = true;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(10, 40);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(272, 20);
            this.label56.TabIndex = 62;
            this.label56.Text = "Paket Doldu?unda Makineyi Durdur";
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
            this.groupBox5.Location = new System.Drawing.Point(438, 162);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(729, 167);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Konveyör Ayarlar?";
            // 
            // nudConveyourLongStep
            // 
            this.nudConveyourLongStep.Location = new System.Drawing.Point(520, 115);
            this.nudConveyourLongStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudConveyourLongStep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudConveyourLongStep.Name = "nudConveyourLongStep";
            this.nudConveyourLongStep.Size = new System.Drawing.Size(92, 26);
            this.nudConveyourLongStep.TabIndex = 69;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label51.Location = new System.Drawing.Point(255, 116);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(38, 20);
            this.label51.TabIndex = 66;
            this.label51.Text = "rpm";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(302, 119);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(170, 20);
            this.label54.TabIndex = 68;
            this.label54.Text = "Konveyor Uzun Ad?m";
            // 
            // nudVaccuumSpeed
            // 
            this.nudVaccuumSpeed.Location = new System.Drawing.Point(156, 114);
            this.nudVaccuumSpeed.Margin = new System.Windows.Forms.Padding(4);
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
            this.nudVaccuumSpeed.Size = new System.Drawing.Size(92, 26);
            this.nudVaccuumSpeed.TabIndex = 65;
            this.nudVaccuumSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudConveyourShortStep
            // 
            this.nudConveyourShortStep.Location = new System.Drawing.Point(520, 82);
            this.nudConveyourShortStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudConveyourShortStep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudConveyourShortStep.Name = "nudConveyourShortStep";
            this.nudConveyourShortStep.Size = new System.Drawing.Size(92, 26);
            this.nudConveyourShortStep.TabIndex = 67;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label52.Location = new System.Drawing.Point(40, 117);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(106, 20);
            this.label52.TabIndex = 64;
            this.label52.Text = "Vakum h?z?:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(302, 86);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(169, 20);
            this.label53.TabIndex = 66;
            this.label53.Text = "Konveyor K?sa Ad?m";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label50.Location = new System.Drawing.Point(255, 83);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(31, 20);
            this.label50.TabIndex = 60;
            this.label50.Text = "Hz";
            // 
            // btnOutputLong
            // 
            this.btnOutputLong.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOutputLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOutputLong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOutputLong.Location = new System.Drawing.Point(619, 112);
            this.btnOutputLong.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutputLong.Name = "btnOutputLong";
            this.btnOutputLong.Size = new System.Drawing.Size(101, 31);
            this.btnOutputLong.TabIndex = 65;
            this.btnOutputLong.Text = "Test";
            this.btnOutputLong.UseVisualStyleBackColor = false;
            this.btnOutputLong.Click += new System.EventHandler(this.btnOutputLong_Click);
            // 
            // btnOutputShort
            // 
            this.btnOutputShort.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOutputShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOutputShort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOutputShort.Location = new System.Drawing.Point(619, 75);
            this.btnOutputShort.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutputShort.Name = "btnOutputShort";
            this.btnOutputShort.Size = new System.Drawing.Size(101, 31);
            this.btnOutputShort.TabIndex = 49;
            this.btnOutputShort.Text = "Test";
            this.btnOutputShort.UseVisualStyleBackColor = false;
            this.btnOutputShort.Click += new System.EventHandler(this.btnOutputShort_Click);
            // 
            // nudConveyorSpeed
            // 
            this.nudConveyorSpeed.Location = new System.Drawing.Point(156, 80);
            this.nudConveyorSpeed.Margin = new System.Windows.Forms.Padding(4);
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
            this.nudConveyorSpeed.Size = new System.Drawing.Size(92, 26);
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
            this.label49.Location = new System.Drawing.Point(17, 84);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(124, 20);
            this.label49.TabIndex = 58;
            this.label49.Text = "Konveyör h?z?:";
            // 
            // numericUpDownExternalConvStop
            // 
            this.numericUpDownExternalConvStop.Location = new System.Drawing.Point(303, 36);
            this.numericUpDownExternalConvStop.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownExternalConvStop.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownExternalConvStop.Name = "numericUpDownExternalConvStop";
            this.numericUpDownExternalConvStop.Size = new System.Drawing.Size(92, 26);
            this.numericUpDownExternalConvStop.TabIndex = 56;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(400, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 20);
            this.label21.TabIndex = 57;
            this.label21.Text = "ad?m";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(15, 39);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(255, 20);
            this.label22.TabIndex = 55;
            this.label22.Text = "Harici konveyör durma mesafesi:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label45.Location = new System.Drawing.Point(507, 42);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(111, 20);
            this.label45.TabIndex = 16;
            this.label45.Text = "Bant vakumu:";
            // 
            // checkBoxConveyorVaccuum
            // 
            this.checkBoxConveyorVaccuum.AutoSize = true;
            this.checkBoxConveyorVaccuum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxConveyorVaccuum.Location = new System.Drawing.Point(633, 41);
            this.checkBoxConveyorVaccuum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxConveyorVaccuum.Name = "checkBoxConveyorVaccuum";
            this.checkBoxConveyorVaccuum.Size = new System.Drawing.Size(68, 24);
            this.checkBoxConveyorVaccuum.TabIndex = 17;
            this.checkBoxConveyorVaccuum.Text = "Aç?k";
            this.checkBoxConveyorVaccuum.UseVisualStyleBackColor = true;
            // 
            // btnFabricSettings
            // 
            this.btnFabricSettings.BackColor = System.Drawing.Color.DarkRed;
            this.btnFabricSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFabricSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFabricSettings.Location = new System.Drawing.Point(43, 800);
            this.btnFabricSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnFabricSettings.Name = "btnFabricSettings";
            this.btnFabricSettings.Size = new System.Drawing.Size(187, 69);
            this.btnFabricSettings.TabIndex = 47;
            this.btnFabricSettings.Text = "Fabrika Ayarlar?na Dön";
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
            this.groupBox4.Location = new System.Drawing.Point(33, 531);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1134, 118);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Encoder Ayarlar?";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label48.Location = new System.Drawing.Point(889, 68);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(32, 20);
            this.label48.TabIndex = 64;
            this.label48.Text = "ms";
            // 
            // nudEncoderReadTimeSpan
            // 
            this.nudEncoderReadTimeSpan.Location = new System.Drawing.Point(787, 64);
            this.nudEncoderReadTimeSpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudEncoderReadTimeSpan.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.nudEncoderReadTimeSpan.Name = "nudEncoderReadTimeSpan";
            this.nudEncoderReadTimeSpan.Size = new System.Drawing.Size(92, 26);
            this.nudEncoderReadTimeSpan.TabIndex = 63;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(577, 68);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(182, 20);
            this.label47.TabIndex = 62;
            this.label47.Text = "Encoder Okuma Süresi";
            // 
            // nudEncoderThreshold
            // 
            this.nudEncoderThreshold.Location = new System.Drawing.Point(787, 32);
            this.nudEncoderThreshold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudEncoderThreshold.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudEncoderThreshold.Name = "nudEncoderThreshold";
            this.nudEncoderThreshold.Size = new System.Drawing.Size(92, 26);
            this.nudEncoderThreshold.TabIndex = 61;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(569, 36);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(196, 20);
            this.label46.TabIndex = 60;
            this.label46.Text = "Encoder Düzeltm Ad?m?";
            // 
            // nudEncoderStepCount
            // 
            this.nudEncoderStepCount.Location = new System.Drawing.Point(223, 60);
            this.nudEncoderStepCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudEncoderStepCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudEncoderStepCount.Name = "nudEncoderStepCount";
            this.nudEncoderStepCount.Size = new System.Drawing.Size(92, 26);
            this.nudEncoderStepCount.TabIndex = 59;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(12, 64);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(196, 20);
            this.label44.TabIndex = 58;
            this.label44.Text = "Ç?k?? Encoder Mesafesi";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.Location = new System.Drawing.Point(501, 32);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(50, 20);
            this.label34.TabIndex = 57;
            this.label34.Text = "ad?m";
            // 
            // textBoxEncoderC251
            // 
            this.textBoxEncoderC251.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxEncoderC251.Location = new System.Drawing.Point(223, 26);
            this.textBoxEncoderC251.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEncoderC251.Name = "textBoxEncoderC251";
            this.textBoxEncoderC251.ReadOnly = true;
            this.textBoxEncoderC251.Size = new System.Drawing.Size(272, 30);
            this.textBoxEncoderC251.TabIndex = 43;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(186, 20);
            this.label25.TabIndex = 42;
            this.label25.Text = "Encoder Sinyal Say?s?:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxPlcPort);
            this.groupBox3.Controls.Add(this.textBoxOutputBarcodeIP);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxInputBarcodeIP);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBoxPrinterIpAddress);
            this.groupBox3.Controls.Add(this.labelPrinterIpAddress);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(33, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1125, 127);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Makine Ba?lant? Ayarlar?";
            // 
            // comboBoxPlcPort
            // 
            this.comboBoxPlcPort.FormattingEnabled = true;
            this.comboBoxPlcPort.Location = new System.Drawing.Point(237, 27);
            this.comboBoxPlcPort.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPlcPort.Name = "comboBoxPlcPort";
            this.comboBoxPlcPort.Size = new System.Drawing.Size(224, 28);
            this.comboBoxPlcPort.TabIndex = 48;
            this.comboBoxPlcPort.DropDown += new System.EventHandler(this.comboBoxPlcPort_DropDown);
            // 
            // textBoxOutputBarcodeIP
            // 
            this.textBoxOutputBarcodeIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOutputBarcodeIP.Location = new System.Drawing.Point(713, 75);
            this.textBoxOutputBarcodeIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOutputBarcodeIP.Name = "textBoxOutputBarcodeIP";
            this.textBoxOutputBarcodeIP.Size = new System.Drawing.Size(217, 30);
            this.textBoxOutputBarcodeIP.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(512, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Ç?k?? barkod IP adresi:";
            // 
            // textBoxInputBarcodeIP
            // 
            this.textBoxInputBarcodeIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxInputBarcodeIP.Location = new System.Drawing.Point(237, 75);
            this.textBoxInputBarcodeIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInputBarcodeIP.Name = "textBoxInputBarcodeIP";
            this.textBoxInputBarcodeIP.Size = new System.Drawing.Size(224, 30);
            this.textBoxInputBarcodeIP.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(35, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(176, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Giri? barkod IP adresi:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(44, 33);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(170, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "PLC istasyon adresi :";
            // 
            // textBoxPrinterIpAddress
            // 
            this.textBoxPrinterIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPrinterIpAddress.Location = new System.Drawing.Point(713, 27);
            this.textBoxPrinterIpAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPrinterIpAddress.Name = "textBoxPrinterIpAddress";
            this.textBoxPrinterIpAddress.Size = new System.Drawing.Size(217, 30);
            this.textBoxPrinterIpAddress.TabIndex = 34;
            // 
            // labelPrinterIpAddress
            // 
            this.labelPrinterIpAddress.AutoSize = true;
            this.labelPrinterIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPrinterIpAddress.Location = new System.Drawing.Point(557, 33);
            this.labelPrinterIpAddress.Name = "labelPrinterIpAddress";
            this.labelPrinterIpAddress.Size = new System.Drawing.Size(140, 20);
            this.labelPrinterIpAddress.TabIndex = 33;
            this.labelPrinterIpAddress.Text = "Yaz?c? IP adresi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxBlowOffset);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.labelBlowerOffset);
            this.groupBox2.Controls.Add(this.labelPistonRunOption);
            this.groupBox2.Controls.Add(this.checkBoxPistonRunOption);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(33, 162);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(397, 167);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yaz?c? Ayarlar?";
            // 
            // textBoxBlowOffset
            // 
            this.textBoxBlowOffset.Location = new System.Drawing.Point(235, 37);
            this.textBoxBlowOffset.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBlowOffset.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.textBoxBlowOffset.Name = "textBoxBlowOffset";
            this.textBoxBlowOffset.Size = new System.Drawing.Size(92, 26);
            this.textBoxBlowOffset.TabIndex = 45;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(336, 42);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 20);
            this.label27.TabIndex = 44;
            this.label27.Text = "ms";
            // 
            // labelBlowerOffset
            // 
            this.labelBlowerOffset.AutoSize = true;
            this.labelBlowerOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBlowerOffset.Location = new System.Drawing.Point(77, 39);
            this.labelBlowerOffset.Name = "labelBlowerOffset";
            this.labelBlowerOffset.Size = new System.Drawing.Size(136, 20);
            this.labelBlowerOffset.TabIndex = 14;
            this.labelBlowerOffset.Text = "Etiket pozisyonu:";
            // 
            // labelPistonRunOption
            // 
            this.labelPistonRunOption.AutoSize = true;
            this.labelPistonRunOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPistonRunOption.Location = new System.Drawing.Point(24, 82);
            this.labelPistonRunOption.Name = "labelPistonRunOption";
            this.labelPistonRunOption.Size = new System.Drawing.Size(192, 20);
            this.labelPistonRunOption.TabIndex = 16;
            this.labelPistonRunOption.Text = "Piston çal??ma yöntemi:";
            // 
            // checkBoxPistonRunOption
            // 
            this.checkBoxPistonRunOption.AutoSize = true;
            this.checkBoxPistonRunOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxPistonRunOption.Location = new System.Drawing.Point(235, 81);
            this.checkBoxPistonRunOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxPistonRunOption.Name = "checkBoxPistonRunOption";
            this.checkBoxPistonRunOption.Size = new System.Drawing.Size(98, 24);
            this.checkBoxPistonRunOption.TabIndex = 17;
            this.checkBoxPistonRunOption.Text = "Hareketli";
            this.checkBoxPistonRunOption.UseVisualStyleBackColor = true;
            // 
            // buttonbuttonSettingsApply
            // 
            this.buttonbuttonSettingsApply.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonbuttonSettingsApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonbuttonSettingsApply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonbuttonSettingsApply.Location = new System.Drawing.Point(771, 793);
            this.buttonbuttonSettingsApply.Margin = new System.Windows.Forms.Padding(4);
            this.buttonbuttonSettingsApply.Name = "buttonbuttonSettingsApply";
            this.buttonbuttonSettingsApply.Size = new System.Drawing.Size(305, 73);
            this.buttonbuttonSettingsApply.TabIndex = 39;
            this.buttonbuttonSettingsApply.Text = "Ayarlar? Uygula";
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
            this.groupBox1.Location = new System.Drawing.Point(33, 337);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1134, 186);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çekmece ve Piston Ayarlar?";
            // 
            // textBoxReject1BlowTime
            // 
            this.textBoxReject1BlowTime.Location = new System.Drawing.Point(871, 47);
            this.textBoxReject1BlowTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReject1BlowTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textBoxReject1BlowTime.Name = "textBoxReject1BlowTime";
            this.textBoxReject1BlowTime.Size = new System.Drawing.Size(92, 26);
            this.textBoxReject1BlowTime.TabIndex = 58;
            // 
            // textBoxDrawer2Mask
            // 
            this.textBoxDrawer2Mask.Location = new System.Drawing.Point(959, 135);
            this.textBoxDrawer2Mask.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDrawer2Mask.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.textBoxDrawer2Mask.Name = "textBoxDrawer2Mask";
            this.textBoxDrawer2Mask.Size = new System.Drawing.Size(92, 26);
            this.textBoxDrawer2Mask.TabIndex = 61;
            // 
            // textBoxDrawer1Mask
            // 
            this.textBoxDrawer1Mask.Location = new System.Drawing.Point(412, 138);
            this.textBoxDrawer1Mask.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDrawer1Mask.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.textBoxDrawer1Mask.Name = "textBoxDrawer1Mask";
            this.textBoxDrawer1Mask.Size = new System.Drawing.Size(92, 26);
            this.textBoxDrawer1Mask.TabIndex = 60;
            // 
            // textBoxReject2BlowTime
            // 
            this.textBoxReject2BlowTime.Location = new System.Drawing.Point(871, 91);
            this.textBoxReject2BlowTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReject2BlowTime.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textBoxReject2BlowTime.Name = "textBoxReject2BlowTime";
            this.textBoxReject2BlowTime.Size = new System.Drawing.Size(92, 26);
            this.textBoxReject2BlowTime.TabIndex = 59;
            // 
            // textBoxRejectOutTime
            // 
            this.textBoxRejectOutTime.Location = new System.Drawing.Point(285, 92);
            this.textBoxRejectOutTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRejectOutTime.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.textBoxRejectOutTime.Name = "textBoxRejectOutTime";
            this.textBoxRejectOutTime.Size = new System.Drawing.Size(92, 26);
            this.textBoxRejectOutTime.TabIndex = 57;
            // 
            // textBoxRejectInputTime
            // 
            this.textBoxRejectInputTime.Location = new System.Drawing.Point(285, 48);
            this.textBoxRejectInputTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRejectInputTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.textBoxRejectInputTime.Name = "textBoxRejectInputTime";
            this.textBoxRejectInputTime.Size = new System.Drawing.Size(92, 26);
            this.textBoxRejectInputTime.TabIndex = 46;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.Location = new System.Drawing.Point(1051, 140);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(32, 20);
            this.label33.TabIndex = 56;
            this.label33.Text = "ms";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(514, 144);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(32, 20);
            this.label32.TabIndex = 55;
            this.label32.Text = "ms";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(976, 95);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 20);
            this.label31.TabIndex = 54;
            this.label31.Text = "ms";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(976, 50);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(32, 20);
            this.label30.TabIndex = 53;
            this.label30.Text = "ms";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(391, 95);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(50, 20);
            this.label29.TabIndex = 52;
            this.label29.Text = "ad?m";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.Location = new System.Drawing.Point(391, 48);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 20);
            this.label28.TabIndex = 51;
            this.label28.Text = "ad?m";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(584, 95);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(250, 20);
            this.label24.TabIndex = 49;
            this.label24.Text = "2. Tahliye pistonu üfleme süresi:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(579, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(250, 20);
            this.label23.TabIndex = 47;
            this.label23.Text = "1. Tahliye pistonu üfleme süresi:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(584, 140);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(321, 20);
            this.label18.TabIndex = 46;
            this.label18.Text = "2. Çekmece dolu sensörü bekleme süresi:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(37, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(321, 20);
            this.label17.TabIndex = 44;
            this.label17.Text = "1. Çekmece dolu sensörü bekleme süresi:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(37, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(217, 20);
            this.label16.TabIndex = 41;
            this.label16.Text = "1. Tahliye pistonu mesafesi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(37, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(217, 20);
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
            this.textBoxBarkodM.Location = new System.Drawing.Point(660, 162);
            this.textBoxBarkodM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBarkodM.Name = "textBoxBarkodM";
            this.textBoxBarkodM.Size = new System.Drawing.Size(393, 38);
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
            this.groupBoxPasaport.Location = new System.Drawing.Point(120, 81);
            this.groupBoxPasaport.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPasaport.Name = "groupBoxPasaport";
            this.groupBoxPasaport.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPasaport.Size = new System.Drawing.Size(477, 654);
            this.groupBoxPasaport.TabIndex = 7;
            this.groupBoxPasaport.TabStop = false;
            // 
            // textBoxPTTBarkodM
            // 
            this.textBoxPTTBarkodM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxPTTBarkodM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPTTBarkodM.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPTTBarkodM.Location = new System.Drawing.Point(188, 111);
            this.textBoxPTTBarkodM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPTTBarkodM.Name = "textBoxPTTBarkodM";
            this.textBoxPTTBarkodM.ReadOnly = true;
            this.textBoxPTTBarkodM.Size = new System.Drawing.Size(133, 15);
            this.textBoxPTTBarkodM.TabIndex = 14;
            // 
            // textBoxIadeAdresi3M
            // 
            this.textBoxIadeAdresi3M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxIadeAdresi3M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIadeAdresi3M.Location = new System.Drawing.Point(101, 537);
            this.textBoxIadeAdresi3M.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIadeAdresi3M.Name = "textBoxIadeAdresi3M";
            this.textBoxIadeAdresi3M.ReadOnly = true;
            this.textBoxIadeAdresi3M.Size = new System.Drawing.Size(288, 15);
            this.textBoxIadeAdresi3M.TabIndex = 15;
            // 
            // textBoxIadeAdresi2M
            // 
            this.textBoxIadeAdresi2M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxIadeAdresi2M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIadeAdresi2M.Location = new System.Drawing.Point(101, 507);
            this.textBoxIadeAdresi2M.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIadeAdresi2M.Name = "textBoxIadeAdresi2M";
            this.textBoxIadeAdresi2M.ReadOnly = true;
            this.textBoxIadeAdresi2M.Size = new System.Drawing.Size(288, 15);
            this.textBoxIadeAdresi2M.TabIndex = 14;
            // 
            // textBoxIadeAdresi1M
            // 
            this.textBoxIadeAdresi1M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxIadeAdresi1M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIadeAdresi1M.Location = new System.Drawing.Point(101, 476);
            this.textBoxIadeAdresi1M.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIadeAdresi1M.Name = "textBoxIadeAdresi1M";
            this.textBoxIadeAdresi1M.ReadOnly = true;
            this.textBoxIadeAdresi1M.Size = new System.Drawing.Size(288, 15);
            this.textBoxIadeAdresi1M.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(97, 448);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "?ade Adresi :";
            // 
            // textBoxTeslimAlacakKisiM
            // 
            this.textBoxTeslimAlacakKisiM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxTeslimAlacakKisiM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTeslimAlacakKisiM.Location = new System.Drawing.Point(101, 427);
            this.textBoxTeslimAlacakKisiM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTeslimAlacakKisiM.Name = "textBoxTeslimAlacakKisiM";
            this.textBoxTeslimAlacakKisiM.ReadOnly = true;
            this.textBoxTeslimAlacakKisiM.Size = new System.Drawing.Size(288, 15);
            this.textBoxTeslimAlacakKisiM.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(97, 400);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Pasaport Sahibi:";
            // 
            // textBoxTelM
            // 
            this.textBoxTelM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxTelM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTelM.Location = new System.Drawing.Point(151, 362);
            this.textBoxTelM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelM.Name = "textBoxTelM";
            this.textBoxTelM.ReadOnly = true;
            this.textBoxTelM.Size = new System.Drawing.Size(133, 15);
            this.textBoxTelM.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(97, 362);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "TEL:";
            // 
            // textBoxAliciAdres3M
            // 
            this.textBoxAliciAdres3M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxAliciAdres3M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAliciAdres3M.Location = new System.Drawing.Point(101, 320);
            this.textBoxAliciAdres3M.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAliciAdres3M.Name = "textBoxAliciAdres3M";
            this.textBoxAliciAdres3M.ReadOnly = true;
            this.textBoxAliciAdres3M.Size = new System.Drawing.Size(288, 15);
            this.textBoxAliciAdres3M.TabIndex = 7;
            // 
            // textBoxAliciAdres2M
            // 
            this.textBoxAliciAdres2M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxAliciAdres2M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAliciAdres2M.Location = new System.Drawing.Point(101, 288);
            this.textBoxAliciAdres2M.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAliciAdres2M.Name = "textBoxAliciAdres2M";
            this.textBoxAliciAdres2M.ReadOnly = true;
            this.textBoxAliciAdres2M.Size = new System.Drawing.Size(288, 15);
            this.textBoxAliciAdres2M.TabIndex = 6;
            // 
            // textBoxAliciAdres1M
            // 
            this.textBoxAliciAdres1M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxAliciAdres1M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAliciAdres1M.Location = new System.Drawing.Point(101, 256);
            this.textBoxAliciAdres1M.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAliciAdres1M.Name = "textBoxAliciAdres1M";
            this.textBoxAliciAdres1M.ReadOnly = true;
            this.textBoxAliciAdres1M.Size = new System.Drawing.Size(288, 15);
            this.textBoxAliciAdres1M.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(97, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Teslimat Adresi :";
            // 
            // textBoxAliciAdSoyad2M
            // 
            this.textBoxAliciAdSoyad2M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxAliciAdSoyad2M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAliciAdSoyad2M.Location = new System.Drawing.Point(101, 188);
            this.textBoxAliciAdSoyad2M.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAliciAdSoyad2M.Name = "textBoxAliciAdSoyad2M";
            this.textBoxAliciAdSoyad2M.ReadOnly = true;
            this.textBoxAliciAdSoyad2M.Size = new System.Drawing.Size(288, 15);
            this.textBoxAliciAdSoyad2M.TabIndex = 3;
            // 
            // textBoxAliciAdSoyad1M
            // 
            this.textBoxAliciAdSoyad1M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.textBoxAliciAdSoyad1M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAliciAdSoyad1M.Location = new System.Drawing.Point(101, 156);
            this.textBoxAliciAdSoyad1M.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAliciAdSoyad1M.Name = "textBoxAliciAdSoyad1M";
            this.textBoxAliciAdSoyad1M.ReadOnly = true;
            this.textBoxAliciAdSoyad1M.Size = new System.Drawing.Size(288, 15);
            this.textBoxAliciAdSoyad1M.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(223)))), ((int)(((byte)(4)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(97, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Al?c? Bilgileri :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 625);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonManuelPrintM
            // 
            this.buttonManuelPrintM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.buttonManuelPrintM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonManuelPrintM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonManuelPrintM.Location = new System.Drawing.Point(660, 238);
            this.buttonManuelPrintM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonManuelPrintM.Name = "buttonManuelPrintM";
            this.buttonManuelPrintM.Size = new System.Drawing.Size(204, 90);
            this.buttonManuelPrintM.TabIndex = 13;
            this.buttonManuelPrintM.Text = "Yazd?r";
            this.buttonManuelPrintM.UseVisualStyleBackColor = false;
            this.buttonManuelPrintM.Click += new System.EventHandler(this.buttonManuelPrintM_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(655, 118);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(377, 29);
            this.label13.TabIndex = 14;
            this.label13.Text = "Pasaport No veya PTT Barkod No";
            // 
            // panelElilePasaportGirdisi
            // 
            this.panelElilePasaportGirdisi.BackColor = System.Drawing.SystemColors.Control;
            this.panelElilePasaportGirdisi.Controls.Add(this.button2);
            this.panelElilePasaportGirdisi.Controls.Add(this.label13);
            this.panelElilePasaportGirdisi.Controls.Add(this.buttonManuelPrintM);
            this.panelElilePasaportGirdisi.Controls.Add(this.groupBoxPasaport);
            this.panelElilePasaportGirdisi.Controls.Add(this.textBoxBarkodM);
            this.panelElilePasaportGirdisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelElilePasaportGirdisi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelElilePasaportGirdisi.Location = new System.Drawing.Point(4, 4);
            this.panelElilePasaportGirdisi.Margin = new System.Windows.Forms.Padding(4);
            this.panelElilePasaportGirdisi.Name = "panelElilePasaportGirdisi";
            this.panelElilePasaportGirdisi.Size = new System.Drawing.Size(1187, 869);
            this.panelElilePasaportGirdisi.TabIndex = 18;
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStop.BackgroundImage")));
            this.buttonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStop.Location = new System.Drawing.Point(23, 716);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(128, 135);
            this.buttonStop.TabIndex = 16;
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 16;
            this.lstLog.Location = new System.Drawing.Point(12, 362);
            this.lstLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(1091, 340);
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
            this.btnFinishJob.Location = new System.Drawing.Point(1043, 716);
            this.btnFinishJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinishJob.Name = "btnFinishJob";
            this.btnFinishJob.Size = new System.Drawing.Size(128, 135);
            this.btnFinishJob.TabIndex = 18;
            this.btnFinishJob.UseVisualStyleBackColor = false;
            this.btnFinishJob.Click += new System.EventHandler(this.btnFinishJob_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 31);
            this.label5.TabIndex = 34;
            this.label5.Text = "Makine Alarmları";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsPackMac
            // 
            this.stsPackMac.BackColor = System.Drawing.Color.YellowGreen;
            this.stsPackMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsPackMac.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsPackMac.Location = new System.Drawing.Point(13, 65);
            this.stsPackMac.Margin = new System.Windows.Forms.Padding(4);
            this.stsPackMac.Name = "stsPackMac";
            this.stsPackMac.Size = new System.Drawing.Size(124, 78);
            this.stsPackMac.TabIndex = 40;
            this.stsPackMac.Text = "Paketleme";
            this.stsPackMac.UseVisualStyleBackColor = false;
            // 
            // stsInputBarcodeReader
            // 
            this.stsInputBarcodeReader.BackColor = System.Drawing.Color.YellowGreen;
            this.stsInputBarcodeReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsInputBarcodeReader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsInputBarcodeReader.Location = new System.Drawing.Point(197, 65);
            this.stsInputBarcodeReader.Margin = new System.Windows.Forms.Padding(4);
            this.stsInputBarcodeReader.Name = "stsInputBarcodeReader";
            this.stsInputBarcodeReader.Size = new System.Drawing.Size(124, 78);
            this.stsInputBarcodeReader.TabIndex = 41;
            this.stsInputBarcodeReader.Text = "Giriş Barkod Okuyucu";
            this.stsInputBarcodeReader.UseVisualStyleBackColor = false;
            // 
            // stsPrinter
            // 
            this.stsPrinter.BackColor = System.Drawing.Color.YellowGreen;
            this.stsPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsPrinter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsPrinter.Location = new System.Drawing.Point(383, 65);
            this.stsPrinter.Margin = new System.Windows.Forms.Padding(4);
            this.stsPrinter.Name = "stsPrinter";
            this.stsPrinter.Size = new System.Drawing.Size(124, 78);
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
            this.stsOutputBarcodereader.Location = new System.Drawing.Point(568, 65);
            this.stsOutputBarcodereader.Margin = new System.Windows.Forms.Padding(4);
            this.stsOutputBarcodereader.Name = "stsOutputBarcodereader";
            this.stsOutputBarcodereader.Size = new System.Drawing.Size(124, 78);
            this.stsOutputBarcodereader.TabIndex = 43;
            this.stsOutputBarcodereader.Text = "Çıkış Barkod Okuyucu";
            this.stsOutputBarcodereader.UseVisualStyleBackColor = false;
            // 
            // stsOutput
            // 
            this.stsOutput.BackColor = System.Drawing.Color.YellowGreen;
            this.stsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsOutput.Location = new System.Drawing.Point(1047, 65);
            this.stsOutput.Margin = new System.Windows.Forms.Padding(4);
            this.stsOutput.Name = "stsOutput";
            this.stsOutput.Size = new System.Drawing.Size(124, 78);
            this.stsOutput.TabIndex = 44;
            this.stsOutput.Text = "Çıkış";
            this.stsOutput.UseVisualStyleBackColor = false;
            // 
            // stsDrawer1
            // 
            this.stsDrawer1.BackColor = System.Drawing.Color.YellowGreen;
            this.stsDrawer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsDrawer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsDrawer1.Location = new System.Drawing.Point(752, 176);
            this.stsDrawer1.Margin = new System.Windows.Forms.Padding(4);
            this.stsDrawer1.Name = "stsDrawer1";
            this.stsDrawer1.Size = new System.Drawing.Size(104, 78);
            this.stsDrawer1.TabIndex = 45;
            this.stsDrawer1.Text = "Çekmece 1";
            this.stsDrawer1.UseVisualStyleBackColor = false;
            // 
            // stsDrawer2
            // 
            this.stsDrawer2.BackColor = System.Drawing.Color.YellowGreen;
            this.stsDrawer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stsDrawer2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stsDrawer2.Location = new System.Drawing.Point(883, 176);
            this.stsDrawer2.Margin = new System.Windows.Forms.Padding(4);
            this.stsDrawer2.Name = "stsDrawer2";
            this.stsDrawer2.Size = new System.Drawing.Size(104, 78);
            this.stsDrawer2.TabIndex = 46;
            this.stsDrawer2.Text = "Çekmece 2";
            this.stsDrawer2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(145, 82);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // panelAlarm
            // 
            this.panelAlarm.Controls.Add(this.ledBulbM17);
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
            this.panelAlarm.Location = new System.Drawing.Point(4, 4);
            this.panelAlarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAlarm.Name = "panelAlarm";
            this.panelAlarm.Size = new System.Drawing.Size(1187, 869);
            this.panelAlarm.TabIndex = 14;
            // 
            // ledBulbM17
            // 
            this.ledBulbM17.Color = System.Drawing.Color.Red;
            this.ledBulbM17.Location = new System.Drawing.Point(433, 191);
            this.ledBulbM17.Margin = new System.Windows.Forms.Padding(4);
            this.ledBulbM17.Name = "ledBulbM17";
            this.ledBulbM17.On = true;
            this.ledBulbM17.Size = new System.Drawing.Size(51, 41);
            this.ledBulbM17.TabIndex = 72;
            // 
            // numericUpDownProductCount
            // 
            this.numericUpDownProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownProductCount.Location = new System.Drawing.Point(972, 293);
            this.numericUpDownProductCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownProductCount.Name = "numericUpDownProductCount";
            this.numericUpDownProductCount.Size = new System.Drawing.Size(79, 30);
            this.numericUpDownProductCount.TabIndex = 70;
            // 
            // txtOutPassCount
            // 
            this.txtOutPassCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOutPassCount.Location = new System.Drawing.Point(1047, 155);
            this.txtOutPassCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutPassCount.Name = "txtOutPassCount";
            this.txtOutPassCount.ReadOnly = true;
            this.txtOutPassCount.Size = new System.Drawing.Size(124, 30);
            this.txtOutPassCount.TabIndex = 69;
            // 
            // labelMachineWorkingState
            // 
            this.labelMachineWorkingState.AutoSize = true;
            this.labelMachineWorkingState.BackColor = System.Drawing.Color.Transparent;
            this.labelMachineWorkingState.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMachineWorkingState.Location = new System.Drawing.Point(596, 759);
            this.labelMachineWorkingState.Name = "labelMachineWorkingState";
            this.labelMachineWorkingState.Size = new System.Drawing.Size(279, 48);
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
            this.buttonPrinterClear.Location = new System.Drawing.Point(327, 716);
            this.buttonPrinterClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrinterClear.Name = "buttonPrinterClear";
            this.buttonPrinterClear.Size = new System.Drawing.Size(128, 135);
            this.buttonPrinterClear.TabIndex = 44;
            this.buttonPrinterClear.UseVisualStyleBackColor = false;
            this.buttonPrinterClear.Click += new System.EventHandler(this.buttonPrinterClear_Click);
            // 
            // txtPrinterBox
            // 
            this.txtPrinterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPrinterBox.Location = new System.Drawing.Point(383, 155);
            this.txtPrinterBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrinterBox.Name = "txtPrinterBox";
            this.txtPrinterBox.ReadOnly = true;
            this.txtPrinterBox.Size = new System.Drawing.Size(124, 30);
            this.txtPrinterBox.TabIndex = 62;
            // 
            // buttonProductCount
            // 
            this.buttonProductCount.BackColor = System.Drawing.Color.Transparent;
            this.buttonProductCount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProductCount.BackgroundImage")));
            this.buttonProductCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProductCount.FlatAppearance.BorderSize = 0;
            this.buttonProductCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductCount.Location = new System.Drawing.Point(1048, 282);
            this.buttonProductCount.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProductCount.Name = "buttonProductCount";
            this.buttonProductCount.Size = new System.Drawing.Size(65, 52);
            this.buttonProductCount.TabIndex = 61;
            this.buttonProductCount.UseVisualStyleBackColor = false;
            this.buttonProductCount.Click += new System.EventHandler(this.buttonProductCount_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(835, 295);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 25);
            this.label20.TabIndex = 58;
            this.label20.Text = "Paket Sayısı :";
            // 
            // txtOutputBReader
            // 
            this.txtOutputBReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOutputBReader.Location = new System.Drawing.Point(545, 155);
            this.txtOutputBReader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutputBReader.Name = "txtOutputBReader";
            this.txtOutputBReader.ReadOnly = true;
            this.txtOutputBReader.Size = new System.Drawing.Size(172, 30);
            this.txtOutputBReader.TabIndex = 57;
            // 
            // txtInputBReader
            // 
            this.txtInputBReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInputBReader.Location = new System.Drawing.Point(197, 155);
            this.txtInputBReader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInputBReader.Name = "txtInputBReader";
            this.txtInputBReader.ReadOnly = true;
            this.txtInputBReader.Size = new System.Drawing.Size(124, 30);
            this.txtInputBReader.TabIndex = 14;
            // 
            // stsDoors
            // 
            this.stsDoors.BackColor = System.Drawing.Color.YellowGreen;
            this.stsDoors.Location = new System.Drawing.Point(197, 27);
            this.stsDoors.Margin = new System.Windows.Forms.Padding(4);
            this.stsDoors.Name = "stsDoors";
            this.stsDoors.Size = new System.Drawing.Size(973, 26);
            this.stsDoors.TabIndex = 56;
            this.stsDoors.UseVisualStyleBackColor = false;
            // 
            // stsLine
            // 
            this.stsLine.BackColor = System.Drawing.Color.YellowGreen;
            this.stsLine.Location = new System.Drawing.Point(752, 89);
            this.stsLine.Margin = new System.Windows.Forms.Padding(4);
            this.stsLine.Name = "stsLine";
            this.stsLine.Size = new System.Drawing.Size(235, 28);
            this.stsLine.TabIndex = 55;
            this.stsLine.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(920, 130);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 33);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 53;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(789, 130);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 52;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(995, 82);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 51;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(700, 82);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 50;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(516, 82);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(328, 82);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 43);
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
            this.btnClearLogs.Location = new System.Drawing.Point(175, 716);
            this.btnClearLogs.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(128, 135);
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
            this.tabMain.Location = new System.Drawing.Point(163, 62);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Drawing.Point(0, 0);
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1203, 886);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 35;
            // 
            // tbpHome
            // 
            this.tbpHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbpHome.Controls.Add(this.panelAlarm);
            this.tbpHome.Location = new System.Drawing.Point(4, 5);
            this.tbpHome.Margin = new System.Windows.Forms.Padding(4);
            this.tbpHome.Name = "tbpHome";
            this.tbpHome.Padding = new System.Windows.Forms.Padding(4);
            this.tbpHome.Size = new System.Drawing.Size(1195, 877);
            this.tbpHome.TabIndex = 0;
            this.tbpHome.UseVisualStyleBackColor = true;
            // 
            // tbpManuel
            // 
            this.tbpManuel.Controls.Add(this.panelElilePasaportGirdisi);
            this.tbpManuel.Location = new System.Drawing.Point(4, 5);
            this.tbpManuel.Margin = new System.Windows.Forms.Padding(4);
            this.tbpManuel.Name = "tbpManuel";
            this.tbpManuel.Padding = new System.Windows.Forms.Padding(4);
            this.tbpManuel.Size = new System.Drawing.Size(1195, 877);
            this.tbpManuel.TabIndex = 1;
            this.tbpManuel.UseVisualStyleBackColor = true;
            // 
            // tbpDbSettings
            // 
            this.tbpDbSettings.Controls.Add(this.panelIzleme);
            this.tbpDbSettings.Location = new System.Drawing.Point(4, 5);
            this.tbpDbSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tbpDbSettings.Name = "tbpDbSettings";
            this.tbpDbSettings.Padding = new System.Windows.Forms.Padding(4);
            this.tbpDbSettings.Size = new System.Drawing.Size(1195, 877);
            this.tbpDbSettings.TabIndex = 2;
            this.tbpDbSettings.UseVisualStyleBackColor = true;
            // 
            // tbpSettings
            // 
            this.tbpSettings.Controls.Add(this.panelAyarlar);
            this.tbpSettings.Location = new System.Drawing.Point(4, 5);
            this.tbpSettings.Margin = new System.Windows.Forms.Padding(4);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Padding = new System.Windows.Forms.Padding(4);
            this.tbpSettings.Size = new System.Drawing.Size(1195, 877);
            this.tbpSettings.TabIndex = 3;
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.ledBulbM19);
            this.panel2.Controls.Add(this.ledBulbM15);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.ledBulbPLCOepn);
            this.panel2.Controls.Add(this.ledBulbWorkState);
            this.panel2.Controls.Add(this.label42);
            this.panel2.Controls.Add(this.lblPageTitle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1365, 65);
            this.panel2.TabIndex = 36;
            // 
            // ledBulbM19
            // 
            this.ledBulbM19.Color = System.Drawing.Color.Red;
            this.ledBulbM19.Location = new System.Drawing.Point(963, 17);
            this.ledBulbM19.Margin = new System.Windows.Forms.Padding(4);
            this.ledBulbM19.Name = "ledBulbM19";
            this.ledBulbM19.On = true;
            this.ledBulbM19.Size = new System.Drawing.Size(51, 41);
            this.ledBulbM19.TabIndex = 72;
            // 
            // ledBulbM15
            // 
            this.ledBulbM15.Color = System.Drawing.Color.Red;
            this.ledBulbM15.Location = new System.Drawing.Point(904, 17);
            this.ledBulbM15.Margin = new System.Windows.Forms.Padding(4);
            this.ledBulbM15.Name = "ledBulbM15";
            this.ledBulbM15.On = true;
            this.ledBulbM15.Size = new System.Drawing.Size(51, 41);
            this.ledBulbM15.TabIndex = 71;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label26.Location = new System.Drawing.Point(1133, 25);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 17);
            this.label26.TabIndex = 70;
            this.label26.Text = "PLC";
            // 
            // ledBulbPLCOepn
            // 
            this.ledBulbPLCOepn.Color = System.Drawing.Color.Red;
            this.ledBulbPLCOepn.Location = new System.Drawing.Point(1173, 10);
            this.ledBulbPLCOepn.Margin = new System.Windows.Forms.Padding(4);
            this.ledBulbPLCOepn.Name = "ledBulbPLCOepn";
            this.ledBulbPLCOepn.On = true;
            this.ledBulbPLCOepn.Size = new System.Drawing.Size(51, 41);
            this.ledBulbPLCOepn.TabIndex = 69;
            // 
            // ledBulbWorkState
            // 
            this.ledBulbWorkState.Color = System.Drawing.Color.Red;
            this.ledBulbWorkState.Location = new System.Drawing.Point(1299, 10);
            this.ledBulbWorkState.Margin = new System.Windows.Forms.Padding(4);
            this.ledBulbWorkState.Name = "ledBulbWorkState";
            this.ledBulbWorkState.On = true;
            this.ledBulbWorkState.Size = new System.Drawing.Size(51, 41);
            this.ledBulbWorkState.TabIndex = 68;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label42.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label42.Location = new System.Drawing.Point(1227, 25);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(64, 17);
            this.label42.TabIndex = 6;
            this.label42.Text = "Çalışma";
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPageTitle.Location = new System.Drawing.Point(576, 12);
            this.lblPageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(161, 36);
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
            this.buttonDatabaseProcess.Location = new System.Drawing.Point(23, 446);
            this.buttonDatabaseProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDatabaseProcess.Name = "buttonDatabaseProcess";
            this.buttonDatabaseProcess.Size = new System.Drawing.Size(116, 110);
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
            this.buttonProductReport.Location = new System.Drawing.Point(23, 28);
            this.buttonProductReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProductReport.Name = "buttonProductReport";
            this.buttonProductReport.Size = new System.Drawing.Size(116, 110);
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
            this.buttonElilePasaportGirisi.Location = new System.Drawing.Point(23, 161);
            this.buttonElilePasaportGirisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonElilePasaportGirisi.Name = "buttonElilePasaportGirisi";
            this.buttonElilePasaportGirisi.Size = new System.Drawing.Size(116, 110);
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
            this.buttonAyarlar.Location = new System.Drawing.Point(23, 300);
            this.buttonAyarlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAyarlar.Name = "buttonAyarlar";
            this.buttonAyarlar.Size = new System.Drawing.Size(116, 110);
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
            this.buttonExit.Location = new System.Drawing.Point(23, 730);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(116, 110);
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
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 882);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(108)))), ((int)(((byte)(148)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(888, 238);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 90);
            this.button2.TabIndex = 15;
            this.button2.Text = "İşle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1365, 945);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private TextBox textBoxOutputBarcodeIP;
        private Label label7;
        private TextBox textBoxInputBarcodeIP;
        private Label label19;
        private Label label14;
        private TextBox textBoxPrinterIpAddress;
        private Label labelPrinterIpAddress;
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
        private Bulb.LedBulb ledBulbM15;
        private Button btnOutputLong;
        private Button btnOutputShort;
        private NumericUpDown nudConveyourLongStep;
        private Label label54;
        private NumericUpDown nudConveyourShortStep;
        private Label label53;
        private GroupBox groupBox6;
        private CheckBox chkStopMachineOnFinish;
        private Label label56;
        private Bulb.LedBulb ledBulbM19;
        private Bulb.LedBulb ledBulbM17;
        private Button button2;
    }
}

