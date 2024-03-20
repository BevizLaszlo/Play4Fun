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

namespace Play4Fun
{
    public partial class StartForm : Form
    {
        private Settings settingsForm = new Settings();
        private Credits creditsForm = new Credits();
        private Game gameForm = new Game();
        public StartForm()
        {
            InitializeComponent();
        }

        private void exitBtm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();
            Application.Exit();
        }

        private void creditsLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            creditsForm.ShowDialog();
            Application.Exit();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            gameForm.ShowDialog();
            Application.Exit();
        }
    }
}
