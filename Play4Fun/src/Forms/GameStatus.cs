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
    public partial class GameStatus : Form
    {
        public GameStatus()
        {
            InitializeComponent();
        }

        private void GameStatus_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            gameDescPnl.Width = Screen.PrimaryScreen.Bounds.Width / 4;
            UpdateFormContent();
        }

        private void UpdateFormContent()
        {
            // turn render
            turnLbl.Text = $"TURN: {Gameplay.Instance.CurrentTurn}/{Gameplay.Instance.NumOfTurns}";

            // game description and button render
            int gameIndex = Gameplay.Instance.CurrentTurn - 1;
            gameNameLbl.Text = Gameplay.Instance.ListOfGames[gameIndex].Name;
            gameDescLbl.Text = Gameplay.Instance.ListOfGames[gameIndex].Description;
            startGameBtn.Click += (object sender, EventArgs e) =>
            {
                if (Gameplay.Instance.ListOfGames[gameIndex].Name == "Hangman")
                {
                    for (int i = 0; i < Gameplay.Instance.Players.Count; i++)
                    {
                        new HangmanWord().ShowDialog();
                        Gameplay.PlayerTurnIndex++;
                        if (Gameplay.PlayerTurnIndex >= Gameplay.Instance.Players.Count) Gameplay.PlayerTurnIndex = 0;
                    }
                }
                else Gameplay.Instance.ListOfGames[gameIndex].GameForm.ShowDialog();
                UpdateFormContent();
            };

            // standings render
            standingPnl.Controls.Clear();
            Gameplay.Instance.SortPlayers();
            int index = 0;
            foreach (Player player in Gameplay.Instance.Players)
            {
                Panel mainPnl = new Panel()
                {
                    Top = index * (110),
                    Left = 0,
                    Width = standingPnl.Width / 2 + player.Points * 5,
                    Height = 100,
                    ForeColor = player.ForeColor,
                    BackColor = player.BackColor,
                    Font = new Font("Arial", 16, FontStyle.Bold)
                };

                mainPnl.Controls.Add(new Label()
                {
                    Text = $"{index + 1}",
                    Top = 40,
                    Left = 10,
                    AutoSize = true
                });

                mainPnl.Controls.Add(new PictureBox()
                {
                    Top = 10,
                    Left = 40,
                    Width = 80,
                    Height = 80,
                    Image = player.Image,
                    SizeMode = PictureBoxSizeMode.Zoom
                });

                mainPnl.Controls.Add(new Label()
                {
                    Text = $"{player.Name} — {player.Points} POINTS",
                    Top = 40,
                    Left = 130,
                    AutoSize = true
                });

                standingPnl.Controls.Add(mainPnl);

                index++;
            }
        }
    }
}
