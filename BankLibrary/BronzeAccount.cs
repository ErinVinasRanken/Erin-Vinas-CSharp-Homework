using System;
using System.Collections.Generic;

namespace BankLibrary
{
    public class BronzeAccount : Account
    {
        public string AccountNumber { get; set; }
        public string Pin { get; set; }
        public string Type { get; set; }
        public decimal Balance { get; set; }
        public List<string> Transactions { get; set; }

        public static BronzeAccount loggedInUser { get; set; }

        public BronzeAccount(string accountNumber, string pin, string type, decimal balance)
        : base(accountNumber, pin, type, balance)
        {
            AccountNumber = accountNumber;
            Pin = pin;
            Type = type;
            Balance = balance;
            Transactions = new List<string>();
        }
 
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Transactions.Add($"Deposited: ${amount}");
            }
        }

        public virtual bool Withdraw(decimal amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                Transactions.Add($"Withdrawn: ${amount}");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
