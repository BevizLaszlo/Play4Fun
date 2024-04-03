namespace Play4Fun.src.Forms
{
    partial class GameStatus
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
            this.gameDescPnl = new System.Windows.Forms.Panel();
            this.startGameBtn = new System.Windows.Forms.Button();
            this.gameDescLbl = new System.Windows.Forms.Label();
            this.nextGameLbl = new System.Windows.Forms.Label();
            this.gameNameLbl = new System.Windows.Forms.Label();
            this.mainPnl = new System.Windows.Forms.Panel();
            this.standingLbl = new System.Windows.Forms.Label();
            this.standingPnl = new System.Windows.Forms.Panel();
            this.turnLbl = new System.Windows.Forms.Label();
            this.gameDescPnl.SuspendLayout();
            this.mainPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameDescPnl
            // 
            this.gameDescPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.gameDescPnl.Controls.Add(this.startGameBtn);
            this.gameDescPnl.Controls.Add(this.gameDescLbl);
            this.gameDescPnl.Controls.Add(this.nextGameLbl);
            this.gameDescPnl.Controls.Add(this.gameNameLbl);
            this.gameDescPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.gameDescPnl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.gameDescPnl.Location = new System.Drawing.Point(550, 0);
            this.gameDescPnl.Name = "gameDescPnl";
            this.gameDescPnl.Size = new System.Drawing.Size(250, 485);
            this.gameDescPnl.TabIndex = 0;
            // 
            // startGameBtn
            // 
            this.startGameBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.startGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameBtn.Font = new System.Drawing.Font("Arial", 14F);
            this.startGameBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.startGameBtn.Location = new System.Drawing.Point(43, 419);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(164, 45);
            this.startGameBtn.TabIndex = 2;
            this.startGameBtn.Text = "START GAME";
            this.startGameBtn.UseVisualStyleBackColor = false;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // gameDescLbl
            // 
            this.gameDescLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameDescLbl.Font = new System.Drawing.Font("Arial", 12F);
            this.gameDescLbl.Location = new System.Drawing.Point(16, 140);
            this.gameDescLbl.Name = "gameDescLbl";
            this.gameDescLbl.Size = new System.Drawing.Size(219, 236);
            this.gameDescLbl.TabIndex = 1;
            this.gameDescLbl.Text = "game desc...";
            this.gameDescLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextGameLbl
            // 
            this.nextGameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextGameLbl.Font = new System.Drawing.Font("Arial", 14F);
            this.nextGameLbl.Location = new System.Drawing.Point(17, 44);
            this.nextGameLbl.Name = "nextGameLbl";
            this.nextGameLbl.Size = new System.Drawing.Size(216, 22);
            this.nextGameLbl.TabIndex = 1;
            this.nextGameLbl.Text = "next game:";
            this.nextGameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameNameLbl
            // 
            this.gameNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameNameLbl.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.gameNameLbl.Location = new System.Drawing.Point(17, 71);
            this.gameNameLbl.Name = "gameNameLbl";
            this.gameNameLbl.Size = new System.Drawing.Size(216, 35);
            this.gameNameLbl.TabIndex = 1;
            this.gameNameLbl.Text = "Game name";
            this.gameNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPnl
            // 
            this.mainPnl.Controls.Add(this.standingLbl);
            this.mainPnl.Controls.Add(this.standingPnl);
            this.mainPnl.Controls.Add(this.turnLbl);
            this.mainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPnl.Location = new System.Drawing.Point(0, 0);
            this.mainPnl.Name = "mainPnl";
            this.mainPnl.Size = new System.Drawing.Size(550, 485);
            this.mainPnl.TabIndex = 1;
            // 
            // standingLbl
            // 
            this.standingLbl.AutoSize = true;
            this.standingLbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.standingLbl.Location = new System.Drawing.Point(20, 108);
            this.standingLbl.Name = "standingLbl";
            this.standingLbl.Size = new System.Drawing.Size(137, 29);
            this.standingLbl.TabIndex = 2;
            this.standingLbl.Text = "Standings:";
            // 
            // standingPnl
            // 
            this.standingPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.standingPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.standingPnl.Location = new System.Drawing.Point(25, 149);
            this.standingPnl.Name = "standingPnl";
            this.standingPnl.Size = new System.Drawing.Size(500, 305);
            this.standingPnl.TabIndex = 1;
            // 
            // turnLbl
            // 
            this.turnLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.turnLbl.AutoSize = true;
            this.turnLbl.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.turnLbl.Location = new System.Drawing.Point(193, 44);
            this.turnLbl.Name = "turnLbl";
            this.turnLbl.Size = new System.Drawing.Size(165, 35);
            this.turnLbl.TabIndex = 0;
            this.turnLbl.Text = "TURN: X/X";
            // 
            // GameStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.mainPnl);
            this.Controls.Add(this.gameDescPnl);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.Name = "GameStatus";
            this.Text = "GameStatus";
            this.Load += new System.EventHandler(this.GameStatus_Load);
            this.gameDescPnl.ResumeLayout(false);
            this.mainPnl.ResumeLayout(false);
            this.mainPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameDescPnl;
        private System.Windows.Forms.Panel mainPnl;
        private System.Windows.Forms.Label turnLbl;
        private System.Windows.Forms.Panel standingPnl;
        private System.Windows.Forms.Label standingLbl;
        private System.Windows.Forms.Label nextGameLbl;
        private System.Windows.Forms.Label gameNameLbl;
        private System.Windows.Forms.Label gameDescLbl;
        private System.Windows.Forms.Button startGameBtn;
    }
}