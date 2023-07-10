namespace GonpaPasaportOtomasyonu
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timerThreepoint = new System.Windows.Forms.Timer(this.components);
            this.richTextBoxWaiting = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ayarlamalar yapılırken,";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerThreepoint
            // 
            this.timerThreepoint.Enabled = true;
            this.timerThreepoint.Interval = 200;
            this.timerThreepoint.Tick += new System.EventHandler(this.timerThreepoint_Tick);
            // 
            // richTextBoxWaiting
            // 
            this.richTextBoxWaiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.richTextBoxWaiting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxWaiting.CausesValidation = false;
            this.richTextBoxWaiting.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBoxWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxWaiting.Location = new System.Drawing.Point(141, 168);
            this.richTextBoxWaiting.Name = "richTextBoxWaiting";
            this.richTextBoxWaiting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBoxWaiting.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxWaiting.Size = new System.Drawing.Size(300, 46);
            this.richTextBoxWaiting.TabIndex = 2;
            this.richTextBoxWaiting.Text = " lütfen bekleyin...";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.richTextBoxWaiting);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SplashForm";
            this.Text = "SplashForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerThreepoint;
        private System.Windows.Forms.RichTextBox richTextBoxWaiting;
    }
}