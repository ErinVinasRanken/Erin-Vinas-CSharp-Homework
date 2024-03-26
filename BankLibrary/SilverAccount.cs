using System;

namespace BankLibrary
{
    public class SilverAccount : Account
    {
        public SilverAccount(string accountNumber, string pin, string type, decimal balance)
            : base(accountNumber, pin, type, balance)
        {
        }

        public override bool Withdraw(decimal amount)
        {
            if (Balance - amount >= 1000)
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

        public override void PrintStatement()
        {
            base.PrintStatement();
            Console.WriteLine("Silver Account Statement:");
        }
    }
}
