namespace Play4Fun
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.exitBtm = new System.Windows.Forms.Button();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.creditsLbl = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(65, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 186);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.startBtn.Location = new System.Drawing.Point(81, 258);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(205, 54);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "START GAME";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settingsBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.settingsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.settingsBtn.Location = new System.Drawing.Point(81, 323);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(205, 54);
            this.settingsBtn.TabIndex = 2;
            this.settingsBtn.Text = "SETTINGS";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // exitBtm
            // 
            this.exitBtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.exitBtm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitBtm.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBtm.Location = new System.Drawing.Point(81, 388);
            this.exitBtm.Name = "exitBtm";
            this.exitBtm.Size = new System.Drawing.Size(205, 54);
            this.exitBtm.TabIndex = 3;
            this.exitBtm.Text = "EXIT";
            this.exitBtm.UseVisualStyleBackColor = false;
            this.exitBtm.Click += new System.EventHandler(this.exitBtm_Click);
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.containerPanel.Controls.Add(this.creditsLbl);
            this.containerPanel.Controls.Add(this.exitBtm);
            this.containerPanel.Controls.Add(this.settingsBtn);
            this.containerPanel.Controls.Add(this.startBtn);
            this.containerPanel.Controls.Add(this.pictureBox1);
            this.containerPanel.Location = new System.Drawing.Point(34, 24);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(367, 512);
            this.containerPanel.TabIndex = 4;
            // 
            // creditsLbl
            // 
            this.creditsLbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.creditsLbl.AutoSize = true;
            this.creditsLbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.creditsLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.creditsLbl.Location = new System.Drawing.Point(157, 480);
            this.creditsLbl.Name = "creditsLbl";
            this.creditsLbl.Size = new System.Drawing.Size(52, 17);
            this.creditsLbl.TabIndex = 5;
            this.creditsLbl.TabStop = true;
            this.creditsLbl.Text = "credits";
            this.creditsLbl.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.creditsLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditsLbl_LinkClicked);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.containerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play4Fun Start";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button exitBtm;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.LinkLabel creditsLbl;
    }
}

