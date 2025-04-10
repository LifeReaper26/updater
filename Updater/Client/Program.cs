using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace ClientUpdater
{
    static class Program
    {
       
        static Mutex mutex = new Mutex(true, "{7d6819a3-7847-4a60-a183-ccc624bb9a30}");
       
        [STAThread]
        static void Main()
        {
           /*int FormStyle = 0;
           try
           {
               IniFile ini = new IniFile("./Updater/Style.ini");
               FormStyle = Convert.ToInt32(ini.ReadValue("Form","FormStyle"));
           }
           catch
           {

           }*/
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
                /*if (FormStyle == 0)
                {
                    Application.Run(new MainForm());
                }
                else if (FormStyle == 1)
                {
                    Application.Run(new FormStyle1());
                }*/
                
            }
            else
            {
                CMessageBox.Show("Error!", "Updater is already running.", CMessageBoxButton.OK, CMessageBoxIcon.INFORMATION);
                return;
            }
        }
    }
}
