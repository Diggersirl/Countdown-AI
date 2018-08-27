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
    public partial class StartRound : Form
    {
        public StartRound(string numbers, int goal)
        {
            InitializeComponent();
            btnStart.DialogResult = DialogResult.Yes;
            btnQuit.DialogResult = DialogResult.No;
            lblDisplay.Text = String.Format("The goal for this round is: {0}\n\nThe numbers for this round are: {1}", goal, numbers);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();      
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartRound_FormClosing(object sender, FormClosingEventArgs e)
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
