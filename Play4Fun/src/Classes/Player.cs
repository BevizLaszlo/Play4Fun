using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play4Fun.src.Classes
{
    internal class Player
    {
        public static List<Player> PlayerList = new List<Player>();

        public string Name { get; set; }
        public Color Color { get; set; }
        public int Points { get; set; }

        public Player(string name, CharacterTemplate charTemplate) 
        {
            Name = name;
            Points = 0;

            PlayerList.Add(this);
        }
        
    }
}
