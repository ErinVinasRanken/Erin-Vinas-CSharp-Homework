using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework03_02
{
    public partial class Form1 : Form
    {
        const int MINHEIGHT = 12;
        const int MAXHEIGHT = 96;
        const int MINWEIGHT = 1;
        const int MAXWEIGHT = 777;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get heigt and weight from textboxes
                double height = double.Parse(txtHeight.Text);
                double weight = double.Parse(txtWeight.Text);
                double bmi = 0;

                // Check valid input
                if (height <= 0 || weight <= 0)
                {
                    throw new ArgumentException("Height And Weight Must Be Positive Numbers");
                }

                // Calculate BMI
                bmi = (weight / (height * height)) * 703;

                // Display BMI
                lblResults.Text += ($"BMI: {bmi:n2}\r\n");

                // Interperet BMI
                if (bmi < 18.5)
                {
                    lblResults.Text += "Underweight";
                }
                else if (bmi >= 18.5 && bmi < 25.0)
                {
                    lblResults.Text += "Optimal Weight";
                }
                else if (bmi >= 25.0 && bmi < 30.0)
                {
                    lblResults.Text += "Overweight";
                }
                else
                {
                    lblResults.Text += "Obese";
                }
            }
            catch (FormatException)
            {
                ShowErrorMessage("Please Enter Valid Numeric Values For Height And Weight.", "ERROR IN INPUT");
            }
            catch (ArgumentException ae)
            {
                ShowErrorMessage(ae.Message, "ERROR IN INPUT");
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message, "ERROR IN INPUT");
            }
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
