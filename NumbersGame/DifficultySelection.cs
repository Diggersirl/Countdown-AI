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
    public partial class DifficultySelection : Form
    {
        public DifficultySelection()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Form1.Difficulty = "easy";
            DifficultySet();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            Form1.Difficulty = "normal";
            DifficultySet();
        }

        private void DifficultySet()
        {
            MessageBox.Show("Difficulty set to " + Form1.Difficulty, "Difficulty Set", MessageBoxButtons.OK);
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DifficultySelection_FormClosing(object sender, FormClosingEventArgs e)
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
