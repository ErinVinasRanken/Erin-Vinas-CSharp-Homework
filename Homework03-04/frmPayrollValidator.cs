using System;
using System.Windows.Forms;

namespace Homework03_04
{
    public partial class frmPayrollValidator : Form
    {
        //Declare and Initialize program constants 
        const decimal MINHOURS = 0.0m;
        const decimal MAXHOURS = 84.00m;
        const decimal MINHRATE = 0.00m;
        const decimal MAXHRATE = 99.99m;
        const decimal MAXNONOT = 40.00m;
        const decimal OTRATE = 2.00m;
        const string EE = "ENTRY ERROR";

        public frmPayrollValidator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal hoursWorked = 0.00m;
            decimal hourlyRate = 0.00m;
            decimal grossPay = 0.00m;

            if (IsValidData())
            {
                hoursWorked = Convert.ToDecimal(txtHoursWorked.Text.Trim());
                hourlyRate = Convert.ToDecimal(txtHourlyRate.Text.Trim());
                CalculateGrossPay(hoursWorked, hourlyRate, ref grossPay);


                txtGrossPay.Text = ($"{grossPay:c}");
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            // Validate the hours worked text box
            errorMessage += IsPresent(txtHoursWorked.Text, "Hours Worked");
            errorMessage += IsDecimal(txtHoursWorked.Text, "Hours Worked");
            errorMessage += IsWithinRange(txtHoursWorked.Text, "Hours Worked", MINHOURS, MAXHOURS);

            // Validate hourly rate text box
            errorMessage += IsPresent(txtHourlyRate.Text, "Hourly Rate");
            errorMessage += IsDecimal(txtHourlyRate.Text, "Hourly Rate");
            errorMessage += IsWithinRange(txtHourlyRate.Text, "Hourly Rate", MINHRATE, MAXHRATE);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, EE);
            }

            return success;
        }



        private void CalculateGrossPay(decimal hw, decimal hr, ref decimal gp)
        {
            if (hw <= MAXNONOT)
            {
                // No overtime was worked
                gp = hw * hr;
            }
            else
            {
                // Some overtime was worked
                gp = (MAXNONOT * hr) + ((hw - MAXNONOT) * hr * OTRATE);
            }
        }

        private string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " is a required field.\n"; 
            }

            return msg;
        }

        private string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg = name + " must be a valid decimal value.\n";
            }

            return msg;
        }

        private string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if(decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg = name + " must be between " + min + " and " + max + ".\n";
                }
            }

            return msg;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtHoursWorked.Text = "";
            txtHourlyRate.Text = "";
            txtGrossPay.Text = "";
            txtHoursWorked.Focus();
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
