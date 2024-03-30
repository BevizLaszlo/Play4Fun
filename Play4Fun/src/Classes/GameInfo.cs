using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Play4Fun.src.Classes
{
    internal class GameInfo
    {
        public static List<GameInfo> AllGameInfos = new List<GameInfo>();
        public string Name { get; set; }
        public string Description { get; set; }
        public Form GameForm { get; set; }

        public GameInfo(string name, string desc, Form gameForm)
        {
            Name = name;
            Description = desc;
            GameForm = gameForm;

            AllGameInfos.Add(this);
        }

    }
}
