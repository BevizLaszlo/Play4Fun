using Play4Fun.src.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play4Fun.src.Classes
{
    internal class Gameplay
    {
        public static int PlayerTurnIndex = 0;
        public static Gameplay Instance { get; set; }
        public List<Player> Players;
        public List<GameInfo> ListOfGames = new List<GameInfo>
        {
            new GameInfo(
                name: "Hangman", 
                desc: "In each round, a player is randomly selected for the game.\nThe player receives 1 point for each guessed word.\nIf someone guesses the solution, they receive an additional 5 points, and the player who gave the word receives points equal to the number of words +1.\nIn one game, a total of 7 mistakes are allowed. If this happens, the game ends, and the guesser receives 2 points.\nIf someone guesses the word incorrectly, the points earned in the game so far are reset to zero, and the player drops out of the game.",
                gameForm: null)
        };
        public int NumOfTurns { get; set; }
        public int CurrentTurn { get; set; }

        public Gameplay(List<Player> players, int numberOfTurns)
        {
            Players = players;
            NumOfTurns = numberOfTurns;
            CurrentTurn = 1;

            Instance = this;
        }

        public void SortPlayers() => Players = Players.OrderByDescending(x => x.Points).ToList();
    }
}
