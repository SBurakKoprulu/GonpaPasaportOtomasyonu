using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GonpaPasaportOtomasyonu
{
    public class RoundButton : Button
    {

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            //GraphicsPath p = new GraphicsPath();
            //p.AddEllipse(this.Width/2, this.Height/2, this.Width, this.Height);
            //this.Region = new Region(p);


            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(2, 2, ClientSize.Width-10, ClientSize.Height-10);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}
