using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ClientUpdater
{
   public enum CMessageBoxButton
    {
       OK,
       OKCANCEL,
       YESNO,
       YESNOCANCEL,
       RETRYCANCEL,
       HELP,
    }
   public enum CMessageBoxIcon
   {
       ERROR,
       QUESTION,
       WARNING,
       INFORMATION,
   }
    
    public partial class CMessageBox : Form
    {
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public CMessageBox()
        {
            InitializeComponent();
        }

        static CMessageBox MsgBox;
        static DialogResult Result;
        public static DialogResult Show(string Caption, string Message, CMessageBoxButton Button, CMessageBoxIcon Icon)
        {
            MsgBox = new CMessageBox();
            MsgBox.tlbCaption.Text = Caption;
            MsgBox.tbxMessage.Text = Message;
         

            switch (Button)
            {
                case CMessageBoxButton.OK:
                    {
                        MsgBox.btnOK.Visible = true;
                        MsgBox.btnOK.Location = new System.Drawing.Point(400, 198);
                        break;
                    }
                case CMessageBoxButton.OKCANCEL:
                    {
                        MsgBox.btnOK.Visible = true;
                        MsgBox.btnCancel.Visible = true;
                        break;
                    }
                case CMessageBoxButton.YESNO:
                    {
                        MsgBox.btnYes.Visible = true;
                        MsgBox.btnNO.Visible = true;
                        MsgBox.btnNO.Location = new System.Drawing.Point(400, 198);
                        MsgBox.btnYes.Location = new System.Drawing.Point(319, 198);
                        break;
                    }
                case CMessageBoxButton.YESNOCANCEL:
                    {
                        MsgBox.btnYes.Visible = true;
                        MsgBox.btnCancel.Visible = true;
                        MsgBox.btnNO.Visible = true;
                        MsgBox.btnYes.Location = new System.Drawing.Point(238, 198);
                        MsgBox.btnNO.Location = new System.Drawing.Point(319, 198);
                        MsgBox.btnCancel.Location = new System.Drawing.Point(400, 198);
                        break;
                    }
                case CMessageBoxButton.RETRYCANCEL:
                    {
                        MsgBox.btnRetry.Visible = true;
                        MsgBox.btnCancel.Visible = true;
                        MsgBox.btnRetry.Location = new System.Drawing.Point(319, 198);
                        break;
                    }
                case CMessageBoxButton.HELP:
                    {
                        MsgBox.btnOK.Visible = true;
                        MsgBox.btnOK.Location = new System.Drawing.Point(400, 198);
                        break;
                    }
               
            }

            switch (Icon)
            {
                case CMessageBoxIcon.ERROR:
                    {
                       // MsgBox.IconPixtureBox.BackgroundImage = Properties.Resources.error;
                        break;
                    }
                case CMessageBoxIcon.INFORMATION:
                    {
                       // MsgBox.IconPixtureBox.BackgroundImage = Properties.Resources.information;
                        break;
                    }
                case CMessageBoxIcon.QUESTION:
                    {
                      //  MsgBox.IconPixtureBox.BackgroundImage = Properties.Resources.question;
                        break;
                    }
                case CMessageBoxIcon.WARNING:
                    {
                      //  MsgBox.IconPixtureBox.BackgroundImage = Properties.Resources.warning;
                        break;
                    }
            }

           
            MsgBox.TopMost = true;
            MsgBox.ShowDialog();
            return Result;
        }

        public static DialogResult Show(string Caption, string Message, CMessageBoxButton Button)
        {
            MsgBox = new CMessageBox();
            MsgBox.tlbCaption.Text = Caption;
            MsgBox.tbxMessage.Text = Message;
            MsgBox.tlbCaption.Location = new System.Drawing.Point(36, 15);
            MsgBox.IconPixtureBox.Visible = false;

            switch (Button)
            {
                case CMessageBoxButton.OK:
                    {
                        MsgBox.btnOK.Visible = true;
                        MsgBox.btnOK.Location = new System.Drawing.Point(400, 198);
                        break;
                    }
                case CMessageBoxButton.OKCANCEL:
                    {
                        MsgBox.btnOK.Visible = true;
                        MsgBox.btnCancel.Visible = true;
                        break;
                    }
                case CMessageBoxButton.YESNO:
                    {
                        MsgBox.btnYes.Visible = true;
                        MsgBox.btnNO.Visible = true;
                        MsgBox.btnNO.Location = new System.Drawing.Point(400, 198);
                        MsgBox.btnYes.Location = new System.Drawing.Point(319, 198);
                        break;
                    }
                case CMessageBoxButton.YESNOCANCEL:
                    {
                        MsgBox.btnYes.Visible = true;
                        MsgBox.btnCancel.Visible = true;
                        MsgBox.btnNO.Visible = true;
                        MsgBox.btnYes.Location = new System.Drawing.Point(238, 198);
                        MsgBox.btnNO.Location = new System.Drawing.Point(319, 198);
                        MsgBox.btnCancel.Location = new System.Drawing.Point(400, 198);
                        break;
                    }
                case CMessageBoxButton.RETRYCANCEL:
                    {
                        MsgBox.btnRetry.Visible = true;
                        MsgBox.btnCancel.Visible = true;
                        MsgBox.btnRetry.Location = new System.Drawing.Point(319, 198);
                        break;
                    }
                case CMessageBoxButton.HELP:
                    {
                        MsgBox.btnOK.Visible = true;
                        MsgBox.btnOK.Location = new System.Drawing.Point(400, 198);
                        break;
                    }

            }
            MsgBox.TopMost = true;
            MsgBox.ShowDialog();
            return Result;
        }

        public static DialogResult Show(string Caption, string Message)
        {
            MsgBox = new CMessageBox();
            MsgBox.tlbCaption.Text = Caption;
            MsgBox.tbxMessage.Text = Message;
            MsgBox.tlbCaption.Location = new System.Drawing.Point(36, 15);
            MsgBox.IconPixtureBox.Visible = false;

            MsgBox.btnOK.Visible = true;
            MsgBox.btnOK.Location = new System.Drawing.Point(400, 198);
            
            MsgBox.TopMost = true;
            MsgBox.ShowDialog();
            return Result;
        }

        public static DialogResult Show(string Message)
        {
            MsgBox = new CMessageBox();
            MsgBox.tbxMessage.Text = Message;

            MsgBox.tlbCaption.Visible = false;
            MsgBox.IconPixtureBox.Visible = false;

            MsgBox.btnOK.Visible = true;
            MsgBox.btnOK.Location = new System.Drawing.Point(400, 198);

            MsgBox.TopMost = true;
            MsgBox.ShowDialog();
            return Result;
        }

        public static DialogResult Show(string Message, CMessageBoxButton Button)
        {
            MsgBox = new CMessageBox();
            MsgBox.tbxMessage.Text = Message;

            MsgBox.tlbCaption.Visible = false;
            MsgBox.IconPixtureBox.Visible = false;

            switch (Button)
            {
                case CMessageBoxButton.OK:
                    {
                        MsgBox.btnOK.Visible = true;
                        MsgBox.btnOK.Location = new System.Drawing.Point(400, 198);
                        break;
                    }
                case CMessageBoxButton.OKCANCEL:
                    {
                        MsgBox.btnOK.Visible = true;
                        MsgBox.btnCancel.Visible = true;
                        break;
                    }
                case CMessageBoxButton.YESNO:
                    {
                        MsgBox.btnYes.Visible = true;
                        MsgBox.btnNO.Visible = true;
                        MsgBox.btnNO.Location = new System.Drawing.Point(400, 198);
                        MsgBox.btnYes.Location = new System.Drawing.Point(319, 198);
                        break;
                    }
                case CMessageBoxButton.YESNOCANCEL:
                    {
                        MsgBox.btnYes.Visible = true;
                        MsgBox.btnCancel.Visible = true;
                        MsgBox.btnNO.Visible = true;
                        MsgBox.btnYes.Location = new System.Drawing.Point(238, 198);
                        MsgBox.btnNO.Location = new System.Drawing.Point(319, 198);
                        MsgBox.btnCancel.Location = new System.Drawing.Point(400, 198);
                        break;
                    }
                case CMessageBoxButton.RETRYCANCEL:
                    {
                        MsgBox.btnRetry.Visible = true;
                        MsgBox.btnCancel.Visible = true;
                        MsgBox.btnRetry.Location = new System.Drawing.Point(319, 198);
                        break;
                    }
                case CMessageBoxButton.HELP:
                    {
                        MsgBox.btnOK.Visible = true;
                        MsgBox.btnOK.Location = new System.Drawing.Point(400, 198);
                        break;
                    }

            }
            MsgBox.TopMost = true;
            MsgBox.ShowDialog();
            return Result;
        }

        public static DialogResult Show(string Message, CMessageBoxButton Button, CMessageBoxIcon Icon)
        {
            MsgBox = new CMessageBox();
            MsgBox.tbxMessage.Text = Message;
            MsgBox.tlbCaption.Visible = false;

            switch (Button)
            {
                case CMessageBoxButton.OK:
                    {
                        MsgBox.btnOK.Visible = true;
                        MsgBox.btnOK.Location = new System.Drawing.Point(400, 198);
                        break;
                    }
                case CMessageBoxButton.OKCANCEL:
                    {
                        MsgBox.btnOK.Visible = true;
                        MsgBox.btnCancel.Visible = true;
                        break;
                    }
                case CMessageBoxButton.YESNO:
                    {
                        MsgBox.btnYes.Visible = true;
                        MsgBox.btnNO.Visible = true;
                        MsgBox.btnNO.Location = new System.Drawing.Point(400, 198);
                        MsgBox.btnYes.Location = new System.Drawing.Point(319, 198);
                        break;
                    }
                case CMessageBoxButton.YESNOCANCEL:
                    {
                        MsgBox.btnYes.Visible = true;
                        MsgBox.btnCancel.Visible = true;
                        MsgBox.btnNO.Visible = true;
                        MsgBox.btnYes.Location = new System.Drawing.Point(238, 198);
                        MsgBox.btnNO.Location = new System.Drawing.Point(319, 198);
                        MsgBox.btnCancel.Location = new System.Drawing.Point(400, 198);
                        break;
                    }
                case CMessageBoxButton.RETRYCANCEL:
                    {
                        MsgBox.btnRetry.Visible = true;
                        MsgBox.btnCancel.Visible = true;
                        MsgBox.btnRetry.Location = new System.Drawing.Point(319, 198);
                        break;
                    }
                case CMessageBoxButton.HELP:
                    {
                        MsgBox.btnOK.Visible = true;
                        MsgBox.btnOK.Location = new System.Drawing.Point(400, 198);
                        break;
                    }

            }

            switch (Icon)
            {
                case CMessageBoxIcon.ERROR:
                    {
                       // MsgBox.IconPixtureBox.BackgroundImage = Properties.Resources.error;
                        break;
                    }
                case CMessageBoxIcon.INFORMATION:
                    {
                        // MsgBox.IconPixtureBox.BackgroundImage = Properties.Resources.information;
                        break;
                    }
                case CMessageBoxIcon.QUESTION:
                    {
                        //MsgBox.IconPixtureBox.BackgroundImage = Properties.Resources.question;
                        break;
                    }
                case CMessageBoxIcon.WARNING:
                    {
                        // MsgBox.IconPixtureBox.BackgroundImage = Properties.Resources.warning;
                        break;
                    }
            }


            MsgBox.TopMost = true;
            MsgBox.ShowDialog();
            return Result;
        }


        private void CMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Result = DialogResult.OK;
            MsgBox.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            MsgBox.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Yes;
            MsgBox.Close();
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            Result = DialogResult.No;
            MsgBox.Close();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Retry;
            MsgBox.Close();
        }
    }
}
