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
    public partial class TicTacToe : Form
    {
        private int playerTurnIndex = 0;
        private PictureBox[,] board;
        private Player currentPlayer;
        private int boardSize;
        private int winLength;

        public TicTacToe()
        {
            InitializeComponent();
            switch (Player.PlayerList.Count)
            {
                case 2:
                    boardSize = 3;
                    winLength = 3;
                    break;
                case 3:
                    boardSize = 4;
                    winLength = 4;
                    break;
                case 4:
                    boardSize = 6;
                    winLength = 5;
                    break;
                default:
                    throw new Exception("Invalid number of players");
            }
            InitializeBoard();
            currentPlayer = Player.PlayerList[playerTurnIndex];
            UpdateContent();
        }
        private void TicTacToe_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void UpdateContent()
        {
            playersTurn_label.Text = $"{Gameplay.Instance.Players[playerTurnIndex].Name.ToUpper()}'S TURN";
            playersTurn_label.ForeColor = Gameplay.Instance.Players[Gameplay.PlayerTurnIndex].BackColor;
        }

        private void InitializeBoard()
        {
            board = new PictureBox[boardSize, boardSize];
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    var pictureBox = new PictureBox
                    {
                        Width = playfield_panel.Width / boardSize,
                        Height = playfield_panel.Height / boardSize,
                        Location = new Point(i * playfield_panel.Width / boardSize, j * playfield_panel.Height / boardSize),
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    pictureBox.Click += PictureBox_Click;
                    board[i, j] = pictureBox;
                    playfield_panel.Controls.Add(pictureBox);
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            if (pictureBox.Image != null)
            {
                return;
            }

            pictureBox.Image = currentPlayer.Image;
            pictureBox.BackColor = currentPlayer.BackColor;

            if (CheckWin())
            {
                MessageBox.Show($"{currentPlayer.Name} won!");
                currentPlayer.Points += 5;
                this.Close();
            }

            playerTurnIndex = (playerTurnIndex + 1) % Player.PlayerList.Count;
            currentPlayer = Player.PlayerList[playerTurnIndex];
            UpdateContent();
        }

        private bool CheckWin()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (board[i, j].Image == null)
                    {
                        continue;
                    }

                    // Vízszintes:
                    if (i <= boardSize - winLength)
                    {
                        bool win = true;
                        for (int offset = 0; offset < winLength; offset++)
                        {
                            if (board[i + offset, j].Image != currentPlayer.Image)
                            {
                                win = false;
                                break;
                            }
                        }
                        if (win)
                        {
                            return true;
                        }
                    }

                    // Függőleges:
                    if (j <= boardSize - winLength)
                    {
                        bool win = true;
                        for (int offset = 0; offset < winLength; offset++)
                        {
                            if (board[i, j + offset].Image != currentPlayer.Image)
                            {
                                win = false;
                                break;
                            }
                        }
                        if (win)
                        {
                            return true;
                        }
                    }

                    // Átlós: bal --> jobb
                    if (i <= boardSize - winLength && j <= boardSize - winLength)
                    {
                        bool win = true;
                        for (int offset = 0; offset < winLength; offset++)
                        {
                            if (board[i + offset, j + offset].Image != currentPlayer.Image)
                            {
                                win = false;
                                break;
                            }
                        }
                        if (win)
                        {
                            return true;
                        }
                    }

                    // Átlós jobb --> bal
                    if (i >= winLength - 1 && j <= boardSize - winLength)
                    {
                        bool win = true;
                        for (int offset = 0; offset < winLength; offset++)
                        {
                            if (board[i - offset, j + offset].Image != currentPlayer.Image)
                            {
                                win = false;
                                break;
                            }
                        }
                        if (win)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

     
    }
}
