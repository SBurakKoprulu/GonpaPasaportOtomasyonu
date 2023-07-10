using Microsoft.Identity.Client;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using WindowsApplication1;

namespace GonpaPasaportOtomasyonu
{
    public partial class FormUserLogin : Form
    {
        public int selectedOption;
        public int SelectedOption
        {
            get { return comboBoxUser.SelectedIndex; }
            set { selectedOption = value; }
        }

        public FormUserLogin()
        {
            InitializeComponent();
        }

        private void FormUserLogin_Load(object sender, EventArgs e)
        {
            CenterGroupBox();
            comboBoxUser.SelectedIndex = 0;
        }

        private void CenterGroupBox()
        {
            int x = (this.ClientSize.Width - grpLoginPanel.Width) / 2;
            int y = (this.ClientSize.Height - grpLoginPanel.Height) / 2;
            int xp = (this.ClientSize.Width - ptcNviLogo.Width) / 2;
            int yp = (this.ClientSize.Height - ptcNviLogo.Height) / 2;
            grpLoginPanel.Location = new Point(x, y+80);
            ptcNviLogo.Location = new Point(xp, yp-200);
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUser.SelectedItem != null)
            {
                selectedOption = comboBoxUser.SelectedIndex;
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            switch (selectedOption)
            {
                case 0:
                    if (maskedTextBoxPin.Text == "1234")
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return;
                    }
                    break;

                case 1:
                    if (maskedTextBoxPin.Text == "5678")
                    {
                        this.DialogResult = DialogResult.OK;

                        this.Close();
                        return;
                    }
                    break;
                default:
                   
                    break;
            }
            var MsgOk=MessageBox.Show("Kullanıcı bilgileri hatalıdır. Lütfen doğru bilgilerle tekrar deneyiniz"
                       , "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (MsgOk==DialogResult.OK)
            {
                maskedTextBoxPin.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Uygulamadan Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void maskedTextBoxPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (maskedTextBoxPin.Text.Length >= 4 && e.KeyChar != '\b') // '\b' geri tuşu
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }


    }
}
