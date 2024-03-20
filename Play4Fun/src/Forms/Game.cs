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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Play4Fun.src.Forms
{
    public partial class Game : Form
    {
        private Panel[] characterPanels;
        private GameModeForm gameModeForm = new GameModeForm();
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

           player3_checkBox.CheckedChanged += new EventHandler(Players);
           player4_checkBox.CheckedChanged += new EventHandler(Players);
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            
            gameModeForm.ShowDialog();
            Application.Exit();

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Players(object sender, EventArgs e)
        {
            player3visible_panel.Visible = player3_checkBox.Checked;
            player4visible_panel.Visible = player4_checkBox.Checked;
        }
    }
}
