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
    public partial class HangmanForm : Form
    {
        private Game game;
        private string secretWord;
        private string displayWord;
        public HangmanForm()
        {
            InitializeComponent();
        }

        private void HangmanForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            game.characterNames[0] = player1_lbl.Text;
            game.characterNames[1] = player2_lbl.Text;
            game.characterNames[2] = player3_lbl.Text;
            game.characterNames[3] = player4_lbl.Text;

           player1_points_lbl.Text =Convert.ToString(game.character_points[0]);
           player2_points_lbl.Text =Convert.ToString(game.character_points[1]);
           player3_points_lbl.Text =Convert.ToString(game.character_points[2]);
           player4_points_lbl.Text =Convert.ToString(game.character_points[3]);
        }
    }
}
