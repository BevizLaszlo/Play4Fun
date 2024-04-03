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
                desc: "In each round, a player is randomly selected for the game.\nThe player receives 1 point for each guessed word.\nIf someone guesses the solution, they receive an additional 5 points, and the player who gave the word receives points equal to the number of words +1.\nIn one game, a total of 7 mistakes are allowed. If this happens, the game ends, and the guesser receives 2 points.\nIf someone guesses the word incorrectly, the points earned in the game so far are reset to zero, and the player drops out of the game."),
            new GameInfo(
                name: "Sliding Block Puzzle", 
                desc: "Try to solve the Sliding Block Puzzle as fast as possible. You can move the blocks by clicking on them. Based on your time, you will get the following points:\n1st place: 10 points\n2nd place: 8 points\n3rd place: 6 points\n4th place: 4 points"),
            new GameInfo(
                name: "Tic Tac Toe",
                desc: "..."),
            new GameInfo(
                name: "Race Game",
                desc: "This game require a lot of luck. In this turn based game you will roll the dice and move forward to the finish line as much as you thrown. Based on your place, you will get the following points:\n1st place: 10 points\n2nd place: 8 points\n3rd place: 6 points\n4th place: 4 points"),
        };
        public int NumOfTurns { get; set; }
        public int CurrentTurn { get; set; }

        public Gameplay(List<Player> players, int numberOfTurns)
        {
            Players = players;
            NumOfTurns = numberOfTurns;
            CurrentTurn = 1;

            ListOfGames.Add(ListOfGames[0]);
            ListOfGames.Add(ListOfGames[1]);
            ListOfGames.Add(ListOfGames[2]);

            Instance = this;
        }

        public void SortPlayers() => Players = Players.OrderByDescending(x => x.Points).ToList();
    }
}
