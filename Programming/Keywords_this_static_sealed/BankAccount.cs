using System;
using System.Collections.Generic;
using System.Text;

namespace keywods_this_static_sealed
{
    internal class BankAccount
    {
        public static string bankName;
        private static int totalAccounts = 0;
        public string accountHolderName;
        public readonly int accountNumber;

        public BankAccount()
        {
            totalAccounts++;
        }
        public BankAccount(string accountHolderName, int accountNumber)
        {
            this.accountHolderName= accountHolderName;
            this.accountNumber= accountNumber;
            totalAccounts++;
        }

        public static void GetTotalAccounts()
        {
            Console.WriteLine("=====================================================================");
            Console.WriteLine($"Total no of accounts: {totalAccounts}");
        }

        public void details()
        {
            Console.WriteLine("======================================================================");
            Console.WriteLine($"Bank Name: {bankName} Account Holder Name: {accountHolderName} Account Number: {accountNumber}");
        }
    }
}
