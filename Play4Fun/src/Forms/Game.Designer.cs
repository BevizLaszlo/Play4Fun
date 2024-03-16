namespace Play4Fun.src.Forms
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.headerPnl = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.char1Pnl = new System.Windows.Forms.Panel();
            this.char2Pnl = new System.Windows.Forms.Panel();
            this.char3Pnl = new System.Windows.Forms.Panel();
            this.char4Pnl = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextPage = new System.Windows.Forms.Button();
            this.headerPnl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.char1Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPnl
            // 
            this.headerPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPnl.Controls.Add(this.titleLbl);
            this.headerPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPnl.Location = new System.Drawing.Point(0, 0);
            this.headerPnl.Name = "headerPnl";
            this.headerPnl.Size = new System.Drawing.Size(800, 100);
            this.headerPnl.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.char1Pnl);
            this.flowLayoutPanel1.Controls.Add(this.char2Pnl);
            this.flowLayoutPanel1.Controls.Add(this.char3Pnl);
            this.flowLayoutPanel1.Controls.Add(this.char4Pnl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 521);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // char1Pnl
            // 
            this.char1Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.char1Pnl.Controls.Add(this.nextBtn);
            this.char1Pnl.Controls.Add(this.prevBtn);
            this.char1Pnl.Controls.Add(this.pictureBox1);
            this.char1Pnl.Location = new System.Drawing.Point(0, 0);
            this.char1Pnl.Margin = new System.Windows.Forms.Padding(0);
            this.char1Pnl.Name = "char1Pnl";
            this.char1Pnl.Size = new System.Drawing.Size(200, 418);
            this.char1Pnl.TabIndex = 0;
            // 
            // char2Pnl
            // 
            this.char2Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.char2Pnl.Location = new System.Drawing.Point(200, 0);
            this.char2Pnl.Margin = new System.Windows.Forms.Padding(0);
            this.char2Pnl.Name = "char2Pnl";
            this.char2Pnl.Size = new System.Drawing.Size(200, 418);
            this.char2Pnl.TabIndex = 1;
            // 
            // char3Pnl
            // 
            this.char3Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.char3Pnl.Location = new System.Drawing.Point(400, 0);
            this.char3Pnl.Margin = new System.Windows.Forms.Padding(0);
            this.char3Pnl.Name = "char3Pnl";
            this.char3Pnl.Size = new System.Drawing.Size(200, 418);
            this.char3Pnl.TabIndex = 2;
            // 
            // char4Pnl
            // 
            this.char4Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.char4Pnl.Location = new System.Drawing.Point(600, 0);
            this.char4Pnl.Margin = new System.Windows.Forms.Padding(0);
            this.char4Pnl.Name = "char4Pnl";
            this.char4Pnl.Size = new System.Drawing.Size(200, 418);
            this.char4Pnl.TabIndex = 3;
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.titleLbl.Location = new System.Drawing.Point(186, 33);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(427, 32);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "CHOOSE YOUR CHARACTERS!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(49, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prevBtn.Location = new System.Drawing.Point(19, 113);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(24, 38);
            this.prevBtn.TabIndex = 1;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextBtn.Location = new System.Drawing.Point(155, 113);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(24, 38);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nextPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // nextPage
            // 
            this.nextPage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextPage.Font = new System.Drawing.Font("Arial", 10F);
            this.nextPage.ForeColor = System.Drawing.SystemColors.Control;
            this.nextPage.Location = new System.Drawing.Point(705, 32);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(83, 37);
            this.nextPage.TabIndex = 3;
            this.nextPage.Text = "NEXT";
            this.nextPage.UseVisualStyleBackColor = false;
            this.nextPage.Click += new System.EventHandler(this.nextPage_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(800, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.headerPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.headerPnl.ResumeLayout(false);
            this.headerPnl.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.char1Pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPnl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel char1Pnl;
        private System.Windows.Forms.Panel char2Pnl;
        private System.Windows.Forms.Panel char3Pnl;
        private System.Windows.Forms.Panel char4Pnl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nextPage;
    }
}