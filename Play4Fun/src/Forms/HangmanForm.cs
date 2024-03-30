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
    public partial class HangmanForm : Form
    {
        private int attempts = 8;
        private int playerGuessingIndex = 0;
        private string secretWord;
        private string guessedWord;
        private int[] points = new int[Gameplay.Instance.Players.Count];
        bool isWin = false;
        public HangmanForm(string word)
        {
            InitializeComponent();
            secretWord = word;
            foreach (char c in secretWord)
            {
                if (c == ' ') guessedWord += ' ';
                else guessedWord += "＿";
            }
            guessplayersword_label.Text = $"GUESS {Gameplay.Instance.Players[Gameplay.PlayerTurnIndex].Name.ToUpper()}'S WORD";
            SetGuessingPlayer();
            UpdateContent();
        }

        private void HangmanForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void UpdateContent()
        {
            wrongWordCouldBe_label.Text = attempts.ToString();
            playersTurn_label.Text = $"{Gameplay.Instance.Players[playerGuessingIndex].Name.ToUpper()}'S TURN";

            hangman_pictureBox.Image = Image.FromFile($@"..\..\src\images\{attempts}.png");

            secretWordLbl.Text = string.Empty;
            foreach (char c in guessedWord)
            {
                secretWordLbl.Text += $"{c}  ";
            }

            player_lbl.Text = string.Empty;
            points_label.Text = string.Empty;
            for (int i = 0; i < Gameplay.Instance.Players.Count; i++)
            {
                player_lbl.Text += $"{Gameplay.Instance.Players[i].Name.ToUpper()}\n";
                points_label.Text += $"{points[i]}\n";
            }
        }

        private void SetGuessingPlayer()
        {
            do
            {
                if (playerGuessingIndex == Gameplay.PlayerTurnIndex) playerGuessingIndex++;
                if (playerGuessingIndex >= Gameplay.Instance.Players.Count) playerGuessingIndex = 0;
            } while (playerGuessingIndex == Gameplay.PlayerTurnIndex);
        }

        private void guessBtn_Click(object sender, EventArgs e)
        {
            string word = guessTextBox.Text;
            char character = ' ';
            guessTextBox.Text = string.Empty;

            if (word.Length == 0)
            {
                MessageBox.Show("You must type something to the textbox before hitting the GUESS button", "Error", MessageBoxButtons.OK);
                return;
            }

            if (word.Length > 1)
            {
                if (word == secretWord)
                {
                    points[playerGuessingIndex] += 5;
                    
                    guessedWord = secretWord;
                    isWin = true;
                }
                else
                {
                    wrong_word_listBox.Items.Add(word);
                    attempts--;
                }
            }
            else
            {
                character = word[0];
                if (secretWord.Contains(character))
                {
                    if (!guessedWord.Contains(character))
                    {
                        points[playerGuessingIndex]++;

                        string tempGuessedWord = string.Empty;
                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            if (secretWord[i] == character) tempGuessedWord += character;
                            else tempGuessedWord += guessedWord[i];
                        }
                        guessedWord = tempGuessedWord;
                    }
                }
                else
                {
                    wrong_word_listBox.Items.Add(character);
                    attempts--;
                }
            }

            playerGuessingIndex++;
            SetGuessingPlayer();

            UpdateContent();
            if (!guessedWord.Contains('＿')) isWin = true;

            if (isWin)
            {
                points[Gameplay.PlayerTurnIndex] += guessedWord.Length;
                AddPointsToPlayers();
                MessageBox.Show($"The word was guessed ({secretWord})", "You win", MessageBoxButtons.OK);
                this.Close();
            }
            if (attempts == 0)
            {
                AddPointsToPlayers();
                MessageBox.Show($"The word was not guessed ({secretWord})", "You lose", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void AddPointsToPlayers()
        {
            for (int i = 0; i < Gameplay.Instance.Players.Count; i++)
                Gameplay.Instance.Players[i].Points += points[i];
        }
    }
}
