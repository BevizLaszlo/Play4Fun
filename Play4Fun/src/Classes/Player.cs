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
        public Image Image { get; set; }
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public int Points { get; set; }
        public int PositionX { get; set; }

        public Player(string name, CharacterTemplate charTemplate) 
        {
            Name = name;
            Points = 0;
            Image = charTemplate.Image;
            BackColor = charTemplate.BackColor;
            ForeColor = charTemplate.ForeColor;
            PositionX = 0;

            PlayerList.Add(this);
        }
        
    }
}
