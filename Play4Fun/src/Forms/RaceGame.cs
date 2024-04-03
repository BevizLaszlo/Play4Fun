using Play4Fun.src.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Play4Fun.src.Forms
{
    public partial class RaceGame : Form
    {
        Random rnd = new Random();
        Dictionary<int, List<Panel>> diceValues = new Dictionary<int, List<Panel>>();
        List<Panel> allDiceValues;

        int gameBoardWidth;
        int characterWidth = 50;
        int oneStep = 25;
        int[] points = { 10, 8, 6, 4 };
        List<Player> playerRanking = new List<Player>();
        bool[] isPlayingIndex = new bool[Gameplay.Instance.Players.Count];
        
        public RaceGame()
        {
            InitializeComponent();
            FillDiceValues();

            gameBoardWidth = gamePanel.Width - characterWidth;
            for (int i = 0; i < isPlayingIndex.Length; i++) isPlayingIndex[i] = true;
            RenderData();
        }

        private void NextPlayerTurnIndex()
        {
            do
            {
                Gameplay.PlayerTurnIndex++;
                if (Gameplay.PlayerTurnIndex >= Gameplay.Instance.Players.Count)
                    Gameplay.PlayerTurnIndex = 0;
            } while (!isPlayingIndex[Gameplay.PlayerTurnIndex]);
        }
        private void RenderData()
        {
            playerTurnLbl.Text = $"{Gameplay.Instance.Players[Gameplay.PlayerTurnIndex].Name}'s turn";
            playerTurnLbl.BackColor = Gameplay.Instance.Players[Gameplay.PlayerTurnIndex].BackColor;
            playerTurnLbl.ForeColor = Gameplay.Instance.Players[Gameplay.PlayerTurnIndex].ForeColor;

            gamePanel.Controls.Clear();
            int i = 0;
            foreach (Player p in Gameplay.Instance.Players)
            {
                gamePanel.Controls.Add(new PictureBox()
                {
                    Image = p.Image,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = characterWidth,
                    Height = characterWidth,
                    Left = p.PositionX,
                    Top = i * characterWidth + 10,
                    BackColor = Color.Transparent
                });
                gamePanel.Controls.Add(new Panel()
                {
                    Height = characterWidth - 10,
                    Width = p.PositionX + characterWidth / 2,
                    Left = 0,
                    Top = i * characterWidth + 20,
                    BackColor = p.BackColor
                });
                i++;
            }
        }
        private void RaceGame_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }


        private void FillDiceValues()
        {
            diceValues.Add(1, new List<Panel>() { middlecenter });
            diceValues.Add(2, new List<Panel>() { topleft, bottomright });
            diceValues.Add(3, new List<Panel>() { topleft, middlecenter, bottomright });
            diceValues.Add(4, new List<Panel>() { topleft, topright, bottomleft, bottomright });
            diceValues.Add(5, new List<Panel>() { topleft, topright, bottomleft, bottomright, middlecenter });
            diceValues.Add(6, new List<Panel>() { topleft, topright, bottomleft, bottomright, middleleft, middleright });


            allDiceValues = new List<Panel>() { topleft, topright, middleleft, middlecenter, middleright, bottomleft, bottomright };
        }
        private void SetDiceState(List<Panel> visibleDots)
        {
            foreach (Panel diceValue in allDiceValues)
                diceValue.Visible = visibleDots.Contains(diceValue);
        }


        private void rollBtn_Click(object sender, EventArgs e)
        {
            RollAnimation();
            int diceValue = rnd.Next(6) + 1;

            SetDiceState(diceValues[diceValue]);
            Thread.Sleep(300);

            Gameplay.Instance.Players[Gameplay.PlayerTurnIndex].PositionX += diceValue * oneStep;
            if (Gameplay.Instance.Players[Gameplay.PlayerTurnIndex].PositionX >= gameBoardWidth)
            {
                Gameplay.Instance.Players[Gameplay.PlayerTurnIndex].PositionX = gameBoardWidth;
                isPlayingIndex[Gameplay.PlayerTurnIndex] = false;
                playerRanking.Add(Gameplay.Instance.Players[Gameplay.PlayerTurnIndex]);
            }
            NextPlayerTurnIndex();

            if (IsEndOfGame())
            {
                playerRanking.Add(Gameplay.Instance.Players[Gameplay.PlayerTurnIndex]);
                string strResult = string.Empty;
                int i = 0;
                foreach (Player p in playerRanking)
                {
                    strResult += $"{i+1}. {p.Name} - {points[i]} points\n";
                    p.Points += points[i];
                    p.PositionX = 0;
                    i++;
                }
                Gameplay.PlayerTurnIndex = 0;
                if (MessageBox.Show(strResult, "End of game", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                RenderData();
            }
        }

        private bool IsEndOfGame()
        {
            return playerRanking.Count == Gameplay.Instance.Players.Count - 1;
        }

        private void RollAnimation()
        {
            for (int i = 0; i < 10; i++)
            {
                SetDiceState(diceValues[rnd.Next(6) + 1]);
                Thread.Sleep(150);

            }
        }
    }
}
