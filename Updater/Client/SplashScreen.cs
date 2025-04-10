using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ClientUpdater
{
    public partial class SplashScreen : Form
    {
        string writingText = "Loading...";
        int pos = 0;

        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();
        }
        private delegate void CloseDelegate();
        private static SplashScreen splashForm;

        static public void ShowSplashScreen()
        {
            if (splashForm != null)
                return;
            Thread thread = new Thread(new ThreadStart(SplashScreen.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            splashForm = new SplashScreen();
            Application.Run(splashForm);
        }

        static public void CloseForm()
        {
            splashForm.Invoke(new CloseDelegate(SplashScreen.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            splashForm.Close();
            splashForm = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pos < writingText.Length)
            {
                tlbStatus.Text = tlbStatus.Text + writingText.Substring(pos, 1);
                ++pos;
            }
            else
            {
                tlbStatus.Text = "";
                pos = 0;
            }
        }
    }
}
