using System;
using System.Windows.Forms;

//Create a program that inputs 3 student Grades (must be 0 – 100, use constants),

//calculates the average, and determines the grade based on this grading system:

//90 – 100 = “A”, 80 – 89 = “B”, 70 – 79 = “C, 60 – 69 = “D”, 0 – 59 = “F”.

//Implement methods for input validation using exception handling to ensure only valid grades (numeric and between 0 – 100) are accepted.

namespace Homework03_03
{
    public partial class frmGrades : Form
    {

        // Declare and initalize program constants 
        const int MINSCORE = 0;
        const int MAXSCORE = 100;
        const string ER = "EXCEPTION RAISED";
        public frmGrades()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = ValidateTextBox(txtTest1);

            if (keepGoing)
            {
                keepGoing = ValidateTextBox(txtTest2);
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidateTextBox(txtTest3);
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                CalculateTotalPoints();
            }
        }

        private bool ValidateTextBox(Control control)
        {
            bool isValid = IsTextBoxNotEmpty(control);

            if (!isValid)           // if (isValid == false)
            {
                return false;
            }

            isValid = IsTextBoxNotNumeric(control);

            if (!isValid)           // if (isValid == false)
            {
                return false;
            }

            isValid = IsTextBoxWithinRange(control);
            if (!isValid)           // if (isValid == false)
            {
                return false;
            }

            return true;
        }

        private bool IsTextBoxNotEmpty (Control control)
        {
            try
            {
                if (control.Text == "")
                {
                    throw new ArgumentNullException();
                }

                return true;
            }
            catch(ArgumentNullException ane) 
            {
                ShowErrorMessage(ane.Message + "\n\n" +
                                 ane.GetType().ToString() + "\n\n" +
                                 ane.StackTrace,
                                 ER);
                return false;
            }
        }

        private bool IsTextBoxNotNumeric(Control control)
        {
            bool result;

            try
            {
                result = int.TryParse(control.Text, out _);
                if (!result)
                {
                    throw new FormatException();
                }

                return true;
            }
            catch(FormatException fe)
            {
                ShowErrorMessage(fe.Message + "\n\n" +
                                 fe.GetType().ToString() + "\n\n" +
                                 fe.StackTrace,
                                 ER);
                return false;
            }
        }

        private bool IsTextBoxWithinRange(Control control)
        {
            int score = Convert.ToInt32(control.Text);

            try
            {
                if (score < MINSCORE || score > MAXSCORE)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return true;
            }
            catch(ArgumentOutOfRangeException aoor)
            {
                ShowErrorMessage(aoor.Message + "\n\n" +
                                 aoor.GetType().ToString() + "\n\n" +
                                 aoor.StackTrace,
                                 ER);
                return false;
            }
        }

        private void CalculateTotalPoints()
        {
            int testGrade1 = Convert.ToInt32(txtTest1.Text.Trim());
            int testGrade2 = Convert.ToInt32(txtTest2.Text.Trim());
            int testGrade3 = Convert.ToInt32(txtTest3.Text.Trim());

            CalculateAverageAndGrade(testGrade1, testGrade2, testGrade3);
        }

        private void CalculateAverageAndGrade(int g1, int g2, int g3) 
        { 
            decimal average = (g1 + g2 + g3) / 3.0m;
            string letterGrade = "";

            if (average >= 90m)
            {
                letterGrade = "A";
            }

            else if (average >= 80m)
            {
                letterGrade = "B";
            }

            else if (average >= 70m)
            {
                letterGrade = "C";
            }

            else if (average >= 60m)
            {
                letterGrade = "D";
            }

            else if (average >= 0m)
            {
                letterGrade = "F";
            }

            txtAvgGrade.Text = ($"{average:n2} = {letterGrade}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtTest1.Text = "";
            txtTest2.Text = "";
            txtTest3.Text = "";
            txtAvgGrade.Text = "";
            txtTest1.Focus();
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
