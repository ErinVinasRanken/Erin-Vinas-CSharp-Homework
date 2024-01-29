using System;
using System.Windows.Forms;

/*
 *  #8. Implement #7 as a GUI program.
 */

namespace HomeSalesG
{
    public partial class HomeSales : Form
    {
        // Declare and initialize program constants
        const string EII = "ERROR IN INPUT";
        const string PEAVI = "Please Enter A Valid Initial";
        const string PEAVSA = "Please Enter A Valid Sales Amount";
        string highestSalesPerson = "";
        int sum = 0;
        int sumD = 0;
        int sumE = 0;
        int sumF = 0;
        int highestSale = 0;
        
        public HomeSales()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            char ch;
            int value;

            if (txtInitial.Text == "")
            {
                ShowErrorMessage(PEAVI, EII);
                return;
            }

            ch = txtInitial.Text.ToUpper()[0];

            if (ch == 'D' || ch == 'E' || ch == 'F')
            {
                if (!int.TryParse(txtSales.Text, out value))
                {
                    ShowErrorMessage(PEAVSA, EII);
                    return;
                }

                UpdateSales(ch, value);
            }
            else if (ch == 'Z')
            {
                DisplayResults();
            }
            else
            {
                ShowErrorMessage(PEAVI, EII);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtInitial.Text = "";
            txtSales.Text = "";
            txtTotal.Text = "";
            txtInitial.Focus();
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

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void UpdateSales(char salesPerson, int salesAmount)
        {
            switch (salesPerson)
            {
                case 'D':
                    sumD += salesAmount;
                    break;
                case 'E':
                    sumE += salesAmount;
                    break;
                case 'F':
                    sumF += salesAmount;
                    break;
            }

            DisplayResults(); // Update display after each sale
        }
        private void DisplayResults()
        {
            //highestSalesPerson = GetHighestSalesPerson();
            //highestSale = GetHighestSale();

            txtTotal.Text = $"Total Sale Of Danielle Is: {sumD:c}\r\n" +
                            $"Total Sale Of Edward IS: {sumE:c}\r\n" +
                            $"Total Sale Of Francis Is: {sumF:c}\r\n" +
                            $"Total Sale Is: {(sumD + sumE + sumF):c}\r\n" +
                            $"Highest Sales Person Is: {GetHighestSalesPerson()}\r\n" +
                            $"Highest Sale Is {GetHighestSale():c}";
        }

        private string GetHighestSalesPerson()
        {
            if (sumD > sumE && sumD > sumF)
            {
                return "Danielle";
            }
            else if (sumE > sumF)
            {
                return "Edward";
            }
            else
            {
                return "Francis";
            }
        }

        private int GetHighestSale()
        {
            return Math.Max(sumD, Math.Max(sumE, sumF));
        }
    }
}
