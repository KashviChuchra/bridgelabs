using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Polymorphism_Interface_AbstractClass
{
    interface ILoanable
    {
        void ApplyForLoan();
        void CalculateLoanEligibility();
    }
    abstract internal class BankAccount
    {
        private int accountNumber;
        private string holderName;
        private double balance;

        public int AccountNumber { get { return accountNumber; } set { accountNumber = value; }  }
        public string HolderName { get { return holderName; } set { holderName = value; }  }
        public double Balance { get { return balance; } set { balance = value; } }

        public BankAccount(int an, string hn,double b){
            AccountNumber = an;
            HolderName = hn;
            Balance = b;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                balance = 0;
            }
        }
        public abstract double CalculateIntererst();
        public void DisplayDetails()
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder Name: {HolderName}");
            Console.WriteLine($"Balance: {Balance}");
        }

    }
    internal class SavingsAccount: BankAccount,ILoanable
    {
        public SavingsAccount(int an, string hn, double b) : base(an, hn, b)
        {
        }
        public override double CalculateIntererst()
        {
            return Balance*(6.50/100)/12;
        }
        public void ApplyForLoan()
        {
            Console.WriteLine("Applied for loan");
        }
        public void CalculateLoanEligibility()
        {
            if (Balance > 10000)
            {
                Console.WriteLine("Eligible to apply for loan");
            }
            else
            {
                Console.WriteLine("Not eligible to apply for loan");

            }
        }


    }
    internal class CurrentAccount : BankAccount,ILoanable
    {
        public CurrentAccount(int an, string hn, double b) : base(an, hn, b)
        {
        }
        public override double CalculateIntererst()
        {
            return Balance * 0.12 / 12;
        }
        public void ApplyForLoan()
        {
            Console.WriteLine("Applied for loan");
        }
        public void CalculateLoanEligibility()
        {
            if (Balance > 50000)
            {
                Console.WriteLine("Eligible to apply for loan");
            }
            else
            {
                Console.WriteLine("Not eligible to apply for loan");

            }
        }
    }
}
