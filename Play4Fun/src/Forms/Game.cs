﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        int[] templates = new int[4] { 0, 1, 2, 3 };
        public Game()
        {
            InitializeComponent();
            characterPanels = new Panel[4] { char1Pnl, char2Pnl, char3Pnl, char4Pnl};

            new CharacterTemplate(@"..\..\src\images\green.png", Color.FromArgb(0, 255, 0), Color.Black);
            new CharacterTemplate(@"..\..\src\images\blue.png", Color.FromArgb(0, 0, 255), Color.White);
            new CharacterTemplate(@"..\..\src\images\yellow.png", Color.FromArgb(255, 255, 0), Color.Black);
            new CharacterTemplate(@"..\..\src\images\red.png", Color.FromArgb(255, 0, 0), Color.Black);

            

            UpdateAllTemplates();
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
            FillPlayers();
            gameModeForm.ShowDialog();
            Application.Exit();

        }

        private void FillPlayers()
        {
            new Player(name1.Text, CharacterTemplate.Templates[templates[0]]);
            new Player(name2.Text, CharacterTemplate.Templates[templates[1]]);
            if (player3_checkBox.Checked) new Player(name3.Text, CharacterTemplate.Templates[templates[2]]);
            if (player4_checkBox.Checked) new Player(name4.Text, CharacterTemplate.Templates[templates[3]]);
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

        private void PrevCharTemp(object sender, EventArgs e)
        {
            int btnIndex = int.Parse((sender as Button).Tag.ToString()) - 1;

            templates[btnIndex]--;
            if (templates[btnIndex] < 0) templates[btnIndex] = 3;
            UpdateAllTemplates();

        }

        private void NextCharTemp(object sender, EventArgs e)
        {
            int btnIndex = int.Parse((sender as Button).Tag.ToString()) - 1;

            templates[btnIndex]++;
            if (templates[btnIndex] > 3) templates[btnIndex] = 0;
            UpdateAllTemplates();
        }


        private void UpdateAllTemplates()
        {
            CharacterTemplate.SetCharacterTemplate(char1Pnl, pictureBox1, templates[0]);
            CharacterTemplate.SetCharacterTemplate(char2Pnl, pictureBox2, templates[1]);
            CharacterTemplate.SetCharacterTemplate(player3visible_panel, pictureBox3, templates[2]);
            CharacterTemplate.SetCharacterTemplate(player4visible_panel, pictureBox4, templates[3]);
        }
    }
}
