using System;
using System.Windows.Forms;

/*	#3. Write a GUI program to calculate projected 
 *	    raises (Done earlier Console app) and:
 *	    ●	Declares a named constant PERCENT_RAISE 
 *	        and assign it a value of 4% (or 1.04).
 *	    ●	Prompts the user for the names and 
 *	        salaries of three employees.
 *	    ●	Displays the projected salaries for 
 *	        these three employees over the next 3 
 *	        years in a table, assuming that they 
 *	        get a 4% raise every year.
 */

namespace CalculateRaises
{
    public partial class CalculateRaises : Form
    {

        // Declare and initialize prograsm constants

        const decimal PERCENT_RAISE = 0.04m;
        const string FCBE = "Field Cannot Be Empty";
        const string FCBN = "Field Must Be Numeric And Not Negative";
        const string EII = "ERROR IN INPUT";

        // Declare and initialize class variables

        string emp1Str = "";
        string emp2Str = "";
        string emp3Str = "";
        string emp1SalaryStr = "";
        string emp2SalaryStr = "";
        string emp3SalaryStr = "";

        decimal emp1Salary = 0m;
        decimal emp2Salary = 0m;
        decimal emp3Salary = 0m;

        string yearString = "";

        int year = 0;

        public CalculateRaises()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string outputStr = "";
            string finalStr = "";
            bool result;
            emp1Str = txtEmployee1.Text.Trim();

            // Check for no input in Employee1
            if (emp1Str == "")
            {
                txtEmployee1.Focus();
                return;
            }

            // Validate Field is complete in Employee1
            if (emp1Str == "")
            {
                ShowErrorMessage(FCBE, EII);
                txtEmployee1.Text = "";
                txtEmployee1.Focus();
                return;
            }

            emp2Str = txtEmployee2.Text.Trim();

            // Check for no input in Employee2
            if (emp2Str == "")
            {
                txtEmployee2.Focus();
                return;
            }

            // Validate Field is complete in Employee2
            if (emp2Str == "")
            {
                ShowErrorMessage(FCBE, EII);
                txtEmployee2.Text = "";
                txtEmployee2.Focus();
                return;
            }

            emp3Str = txtEmployee3.Text.Trim();

            // Check for no input in Employee3
            if (emp3Str == "")
            {
                txtEmployee3.Focus();
                return;
            }

            // Validate Field is complete in Employee3
            if (emp3Str == "")
            {
                ShowErrorMessage(FCBE, EII);
                txtEmployee3.Text = "";
                txtEmployee3.Focus();
                return;
            }

            string emp1SalaryStr = txtEmployee1Salary.Text.Trim();

            // Check for no input in Employee1Salary
            if (emp1SalaryStr == "")
            {
                txtEmployee1.Focus();
                return;
            }

            // Validate field is numeric and positive in Employee1Salary
            result = decimal.TryParse(emp1SalaryStr, out emp1Salary);

            if (!result)
            {
                ShowErrorMessage(FCBN, EII);
                txtEmployee1Salary.Text = "";
                txtEmployee1.Focus();
                return;
            }

            string emp2SalaryStr = txtEmployee2Salary.Text.Trim();

            // Check for no input in Employee2Salary
            if (emp2SalaryStr == "")
            {
                txtEmployee1.Focus();
                return;
            }

            // Validate field is numeric and positive in Employee2Salary
            result = decimal.TryParse(emp2SalaryStr, out emp2Salary);

            if (!result)
            {
                ShowErrorMessage(FCBN, EII);
                txtEmployee2Salary.Text = "";
                txtEmployee1.Focus();
                return;
            }

            string emp3SalaryStr = txtEmployee3Salary.Text.Trim();

            // Check for no input in Employee3Salary
            if (emp3SalaryStr == "")
            {
                txtEmployee1.Focus();
                return;
            }

            // Validate field is numeric and positive in Employee3Salary
            result = decimal.TryParse(emp3SalaryStr, out emp3Salary);

            if (!result)
            {
                ShowErrorMessage(FCBN, EII);
                txtEmployee3Salary.Text = "";
                txtEmployee1.Focus();
                return;
            }

            outputStr += txtEmployee1.Text + "\t\t" +
                         txtEmployee2.Text + "\t\t" +
                         txtEmployee3.Text + "\r\n" +
                         "------------------------------" +
                         "------------------------------" +
                         "------------------------------" +
                         "\r\n";

            // Multiply yearly salaries for the next 3 years
            for (int i = 0; i < 3; i++)
            {
                emp1Salary += (emp1Salary * PERCENT_RAISE);
                emp2Salary += (emp2Salary * PERCENT_RAISE);
                emp3Salary += (emp3Salary * PERCENT_RAISE);
                outputStr += emp1Salary.ToString("c") + "\t\t" +
                             emp2Salary.ToString("c") + "\t\t" +
                             emp3Salary.ToString("c");
                finalStr += outputStr + "\r\n";
                outputStr = "";
            }

            txtRaises.Text = finalStr;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtEmployee1.Text = "";
            txtEmployee2.Text = "";
            txtEmployee3.Text = "";
            txtEmployee1Salary.Text = "";
            txtEmployee2Salary.Text = "";
            txtEmployee3Salary.Text = "";
            txtEmployee1.Focus();
            txtRaises.Text = "";
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
    

       
