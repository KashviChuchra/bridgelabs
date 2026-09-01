using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Transactions;
using static System.Net.WebRequestMethods;

namespace LibraryManagementSystem
{
   
    public class CirculationManager
    {
        //processes checkouts/returns, evaluates overdue rules, raises alerts, and logs transactions.

        public List<int> fine = new List<int>();

        // ===============Clouser===============
        public Predicate<Loan> CreateOverdueRule(int loanPeriodDays)
        {
            return x => x.ReturnedDate == DateTime.MinValue && DateTime.Today > x.CheckoutDate.Date.AddDays(loanPeriodDays);
        }

        // =========================Event=====================================
        public event Action<int, int, int> ItemOverdue;
        public void ProcessOverdue(Loan loan)
        {
            DateTime today = DateTime.Today;

            if (loan.ReturnedDate == DateTime.MinValue && loan.DueDate < today)
            {
                int duedays = (int)(today - loan.DueDate).TotalDays;
                ItemOverdue?.Invoke(loan.PatronId, duedays, loan.ItemId);
            }
            else
            {
                log(today, loan.PatronId, "No Loan Pending over Due Date");
            }
        }
        public void ItemOverDueNotification(int patronid, int days, int ItemId)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine($"{ItemId} overdue by {days} days (Patron {patronid})");
            fine.Add(patronid);
            log(today, patronid, "Loan overdue: Added into Fine Eligible List");
        }
        public void log(DateTime date,int id,string message) 
        {
            Console.WriteLine($"Date: {date}\t User: {id}\t Issue:{message}");
        }
        public Action<Loan> CheckoutLogger { get; set; } = loan => 
            Console.WriteLine($"Checkout: Item {loan.ItemId}, Patron {loan.PatronId}"); 
        public Action<Loan> ReturnLogger { get; set; } = loan => 
            Console.WriteLine($"Return: Item {loan.ItemId}, Patron {loan.PatronId}");

        //================Lambda Expressions=========================
        public void FindActiveLoans(List<Loan> loans)
        {
            List<Loan> activeLoans=loans.Where(loan => loan.ReturnedDate == DateTime.MinValue).ToList();
            activeLoans.ForEach(x =>
            {
                Console.WriteLine("Active Loan");
                DaysOverduePerLoan(x);
            });

        }

        public void DaysOverduePerLoan(Loan loan)
        {
            int days = 0;

            if (loan.ReturnedDate == DateTime.MinValue && loan.DueDate < DateTime.Today)
            {
                days = (int)(DateTime.Today - loan.DueDate).TotalDays;
            }

            Console.WriteLine("Days Overude: " + days);
        }

        //=====================Linq=========================
        public void GroupLoans(List<Loan> loans, int id)
        {
            var resultLoan = loans.Where(x => x.PatronId == id).GroupBy(x => x.PatronId);

            foreach (var group in resultLoan)
            {
                Console.WriteLine($"Loans by {group.Key}");
                foreach (var loan in group)
                {
                    Console.WriteLine(loan.ItemId);
                }
            }
        }
        public void CountActiveLoans(List<Loan> loans)
        {
            var resultLoan = loans.Where(x => x.ReturnedDate == DateTime.MinValue).GroupBy(x => x.PatronId)
                .Select(x => new
                {
                    PatronId = x.Key,
                    Count = x.Count()
                });

            foreach (var patron in resultLoan)
            {
                Console.WriteLine($"Patron {patron.PatronId}: {patron.Count} Active Loans");
            }
        }
        public int LoanCountByPatron(List<Loan> loans, int id)
        {
            return loans.Count(x =>x.PatronId == id && x.ReturnedDate == DateTime.MinValue);
        }
        public void PatronBorrowingLimit(List<Loan> loans, int limit)
        {
            var patrons = loans
                .Where(x => x.ReturnedDate == DateTime.MinValue)
                .GroupBy(x => x.PatronId)
                .Where(x => x.Count() >= limit)
                .Select(x => x.Key)
                .ToList();

            patrons.ForEach(x =>Console.WriteLine($"Patron {x} has reached the borrowing limit"));
        }


        public bool Reflection(MediaItem item)
        {
            Type itemType = item.GetType(); 
            NonCirculatingAttribute? attribute = itemType.GetCustomAttribute<NonCirculatingAttribute>(); 
            if (attribute != null) { return true; }
            return false;
        }
        // logger
        private CirculationLogger? transactionLogger;
        public CirculationLogger? TransactionLogger
        {
            get => transactionLogger;
            set => transactionLogger = value;
        }
        //=====Checkout/Return Item
        private readonly List<Loan> managedLoans = new List<Loan>();
        public void ReturnItem(Loan loan)
        {
            try
            {
                if (!managedLoans.Contains(loan) ||loan.ReturnedDate != DateTime.MinValue)
                {
                    throw new InvalidOperationException("Item was never checked out or has already been returned.");
                }

                loan.ReturnedDate = DateTime.Now;
                ReturnLogger(loan);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                transactionLogger?.Log($"RETURN ATTEMPT: Item {loan.ItemId}, Patron {loan.PatronId}");
            }
        }
 

        //incorrect

        //public void CheckoutItem(List<Loan> loans, MediaItem item, int patronId, int loanPeriodDays, int borrowingLimit)
        //{
        //    var attribute = item.GetType().GetCustomAttributes(typeof(NonCirculatingAttribute), true).FirstOrDefault() as NonCirculatingAttribute;

        //    if (attribute != null)
        //    {
        //        throw new ItemNotCirculatingException(item.ItemId, attribute.Message);
        //    }
        //    if (loans.Any(x =>x.ItemId == item.ItemId && x.ReturnedDate == DateTime.MinValue))
        //    {
        //        throw new InvalidOperationException("Item is already checked out");
        //    }
        //    if (loans.Count(x =>x.PatronId == patronId && x.ReturnedDate == DateTime.MinValue) >= borrowingLimit)
        //    {
        //        throw new InvalidOperationException("Patron has reached the borrowing limit.");
        //    }

        //    DateTime checkoutDate = DateTime.Now;
        //    DateTime dueDate = checkoutDate.AddDays(loanPeriodDays);

        //    loans.Add(new Loan(item.ItemId,patronId,checkoutDate,dueDate));
        //}

        //public void AddItems(List<MediaItem> items)
        //{
        //    items.Add(new MediaItem(1,"Learn","Maths"));
        //}

        //public void ProcessAllOverdue(List<Loan> loans) 
        //{ 
        //    foreach (Loan loan in loans) { ProcessOverdue(loan); 
        //    } 
        //}

    }
}
