using GonpaPasaportOtomasyonu;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace WindowsApplication1
{
    static class Program
    {
        private static string appGuid = "c0a76b5a-12ab-45c5-b9d9-d693faa6e7b9";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false,appGuid)) 
            {
                if (!mutex.WaitOne(0, false)) 
                {
                    MessageBox.Show("Uygulama zaten çalýþýyor");
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main());
            }
        }
    }
}