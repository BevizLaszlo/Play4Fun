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
    public partial class GameModeForm : Form
    {
        public GameModeForm()
        {
            InitializeComponent();
        }

        private void GameModeForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            int turns;
            if (quick_radioButton.Checked) turns = 3;
            else if (normal_radioButton.Checked) turns = 5;
            else turns = 7;


            new Gameplay(Player.PlayerList, turns);
            GameStatus gameStatus = new GameStatus();
            gameStatus.ShowDialog();

            Application.Exit();

        }
    }
}
