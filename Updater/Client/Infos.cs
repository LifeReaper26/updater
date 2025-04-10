using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ClientUpdater
{
    public partial class Infos : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Infos()
        {
            InitializeComponent();
        }

        private void TopCenter_Frame_pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Infos_Load(object sender, EventArgs e)
        {
            this.Hide();
            Info_webBrowser.Navigate(new Uri(MainForm.Instance._InfoWindowHtmL));
            this.Show();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Infos_Shown(object sender, EventArgs e)
        {
            this.TopMost = (false);
        }
    }
}
