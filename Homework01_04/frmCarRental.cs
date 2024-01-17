using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework01_04
{
    public partial class frmCarRental : Form
    {
        public frmCarRental()
        {
            InitializeComponent();
        }


        // Declare and initialize program constants
        const decimal PERDAYCHARGE = 100.00m;
        const decimal PERMILECHARGE = 0.50m;

        private void frmCarRental_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateTotalCharge();
        }

        private void CalculateTotalCharge()
        {
            int totalDays = Convert.ToInt32(txtNumberOfDays.Text);
            decimal totalMiles = Convert.ToDecimal(txtNumberOfMiles.Text);
            decimal totalCharge = (totalDays * PERDAYCHARGE) + (totalMiles * PERMILECHARGE);

            txtTotalCharge.Text = totalCharge.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtNumberOfDays.Text = "";
            txtNumberOfMiles.Text = "";
            txtTotalCharge.Text = "";
            txtNumberOfDays.Focus();
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
    }
}
