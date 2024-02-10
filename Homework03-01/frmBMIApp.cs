using System;
using System.Windows.Forms;

namespace Homework03_01
{
    public partial class frmBMIApp : Form
    {
        const int MINHEIGHT = 12;
        const int MAXHEIGHT = 96;
        const int MINWEIGHT  = 1;
        const int MAXWEIGHT = 777;

        public frmBMIApp()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string heightStr = txtHeight.Text;
            string weightStr = txtWeight.Text;

            if (ValidateHeight(heightStr) && ValidateWeight(weightStr))
            {
                int height = int.Parse(heightStr);
                int weight = int.Parse(weightStr);

                double bmi = CalculateBMI(weight, height);

                if (bmi < 18.5)
                {
                    lblResults.Text = "Underweight";
                }
                else if (bmi >= 18.5 && bmi < 25.0)
                {
                    lblResults.Text = "Optimal weight";
                }
                else if (bmi >= 25.0 && bmi < 30.0)
                {
                    lblResults.Text = "Overweight";
                }
                else
                {
                    lblResults.Text = "Obese";
                }
            }
        }
        
        private bool IsPresent(string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        private bool IsInt32(string value)
        {
            return int.TryParse(value, out _);
        }

        private bool IsWithinRange(int value, int min, int max)
        {
            return value >= min && value <= max;
        }

        private bool ValidateHeight(string heightStr)
        {
            if (!IsPresent(heightStr) || !IsInt32(heightStr))
            {
                ShowErrorMessage("Please Enter A Valid Height.", "ERROR IN INPUT");
                return false;
            }

            int height = int.Parse(heightStr);

            if (!IsWithinRange(height, MINHEIGHT, MAXHEIGHT))
            {
                ShowErrorMessage("Height Must Be Between 12 And 96 Inches.", "ERROR IN INPUT");
                return false;
            }

            return true;
        }

        private bool ValidateWeight(string weightStr)
        {
            if (!IsPresent(weightStr) || !IsInt32(weightStr))
            {
                ShowErrorMessage("Please Enter A Valid Weight.", "ERROR IN INPUT");
                return false;
            }

            int weight = int.Parse(weightStr);

            if (!IsWithinRange(weight, MINWEIGHT, MAXWEIGHT))
            {
                ShowErrorMessage("Weight Must Be Between 1 And 777 Pounds.", "ERROR IN INPUT");
                return false;
            }

            return true;
        }

        private double CalculateBMI(int weight, int height)
        {
            return (weight / (double)(height * height)) * 703;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtWeight.Text = "";
            txtHeight.Text = "";
            lblResults.Text = "";
            txtWeight.Focus();
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
