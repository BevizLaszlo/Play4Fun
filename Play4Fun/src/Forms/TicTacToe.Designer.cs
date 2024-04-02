namespace Play4Fun.src.Forms
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.titleLbl = new System.Windows.Forms.Label();
            this.game_panel = new System.Windows.Forms.Panel();
            this.character_panel = new System.Windows.Forms.Panel();
            this.points_label = new System.Windows.Forms.Label();
            this.player_lbl = new System.Windows.Forms.Label();
            this.playersTurn_label = new System.Windows.Forms.Label();
            this.playfield_panel = new System.Windows.Forms.Panel();
            this.game_panel.SuspendLayout();
            this.character_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.titleLbl.Location = new System.Drawing.Point(572, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(188, 32);
            this.titleLbl.TabIndex = 4;
            this.titleLbl.Text = "TIC TAC TOE";
            // 
            // game_panel
            // 
            this.game_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.game_panel.Controls.Add(this.character_panel);
            this.game_panel.Controls.Add(this.playersTurn_label);
            this.game_panel.Controls.Add(this.playfield_panel);
            this.game_panel.Location = new System.Drawing.Point(3, 44);
            this.game_panel.Name = "game_panel";
            this.game_panel.Size = new System.Drawing.Size(1332, 738);
            this.game_panel.TabIndex = 5;
            // 
            // character_panel
            // 
            this.character_panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.character_panel.Controls.Add(this.points_label);
            this.character_panel.Controls.Add(this.player_lbl);
            this.character_panel.Location = new System.Drawing.Point(4, 3);
            this.character_panel.Name = "character_panel";
            this.character_panel.Size = new System.Drawing.Size(216, 184);
            this.character_panel.TabIndex = 17;
            // 
            // points_label
            // 
            this.points_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.points_label.AutoSize = true;
            this.points_label.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.points_label.Location = new System.Drawing.Point(193, 13);
            this.points_label.Name = "points_label";
            this.points_label.Size = new System.Drawing.Size(20, 22);
            this.points_label.TabIndex = 17;
            this.points_label.Text = "0";
            this.points_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // player_lbl
            // 
            this.player_lbl.AutoSize = true;
            this.player_lbl.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player_lbl.Location = new System.Drawing.Point(3, 13);
            this.player_lbl.Name = "player_lbl";
            this.player_lbl.Size = new System.Drawing.Size(87, 22);
            this.player_lbl.TabIndex = 9;
            this.player_lbl.Text = "PLAYER1";
            this.player_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playersTurn_label
            // 
            this.playersTurn_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playersTurn_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.playersTurn_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.playersTurn_label.Location = new System.Drawing.Point(238, 696);
            this.playersTurn_label.Name = "playersTurn_label";
            this.playersTurn_label.Size = new System.Drawing.Size(857, 32);
            this.playersTurn_label.TabIndex = 6;
            this.playersTurn_label.Text = "PLAYER\'S TURN";
            this.playersTurn_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playfield_panel
            // 
            this.playfield_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playfield_panel.Location = new System.Drawing.Point(226, 0);
            this.playfield_panel.Name = "playfield_panel";
            this.playfield_panel.Size = new System.Drawing.Size(881, 663);
            this.playfield_panel.TabIndex = 0;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1332, 781);
            this.Controls.Add(this.game_panel);
            this.Controls.Add(this.titleLbl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.game_panel.ResumeLayout(false);
            this.character_panel.ResumeLayout(false);
            this.character_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel game_panel;
        private System.Windows.Forms.Panel playfield_panel;
        private System.Windows.Forms.Label playersTurn_label;
        private System.Windows.Forms.Panel character_panel;
        private System.Windows.Forms.Label points_label;
        private System.Windows.Forms.Label player_lbl;
    }
}