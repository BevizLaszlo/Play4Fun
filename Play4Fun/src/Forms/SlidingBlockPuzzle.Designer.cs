namespace Play4Fun.src.Forms
{
    partial class SlidingBlockPuzzle
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
            this.components = new System.ComponentModel.Container();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.startBtn = new System.Windows.Forms.Button();
            this.playerLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.playerResultLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GamePanel
            // 
            this.GamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GamePanel.Location = new System.Drawing.Point(85, 92);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(300, 300);
            this.GamePanel.TabIndex = 0;
            // 
            // startBtn
            // 
            this.startBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Arial", 15F);
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.startBtn.Location = new System.Drawing.Point(415, 339);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(171, 53);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "START GAME";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // playerLbl
            // 
            this.playerLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerLbl.AutoSize = true;
            this.playerLbl.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.playerLbl.Location = new System.Drawing.Point(409, 92);
            this.playerLbl.Name = "playerLbl";
            this.playerLbl.Size = new System.Drawing.Size(122, 32);
            this.playerLbl.TabIndex = 2;
            this.playerLbl.Text = "PLAYER";
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Arial", 12F);
            this.timeLbl.Location = new System.Drawing.Point(412, 152);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(123, 18);
            this.timeLbl.TabIndex = 3;
            this.timeLbl.Text = "TIME: 00:00.000";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.playerResultLbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(678, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 485);
            this.panel2.TabIndex = 4;
            // 
            // playerResultLbl
            // 
            this.playerResultLbl.AutoSize = true;
            this.playerResultLbl.Font = new System.Drawing.Font("Arial", 12F);
            this.playerResultLbl.Location = new System.Drawing.Point(45, 129);
            this.playerResultLbl.Name = "playerResultLbl";
            this.playerResultLbl.Size = new System.Drawing.Size(0, 18);
            this.playerResultLbl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(119, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESULTS";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SlidingBlockPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1010, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.playerLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.GamePanel);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.Name = "SlidingBlockPuzzle";
            this.Text = "SlidingBlockPuzzle";
            this.Load += new System.EventHandler(this.SlidingBlockPuzzle_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label playerLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label playerResultLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
    }
}