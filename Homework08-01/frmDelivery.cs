using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Homework08_01
{
    public partial class frmDelivery : Form
    {
        // Dictionary to store zip code and delivery charges
        private Dictionary<string, string> deliveryCharges = new Dictionary<string, string>()
        {
            {"63101", "$20" },
            {"63103", "$12" },
            {"63105", "$25" },
            {"63109", "$15" },
            {"63113", "$10" },
            {"63118", "$23" },
            {"63130", "$18" },
            {"63133", "$20" },
            {"63136", "$17" },
            {"63137", "$12" }
        };
        public frmDelivery()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string zipCode = txtZipCode.Text.Trim();
            
            if (deliveryCharges.ContainsKey(zipCode))
            {
                string deliveryCharge = deliveryCharges[zipCode];
                txtResults.Text = ($"Delivery Charge To {zipCode}: {deliveryCharge}");
            }
            else
            {
                ShowErrorMessage("Zip Code Not Found", "ERROR IN INPUT");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtZipCode.Text = "";
            txtResults.Text = "";
            txtZipCode.Focus();
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
