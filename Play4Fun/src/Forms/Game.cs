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

namespace Play4Fun.src.Forms
{
    public partial class Game : Form
    {
        private Panel[] characterPanels;
        public Game()
        {
            InitializeComponent();
            characterPanels = new Panel[4] { char1Pnl, char2Pnl, char3Pnl, char4Pnl};

            new CharacterTemplate(@"..\..\src\images\green.png", Color.FromArgb(0, 255, 0), Color.Black);
            new CharacterTemplate(@"..\..\src\images\blue.png", Color.FromArgb(0, 0, 255), Color.Black);
            new CharacterTemplate(@"..\..\src\images\yellow.png", Color.FromArgb(0, 255, 255), Color.Black);
            new CharacterTemplate(@"..\..\src\images\red.png", Color.FromArgb(255, 0, 0), Color.Black);

            pictureBox1.BackgroundImage = CharacterTemplate.Templates[0].Image;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            foreach (Panel character in characterPanels)
            {
                character.Width = flowLayoutPanel1.Width / 4;
                character.Height = flowLayoutPanel1.Height;
            }

        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
