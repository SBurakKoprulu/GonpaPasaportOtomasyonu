namespace GonpaPasaportOtomasyonu
{
    partial class FormUserLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserLogin));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBoxPin = new System.Windows.Forms.MaskedTextBox();
            this.grpLoginPanel = new System.Windows.Forms.GroupBox();
            this.ptcNviLogo = new System.Windows.Forms.PictureBox();
            this.grpLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNviLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(151, 198);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(178, 45);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Giriş";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Items.AddRange(new object[] {
            "Operatör",
            "Bakım"});
            this.comboBoxUser.Location = new System.Drawing.Point(151, 51);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(394, 46);
            this.comboBoxUser.TabIndex = 1;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(67, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(367, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBoxPin
            // 
            this.maskedTextBoxPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxPin.Location = new System.Drawing.Point(151, 123);
            this.maskedTextBoxPin.Name = "maskedTextBoxPin";
            this.maskedTextBoxPin.PasswordChar = '*';
            this.maskedTextBoxPin.Size = new System.Drawing.Size(394, 45);
            this.maskedTextBoxPin.TabIndex = 2;
            this.maskedTextBoxPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxPin_KeyPress);
            // 
            // grpLoginPanel
            // 
            this.grpLoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(109)))), ((int)(((byte)(110)))));
            this.grpLoginPanel.Controls.Add(this.label1);
            this.grpLoginPanel.Controls.Add(this.maskedTextBoxPin);
            this.grpLoginPanel.Controls.Add(this.buttonLogin);
            this.grpLoginPanel.Controls.Add(this.button1);
            this.grpLoginPanel.Controls.Add(this.comboBoxUser);
            this.grpLoginPanel.Controls.Add(this.label2);
            this.grpLoginPanel.Location = new System.Drawing.Point(487, 507);
            this.grpLoginPanel.Name = "grpLoginPanel";
            this.grpLoginPanel.Size = new System.Drawing.Size(626, 287);
            this.grpLoginPanel.TabIndex = 7;
            this.grpLoginPanel.TabStop = false;
            // 
            // ptcNviLogo
            // 
            this.ptcNviLogo.BackColor = System.Drawing.Color.Transparent;
            this.ptcNviLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcNviLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptcNviLogo.Image")));
            this.ptcNviLogo.Location = new System.Drawing.Point(679, 160);
            this.ptcNviLogo.Name = "ptcNviLogo";
            this.ptcNviLogo.Size = new System.Drawing.Size(240, 243);
            this.ptcNviLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcNviLogo.TabIndex = 8;
            this.ptcNviLogo.TabStop = false;
            // 
            // FormUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1443, 806);
            this.ControlBox = false;
            this.Controls.Add(this.grpLoginPanel);
            this.Controls.Add(this.ptcNviLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FormUserLogin";
            this.Text = "Kullancı Giriş";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUserLogin_Load);
            this.grpLoginPanel.ResumeLayout(false);
            this.grpLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcNviLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPin;
        private System.Windows.Forms.GroupBox grpLoginPanel;
        private System.Windows.Forms.PictureBox ptcNviLogo;
    }
}