namespace ClientUpdater
{
    partial class CMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlbCaption = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.IconPixtureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconPixtureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tlbCaption
            // 
            this.tlbCaption.AutoSize = true;
            this.tlbCaption.BackColor = System.Drawing.Color.Black;
            this.tlbCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlbCaption.ForeColor = System.Drawing.Color.SandyBrown;
            this.tlbCaption.Location = new System.Drawing.Point(67, 15);
            this.tlbCaption.Name = "tlbCaption";
            this.tlbCaption.Size = new System.Drawing.Size(56, 15);
            this.tlbCaption.TabIndex = 0;
            this.tlbCaption.Text = "Caption";
            // 
            // tbxMessage
            // 
            this.tbxMessage.BackColor = System.Drawing.Color.Black;
            this.tbxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMessage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMessage.ForeColor = System.Drawing.Color.Peru;
            this.tbxMessage.HideSelection = false;
            this.tbxMessage.Location = new System.Drawing.Point(26, 91);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.ReadOnly = true;
            this.tbxMessage.Size = new System.Drawing.Size(449, 101);
            this.tbxMessage.TabIndex = 1;
            this.tbxMessage.TabStop = false;
            this.tbxMessage.Text = "Message";
            this.tbxMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.BackgroundImage = global::ClientUpdater.Properties.Resources.B_default;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.Color.Peru;
            this.btnCancel.Location = new System.Drawing.Point(400, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Close_button
            // 
            this.Close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_button.BackColor = System.Drawing.Color.Black;
            this.Close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Location = new System.Drawing.Point(462, 12);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(18, 18);
            this.Close_button.TabIndex = 9;
            this.Close_button.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Black;
            this.btnOK.BackgroundImage = global::ClientUpdater.Properties.Resources.B_default;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.ForeColor = System.Drawing.Color.Peru;
            this.btnOK.Location = new System.Drawing.Point(319, 198);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Black;
            this.btnYes.BackgroundImage = global::ClientUpdater.Properties.Resources.B_default;
            this.btnYes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYes.ForeColor = System.Drawing.Color.Peru;
            this.btnYes.Location = new System.Drawing.Point(238, 198);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 11;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNO
            // 
            this.btnNO.BackColor = System.Drawing.Color.Black;
            this.btnNO.BackgroundImage = global::ClientUpdater.Properties.Resources.B_default;
            this.btnNO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNO.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNO.ForeColor = System.Drawing.Color.Peru;
            this.btnNO.Location = new System.Drawing.Point(157, 198);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(75, 23);
            this.btnNO.TabIndex = 12;
            this.btnNO.Text = "No";
            this.btnNO.UseVisualStyleBackColor = false;
            this.btnNO.Visible = false;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.Black;
            this.btnRetry.BackgroundImage = global::ClientUpdater.Properties.Resources.B_default;
            this.btnRetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetry.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetry.ForeColor = System.Drawing.Color.Peru;
            this.btnRetry.Location = new System.Drawing.Point(76, 198);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(75, 23);
            this.btnRetry.TabIndex = 13;
            this.btnRetry.Text = "Retry";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // IconPixtureBox
            // 
            this.IconPixtureBox.BackColor = System.Drawing.Color.Transparent;
            this.IconPixtureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconPixtureBox.Location = new System.Drawing.Point(39, 12);
            this.IconPixtureBox.Name = "IconPixtureBox";
            this.IconPixtureBox.Size = new System.Drawing.Size(22, 22);
            this.IconPixtureBox.TabIndex = 14;
            this.IconPixtureBox.TabStop = false;
            // 
            // CMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::ClientUpdater.Properties.Resources.CMessageBox;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.IconPixtureBox);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.tlbCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMessageBox";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CMessageBox_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.IconPixtureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tlbCaption;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.PictureBox IconPixtureBox;
    }
}