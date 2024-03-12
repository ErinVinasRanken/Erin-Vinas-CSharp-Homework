namespace Homework12_02
{
    public partial class frmBankLogin : Form
    {
        // Declare class variables
        List<Account> accounts = new List<Account>();
        string currentAccountNumber = "";
        string currentPinNumber = "";
        int accountNumberLocation = 0;
        int pinNumberLocation = 0;
        bool youAreLoggedIn = false;

        public frmBankLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AttemptToLogin();
        }

        private void AttemptToLogin()
        {
            bool keepGoing = ValidateAccountNumber();

            if (keepGoing)
            {
                keepGoing = ValidatePinNumber();
            }
            else
            {
                return;
            }

            // Debugging message box
            //MessageBox.Show("accountNumberLocation = " +
            //                accountNumberLocation + "\n" +
            //                "pinNumberLocation = " +
            //                pinNumberLocation,
            //                "LOCATIONS"); 

            if (accountNumberLocation == -1 ||
                pinNumberLocation == -1 ||
                accountNumberLocation != pinNumberLocation)
            {
                youAreLoggedIn = false;

                ShowErrorMessage("Account Number Or Pin Number Error",
                                 "ACCOUNT NUMBER AND/OR PIN NUMBER ERROR");
                return;
            }

            if (accountNumberLocation == pinNumberLocation)
            {
                youAreLoggedIn = true;
                DisplayCustomerInformation();
            }
            else
            {

            }
        }

        private bool ValidateAccountNumber()
        {
            string acctNumber = txtAccountNumber.Text.Trim();

            // Look for the account number in the list of current customers
            for (int lcv = 0; lcv < accounts.Count; lcv++)
            {
                if (acctNumber == accounts[lcv].GetAccountNumber())
                {
                    currentAccountNumber = acctNumber;
                    accountNumberLocation = lcv;
                    return true;
                }
            }

            ShowErrorMessage("That Account Number Does Not Exist!",
                             "INVALID ACCOUNT NUMBER");
            txtAccountNumber.Text = "";
            txtAccountNumber.Focus();
            accountNumberLocation = -1;
            return false;
        }

        private bool ValidatePinNumber()
        {
            string pinNumber = txtPinNumber.Text.Trim();

            // Look for the account number in the list of current customers
            for (int lcv = 0; lcv < accounts.Count; lcv++)
            {
                if (pinNumber == accounts[lcv].GetPinNumber())
                {
                    currentPinNumber = pinNumber;
                    pinNumberLocation = lcv;
                    return true;
                }
            }

            ShowErrorMessage("That Pin Number Does Not Exist!",
                             "INVALID PIN NUMBER");
            txtPinNumber.Text = "";
            txtPinNumber.Focus();
            pinNumberLocation = -1;
            return false;
        }

        public void DisplayCustomerInformation()
        {
            txtCustomerInformation.Text = "";
            int local = accountNumberLocation;
            string outputStr = "";
            outputStr += "\r\nWelcome " + accounts[local].GetTitle() +
                         " " + accounts[local].GetFirstName() +
                         " " + accounts[local].GetLastName() + "\r\n\r\n" +
                         "Your Current Balance:\t" + accounts[local].GetBalance().ToString("c");

            txtCustomerInformation.Text = outputStr;
            SetPostLoginControls();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            AttemptToMakeDeposit();
        }

        private void AttemptToMakeDeposit()
        {
            bool result;
            decimal deposit = 0.00m;
            string depositStr = txtMakeADeposit.Text.Trim();

            if (string.IsNullOrEmpty(depositStr))
            {
                ShowErrorMessage("You Must Enter A Positive Number For Deposit.",
                                 "NO DEPOSIT AMOUNT ENTERED");
            }

            try
            {
                result = decimal.TryParse(depositStr, out deposit);
                if (!result)
                {
                    throw new FormatException();
                }

                accounts[accountNumberLocation].MakeDeposit(deposit);
                DisplayCustomerInformation();
                txtMakeADeposit.Text = "";
                txtMakeADeposit.Focus();
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Message:\t" + fe.Message +
                                 "n\n" + "Non-Numeric Input For Deposit",
                                 "ILLEGAL DEPOSIT VALUE");
            }
        }

        private void btnWithdrawl_Click(object sender, EventArgs e)
        {
            AttemptToMakeWithdrawl();
        }

        private void AttemptToMakeWithdrawl()
        {
            bool result;
            decimal withdrawl = 0.00m;
            string withdrawlStr = txtMakeAWithdrawl.Text.Trim();

            if (string.IsNullOrEmpty(withdrawlStr))
            {
                ShowErrorMessage("You Must Enter A Positive Number For Withdrawl.",
                                 "NO WITHDRAWL AMOUNT ENTERED");
            }

            try
            {
                result = decimal.TryParse(withdrawlStr, out withdrawl);
                if (!result)
                {
                    throw new FormatException();
                }

                accounts[accountNumberLocation].MakeWithdrawl(withdrawl);
                DisplayCustomerInformation();
                txtMakeAWithdrawl.Text = "";
                txtMakeAWithdrawl.Focus();
            }
            catch (FormatException fe)
            {
                ShowErrorMessage("System Message:\t" + fe.Message +
                                 "n\n" + "Non-Numeric Input For Withdrawl",
                                 "ILLEGAL WITHDRAWL VALUE");
            }
        }

        private void SetPostLoginControls()
        {
            youAreLoggedIn = true;
            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
            btnDeposit.Enabled = true;
            btnWithdrawl.Enabled = true;
           // txtCustomerInformation.Text = "";
            ClearTextBoxes();

        }

        private void ClearTextBoxes()
        {
            txtAccountNumber.Text = "";
            txtMakeADeposit.Text = "";
            txtMakeAWithdrawl.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SetPreLoginControls();
            txtCustomerInformation.Text = "";
            txtAccountNumber.Focus();
        }

        private void SetPreLoginControls()
        {
            youAreLoggedIn = false;
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            btnDeposit.Enabled = false;
            btnWithdrawl.Enabled = false;
            currentAccountNumber = "";
            currentPinNumber = "";
            accountNumberLocation = 0;
            pinNumberLocation = 0;
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

        private void frmBankLogin_Load(object sender, EventArgs e)
        {
            accounts.Add(new Account("Mr.", "Jeffrey", "Scott", "123-45-6789", "1234", 10000.00m));
            accounts.Add(new Account("Mr.", "Evan", "Gudmestad", "234-56-7890", "2345", 2578.00m));
            accounts.Add(new Account("Mr.", "Doug", "Geggleman", "345-67-8901", "3456", 7654.00m));
            accounts.Add(new Account("Mr.", "James", "Kaufmann", "456-78-9012", "4567", 87654.00m));
            accounts.Add(new Account("Ms.", "Shannon", "Brueggmann", "567-89-0123", "5678", 782.00m));

            SetPreLoginControls();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
