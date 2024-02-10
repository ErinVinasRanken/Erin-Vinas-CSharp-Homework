using System;
using System.Web;
using System.Windows.Forms;

namespace Homework03_06
{
    public partial class frmOrderValidator2 : Form
    {

        private const int MINNUMBER = 100;
        private const int MAXNUMBER = 999;
        private const int MINQUAN = 1;
        private const int MAXQUAN = 12;
        private const int MINDAYS = 1;
        private const int MAXDAYS = 30;

        public frmOrderValidator2()
        {
            InitializeComponent();
        }

        private void frmOrderValidator2_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string itemNumber = txtItemNumber.Text;
                string quantity = txtQuantity.Text;
                string estimatedDelivery = txtEstimatedDelivery.Text;

                // Check if item number is valid
                int itemNumberInt = int.Parse(itemNumber);
                if (itemNumberInt < MINNUMBER || itemNumberInt > MAXNUMBER)
                {
                    throw new ArgumentException("Item number must be between 100 and 999.");
                }

                // Check if quantity is valid
                int quantityInt = int.Parse(quantity);
                if (quantityInt < MINQUAN || quantityInt > MAXQUAN)
                {
                    throw new ArgumentException("Quantity must be between 1 and 12.");
                }

                // Check if estimated delivery is valid
                int estimatedDeliveryInt = int.Parse(estimatedDelivery);
                if (estimatedDeliveryInt < MINDAYS || estimatedDeliveryInt > MAXDAYS)
                {
                    throw new ArgumentException("Estimated delivery days must be between 1 and 30.");
                }

                // If all checks pass, display valid results in lblResults
                lblResults.Text = "Order details are valid.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integer values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtItemNumber.Text = "";
            txtQuantity.Text = "";
            txtEstimatedDelivery.Text = "";
            lblResults.Text = "";
            txtItemNumber.Focus();
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
