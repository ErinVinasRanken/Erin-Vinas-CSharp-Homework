using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Homework03_05
{
    public partial class frmOrderValidator : Form
    {
        const int MINNUMBER = 100;
        const int MAXNUMBER = 999;
        const int MINQUAN = 1;
        const int MAXQUAN = 12;
        const int MINDAYS = 1;
        const int MAXDAYS = 30;
        const string OIV = "THE ORDER IS VALID";
        const string OINV = "THE ORDER IS NOT VALID";

        public frmOrderValidator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string itemNumber = txtItemNumber.Text;
            string quantity = txtQuantity.Text;
            string estimatedDelivery = txtEstimatedDelivery.Text;
            bool validOrder = true;
            lblResults.Text = "";

            if (!IsPresent(itemNumber) ||
                !IsPresent(quantity) ||
                !IsPresent(estimatedDelivery))
            {
                validOrder = false;
                ShowErrorMessage("Please Fill In all Fields.", "ERROR IN INPUT");
                lblResults.Text = OINV;
                return;
            }

            if (!IsInt32(itemNumber) ||
                !IsInt32(quantity) ||
                !IsInt32(estimatedDelivery))
            {
                validOrder = false;
                ShowErrorMessage("Please Enter Valid Integer Values.", "ERROR IN INPUT");
                lblResults.Text = OINV;
                return;
            }

            int itemNumberInt = int.Parse(itemNumber);
            int quantityInt = int.Parse(quantity);
            int estimatedDeliveryInt = int.Parse(estimatedDelivery);

            if (!IsWithinRange(itemNumberInt, MINNUMBER, MAXNUMBER) ||
                !IsWithinRange(quantityInt, MINQUAN, MAXQUAN) ||
                !IsWithinRange(estimatedDeliveryInt, MINDAYS, MAXDAYS))
            {
                validOrder = false;
                ShowErrorMessage("Out Of Range Values Entered", "ERROR IN INPUT");
                lblResults.Text = OINV;
                return;
            }

            if (validOrder)
            {
                lblResults.Text = OIV;
            }
            else
            {
                lblResults.Text = OINV;
            }
        }

        public bool IsPresent(string value)
        {
            return (value != "");
        }

        public bool IsInt32(string value)
        {
            bool result = int.TryParse(value, out _);
            return result;
        }

        public bool IsWithinRange(int value, int min, int max)
        {
            bool isWithinRange = value >= min && value <= max;
            return isWithinRange;
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

        private void frmOrderValidator_Load(object sender, EventArgs e)
        {
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
