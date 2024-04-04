namespace Play4Fun.src.Forms
{
    partial class HangmanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangmanForm));
            this.titleLbl = new System.Windows.Forms.Label();
            this.hangman_pictureBox = new System.Windows.Forms.PictureBox();
            this.playersTurn_label = new System.Windows.Forms.Label();
            this.player_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guessBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.secretWordLbl = new System.Windows.Forms.Label();
            this.wrongWordCouldBe_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.wrong_word_listBox = new System.Windows.Forms.ListBox();
            this.guessFullWord_label = new System.Windows.Forms.Label();
            this.guessplayersword_label = new System.Windows.Forms.Label();
            this.wrongchar_label = new System.Windows.Forms.Label();
            this.character_panel = new System.Windows.Forms.Panel();
            this.points_label = new System.Windows.Forms.Label();
            this.pluspoints_label = new System.Windows.Forms.Label();
            this.guess_points_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangman_pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.character_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.titleLbl.Location = new System.Drawing.Point(556, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(154, 32);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "HANGMAN";
            // 
            // hangman_pictureBox
            // 
            this.hangman_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.hangman_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hangman_pictureBox.Image")));
            this.hangman_pictureBox.Location = new System.Drawing.Point(334, 41);
            this.hangman_pictureBox.Name = "hangman_pictureBox";
            this.hangman_pictureBox.Size = new System.Drawing.Size(239, 268);
            this.hangman_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hangman_pictureBox.TabIndex = 4;
            this.hangman_pictureBox.TabStop = false;
            // 
            // playersTurn_label
            // 
            this.playersTurn_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playersTurn_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.playersTurn_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.playersTurn_label.Location = new System.Drawing.Point(242, 641);
            this.playersTurn_label.Name = "playersTurn_label";
            this.playersTurn_label.Size = new System.Drawing.Size(857, 32);
            this.playersTurn_label.TabIndex = 5;
            this.playersTurn_label.Text = "PLAYER\'S TURN";
            this.playersTurn_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.guessBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.wrongWordCouldBe_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guessTextBox);
            this.panel1.Controls.Add(this.wrong_word_listBox);
            this.panel1.Controls.Add(this.guessFullWord_label);
            this.panel1.Controls.Add(this.guessplayersword_label);
            this.panel1.Controls.Add(this.wrongchar_label);
            this.panel1.Controls.Add(this.hangman_pictureBox);
            this.panel1.Location = new System.Drawing.Point(223, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 502);
            this.panel1.TabIndex = 11;
            // 
            // guessBtn
            // 
            this.guessBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guessBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.guessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.guessBtn.Location = new System.Drawing.Point(416, 469);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(75, 30);
            this.guessBtn.TabIndex = 24;
            this.guessBtn.Text = "GUESS";
            this.guessBtn.UseVisualStyleBackColor = false;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.secretWordLbl);
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 62);
            this.panel2.TabIndex = 23;
            // 
            // secretWordLbl
            // 
            this.secretWordLbl.AllowDrop = true;
            this.secretWordLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secretWordLbl.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.secretWordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.secretWordLbl.Location = new System.Drawing.Point(19, 15);
            this.secretWordLbl.Name = "secretWordLbl";
            this.secretWordLbl.Size = new System.Drawing.Size(868, 32);
            this.secretWordLbl.TabIndex = 22;
            this.secretWordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wrongWordCouldBe_label
            // 
            this.wrongWordCouldBe_label.AutoSize = true;
            this.wrongWordCouldBe_label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrongWordCouldBe_label.ForeColor = System.Drawing.Color.Red;
            this.wrongWordCouldBe_label.Location = new System.Drawing.Point(104, 155);
            this.wrongWordCouldBe_label.Name = "wrongWordCouldBe_label";
            this.wrongWordCouldBe_label.Size = new System.Drawing.Size(26, 29);
            this.wrongWordCouldBe_label.TabIndex = 16;
            this.wrongWordCouldBe_label.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 38);
            this.label2.TabIndex = 20;
            this.label2.Text = "HOW MANY MORE BAD \r\nATTEMPTS THERE  COULD BE:";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guessTextBox.Location = new System.Drawing.Point(285, 443);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(337, 20);
            this.guessTextBox.TabIndex = 19;
            // 
            // wrong_word_listBox
            // 
            this.wrong_word_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wrong_word_listBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.wrong_word_listBox.FormattingEnabled = true;
            this.wrong_word_listBox.Location = new System.Drawing.Point(779, 41);
            this.wrong_word_listBox.Name = "wrong_word_listBox";
            this.wrong_word_listBox.Size = new System.Drawing.Size(125, 303);
            this.wrong_word_listBox.TabIndex = 19;
            // 
            // guessFullWord_label
            // 
            this.guessFullWord_label.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guessFullWord_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.guessFullWord_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.guessFullWord_label.Location = new System.Drawing.Point(14, 408);
            this.guessFullWord_label.Name = "guessFullWord_label";
            this.guessFullWord_label.Size = new System.Drawing.Size(878, 32);
            this.guessFullWord_label.TabIndex = 13;
            this.guessFullWord_label.Text = "GUESS THE FULL WORD OR CHARACTER";
            this.guessFullWord_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessplayersword_label
            // 
            this.guessplayersword_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guessplayersword_label.AutoSize = true;
            this.guessplayersword_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.guessplayersword_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.guessplayersword_label.Location = new System.Drawing.Point(282, 7);
            this.guessplayersword_label.Name = "guessplayersword_label";
            this.guessplayersword_label.Size = new System.Drawing.Size(343, 32);
            this.guessplayersword_label.TabIndex = 12;
            this.guessplayersword_label.Text = "GUESS PLAYER\'S WORD";
            // 
            // wrongchar_label
            // 
            this.wrongchar_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wrongchar_label.AutoSize = true;
            this.wrongchar_label.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrongchar_label.ForeColor = System.Drawing.Color.Red;
            this.wrongchar_label.Location = new System.Drawing.Point(776, 13);
            this.wrongchar_label.Name = "wrongchar_label";
            this.wrongchar_label.Size = new System.Drawing.Size(128, 16);
            this.wrongchar_label.TabIndex = 12;
            this.wrongchar_label.Text = "WRONG CHARACTERS";
            // 
            // character_panel
            // 
            this.character_panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.character_panel.Controls.Add(this.points_label);
            this.character_panel.Controls.Add(this.pluspoints_label);
            this.character_panel.Controls.Add(this.guess_points_lbl);
            this.character_panel.Controls.Add(this.player_lbl);
            this.character_panel.Location = new System.Drawing.Point(1, 82);
            this.character_panel.Name = "character_panel";
            this.character_panel.Size = new System.Drawing.Size(216, 184);
            this.character_panel.TabIndex = 16;
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
            // pluspoints_label
            // 
            this.pluspoints_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pluspoints_label.AutoSize = true;
            this.pluspoints_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pluspoints_label.ForeColor = System.Drawing.Color.Green;
            this.pluspoints_label.Location = new System.Drawing.Point(186, 151);
            this.pluspoints_label.Name = "pluspoints_label";
            this.pluspoints_label.Size = new System.Drawing.Size(27, 19);
            this.pluspoints_label.TabIndex = 16;
            this.pluspoints_label.Text = "+1";
            this.pluspoints_label.Visible = false;
            // 
            // guess_points_lbl
            // 
            this.guess_points_lbl.AutoSize = true;
            this.guess_points_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guess_points_lbl.Location = new System.Drawing.Point(6, 151);
            this.guess_points_lbl.Name = "guess_points_lbl";
            this.guess_points_lbl.Size = new System.Drawing.Size(18, 19);
            this.guess_points_lbl.TabIndex = 13;
            this.guess_points_lbl.Text = "0";
            this.guess_points_lbl.Visible = false;
            // 
            // HangmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1267, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playersTurn_label);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.character_panel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HangmanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HangmanForm";
            this.Load += new System.EventHandler(this.HangmanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangman_pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.character_panel.ResumeLayout(false);
            this.character_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox hangman_pictureBox;
        private System.Windows.Forms.Label playersTurn_label;
        private System.Windows.Forms.Label player_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label wrongchar_label;
        private System.Windows.Forms.ListBox wrong_word_listBox;
        private System.Windows.Forms.Label guessFullWord_label;
        private System.Windows.Forms.Label guessplayersword_label;
        private System.Windows.Forms.Panel character_panel;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Label wrongWordCouldBe_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label secretWordLbl;
        private System.Windows.Forms.Label pluspoints_label;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Label points_label;
        private System.Windows.Forms.Label guess_points_lbl;
    }
}