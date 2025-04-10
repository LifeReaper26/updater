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
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml;
using System.Management;


namespace ClientUpdater
{
    public partial class MainForm : Form
    {
        #region Variable's
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
 
        Updater updater;
        IniFile ini;
        public string UpdaterIniPath = (Application.StartupPath + @"\Updater.ini");
        public string StyleIniPath = (Application.StartupPath + @"\data\Updater\Style.ini");
        public string ImageFolderpath = (Application.StartupPath + @"\data\Updater\");

        private int ServerStatus = (0);

        private string _UpdaterPhp = (string.Empty);
        private string _WebsiteURL = (string.Empty);
        private string _UpdateURL = (string.Empty);
        public string _InfoWindowHtmL = (string.Empty);
        private int _InfoWindowState = (0);

        private bool resizing = (false);
        private Point last = new Point(0, 0);
        private int NewWidth = (0);
        private int NewHeight = (0);
        private bool Left_to_Right =(true);
        private bool Right_to_Left = (false);

        private bool Shutdown = (false);
        private Stopwatch sw = new Stopwatch();

        private Thread UpdateThread;
        private bool UpdateRequired = (false);

        private ProgressBar pb;
        private Graphics g;

        private static MainForm instance;
        #endregion

        public static MainForm Instance
        {
            get { return instance; }
        }

        public MainForm()
        {
            InitializeComponent();
            instance = (this);
            g = ProgressBar_PictureBox.CreateGraphics();
            timer1.Start();
            this.TopMost = (true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();

            SplashScreen.ShowSplashScreen();

            if (!File.Exists(UpdaterIniPath))
            {
                Shutdown = (true);
                DialogResult result = CMessageBox.Show("Settings!!", "Unable to locate Updater.ini." + Environment.NewLine + "Do you want to create the Default ini File?", CMessageBoxButton.YESNO, CMessageBoxIcon.QUESTION);
                if(result == DialogResult.Yes)
                {
                    using (StreamWriter sw = File.AppendText(UpdaterIniPath))
                    {
                        sw.WriteLine("[Updater]");
                        sw.WriteLine("WebsiteURL = http://www.YourDomain.com/");
                        sw.WriteLine("UpdaterPhp = http://www.YourDomain.com/Updater/Updater.php");
                        sw.WriteLine("UpdateURL = http://www.YourDomain.com/Updater/Update/");
                        sw.WriteLine("[AppInfo]");
                        sw.WriteLine("BGimg = 1");
                    } 
                }
            }
            else
            {
                ini = new IniFile(UpdaterIniPath);
                //load Images
                LoadImages();
                try
                {
                    _UpdaterPhp = ini.ReadValue("Updater", "UpdaterPhp");
                    _WebsiteURL = ini.ReadValue("Updater", "WebsiteUrl");
                    _UpdateURL = ini.ReadValue("Updater", "UpdateURL");
                }
                catch (Exception)
                {
                    CMessageBox.Show("Exception!", "Unable to read Updater.ini, program will now exit.", CMessageBoxButton.OK, CMessageBoxIcon.ERROR);
                    Shutdown = (true);
                }
            }
            if (!Shutdown)
            {
                //Informationen aus der Updater.php holen
                updater = new Updater(_UpdaterPhp, _UpdateURL, g);

                _InfoWindowState = updater.GetInfoWindowState();
                _InfoWindowHtmL = updater.GetInfoHtmlPath();

                BreakingNewsColor(updater.GetNewsColor());
                Infos_lable.Text = updater.GetNews();
                ChangeLog_richTextBox.Text = updater.GetChangelog();


                //Update Thread
                UpdateThread = new Thread(new ThreadStart(Updatethread));
                UpdateThread.IsBackground = (true);
                UpdateThread.Start();

                //Splash screen schließen und MainForm anzeigen
                SplashScreen.CloseForm();
                this.Show();
                this.TopMost = (false);

                //Info fenster anzeigen
                if (_InfoWindowState == 1)
                {
                    Infos IW = new Infos();
                    IW.Show();
                }
            }
            else
            {
                SplashScreen.CloseForm();
                Application.Exit();
            }
        }
        public void Updatethread()
        {
            if (updater.GetDeleteList()) { updater.DeleteFiles(); }
            if (updater.GetFileList())
            {
                if (updater.CompareFiles() > 0)
                {
                    DialogResult result = CMessageBox.Show("Update available!", "There is an update available, do you want to download it?", CMessageBoxButton.YESNO, CMessageBoxIcon.INFORMATION);
                    if (result == DialogResult.Yes)
                    {
                        pb = new ProgressBar(Brushes.Peru, Brushes.Peru, new Rectangle(41, 14, 581, 7), 99);
                        UpdateRequired = (true);
                        updater.DownloadUpdate();
                        StyleTimer.Start();
                    }
                    else
                    {
                        updater.DeleteFile("FileList.xml");
                    }
                }
                else
                {
                    UpdateRequired = (false);
                    updater.DeleteFile("FileList.xml");
                }
            }
            UpdateThread.Abort();
        }
        private void StyleTimer_Tick(object sender, EventArgs e)
        {
            if(UpdateRequired)
            {
                if (updater.DownloadDone)
                {
                    Update_label.Visible = (false);
                    ProgressBar_PictureBox.Visible = (false);
                    linkLabel1.Visible = (true);
                    ChangeLog_richTextBox.Location = new System.Drawing.Point(36, 277);
                    Start_button.Enabled = (true);
                    Settings_button.Enabled = (true);
                    Start_button.Location = new System.Drawing.Point(462, 445);
                    Website_button.Location = new System.Drawing.Point(565, 445);
                    Settings_button.Location = new System.Drawing.Point(668, 445);
                    
                    StyleTimer.Stop();
                }
                else
                {
                    linkLabel1.Visible = (false);
                    ChangeLog_richTextBox.Location = new System.Drawing.Point(36, 252);
                    //Update_label.Location = new System.Drawing.Point(130, 430);
                    ProgressBar_PictureBox.Location = new System.Drawing.Point(73, 437);
                    Start_button.Location = new System.Drawing.Point(462, 378);
                    Website_button.Location = new System.Drawing.Point(565, 378);
                    Settings_button.Location = new System.Drawing.Point(668, 378);

                    Start_button.Enabled = (false);
                    Settings_button.Enabled = (false);
                    //Update_label.Visible = true;
                    ProgressBar_PictureBox.Visible = true;
                    //Update_label.Text = updater.UpdateLable_Text;
                    this.Size = new System.Drawing.Size(800, 500);
                    resizing = (false);
                   
                    pb.SetCurrent(updater.progressBarValue);
                    pb.SetDrawString(updater.UpdateLable_Text);
                    g.DrawImage(pb.DrawProgressBar(), pb.GetCorner());
                }
            }
        }

        private void LoadImages()
        {
            try
            {
                Background_Image_Switch();
                Logo_pictureBox.BackgroundImage = Image.FromFile(ImageFolderpath + @"Logo.png");
            }
            catch
            {
                CMessageBox.Show("Error", "Unable to load background images", CMessageBoxButton.OK, CMessageBoxIcon.ERROR);
                Shutdown = (true);
            }
        }
        private void Background_Image_Switch()
        {
            int AppStarts = Convert.ToInt32(ini.ReadValue("AppInfo", "BGimg"));
            if (AppStarts <= 0 || AppStarts > 5)
            {
                AppStarts = (1);
                ini.WriteValue("AppInfo", "BGimg", Convert.ToString(AppStarts + 1));
            }
            else
            {
                ini.WriteValue("AppInfo", "BGimg", Convert.ToString(AppStarts + 1));
            }
            switch (AppStarts)
            {
                case 1:
                    this.BackgroundImage = Image.FromFile(ImageFolderpath + @"background-1.jpg");
                    break;
                case 2:
                    this.BackgroundImage = Image.FromFile(ImageFolderpath + @"background-2.jpg");
                    break;
                case 3:
                    this.BackgroundImage = Image.FromFile(ImageFolderpath + @"background-3.jpg");
                    break;
                case 4:
                    this.BackgroundImage = Image.FromFile(ImageFolderpath + @"background-4.jpg");
                    break;
                case 5:
                    this.BackgroundImage = Image.FromFile(ImageFolderpath + @"background-5.jpg");
                    break;
            }

        }
        

#region Hover Buttons Events
        private void Start_button_MouseDown(object sender, MouseEventArgs e)
        {
            //this.Start_button.BackgroundImage = Properties.Resources.btn_on;
        }

        private void Start_button_MouseEnter(object sender, EventArgs e)
        {
            //this.Start_button.BackgroundImage = Properties.Resources.btn_over;
        }

        private void Start_button_MouseLeave(object sender, EventArgs e)
        {
            // this.Start_button.BackgroundImage = Properties.Resources.btn_default;
        }

        private void Start_button_MouseUp(object sender, MouseEventArgs e)
        {
            // this.Start_button.BackgroundImage = Properties.Resources.btn_over;
        }




        private void Website_button_MouseDown(object sender, MouseEventArgs e)
        {
            //this.Website_button.BackgroundImage = Properties.Resources.btn_on;
        }

        private void Website_button_MouseEnter(object sender, EventArgs e)
        {
            //this.Website_button.BackgroundImage = Properties.Resources.btn_over;
        }

        private void Website_button_MouseLeave(object sender, EventArgs e)
        {
            //this.Website_button.BackgroundImage = Properties.Resources.btn_default;
        }

        private void Website_button_MouseUp(object sender, MouseEventArgs e)
        {
            // this.Website_button.BackgroundImage = Properties.Resources.btn_over;
        }





        private void Settings_button_MouseDown(object sender, MouseEventArgs e)
        {
            // this.Settings_button.BackgroundImage = Properties.Resources.btn_on;
        }

        private void Settings_button_MouseEnter(object sender, EventArgs e)
        {
            // this.Settings_button.BackgroundImage = Properties.Resources.btn_over;
        }

        private void Settings_button_MouseLeave(object sender, EventArgs e)
        {
            // this.Settings_button.BackgroundImage = Properties.Resources.btn_default;
        }

        private void Settings_button_MouseUp(object sender, MouseEventArgs e)
        {
            //this.Settings_button.BackgroundImage = Properties.Resources.btn_over;
        }
#endregion
        private void Start_button_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "engine.exe";
                p.StartInfo.Arguments = "/load /config debug";
                p.Start();
                Application.Exit();
            }
            catch
            {
                CMessageBox.Show("Error!", "Failed to Start engine.exe", CMessageBoxButton.OK, CMessageBoxIcon.ERROR);
            }
        }
        private void Settings_button_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "engine.exe";
                p.StartInfo.Arguments = "/setup";
                p.Start();
            }
            catch
            {
                CMessageBox.Show("Error!", "Failed to open settings.", CMessageBoxButton.OK, CMessageBoxIcon.ERROR);
            }
        }
        private void Website_button_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = _WebsiteURL;
                p.StartInfo.Arguments = "";
                p.Start();
            }
            catch
            {
                CMessageBox.Show("Error!", "Failed to Navigate to the Server Website.", CMessageBoxButton.OK, CMessageBoxIcon.ERROR);
            }
        }
        private void TopCenterFrame_pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
        }
        private void BottomRightFrame_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.resizing){
				NewWidth = Cursor.Position.X - Location.X;
				NewHeight = Cursor.Position.Y - Location.Y;
                if (NewWidth <= 800 && NewHeight <= 500)
                {
                    NewWidth = (800);
                    NewHeight = (500);
                    this.Size = new System.Drawing.Size(NewWidth, NewHeight);
                }
                else
                {
                    this.Size = new System.Drawing.Size(NewWidth + 20, NewHeight + 25);
                }

                
			 }
        }
        private void BottomRightFrame_pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.resizing = (true);
        }
        private void BottomRightFrame_pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.resizing = (false);
            
        }
        private void Resize_timer_Tick(object sender, EventArgs e)
        {
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Infos_lable.Location.X < 74)
            {
                Left_to_Right = (true);
                Right_to_Left = (false);
            }
            if (Infos_lable.Location.X + Infos_lable.Width > this.Width - 49)
            {
                Right_to_Left = (true);
                Left_to_Right = (false);
            }


            if (Left_to_Right)
            {
                Infos_lable.Location = new Point(Infos_lable.Location.X + 3, Infos_lable.Location.Y);
            }
            else if (Right_to_Left)
            {
                Infos_lable.Location = new Point(Infos_lable.Location.X - 3, Infos_lable.Location.Y);
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About ABform = new About();
            ABform.Show();
        }
        private void BreakingNewsColor(int value)
        {
            switch(value)
            {
                case 1:
                    this.Infos_lable.ForeColor = System.Drawing.Color.White;
                    break;
                case 2:
                    this.Infos_lable.ForeColor = System.Drawing.Color.Black;
                    break;
                case 3:
                    this.Infos_lable.ForeColor = System.Drawing.Color.Blue;
                    break;
                case 4:
                    this.Infos_lable.ForeColor = System.Drawing.Color.Green;
                    break;
                case 5:
                    this.Infos_lable.ForeColor = System.Drawing.Color.Red;
                    break;
                case 6:
                    this.Infos_lable.ForeColor = System.Drawing.Color.Orange;
                    break;
                case 7:
                    this.Infos_lable.ForeColor = System.Drawing.Color.OrangeRed;
                    break;
                case 8:
                    this.Infos_lable.ForeColor = System.Drawing.Color.Yellow;
                    break;
                case 9:
                    this.Infos_lable.ForeColor = System.Drawing.Color.Peru;
                    break;
                case 10:
                    this.Infos_lable.ForeColor = System.Drawing.Color.SandyBrown;
                    break;
                default:
                    this.Infos_lable.ForeColor = System.Drawing.Color.WhiteSmoke;
                    break;

            }

        }
        private void Logo_pictureBox_Click(object sender, EventArgs e)
        {

        }
        private void ServerStatus_pictureBox_MouseHover(object sender, EventArgs e)
        {
            if(this.ServerStatus == 0)
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.ServerStatus_pictureBox, "The MainSvr is currently on maintenance. Please visit the website.");
            }
            else if(this.ServerStatus == 1)
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(this.ServerStatus_pictureBox, "The MainSvr is online and protected.");
            }
            
        }
        private void ServerStatus_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
        }
        private void Close_button_Click(object sender, EventArgs e)
        {
            DialogResult result = CMessageBox.Show("Exit !?", "Are you Sure you want to Exit?", CMessageBoxButton.YESNO, CMessageBoxIcon.QUESTION);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void ProgressBar_PictureBox_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!Shutdown)
            updater.DeleteFile("FileList.xml");
        }

        private void ServerStatus_pictureBox_Click(object sender, EventArgs e)
        {

        }
     }
}
