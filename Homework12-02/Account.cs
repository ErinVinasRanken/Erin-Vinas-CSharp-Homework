using System;
using System.Data;

namespace Homework12_02
{
    public class Account
    {
        // Declare and initialize constant
        public const decimal MINBALANCE = 25.00m;

        // Instance Variables
        private readonly string _title;
        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _accountNumber;
        private readonly string _pinNumber;
        private decimal         _balance;

        // Full-arg constructor
        public Account(string title, string firstName, string lastName, string accountNumber, string pinNumber, decimal balance)
        {
            _title         = title;
            _firstName     = firstName;
            _lastName      = lastName;
            _accountNumber = accountNumber;
            _pinNumber     = pinNumber;
            _balance       = balance;
        }

        // Getters
        public string GetTitle() => _title;
        public string GetFirstName() => _firstName;
        public string GetLastName() => _lastName;
        public string GetAccountNumber() => _accountNumber;
        public string GetPinNumber() => _pinNumber;
        public decimal GetBalance() => _balance;

        // Attempt to make a deposite method
        public void MakeDeposit(decimal deposit)
        {
            // Create a locla variable to hold a copy of the attempted deposit
            decimal theDeposit = deposit;

            try
            {
                // Attempt to make a deposit but first verify deposit amount is not negative
                if (theDeposit <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                // Deposit was > 0
                _balance += theDeposit;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("System Message:\t" +
                                aoore.Message + "\n\n" +
                                "Illegal Deposit. Must Be > 0",
                                "ILLEGAL DEPOSIT ATTEMPTED");

                return;
            }
        }

        // Attempt to make a withdrawl method
        public void MakeWithdrawl(decimal withdrawl)
        {
            // Create a locla variable to hold a copy of the attempted deposit
            decimal theWithdrawl = withdrawl;
            decimal newBalance;

            try
            {
                // Attempt to make a deposit but first verify deposit amount is not negative
                if (theWithdrawl <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                newBalance = _balance - theWithdrawl;

                if (newBalance < MINBALANCE)
                {
                    throw new DataException();
                }

                // Withdrawl was > 0
                _balance -= theWithdrawl;
            }
            catch (DataException de)
            {
                MessageBox.Show("System Message:\t" +
                                de.Message + "\n\n" +
                                "Insufficient Funds For This Withdrawl.",
                                "INSUFFICIENT FUNDS");
                return;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                MessageBox.Show("System Message:\t" +
                                aoore.Message +"\n\n" +
                                "Illegal Withdrawl. Must Be > 0",
                                "ILLEGAL WITHDRAWL ATTEMPTED");
                return;
            }
        }
    }
}
