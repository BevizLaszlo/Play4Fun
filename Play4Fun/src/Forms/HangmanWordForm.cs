using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Play4Fun.src.Forms;

namespace Play4Fun.src.Forms
{
    public partial class HangmanWord : Form
    {
        public string SecretWord { get; private set; }
        private string characterName;
        private Color backgroundColor;
        private Color textColor;
        public HangmanWord(string name, Color bgCol, Color textCol)
        {
            InitializeComponent();
            characterName = name;
            backgroundColor = bgCol;
            textColor = textCol;
        }

        private void HangmanWord_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.BackColor = backgroundColor;
            name_label.ForeColor = textColor;
            name_label.Text = characterName;
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            SecretWord = word_textBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
