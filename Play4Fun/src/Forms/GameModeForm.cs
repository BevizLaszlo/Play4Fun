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
        private Game game;
        private Form[] games = new Form[5];
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
            Random random = new Random();
            int randomnum = random.Next(0, games.Length); 
            games[0] = new HangmanWord(game.characterNames[randomnum], game.characterTemplates[randomnum].Item2, game.characterTemplates[randomnum].Item3);
            games[randomnum].ShowDialog();
            Application.Exit();

        }
    }
}
