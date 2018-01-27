using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GuessNumber
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            //int randInt = 0;


            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            if (Regex.IsMatch(txtNumber.Text.Trim(), "^[a-zA-Z]*$"))
            {
                MessageBox.Show("IN DEVELOPMENT");
            }

            else if (Int32.Parse(txtNumber.Text) < 1 || Int32.Parse(txtNumber.Text) > 100)
            {
                MessageBox.Show("Your number has to be between 1 and 100!");
            }
            else { if (randomNumber.ToString() == txtNumber.Text) {
                MessageBox.Show("         Yes. You got it!");
            } else {
                MessageBox.Show("No dear, it was " + randomNumber);
            }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try to guess the number I'm thinking!\n  Enter a number between 1 and 100\n                    Good Luck!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //btnClose. Asks if we want to close the app
            DialogResult drCloseApp = MessageBox.Show("Do you really want to quit??", "ALERT!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drCloseApp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Try to guess the number I'm thinking!\n  Enter a number between 1 and 100\n                    Good Luck!\n\n\n Simple App made in C# by Leandro Almeida\n github.com/iLeandro");
        }
    }
}
