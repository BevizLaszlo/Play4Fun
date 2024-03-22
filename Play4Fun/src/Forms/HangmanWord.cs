using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Play4Fun.src.Forms;

namespace Play4Fun.src.Forms
{
    public partial class HangmanWord : Form
    {
        public HangmanWord()
        {
            InitializeComponent();
        }

        private void HangmanWord_Load(object sender, EventArgs e)
        {
            Game game = new Game();
            int playercounter = game.characterNames.Length;
            Random random = new Random();

            name_label.Text = game.characterNames[random.Next(0, playercounter)];

            //A háttér is a karakter színére változik
        }
    }
}
