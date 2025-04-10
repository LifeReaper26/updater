namespace ClientUpdater
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ChangeLog_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Update_progressBar = new System.Windows.Forms.ProgressBar();
            this.Infos_lable = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Resize_timer = new System.Windows.Forms.Timer(this.components);
            this.StyleTimer = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar_PictureBox = new System.Windows.Forms.PictureBox();
            this.Logo_pictureBox = new System.Windows.Forms.PictureBox();
            this.Settings_button = new System.Windows.Forms.Button();
            this.Website_button = new System.Windows.Forms.Button();
            this.Start_button = new System.Windows.Forms.Button();
            this.ServerStatus_pictureBox = new System.Windows.Forms.PictureBox();
            this.Close_button = new System.Windows.Forms.Button();
            this.TopCenterFrame_pictureBox = new System.Windows.Forms.PictureBox();
            this.TopRightFrame_pictureBox = new System.Windows.Forms.PictureBox();
            this.RightCenterFrame_pictureBox = new System.Windows.Forms.PictureBox();
            this.BottomRightFrame_pictureBox = new System.Windows.Forms.PictureBox();
            this.BottomCenterFrame_pictureBox = new System.Windows.Forms.PictureBox();
            this.BottomLeftFrame_pictureBox = new System.Windows.Forms.PictureBox();
            this.LeftCenterFrame_pictureBox = new System.Windows.Forms.PictureBox();
            this.TopLeftFrame_pictureBox = new System.Windows.Forms.PictureBox();
            this.Update_label = new System.Windows.Forms.Label();
            this.ServerStatus2_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerStatus_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCenterFrame_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightFrame_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightCenterFrame_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightFrame_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomCenterFrame_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftFrame_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftCenterFrame_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftFrame_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerStatus2_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeLog_richTextBox
            // 
            this.ChangeLog_richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeLog_richTextBox.BackColor = System.Drawing.Color.Black;
            this.ChangeLog_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangeLog_richTextBox.ForeColor = System.Drawing.Color.White;
            this.ChangeLog_richTextBox.Location = new System.Drawing.Point(36, 273);
            this.ChangeLog_richTextBox.Name = "ChangeLog_richTextBox";
            this.ChangeLog_richTextBox.Size = new System.Drawing.Size(353, 158);
            this.ChangeLog_richTextBox.TabIndex = 9;
            this.ChangeLog_richTextBox.Text = "";
            // 
            // Update_progressBar
            // 
            this.Update_progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Update_progressBar.Location = new System.Drawing.Point(336, 300);
            this.Update_progressBar.MarqueeAnimationSpeed = 50;
            this.Update_progressBar.Name = "Update_progressBar";
            this.Update_progressBar.Size = new System.Drawing.Size(371, 10);
            this.Update_progressBar.TabIndex = 14;
            this.Update_progressBar.Visible = false;
            // 
            // Infos_lable
            // 
            this.Infos_lable.AutoSize = true;
            this.Infos_lable.BackColor = System.Drawing.Color.Black;
            this.Infos_lable.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infos_lable.ForeColor = System.Drawing.Color.Lime;
            this.Infos_lable.Location = new System.Drawing.Point(70, 16);
            this.Infos_lable.Name = "Infos_lable";
            this.Infos_lable.Size = new System.Drawing.Size(49, 16);
            this.Infos_lable.TabIndex = 16;
            this.Infos_lable.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(28, 462);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(C)Updater";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Resize_timer
            // 
            this.Resize_timer.Tick += new System.EventHandler(this.Resize_timer_Tick);
            // 
            // StyleTimer
            // 
            this.StyleTimer.Enabled = true;
            this.StyleTimer.Interval = 50;
            this.StyleTimer.Tick += new System.EventHandler(this.StyleTimer_Tick);
            // 
            // ProgressBar_PictureBox
            // 
            this.ProgressBar_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProgressBar_PictureBox.Location = new System.Drawing.Point(41, 402);
            this.ProgressBar_PictureBox.Name = "ProgressBar_PictureBox";
            this.ProgressBar_PictureBox.Size = new System.Drawing.Size(666, 37);
            this.ProgressBar_PictureBox.TabIndex = 19;
            this.ProgressBar_PictureBox.TabStop = false;
            this.ProgressBar_PictureBox.Visible = false;
            this.ProgressBar_PictureBox.Click += new System.EventHandler(this.ProgressBar_PictureBox_Click);
            // 
            // Logo_pictureBox
            // 
            this.Logo_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Logo_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo_pictureBox.Location = new System.Drawing.Point(39, 56);
            this.Logo_pictureBox.Name = "Logo_pictureBox";
            this.Logo_pictureBox.Size = new System.Drawing.Size(328, 179);
            this.Logo_pictureBox.TabIndex = 18;
            this.Logo_pictureBox.TabStop = false;
            this.Logo_pictureBox.Click += new System.EventHandler(this.Logo_pictureBox_Click);
            // 
            // Settings_button
            // 
            this.Settings_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings_button.BackColor = System.Drawing.Color.Transparent;
            this.Settings_button.BackgroundImage = global::ClientUpdater.Properties.Resources.B_default;
            this.Settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Settings_button.ForeColor = System.Drawing.Color.Peru;
            this.Settings_button.Location = new System.Drawing.Point(668, 445);
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.Size = new System.Drawing.Size(97, 22);
            this.Settings_button.TabIndex = 13;
            this.Settings_button.Text = "Settings";
            this.Settings_button.UseVisualStyleBackColor = false;
            this.Settings_button.Click += new System.EventHandler(this.Settings_button_Click);
            this.Settings_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Settings_button_MouseDown);
            this.Settings_button.MouseEnter += new System.EventHandler(this.Settings_button_MouseEnter);
            this.Settings_button.MouseLeave += new System.EventHandler(this.Settings_button_MouseLeave);
            this.Settings_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Settings_button_MouseUp);
            // 
            // Website_button
            // 
            this.Website_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Website_button.BackColor = System.Drawing.Color.Transparent;
            this.Website_button.BackgroundImage = global::ClientUpdater.Properties.Resources.B_default;
            this.Website_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Website_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Website_button.ForeColor = System.Drawing.Color.Peru;
            this.Website_button.Location = new System.Drawing.Point(565, 445);
            this.Website_button.Name = "Website_button";
            this.Website_button.Size = new System.Drawing.Size(97, 22);
            this.Website_button.TabIndex = 12;
            this.Website_button.Text = "Website";
            this.Website_button.UseVisualStyleBackColor = false;
            this.Website_button.Click += new System.EventHandler(this.Website_button_Click);
            this.Website_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Website_button_MouseDown);
            this.Website_button.MouseEnter += new System.EventHandler(this.Website_button_MouseEnter);
            this.Website_button.MouseLeave += new System.EventHandler(this.Website_button_MouseLeave);
            this.Website_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Website_button_MouseUp);
            // 
            // Start_button
            // 
            this.Start_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Start_button.BackColor = System.Drawing.Color.Transparent;
            this.Start_button.BackgroundImage = global::ClientUpdater.Properties.Resources.B_default;
            this.Start_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Start_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start_button.ForeColor = System.Drawing.Color.Peru;
            this.Start_button.Location = new System.Drawing.Point(462, 445);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(97, 22);
            this.Start_button.TabIndex = 11;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = false;
            this.Start_button.Click += new System.EventHandler(this.Start_button_Click);
            this.Start_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Start_button_MouseDown);
            this.Start_button.MouseEnter += new System.EventHandler(this.Start_button_MouseEnter);
            this.Start_button.MouseLeave += new System.EventHandler(this.Start_button_MouseLeave);
            this.Start_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Start_button_MouseUp);
            // 
            // ServerStatus_pictureBox
            // 
            this.ServerStatus_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerStatus_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ServerStatus_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ServerStatus_pictureBox.Location = new System.Drawing.Point(591, 70);
            this.ServerStatus_pictureBox.Name = "ServerStatus_pictureBox";
            this.ServerStatus_pictureBox.Size = new System.Drawing.Size(154, 103);
            this.ServerStatus_pictureBox.TabIndex = 10;
            this.ServerStatus_pictureBox.TabStop = false;
            this.ServerStatus_pictureBox.Visible = false;
            this.ServerStatus_pictureBox.Click += new System.EventHandler(this.ServerStatus_pictureBox_Click);
            this.ServerStatus_pictureBox.MouseHover += new System.EventHandler(this.ServerStatus_pictureBox_MouseHover);
            this.ServerStatus_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ServerStatus_pictureBox_MouseMove);
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Close_button.Location = new System.Drawing.Point(766, 16);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(18, 18);
            this.Close_button.TabIndex = 8;
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // TopCenterFrame_pictureBox
            // 
            this.TopCenterFrame_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopCenterFrame_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TopCenterFrame_pictureBox.BackgroundImage = global::ClientUpdater.Properties.Resources.TopCenter;
            this.TopCenterFrame_pictureBox.Location = new System.Drawing.Point(73, 0);
            this.TopCenterFrame_pictureBox.Name = "TopCenterFrame_pictureBox";
            this.TopCenterFrame_pictureBox.Size = new System.Drawing.Size(678, 50);
            this.TopCenterFrame_pictureBox.TabIndex = 7;
            this.TopCenterFrame_pictureBox.TabStop = false;
            this.TopCenterFrame_pictureBox.WaitOnLoad = true;
            this.TopCenterFrame_pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopCenterFrame_pictureBox_MouseDown);
            // 
            // TopRightFrame_pictureBox
            // 
            this.TopRightFrame_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopRightFrame_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TopRightFrame_pictureBox.BackgroundImage = global::ClientUpdater.Properties.Resources.TopRight;
            this.TopRightFrame_pictureBox.Location = new System.Drawing.Point(751, 0);
            this.TopRightFrame_pictureBox.Name = "TopRightFrame_pictureBox";
            this.TopRightFrame_pictureBox.Size = new System.Drawing.Size(49, 84);
            this.TopRightFrame_pictureBox.TabIndex = 6;
            this.TopRightFrame_pictureBox.TabStop = false;
            this.TopRightFrame_pictureBox.WaitOnLoad = true;
            // 
            // RightCenterFrame_pictureBox
            // 
            this.RightCenterFrame_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightCenterFrame_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RightCenterFrame_pictureBox.BackgroundImage = global::ClientUpdater.Properties.Resources.RightCenter;
            this.RightCenterFrame_pictureBox.Location = new System.Drawing.Point(771, 84);
            this.RightCenterFrame_pictureBox.Name = "RightCenterFrame_pictureBox";
            this.RightCenterFrame_pictureBox.Size = new System.Drawing.Size(31, 353);
            this.RightCenterFrame_pictureBox.TabIndex = 5;
            this.RightCenterFrame_pictureBox.TabStop = false;
            this.RightCenterFrame_pictureBox.WaitOnLoad = true;
            // 
            // BottomRightFrame_pictureBox
            // 
            this.BottomRightFrame_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomRightFrame_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.BottomRightFrame_pictureBox.BackgroundImage = global::ClientUpdater.Properties.Resources.BottomRight;
            this.BottomRightFrame_pictureBox.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.BottomRightFrame_pictureBox.Location = new System.Drawing.Point(771, 437);
            this.BottomRightFrame_pictureBox.Name = "BottomRightFrame_pictureBox";
            this.BottomRightFrame_pictureBox.Size = new System.Drawing.Size(30, 64);
            this.BottomRightFrame_pictureBox.TabIndex = 4;
            this.BottomRightFrame_pictureBox.TabStop = false;
            this.BottomRightFrame_pictureBox.WaitOnLoad = true;
            this.BottomRightFrame_pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomRightFrame_pictureBox_MouseDown);
            this.BottomRightFrame_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomRightFrame_pictureBox_MouseMove);
            this.BottomRightFrame_pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomRightFrame_pictureBox_MouseUp);
            // 
            // BottomCenterFrame_pictureBox
            // 
            this.BottomCenterFrame_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomCenterFrame_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.BottomCenterFrame_pictureBox.BackgroundImage = global::ClientUpdater.Properties.Resources.BottomCenter;
            this.BottomCenterFrame_pictureBox.Location = new System.Drawing.Point(30, 473);
            this.BottomCenterFrame_pictureBox.Name = "BottomCenterFrame_pictureBox";
            this.BottomCenterFrame_pictureBox.Size = new System.Drawing.Size(742, 28);
            this.BottomCenterFrame_pictureBox.TabIndex = 3;
            this.BottomCenterFrame_pictureBox.TabStop = false;
            this.BottomCenterFrame_pictureBox.WaitOnLoad = true;
            // 
            // BottomLeftFrame_pictureBox
            // 
            this.BottomLeftFrame_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BottomLeftFrame_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.BottomLeftFrame_pictureBox.BackgroundImage = global::ClientUpdater.Properties.Resources.BottomLeft;
            this.BottomLeftFrame_pictureBox.Location = new System.Drawing.Point(0, 437);
            this.BottomLeftFrame_pictureBox.Name = "BottomLeftFrame_pictureBox";
            this.BottomLeftFrame_pictureBox.Size = new System.Drawing.Size(30, 64);
            this.BottomLeftFrame_pictureBox.TabIndex = 2;
            this.BottomLeftFrame_pictureBox.TabStop = false;
            this.BottomLeftFrame_pictureBox.WaitOnLoad = true;
            // 
            // LeftCenterFrame_pictureBox
            // 
            this.LeftCenterFrame_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftCenterFrame_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LeftCenterFrame_pictureBox.BackgroundImage = global::ClientUpdater.Properties.Resources.LeftCenter;
            this.LeftCenterFrame_pictureBox.Location = new System.Drawing.Point(0, 84);
            this.LeftCenterFrame_pictureBox.Name = "LeftCenterFrame_pictureBox";
            this.LeftCenterFrame_pictureBox.Size = new System.Drawing.Size(31, 353);
            this.LeftCenterFrame_pictureBox.TabIndex = 1;
            this.LeftCenterFrame_pictureBox.TabStop = false;
            this.LeftCenterFrame_pictureBox.WaitOnLoad = true;
            // 
            // TopLeftFrame_pictureBox
            // 
            this.TopLeftFrame_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TopLeftFrame_pictureBox.BackgroundImage = global::ClientUpdater.Properties.Resources.TopLeft;
            this.TopLeftFrame_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.TopLeftFrame_pictureBox.Name = "TopLeftFrame_pictureBox";
            this.TopLeftFrame_pictureBox.Size = new System.Drawing.Size(74, 84);
            this.TopLeftFrame_pictureBox.TabIndex = 0;
            this.TopLeftFrame_pictureBox.TabStop = false;
            this.TopLeftFrame_pictureBox.WaitOnLoad = true;
            // 
            // Update_label
            // 
            this.Update_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Update_label.AutoSize = true;
            this.Update_label.BackColor = System.Drawing.Color.Black;
            this.Update_label.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_label.ForeColor = System.Drawing.Color.White;
            this.Update_label.Location = new System.Drawing.Point(155, 416);
            this.Update_label.Name = "Update_label";
            this.Update_label.Size = new System.Drawing.Size(77, 15);
            this.Update_label.TabIndex = 20;
            this.Update_label.Text = "Update label";
            this.Update_label.Visible = false;
            // 
            // ServerStatus2_pictureBox
            // 
            this.ServerStatus2_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerStatus2_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ServerStatus2_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ServerStatus2_pictureBox.Location = new System.Drawing.Point(431, 70);
            this.ServerStatus2_pictureBox.Name = "ServerStatus2_pictureBox";
            this.ServerStatus2_pictureBox.Size = new System.Drawing.Size(154, 103);
            this.ServerStatus2_pictureBox.TabIndex = 21;
            this.ServerStatus2_pictureBox.TabStop = false;
            this.ServerStatus2_pictureBox.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.ServerStatus2_pictureBox);
            this.Controls.Add(this.Update_label);
            this.Controls.Add(this.ProgressBar_PictureBox);
            this.Controls.Add(this.Logo_pictureBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Infos_lable);
            this.Controls.Add(this.Update_progressBar);
            this.Controls.Add(this.Settings_button);
            this.Controls.Add(this.Website_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.ServerStatus_pictureBox);
            this.Controls.Add(this.ChangeLog_richTextBox);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.TopCenterFrame_pictureBox);
            this.Controls.Add(this.TopRightFrame_pictureBox);
            this.Controls.Add(this.RightCenterFrame_pictureBox);
            this.Controls.Add(this.BottomRightFrame_pictureBox);
            this.Controls.Add(this.BottomCenterFrame_pictureBox);
            this.Controls.Add(this.BottomLeftFrame_pictureBox);
            this.Controls.Add(this.LeftCenterFrame_pictureBox);
            this.Controls.Add(this.TopLeftFrame_pictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProgressBar_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerStatus_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopCenterFrame_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRightFrame_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightCenterFrame_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRightFrame_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomCenterFrame_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomLeftFrame_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftCenterFrame_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopLeftFrame_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServerStatus2_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopLeftFrame_pictureBox;
        private System.Windows.Forms.PictureBox LeftCenterFrame_pictureBox;
        private System.Windows.Forms.PictureBox BottomLeftFrame_pictureBox;
        private System.Windows.Forms.PictureBox BottomCenterFrame_pictureBox;
        private System.Windows.Forms.PictureBox BottomRightFrame_pictureBox;
        private System.Windows.Forms.PictureBox RightCenterFrame_pictureBox;
        private System.Windows.Forms.PictureBox TopRightFrame_pictureBox;
        private System.Windows.Forms.PictureBox TopCenterFrame_pictureBox;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.RichTextBox ChangeLog_richTextBox;
        private System.Windows.Forms.PictureBox ServerStatus_pictureBox;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Website_button;
        private System.Windows.Forms.Button Settings_button;
        private System.Windows.Forms.ProgressBar Update_progressBar;
        private System.Windows.Forms.Label Infos_lable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox Logo_pictureBox;
        private System.Windows.Forms.Timer Resize_timer;
        private System.Windows.Forms.Timer StyleTimer;
        private System.Windows.Forms.PictureBox ProgressBar_PictureBox;
        private System.Windows.Forms.Label Update_label;
        private System.Windows.Forms.PictureBox ServerStatus2_pictureBox;
    }
}

