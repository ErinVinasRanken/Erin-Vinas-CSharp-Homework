using System;
using System.Windows.Forms;

namespace Homework09_04
{
    public partial class frmReservations : Form
    {
        public frmReservations()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime arrivalDate = dtpArrival.Value;

            DateTime departureDate = dtpDeparture.Value;

            if (departureDate <= arrivalDate)
            {
                ShowErrorMessage("Departure Date Must Be After Arrival Date.", 
                                 "ERROR");
                return;
            }

            TimeSpan duration = departureDate - arrivalDate;
            int numberOfNights = duration.Days;

            double pricePerNight = 120.0;
            double totalPrice = numberOfNights * pricePerNight;

            double averagePricePerNight = totalPrice / numberOfNights;

            txtNumberOfNights.Text = numberOfNights.ToString();
            txtTotalPrice.Text = $"${totalPrice:f2}";
            txtAvgPricePerNight.Text = $"${averagePricePerNight:F2}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpArrival.Value = DateTime.Today;
            dtpDeparture.Value = DateTime.Today;
            txtNumberOfNights.Text = "";
            txtTotalPrice.Text = "";
            txtAvgPricePerNight.Text = "";

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
