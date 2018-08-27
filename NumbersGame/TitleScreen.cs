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
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            NumberSelection ns = new NumberSelection();
            ns.Show();
            this.Hide();
            Form1.PlayerScore = 0;
            Form1.ComputerScore = 0;
            Form1.RoundNo = 1;
        }

        private void btnDifficulty_Click(object sender, EventArgs e)
        {
            DifficultySelection ds = new DifficultySelection();
            ds.Show();
        }

        private void TitleScreen_FormClosing(object sender, FormClosingEventArgs e)
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

