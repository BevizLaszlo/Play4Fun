using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Play4Fun.src.Classes;
using Play4Fun.src.Forms;

namespace Play4Fun.src.Forms
{
    public partial class HangmanWord : Form
    {
        public HangmanWord()
        {
            InitializeComponent();

            name_label.Text = Gameplay.Instance.Players[Gameplay.PlayerTurnIndex].Name; 
            name_label.ForeColor = Gameplay.Instance.Players[Gameplay.PlayerTurnIndex].BackColor;
            name_label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
        }

        private void HangmanWord_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            if (word_textBox.Text.Length > 3)
            {
                new HangmanForm(word_textBox.Text).ShowDialog();
                this.Close();
            }
            else MessageBox.Show("The secret word must be more than 3 characters long", "Error", MessageBoxButtons.OK);
        }
    }
}
