using Play4Fun.src.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Play4Fun.src.Forms
{
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void EndForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            Gameplay.Instance.SortPlayers();
            Player winner = Gameplay.Instance.Players[0];
            pictureBox.Image = winner.Image;
            playerLabel.Text = $"Congratulations {winner.Name}!\nYou won the game";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thank you for playing our game!", "The End", MessageBoxButtons.OK) == DialogResult.OK)
                Application.Exit();
        }
    }
}
