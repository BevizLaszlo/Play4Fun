using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Play4Fun.src.Forms
{
    public partial class Settings : Form
    {
        public SoundPlayer music = new SoundPlayer(@"..\..\src\Music\music.wav");
        public Settings()
        {
            InitializeComponent();
            music.PlayLooping();
        }

        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            if (soundON.Checked)
            {
                music.PlayLooping();
            }
            else
            {
                music.Stop();
            }
            this.Close();
        }
    }
}
