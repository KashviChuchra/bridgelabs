using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public BankAccount(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public  void DisplayAccountType()
        {
            Console.WriteLine("========================");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
    internal class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }
        public SavingsAccount(int accountNumber, double balance, double interestRate) : base(accountNumber, balance)
        {
            InterestRate= interestRate;
        }

        public  void DisplayAccountType()
        {
            base.DisplayAccountType();
            Console.WriteLine("This is a Savings Account.");
        }
    }
    internal class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit { get; set; }
        public double MinimumBalance { get; set; }

        public CheckingAccount(int accountNumber, double balance, double withdrawalLimit, double minimumBalance) : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
            MinimumBalance = minimumBalance;
        }
        public  void DisplayAccountType()
        {
            base.DisplayAccountType();
            Console.WriteLine("This is a Checking Account.");
        }
    }
    internal class FixedDepositAccount : BankAccount
    {
        public double InterestRate { get; set; }
        public DateTime MaturityDate { get; set; }

        public FixedDepositAccount(int accountNumber, double balance, double interestRate, DateTime maturityDate) : base(accountNumber, balance)
        {
            InterestRate = interestRate;
            MaturityDate = maturityDate;
        }
        public  void DisplayAccountType()
        {
            base.DisplayAccountType();
            Console.WriteLine("This is a Fixed Deposit Account.");
        }
    }
}
