using System;
using System.Windows.Forms;

/*	#2. Write a GUI program that adds up the 
 *      number of eggs produced by chickens and:
 *      ●	Prompts the user for a number of eggs 
 *          laid by four chickens.
 *      ●	Sums the eggs laid and display the 
 *          total in dozens and eggs.  
 *          
 *          For example, a total of 127 eggs 
 *          would be displayed as: 
 *          "10 dozen and 7 eggs"
 */

namespace EggCount
{
    public partial class frmEggCount : Form
    {
        // Declare and initialize constants
        const string MOII = "MISSING OR INVALID INPUT";
        const string CCCBE = "Chicken Count Cannot Be Empty";
        const string ECCBE = "Egg Count Cannot Be Empty";

        public frmEggCount()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Read Chicken count input
            string chickenCountStr = txtChickenCount.Text.Trim();

            if (chickenCountStr == "")
            {
                ShowErrorMessage(CCCBE, MOII);
                return;
            }

            // Read egg count input
            string eggCountStr = txtEggCount.Text.Trim();

            if(eggCountStr == "")
            {
                ShowErrorMessage(ECCBE, MOII);
                return;
            }

            // Convert input strings to integers
            if (!int.TryParse(chickenCountStr, out int chickenCount) || !int.TryParse(eggCountStr, out int eggCount))
            {
                ShowErrorMessage(MOII, MOII);
                return;
            }

            // Calculate total eggs
            int totalEggs = chickenCount * eggCount;

            // Calculate dozens and remaining eggs
            int dozens = totalEggs / 12;
            int remainingEggs = totalEggs % 12;

            // Display result
            lblResult.Text = ($"{dozens} dozen and {remainingEggs} eggs");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtChickenCount.Text = "";
            txtEggCount.Text = "";
            lblResult.Text = "";
            txtChickenCount.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                        "Do You Really Want To Exit The Program?",
                        "EXIT NOW?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
