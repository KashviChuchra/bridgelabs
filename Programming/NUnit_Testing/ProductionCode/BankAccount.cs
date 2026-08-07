using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionCode
{
    public class BankAccount
    {
        public double Balance { get; private set; }
        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount can't be negative");
            }
            Balance += amount;
        }
        public double Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount can't be negative");
            }
            else if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                throw new ArgumentException("Insufficient Balance");
            }
            return Balance;
        }
        public double GetBalance()
        {
            return Balance;
        }

    }
}
