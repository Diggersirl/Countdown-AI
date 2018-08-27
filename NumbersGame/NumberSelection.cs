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
    public partial class NumberSelection : Form
    {

        public NumberSelection()
        {
            InitializeComponent();       
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f = new Form1(int.Parse(cmbLargeNums.Text), int.Parse(cmbSmallNums.Text));
                this.Hide();
                f.Show();
            }
            catch(FormatException)
            {
                MessageBox.Show("You must select an amount of small and large numbers to use");
            }
        }

        private void cmbLargeNums_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val = 0;
            bool invalid = false;

            try
            {
                val = int.Parse(cmbLargeNums.Text);
                if(val > 4)
                {
                    throw new FormatException();
                }
                
            }
            catch(FormatException)
            {
                MessageBox.Show("Invalid value entered, please enter a number between 0 and 4");
               cmbLargeNums.Text = "";
               cmbSmallNums.Text = "";
               invalid = true;
               
            }

            if (!invalid)
            {
                if (val > 4)
                {
                    btnSubmit.Enabled = false;
                    cmbLargeNums.SelectedIndex = 4;
                }
                else
                {
                    cmbLargeNums.SelectedIndex = val;
                }
                cmbSmallNums.SelectedIndex = SetRemainingCombobox(int.Parse((string)cmbLargeNums.SelectedItem));
            }
        }

        private void cmbSmallNums_SelectedIndexChanged(object sender, EventArgs e)
        {
            int val = 0;
            bool invalid = false;
            try
            {
                val = int.Parse(cmbSmallNums.Text);
                if(val > 6)
                {
                    throw new FormatException();
                }
                
            }
            catch(FormatException)
            {
                MessageBox.Show("Invalid value entered, please enter a number between 0 and 4");
               cmbLargeNums.Text = "";
               cmbSmallNums.Text = "";
               invalid = true;      
            }
            if (!invalid)
            {
                if (val != 1 && val != 0)
                {
                    cmbLargeNums.SelectedIndex = SetRemainingCombobox(val);
                }
                else
                {
                    cmbLargeNums.SelectedIndex = 4;
                    cmbSmallNums.SelectedIndex = 2;
                }
            }
        }

        private int SetRemainingCombobox(int val)
        {
            int remainingnums;
            
                switch (val)
                {

                    case 1:
                        remainingnums = 5;
                        break;

                    case 2:
                        remainingnums = 4;
                        break;

                    case 3:
                        remainingnums = 3;
                        break;

                    case 4:
                        remainingnums = 2;
                        break;

                    case 5:
                        remainingnums = 1;
                        break;

                    case 6:
                        remainingnums = 0;
                        break;

                    default:
                        remainingnums = 6;
                        break;
                }
         

            return remainingnums;


        }

        private void NumberSelection_FormClosing(object sender, FormClosingEventArgs e)
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
