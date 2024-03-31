using Play4Fun.src.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Play4Fun.src.Forms
{
    public partial class TicTacToe : Form
    {
        private int playerTurnIndex = 0;
        public TicTacToe()
        {
            InitializeComponent();
            UpdateContent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void UpdateContent() 
        {
            playersTurn_label.Text = $"{Gameplay.Instance.Players[playerTurnIndex].Name.ToUpper()}'S TURN";
            playersTurn_label.ForeColor = Gameplay.Instance.Players[Gameplay.PlayerTurnIndex].BackColor;
        }
    }
}
