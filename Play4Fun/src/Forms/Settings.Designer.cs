namespace Play4Fun.src.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.soundLbl = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.soundPanel = new System.Windows.Forms.Panel();
            this.soundON = new System.Windows.Forms.RadioButton();
            this.soundOFF = new System.Windows.Forms.RadioButton();
            this.containerPanel.SuspendLayout();
            this.soundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.saveSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveSettingsBtn.Font = new System.Drawing.Font("Arial", 10F);
            this.saveSettingsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.saveSettingsBtn.Location = new System.Drawing.Point(285, 365);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(192, 37);
            this.saveSettingsBtn.TabIndex = 2;
            this.saveSettingsBtn.Text = "SAVE SETTINGS";
            this.saveSettingsBtn.UseVisualStyleBackColor = false;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // soundLbl
            // 
            this.soundLbl.AutoSize = true;
            this.soundLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soundLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.soundLbl.Location = new System.Drawing.Point(272, 164);
            this.soundLbl.Name = "soundLbl";
            this.soundLbl.Size = new System.Drawing.Size(53, 16);
            this.soundLbl.TabIndex = 3;
            this.soundLbl.Text = "SOUND";
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.containerPanel.Controls.Add(this.soundPanel);
            this.containerPanel.Controls.Add(this.soundLbl);
            this.containerPanel.Controls.Add(this.saveSettingsBtn);
            this.containerPanel.Location = new System.Drawing.Point(11, 7);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(762, 416);
            this.containerPanel.TabIndex = 4;
            // 
            // soundPanel
            // 
            this.soundPanel.Controls.Add(this.soundOFF);
            this.soundPanel.Controls.Add(this.soundON);
            this.soundPanel.Location = new System.Drawing.Point(341, 159);
            this.soundPanel.Name = "soundPanel";
            this.soundPanel.Size = new System.Drawing.Size(150, 25);
            this.soundPanel.TabIndex = 4;
            // 
            // soundON
            // 
            this.soundON.AutoSize = true;
            this.soundON.Checked = true;
            this.soundON.Location = new System.Drawing.Point(17, 5);
            this.soundON.Name = "soundON";
            this.soundON.Size = new System.Drawing.Size(41, 17);
            this.soundON.TabIndex = 0;
            this.soundON.TabStop = true;
            this.soundON.Text = "ON";
            this.soundON.UseVisualStyleBackColor = true;
            // 
            // soundOFF
            // 
            this.soundOFF.AutoSize = true;
            this.soundOFF.Location = new System.Drawing.Point(85, 5);
            this.soundOFF.Name = "soundOFF";
            this.soundOFF.Size = new System.Drawing.Size(45, 17);
            this.soundOFF.TabIndex = 1;
            this.soundOFF.Text = "OFF";
            this.soundOFF.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.ControlBox = false;
            this.Controls.Add(this.containerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.containerPanel.ResumeLayout(false);
            this.containerPanel.PerformLayout();
            this.soundPanel.ResumeLayout(false);
            this.soundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveSettingsBtn;
        private System.Windows.Forms.Label soundLbl;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel soundPanel;
        private System.Windows.Forms.RadioButton soundOFF;
        private System.Windows.Forms.RadioButton soundON;
    }
}