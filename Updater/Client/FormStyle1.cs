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
    public partial class FormStyle1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        IniFile ini;
        string IniForm1 = "FormStyle1";
        string IniPath = "./Updater/Style.ini";

        int FormWidth;
        int FormHeight;
        int TitleLable_LocationX;
        int TitleLable_LocationY;
        string TitleLable_Text;

        string ExitButton_Text;
        int ExitButton_Width;
        int ExitButton_Height;
        int ExitButton_LocationX;
        int ExitButton_LocationY;
        string ExitButton_Image;

        SplashScreen SPS = new SplashScreen();
        public FormStyle1()
        {
            InitializeComponent();
            ini = new IniFile(IniPath);
            this.TopMost = true;
        }

        private void FormStyle1_Load(object sender, EventArgs e)
        {
            

            try
            {
                FormWidth = Convert.ToInt32(ini.ReadValue(IniForm1, "FormWidth"));
                FormHeight = Convert.ToInt32(ini.ReadValue(IniForm1, "FormHeight"));
                TitleLable_LocationX = Convert.ToInt32(ini.ReadValue(IniForm1, "TitleLable_LocationX"));
                TitleLable_LocationY = Convert.ToInt32(ini.ReadValue(IniForm1, "TitleLable_LocationY"));
                TitleLable_Text = ini.ReadValue(IniForm1, "TitleLable_Text");

                ExitButton_Text = ini.ReadValue(IniForm1, "ExitButton_Text");
                ExitButton_Width = Convert.ToInt32(ini.ReadValue(IniForm1, "ExitButton_Width"));
                ExitButton_Height = Convert.ToInt32(ini.ReadValue(IniForm1, "ExitButton_Height"));
                ExitButton_LocationX = Convert.ToInt32(ini.ReadValue(IniForm1, "ExitButton_LocationX"));
                ExitButton_LocationY = Convert.ToInt32(ini.ReadValue(IniForm1, "ExitButton_LocationY"));
                ExitButton_Image = ini.ReadValue(IniForm1, "ExitButton_Image");

            }
            catch
            {
                MessageBox.Show("Failed to Read the ini.");
            }

            this.Height = FormHeight;
            this.Width = FormWidth;
            this.TitleLable.Location = new System.Drawing.Point(TitleLable_LocationX, TitleLable_LocationY);
            this.TitleLable.Text = TitleLable_Text;

            this.ExitButton.Text = ExitButton_Text;
            this.ExitButton.Width = ExitButton_Width;
            this.ExitButton.Height = ExitButton_Height;
            this.ExitButton.Location = new System.Drawing.Point(ExitButton_LocationX, ExitButton_LocationY);

            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TopCenterFrame_pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
        }
    }
}
