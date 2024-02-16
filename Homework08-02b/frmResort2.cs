using System;
using System.Windows.Forms;

namespace Homework08_02b
{
    public partial class frmResort2 : Form
    {
        decimal[] nightCost = { 200.00m, 180.00m, 160.00m, 145.00m };
        string[] numNights = { "One Or Two", "Three Or Four", "Five To Seven", "Eight Or More" };

        public frmResort2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DetermineNightsStayed();
        }

        private void DetermineNightsStayed()
        {
            int nights = 0;

            try
            {
                nights = Convert.ToInt32(txtNightsStayed.Text.Trim());

                if (nights <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                DetermineBill(nights);
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Message:\t" + fe.Message +
                                 "\n\n" + "Nights Must Be An Integer",
                                 "FORMAT EXCEPTION");
                ClearForm();
                return;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                ShowErrorMessage("System Message:\t" + aoore.Message +
                                 "\n\n" + "Nights Must Be An Integer Greater Than 0",
                                 "ARGUMENT OUT OF RANGE EXCEPTION");
                ClearForm();
                return;
            }
        }

        private void DetermineBill(int nights)
        {
            decimal nightlyCost = 0.00m;
            decimal totalCost = 0.00m;
            string numNightsStr = "";

            switch (nights)
            {
                case 1:
                case 2:
                    nightlyCost = nightCost[0];
                    numNightsStr = numNights[0];
                    break;

                case 3:
                case 4:
                    nightlyCost = nightCost[1];
                    numNightsStr = numNights[1];
                    break;

                case 5:
                case 6:
                case 7:
                    nightlyCost = nightCost[2];
                    numNightsStr = numNights[2];
                    break;

                default:
                    nightlyCost = nightCost[3];
                    numNightsStr = numNights[3];
                    break;
            }

            totalCost = nightlyCost * nights;
            txtNightsString.Text = ($"{numNightsStr}");
            txtNightlyCost.Text = ($"{nightlyCost:c}");
            txtTotalCost.Text = ($"{totalCost:c}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtNightsStayed.Text = "";
            txtNightsString.Text = "";
            txtNightlyCost.Text = "";
            txtTotalCost.Text = "";
            txtNightsStayed.Focus();
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
