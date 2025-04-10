using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ClientUpdater
{
    public partial class About : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);
        [DllImport("user32.dll")]
        static extern bool ShowCaret(IntPtr hWnd);
        [DllImport("user32.dll")]
        public extern static int HideCaret(IntPtr hwnd); 

        [DllImport("user32.dll")]
        public extern static int SetCaretBlinkTime(int wMSeconds); 


        public About()
        {
            InitializeComponent();
            timer1.Start();

           
        }

        string writingText = "Client Updater";
        int pos = 0;

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pos < writingText.Length)
            {
                textBox1.AppendText(writingText.Substring(pos, 1));
                ++pos;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
        }

        private void About_Shown(object sender, EventArgs e)
        {
            CreateCaret(textBox1.Handle, IntPtr.Zero, 4, 13);
            SetCaretBlinkTime(200);
            ShowCaret(textBox1.Handle);
        }

    }
}
