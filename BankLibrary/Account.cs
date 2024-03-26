using System;
using System.Collections.Generic;


namespace BankLibrary
{
    public  class Account
    {
        public string AccountNumber { get; set; }
        public string Pin { get; set; }
        public string Type { get; set; }
        public decimal Balance { get; set; }
        public List<string> Transactions { get; set; }

        public Account(string accountNumber, string pin, string type, decimal balance)
        {
            AccountNumber = accountNumber;
            Pin = pin;
            Type = type;
            Balance = balance;
            Transactions = new List<string>();
        }

        public virtual void Deposit(decimal amount)
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

        public virtual void PrintStatement()
        {
            int count = Transactions.Count;

            if (count <= 0)
            {
                return;
            }

            foreach (var transaction in Transactions)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
