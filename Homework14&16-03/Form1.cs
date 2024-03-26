using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using Homework14_16_03;
using BankLibrary;

namespace Homework14_16_03
{
    public partial class Form1 : Form
    {
        private Account loggedInUser = null;

        private Dictionary<string, (string AccountNumber, string Pin)> userCredentials = new Dictionary<string, (string, string)>()
        {
            {"Jane Doe", ("1001", "1234")},
            {"Bethany Gray", ("1002", "5678")},
            {"Johnathan Smith", ("1003", "9012")},
            {"Dylan Johnson", ("1004", "3456")},
            {"Alex Miller", ("1005", "7890")}
        };

        private Dictionary<string, Account> accounts = new Dictionary<string, Account>()
        {
            {"Jane Doe", new BronzeAccount("1001", "1234", "Bronze", 0)},
            {"Bethany Gray", new SilverAccount("1002", "5678", "Silver", 1000)},
            {"Johnathan Smith", new GoldAccount("1003", "9012", "Gold", 5000) },
            {"Dylan Johnson", new BronzeAccount("1004", "3456", "Bronze", 0) },
            {"Alex Miller", new SilverAccount("1005", "7890", "Silver", 1000) }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtAccountNumber.Text;
            string pin = txtPinNumber.Text;

            if (userCredentials.ContainsKey(username))
            {
                var storedPin = userCredentials[username].Pin;

                if (pin == storedPin)
                {
                    loggedInUser = accounts[username];
                    ShowAccountForm();
                    return;
                }
            }

            MessageBox.Show("Invalid Account Number or Pin. Please Try Again.");
        }

        private void ShowAccountForm()
        {
            Form1 accountForm = new Form1();
            accountForm.Show();
            this.Hide();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(txtDeposit.Text, out amount))
            {
                if (loggedInUser != null)
                {
                    loggedInUser.Deposit(amount);
                    MessageBox.Show($"Successfully deposited ${amount}. New balance: ${loggedInUser.Balance}");
                }
                else
                {
                    MessageBox.Show("No user logged in.");
                }
            }
            else
            {
                MessageBox.Show("Invalid amount. Please enter a valid number.");
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(txtWithdraw.Text, out amount))
            {
                if (loggedInUser != null)
                {
                    if (loggedInUser.Withdraw(amount))
                    {
                        MessageBox.Show($"Successfully withdrew ${amount}. New balance: ${loggedInUser.Balance}");
                    }
                    else
                    {
                        MessageBox.Show("Withdrawal failed. Insufficient funds or below minimum balance.");
                    }
                }
                else
                {
                    MessageBox.Show("No user logged in.");
                }
            }
            else
            {
                MessageBox.Show("Invalid amount. Please enter a valid number.");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (loggedInUser != null && (loggedInUser.Type == "Silver" || loggedInUser.Type == "Gold"))
            {
                Statement transactionsForm = new Statement(loggedInUser.Transactions);
                transactionsForm.Show();
            }
            else
            {
                MessageBox.Show("No user logged in or only Silver and Gold accounts can print transactions.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loggedInUser = null;
            txtAccountNumber.Text = "";
            txtPinNumber.Text = "";
            this.Show();
        }
    }
}
