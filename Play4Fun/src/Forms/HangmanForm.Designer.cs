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
            this.label1 = new System.Windows.Forms.Label();
            this.player2_lbl = new System.Windows.Forms.Label();
            this.player3_lbl = new System.Windows.Forms.Label();
            this.player4_lbl = new System.Windows.Forms.Label();
            this.player1_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wrongchar_label = new System.Windows.Forms.Label();
            this.guessplayersword_label = new System.Windows.Forms.Label();
            this.player1_points_lbl = new System.Windows.Forms.Label();
            this.player2_points_lbl = new System.Windows.Forms.Label();
            this.player3_points_lbl = new System.Windows.Forms.Label();
            this.player4_points_lbl = new System.Windows.Forms.Label();
            this.character_panel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.word_textBox = new System.Windows.Forms.TextBox();
            this.guess_label = new System.Windows.Forms.Label();
            this.wrong_word_listBox = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.guess_points_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wrongWordCouldBe_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangman_pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.character_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.titleLbl.Location = new System.Drawing.Point(457, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(154, 32);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "HANGMAN";
            // 
            // hangman_pictureBox
            // 
            this.hangman_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hangman_pictureBox.Image")));
            this.hangman_pictureBox.Location = new System.Drawing.Point(276, 41);
            this.hangman_pictureBox.Name = "hangman_pictureBox";
            this.hangman_pictureBox.Size = new System.Drawing.Size(239, 268);
            this.hangman_pictureBox.TabIndex = 4;
            this.hangman_pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(418, 537);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "PLAYER\'S TURN";
            // 
            // player2_lbl
            // 
            this.player2_lbl.AutoSize = true;
            this.player2_lbl.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_lbl.Location = new System.Drawing.Point(3, 44);
            this.player2_lbl.Name = "player2_lbl";
            this.player2_lbl.Size = new System.Drawing.Size(87, 22);
            this.player2_lbl.TabIndex = 6;
            this.player2_lbl.Text = "PLAYER2";
            // 
            // player3_lbl
            // 
            this.player3_lbl.AutoSize = true;
            this.player3_lbl.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player3_lbl.Location = new System.Drawing.Point(3, 71);
            this.player3_lbl.Name = "player3_lbl";
            this.player3_lbl.Size = new System.Drawing.Size(87, 22);
            this.player3_lbl.TabIndex = 7;
            this.player3_lbl.Text = "PLAYER3";
            // 
            // player4_lbl
            // 
            this.player4_lbl.AutoSize = true;
            this.player4_lbl.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player4_lbl.Location = new System.Drawing.Point(6, 98);
            this.player4_lbl.Name = "player4_lbl";
            this.player4_lbl.Size = new System.Drawing.Size(87, 22);
            this.player4_lbl.TabIndex = 8;
            this.player4_lbl.Text = "PLAYER4";
            // 
            // player1_lbl
            // 
            this.player1_lbl.AutoSize = true;
            this.player1_lbl.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_lbl.Location = new System.Drawing.Point(3, 13);
            this.player1_lbl.Name = "player1_lbl";
            this.player1_lbl.Size = new System.Drawing.Size(87, 22);
            this.player1_lbl.TabIndex = 9;
            this.player1_lbl.Text = "PLAYER1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.wrongWordCouldBe_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.wrong_word_listBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.guessplayersword_label);
            this.panel1.Controls.Add(this.wrongchar_label);
            this.panel1.Controls.Add(this.hangman_pictureBox);
            this.panel1.Location = new System.Drawing.Point(135, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 396);
            this.panel1.TabIndex = 11;
            // 
            // wrongchar_label
            // 
            this.wrongchar_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wrongchar_label.AutoSize = true;
            this.wrongchar_label.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrongchar_label.Location = new System.Drawing.Point(666, 13);
            this.wrongchar_label.Name = "wrongchar_label";
            this.wrongchar_label.Size = new System.Drawing.Size(128, 16);
            this.wrongchar_label.TabIndex = 12;
            this.wrongchar_label.Text = "WRONG CHARACTERS";
            // 
            // guessplayersword_label
            // 
            this.guessplayersword_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guessplayersword_label.AutoSize = true;
            this.guessplayersword_label.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.guessplayersword_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.guessplayersword_label.Location = new System.Drawing.Point(227, 7);
            this.guessplayersword_label.Name = "guessplayersword_label";
            this.guessplayersword_label.Size = new System.Drawing.Size(343, 32);
            this.guessplayersword_label.TabIndex = 12;
            this.guessplayersword_label.Text = "GUESS PLAYER\'S WORD";
            // 
            // player1_points_lbl
            // 
            this.player1_points_lbl.AutoSize = true;
            this.player1_points_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_points_lbl.Location = new System.Drawing.Point(96, 16);
            this.player1_points_lbl.Name = "player1_points_lbl";
            this.player1_points_lbl.Size = new System.Drawing.Size(18, 19);
            this.player1_points_lbl.TabIndex = 12;
            this.player1_points_lbl.Text = "0";
            // 
            // player2_points_lbl
            // 
            this.player2_points_lbl.AutoSize = true;
            this.player2_points_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_points_lbl.Location = new System.Drawing.Point(96, 46);
            this.player2_points_lbl.Name = "player2_points_lbl";
            this.player2_points_lbl.Size = new System.Drawing.Size(18, 19);
            this.player2_points_lbl.TabIndex = 13;
            this.player2_points_lbl.Text = "0";
            // 
            // player3_points_lbl
            // 
            this.player3_points_lbl.AutoSize = true;
            this.player3_points_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player3_points_lbl.Location = new System.Drawing.Point(96, 74);
            this.player3_points_lbl.Name = "player3_points_lbl";
            this.player3_points_lbl.Size = new System.Drawing.Size(18, 19);
            this.player3_points_lbl.TabIndex = 14;
            this.player3_points_lbl.Text = "0";
            // 
            // player4_points_lbl
            // 
            this.player4_points_lbl.AutoSize = true;
            this.player4_points_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player4_points_lbl.Location = new System.Drawing.Point(96, 99);
            this.player4_points_lbl.Name = "player4_points_lbl";
            this.player4_points_lbl.Size = new System.Drawing.Size(18, 19);
            this.player4_points_lbl.TabIndex = 15;
            this.player4_points_lbl.Text = "0";
            // 
            // character_panel
            // 
            this.character_panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.character_panel.Controls.Add(this.guess_points_lbl);
            this.character_panel.Controls.Add(this.player1_points_lbl);
            this.character_panel.Controls.Add(this.player4_points_lbl);
            this.character_panel.Controls.Add(this.player1_lbl);
            this.character_panel.Controls.Add(this.player3_points_lbl);
            this.character_panel.Controls.Add(this.player4_lbl);
            this.character_panel.Controls.Add(this.player2_points_lbl);
            this.character_panel.Controls.Add(this.player3_lbl);
            this.character_panel.Controls.Add(this.player2_lbl);
            this.character_panel.Location = new System.Drawing.Point(9, 34);
            this.character_panel.Name = "character_panel";
            this.character_panel.Size = new System.Drawing.Size(119, 184);
            this.character_panel.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.label10.Location = new System.Drawing.Point(227, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(343, 32);
            this.label10.TabIndex = 13;
            this.label10.Text = "GUESS PLAYER\'S WORD";
            // 
            // word_textBox
            // 
            this.word_textBox.Location = new System.Drawing.Point(422, 505);
            this.word_textBox.Name = "word_textBox";
            this.word_textBox.Size = new System.Drawing.Size(36, 20);
            this.word_textBox.TabIndex = 17;
            // 
            // guess_label
            // 
            this.guess_label.AutoSize = true;
            this.guess_label.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guess_label.Location = new System.Drawing.Point(299, 507);
            this.guess_label.Name = "guess_label";
            this.guess_label.Size = new System.Drawing.Size(117, 18);
            this.guess_label.TabIndex = 18;
            this.guess_label.Text = "TYPE HERE -->";
            // 
            // wrong_word_listBox
            // 
            this.wrong_word_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.wrong_word_listBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.wrong_word_listBox.FormattingEnabled = true;
            this.wrong_word_listBox.Location = new System.Drawing.Point(669, 41);
            this.wrong_word_listBox.Name = "wrong_word_listBox";
            this.wrong_word_listBox.Size = new System.Drawing.Size(125, 303);
            this.wrong_word_listBox.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 363);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 20);
            this.textBox2.TabIndex = 19;
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
            // wrongWordCouldBe_label
            // 
            this.wrongWordCouldBe_label.AutoSize = true;
            this.wrongWordCouldBe_label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrongWordCouldBe_label.Location = new System.Drawing.Point(104, 155);
            this.wrongWordCouldBe_label.Name = "wrongWordCouldBe_label";
            this.wrongWordCouldBe_label.Size = new System.Drawing.Size(26, 29);
            this.wrongWordCouldBe_label.TabIndex = 16;
            this.wrongWordCouldBe_label.Text = "0";
            // 
            // HangmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(204)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1069, 578);
            this.Controls.Add(this.guess_label);
            this.Controls.Add(this.word_textBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
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
            this.character_panel.ResumeLayout(false);
            this.character_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.PictureBox hangman_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label player2_lbl;
        private System.Windows.Forms.Label player3_lbl;
        private System.Windows.Forms.Label player4_lbl;
        private System.Windows.Forms.Label player1_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label wrongchar_label;
        private System.Windows.Forms.ListBox wrong_word_listBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label guessplayersword_label;
        private System.Windows.Forms.Label player1_points_lbl;
        private System.Windows.Forms.Label player2_points_lbl;
        private System.Windows.Forms.Label player3_points_lbl;
        private System.Windows.Forms.Label player4_points_lbl;
        private System.Windows.Forms.Panel character_panel;
        private System.Windows.Forms.TextBox word_textBox;
        private System.Windows.Forms.Label guess_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label guess_points_lbl;
        private System.Windows.Forms.Label wrongWordCouldBe_label;
        private System.Windows.Forms.Label label2;
    }
}