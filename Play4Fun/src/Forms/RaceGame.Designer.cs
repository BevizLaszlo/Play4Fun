namespace Play4Fun.src.Forms
{
    partial class RaceGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bottomright = new System.Windows.Forms.Panel();
            this.bottomleft = new System.Windows.Forms.Panel();
            this.middleright = new System.Windows.Forms.Panel();
            this.middlecenter = new System.Windows.Forms.Panel();
            this.middleleft = new System.Windows.Forms.Panel();
            this.topright = new System.Windows.Forms.Panel();
            this.topleft = new System.Windows.Forms.Panel();
            this.rollBtn = new System.Windows.Forms.Button();
            this.playerTurnLbl = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bottomright);
            this.panel1.Controls.Add(this.bottomleft);
            this.panel1.Controls.Add(this.middleright);
            this.panel1.Controls.Add(this.middlecenter);
            this.panel1.Controls.Add(this.middleleft);
            this.panel1.Controls.Add(this.topright);
            this.panel1.Controls.Add(this.topleft);
            this.panel1.Location = new System.Drawing.Point(85, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 140);
            this.panel1.TabIndex = 0;
            // 
            // bottomright
            // 
            this.bottomright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.bottomright.Location = new System.Drawing.Point(91, 95);
            this.bottomright.Name = "bottomright";
            this.bottomright.Size = new System.Drawing.Size(20, 22);
            this.bottomright.TabIndex = 0;
            // 
            // bottomleft
            // 
            this.bottomleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.bottomleft.Location = new System.Drawing.Point(17, 95);
            this.bottomleft.Name = "bottomleft";
            this.bottomleft.Size = new System.Drawing.Size(20, 22);
            this.bottomleft.TabIndex = 0;
            // 
            // middleright
            // 
            this.middleright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.middleright.Location = new System.Drawing.Point(91, 58);
            this.middleright.Name = "middleright";
            this.middleright.Size = new System.Drawing.Size(20, 22);
            this.middleright.TabIndex = 0;
            // 
            // middlecenter
            // 
            this.middlecenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.middlecenter.Location = new System.Drawing.Point(54, 58);
            this.middlecenter.Name = "middlecenter";
            this.middlecenter.Size = new System.Drawing.Size(20, 22);
            this.middlecenter.TabIndex = 0;
            this.middlecenter.Visible = false;
            // 
            // middleleft
            // 
            this.middleleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.middleleft.Location = new System.Drawing.Point(17, 58);
            this.middleleft.Name = "middleleft";
            this.middleleft.Size = new System.Drawing.Size(20, 22);
            this.middleleft.TabIndex = 0;
            // 
            // topright
            // 
            this.topright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.topright.Location = new System.Drawing.Point(91, 22);
            this.topright.Name = "topright";
            this.topright.Size = new System.Drawing.Size(20, 22);
            this.topright.TabIndex = 0;
            // 
            // topleft
            // 
            this.topleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.topleft.Location = new System.Drawing.Point(17, 22);
            this.topleft.Name = "topleft";
            this.topleft.Size = new System.Drawing.Size(20, 22);
            this.topleft.TabIndex = 0;
            // 
            // rollBtn
            // 
            this.rollBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rollBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.rollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollBtn.Font = new System.Drawing.Font("Arial", 12F);
            this.rollBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.rollBtn.Location = new System.Drawing.Point(257, 116);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(157, 37);
            this.rollBtn.TabIndex = 1;
            this.rollBtn.Text = "ROLL THE DICE";
            this.rollBtn.UseVisualStyleBackColor = false;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // playerTurnLbl
            // 
            this.playerTurnLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerTurnLbl.AutoSize = true;
            this.playerTurnLbl.Font = new System.Drawing.Font("Arial", 20F);
            this.playerTurnLbl.Location = new System.Drawing.Point(252, 58);
            this.playerTurnLbl.Name = "playerTurnLbl";
            this.playerTurnLbl.Size = new System.Drawing.Size(162, 32);
            this.playerTurnLbl.TabIndex = 2;
            this.playerTurnLbl.Text = "player\'s turn";
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Location = new System.Drawing.Point(85, 210);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(630, 240);
            this.gamePanel.TabIndex = 3;
            // 
            // RaceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.playerTurnLbl);
            this.Controls.Add(this.rollBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.Name = "RaceGame";
            this.Text = "RaceGame";
            this.Load += new System.EventHandler(this.RaceGame_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel bottomright;
        private System.Windows.Forms.Panel bottomleft;
        private System.Windows.Forms.Panel middleright;
        private System.Windows.Forms.Panel middlecenter;
        private System.Windows.Forms.Panel middleleft;
        private System.Windows.Forms.Panel topright;
        private System.Windows.Forms.Panel topleft;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.Label playerTurnLbl;
        private System.Windows.Forms.Panel gamePanel;
    }
}