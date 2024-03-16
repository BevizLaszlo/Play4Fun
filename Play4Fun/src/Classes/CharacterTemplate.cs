using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Play4Fun.src.Classes
{
    internal class CharacterTemplate
    {
        public static List<CharacterTemplate> Templates = new List<CharacterTemplate>();

        public Image Image { get; set; }
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }

        public CharacterTemplate(string imgSrc, Color backColor, Color foreColor)
        {
            Image = Image.FromFile(imgSrc);
            BackColor = backColor;
            ForeColor = foreColor;

            Templates.Add(this);
        }

    }
}
