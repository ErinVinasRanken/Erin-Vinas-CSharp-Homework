using System;
using System.Windows.Forms;

namespace Homework08_02a
{
    public partial class frmResort : Form
    {
        // Decalre and initialize program comstamts
        const decimal ONEORTWONIGHTS    = 200.00m;
        const decimal THREEORFOURNIGHTS = 180.00m;
        const decimal FIVETOSEVENNIGHTS = 160.00m;
        const decimal EIGHTORMORENIGHTS = 145.00m;
        const string  ONEORTWO          = "One Or Two";
        const string  THREEORFOUR       = "Three Or Four";
        const string  FIVETOSEVEN       = "Five To Seven";
        const string  EIGHTORMORE       = "Eright Or More";
        public frmResort()
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
            catch(FormatException fe)
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
                    nightlyCost = ONEORTWONIGHTS;
                    numNightsStr = ONEORTWO;
                    break;

                case 3:
                case 4:
                    nightlyCost = THREEORFOURNIGHTS;
                    numNightsStr = THREEORFOUR;
                    break;

                case 5:
                case 6:
                case 7:
                    nightlyCost = FIVETOSEVENNIGHTS;
                    numNightsStr = FIVETOSEVEN;
                    break;

                default:
                    nightlyCost = EIGHTORMORENIGHTS;
                    numNightsStr = EIGHTORMORE;
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
