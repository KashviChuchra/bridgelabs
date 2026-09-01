using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Transactions;
using static System.Net.WebRequestMethods;

namespace LibraryManagementSystem
{
   
    internal class CirculationManager
    {
        //processes checkouts/returns, evaluates overdue rules, raises alerts, and logs transactions.

        public List<int> fine = new List<int>();

        // ===============Clouser===============
        public Predicate<Loan> CreateOverdueRule(int loanPeriodDays)
        {
            return x => loanPeriodDays < (x.DueDate - x.CheckoutDate).TotalDays;
        }

        // =========================Event=====================================
        public event Action<int> ItemOverdue;
        public void ProcessOverdue(Loan loan)
        {
            DateTime today = DateTime.Now;
            if (loan.DueDate > today)
            {
                log(today,loan.PatronId, "No Loan Pending over Due Date");
            }
            else
            {
                ItemOverdue?.Invoke(loan.PatronId);
            }
        }
        public void ItemOverDueNotification(int id)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine($"{id} is added to Fine Eligible List");
            fine.Add(id);
            log(today,id, "Loan overdue: Added into Fine Eligible List");
        }
        public void log(DateTime date,int id,string message) 
        {
            Console.WriteLine($"Date: {date}\t User: {id}\t Issue:{message}");
        }

        //================Lambda Expressions=========================
        public void FindActiveLoans(Loan loan)
        {
            if (loan.ReturnedDate == DateTime.MinValue)
            {
                Console.WriteLine("Active Loan");
                DaysOverduePerLoan(loan);
            }
            else
            {
                Action<Loan> action = (loan) =>
                {
                    Console.WriteLine("Loan is already settled!");
                };
            }
        }
        public void DaysOverduePerLoan(Loan loan)
        {
            Console.WriteLine("Days Overude: " + DateTime.Compare(DateTime.Today, loan.DueDate));
        }

        //=====================Linq=========================
        public void GroupLoans(List<Loan> loans, int id)
        {
            List<Loan> resultLoan = loans.Where(x => x.PatronId == id).ToList();
            Console.WriteLine($"Loans by {id}");
            resultLoan.ForEach(x => Console.WriteLine(x.ItemId));
        }
        public void CountActiveLoans(List<Loan> loans)
        {
            List<Loan> resultLoan = loans.Where(x => x.ReturnedDate == DateTime.MinValue).ToList();
            Console.WriteLine($"Count of Active Loans: {resultLoan.Count}");
        }
        // Helper Method
        public int LoanCountByPatron(List<Loan> loans, int id)
        {
            List<Loan> resultLoan = loans.Where(x => x.PatronId == id).ToList();
            return resultLoan.Count;
        }
        public void PatronBorrowingLimit(List<Loan>loans, int limit)
        {
            List<Loan> patrons = loans.Where(x => LoanCountByPatron(loans,x.PatronId) >limit).ToList();
            patrons.ForEach(x => Console.WriteLine(x.ItemId));
        }


        public bool Reflection()
        {
            var properties = typeof(MediaItem).GetProperties();
            foreach (var property in properties)
            {
                var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), true);
                //if(requiredAttribute== "NonCirculatingAttribute")
                //{
                //    throw new ItemNotCirculatingException("This Item can't be circulated");

                //}
                else
                {
                    Console.WriteLine(property.Name);
                }
            }
            return true;
        }

        //=====Checkout/Return Item
        public void ReturnItem(Loan loan)
        {
            DateTime today = DateTime.Now;
            loan.ReturnedDate=today;
        }

        public void CheckoutItem(List<Loan> loans) {
            loans.Add(new Loan(1, 102, DateTime.Now, DateTime.Now.AddDays(10)));
        }
       
        public void AddItems(List<MediaItem> items)
        {
            items.Add(new MediaItem(1,"Learn","Maths"));
        }



    }
}
