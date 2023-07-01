using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GonpaPasaportOtomasyonu
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            CenterText();
        }

        private void CenterText()
        {
            int x = (this.ClientSize.Width - label1.Width) / 2;
            int y = (this.ClientSize.Height - label1.Height) / 2;
            int xp = (this.ClientSize.Width - labelWaiting.Width) / 2;
            int yp = (this.ClientSize.Height - labelWaiting.Height) / 2;
            label1.Location = new Point(x, y);
            labelWaiting.Location = new Point(xp, yp + 50);
        }

        
    }
}
