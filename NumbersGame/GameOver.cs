using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersGame
{
    public partial class GameOver : Form
    {
        private string Winner;

        public GameOver()
        {
            InitializeComponent();
        }

        public GameOver(string winner)
        {
            InitializeComponent();
            Winner = winner;
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            if (Winner == "player")
            {
                lblDisplayWinner.Text = "You Win!!!";
            }
            else if(Winner == "computer")
            {
                lblDisplayWinner.Text = "Computer Wins!!!";
            }
            else
            {
                lblDisplayWinner.Text = "It's a Draw";
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            TitleScreen ts = new TitleScreen();
            ts.Show();
            this.Hide();
        }

        private void GameOver_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult d = MessageBox.Show("Are you sure you wish to exit?", "exit", MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
