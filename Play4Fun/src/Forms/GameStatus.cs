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
            if (Gameplay.Instance.CurrentTurn > Gameplay.Instance.NumOfTurns)
            {
                startGameBtn.Text = "NEXT";
                turnLbl.Text = "THE GAME IS OVER";
                gameNameLbl.Text = "Thank you for playing our game";
                gameDescLbl.Text = $"Makers of the game:\nLászló Bevíz\nRévaiErik";
                nextGameLbl.Visible = false;
            }
            else
            {
                gameNameLbl.Text = Gameplay.Instance.ListOfGames[Gameplay.Instance.CurrentTurn - 1].Name;
                gameDescLbl.Text = Gameplay.Instance.ListOfGames[Gameplay.Instance.CurrentTurn - 1].Description;

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

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            if (Gameplay.Instance.CurrentTurn > Gameplay.Instance.NumOfTurns)
            {
                new EndForm().ShowDialog();
            }
            switch (Gameplay.Instance.ListOfGames[Gameplay.Instance.CurrentTurn - 1].Name)
            {
                case "Hangman":
                    for (int i = 0; i < Gameplay.Instance.Players.Count; i++)
                    {
                        new HangmanWord().ShowDialog();
                        Gameplay.PlayerTurnIndex++;
                        if (Gameplay.PlayerTurnIndex >= Gameplay.Instance.Players.Count) Gameplay.PlayerTurnIndex = 0;
                    }
                    break;
                case "Sliding Block Puzzle":
                    new SlidingBlockPuzzle().ShowDialog();
                    break;
                case "Tic Tac Toe":
                    new TicTacToe().ShowDialog();
                    break;
                case "Race Game":
                    new RaceGame().ShowDialog();
                    break;
                default:
                    break;
            }
            Gameplay.Instance.CurrentTurn++;
            UpdateFormContent();
        }
    }
}
