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
using System.Globalization;

namespace ClientUpdater
{
    class Updater
    {
        string UpdaterPHP;
        string UpdateURL;
        WebClient DownloadClient = null;

        public int LeftToDownload = 0;
        public int toDownloadNumber = 0;
        public string[] toDownloadFile = new string[0];
        public string CurrentDownFile;


        public int progressBarValue;
        public string UpdateLable_Text;
        public bool DownloadDone;
        Graphics G;

        Stopwatch sw = new Stopwatch();

        ProgressBar pb = new ProgressBar(Brushes.Black, Brushes.Black, new Rectangle(41, 14, 581, 7), 99);

        public Updater(string UpdaterPHP, string UpdateURL, Graphics g)
        {
            this.UpdaterPHP = UpdaterPHP;
            this.UpdateURL = UpdateURL;
            DownloadClient = new WebClient();
            G = g;
        }


        public int GetStatus()
        {
            try
            {
                WebClient wclient = new WebClient();
                return Convert.ToInt32(wclient.DownloadString(UpdaterPHP + "?id=GetServerStatus"));
            }
            catch (Exception)
            {
                CMessageBox.Show("Unable to retrieve server status, please check your internet connection and try again.");
                return 0;
            }
        }

        public string GetChangelog()
        {
            try
            {
                WebClient wclient = new WebClient();
                return wclient.DownloadString(UpdaterPHP + "?id=GetChangelog");
            }
            catch (Exception)
            {
                CMessageBox.Show("Unable to retrieve Changelog, please check your internet connection and try again.");
                return "Updater";
            }
        }

        public string GetNews()
        {
            try
            {
                WebClient wclient = new WebClient();
                return wclient.DownloadString(UpdaterPHP + "?id=GetNews");
            }
            catch(Exception)
            {
                return "Unable to retrieve News, please check your internet connection and try again.";
            }
        }
        public int GetNewsColor()
        {
            try
            {
                WebClient wclient = new WebClient();
                return Convert.ToInt32(wclient.DownloadString(UpdaterPHP + "?id=GetNewsColor"));
            }
            catch(Exception)
            {
                return 1;
            }
        }

        public bool GetFileList()
        {
            try
            {
                WebClient wclient = new WebClient();
                string remoteUri = wclient.DownloadString(UpdaterPHP + "?id=GetFileListPath");
                wclient.DownloadFile(remoteUri, "FileList.xml");
                return true;
            }
            catch(Exception)
            {
                CMessageBox.Show("Unable to retrieve FileList, please check your internet connection and try again.");
                return false;
            }
        }
        public bool GetDeleteList()
        {
            try
            {
                WebClient wclient = new WebClient();
                string remoteUri = wclient.DownloadString(UpdaterPHP + "?id=GetDeleteListPath");
                wclient.DownloadFile(remoteUri, "DeleteList.xml");
                return true;
            }
            catch
            {
                CMessageBox.Show("Unable to retrieve DeleteList, please check your internet connection and try again.");
                return false;
            }
        }

        public string GetInfoHtmlPath()
        {
            try
            {
                WebClient wclient = new WebClient();
                return wclient.DownloadString(UpdaterPHP + "?id=GetInfoHtmlPath");
            }
            catch (Exception)
            {
                CMessageBox.Show("Unable to retrieve Info Html Path, please check your internet connection and try again.");
                return "Error connecting to update server.";
            }
        }

        public int GetInfoWindowState()
        {
            try
            {
                WebClient wclient = new WebClient();
                return Convert.ToInt32(wclient.DownloadString(UpdaterPHP + "?id=InfoWindowState"));
            }
            catch (Exception)
            {
                CMessageBox.Show("Unable to retrieve Info Window State, please check your internet connection and try again.");
                return 0;
            }
        }

        private void addToDownloadList(string file, int elementCount)
        {
            toDownloadFile[elementCount] = file;
        }
        public void increaseDownloadNumber()
        {
            toDownloadNumber++;
        }

        public int CompareFiles()
        {
            int curr_array_element = 0;
            XmlDocument doc = new XmlDocument();
            Hash hash = new Hash();
            doc.Load("FileList.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList allFiles = root.GetElementsByTagName("Fileinfo");

            foreach (XmlNode n in allFiles)
            {
                string fileName = n["File"].InnerText;
                string fileHash = n["Hash"].InnerText;

                if (!File.Exists(fileName))
                {
                    this.increaseDownloadNumber();
                    string[] temp = toDownloadFile;
                    toDownloadFile = new string[toDownloadNumber];
                    int curr_store_element = 0;
                    foreach (string curr_element in temp)
                    {
                        toDownloadFile[curr_store_element] = curr_element;
                        curr_store_element++;
                    }
                    addToDownloadList(fileName, curr_array_element);
                    curr_array_element++;
                }
                else if (hash.GetMD5HashFromFile(fileName) != fileHash)
                {
                    this.increaseDownloadNumber();
                    string[] temp = toDownloadFile;
                    toDownloadFile = new string[toDownloadNumber];
                    int curr_store_element = 0;
                    foreach (string curr_element in temp)
                    {
                        toDownloadFile[curr_store_element] = curr_element;
                        curr_store_element++;
                    }
                    addToDownloadList(fileName, curr_array_element);
                    curr_array_element++;
                }
            }
            return toDownloadNumber;
        }
        public void DeleteFiles()
        {
            XmlDocument doc = new XmlDocument();
            Hash hash = new Hash();
            doc.Load("DeleteList.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList allFiles = root.GetElementsByTagName("Fileinfo");

            foreach (XmlNode n in allFiles)
            {
                string fileName = n["File"].InnerText;
                string fileHash = n["Hash"].InnerText;

                if (File.Exists(fileName) && hash.GetMD5HashFromFile(fileName) == fileHash)
                {
                    File.Delete(fileName);
                }
            }
            this.DeleteFile("DeleteList.xml");
        }


        public void DownloadUpdate()
        {
            if (DownloadClient == null)
                DownloadClient = new WebClient();
           

            sw.Start();
            DownloadClient.DownloadFileCompleted += new AsyncCompletedEventHandler(wclient_DownloadFileCompleted);
            DownloadClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wclient_DownloadProgressChanged);

            CurrentDownFile = Path.GetFileName(toDownloadFile[LeftToDownload]);
            string dpath = Path.GetDirectoryName(toDownloadFile[LeftToDownload]);

            if (!Directory.Exists(dpath))
            {
                if (dpath == "") { }
                else { Directory.CreateDirectory(dpath); }
            }

            try
            {
                string fileToDownload = UpdateURL + toDownloadFile[LeftToDownload];
                DownloadClient.DownloadFileAsync(new Uri(fileToDownload), toDownloadFile[LeftToDownload]);
            }
            catch (Exception)
            {
                CMessageBox.Show("Error!", "Error downloading File:" + toDownloadFile[LeftToDownload], CMessageBoxButton.OK, CMessageBoxIcon.ERROR);
            }
            this.LeftToDownload++;
        }



        void wclient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            string Downloaded = string.Format("{0} MB / {1} MB", (e.BytesReceived / 1024d / 1024d).ToString("0.00"), (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
            string Downloadspeed = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));
            progressBarValue = e.ProgressPercentage;
            UpdateLable_Text = "Downloading: (" + CurrentDownFile + ") " + Downloaded + " (" + e.ProgressPercentage.ToString() + "%) " + Downloadspeed;
        }

        void wclient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBarValue = 0;
            DownloadClient = null;
            sw.Reset();
            if (LeftToDownload < toDownloadNumber)
            {
               pb.SetCurrent(100);
               G.DrawImage(pb.DrawProgressBar(), pb.GetCorner());
               DownloadUpdate();
               DownloadDone = (false);
              
            }
            else
            {
                DownloadDone = (true);
                DeleteFile("FileList.xml");
            }
        }



        public void DeleteFile(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
        }
    }
}
