using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Loan> loansList= new List<Loan>();
            loansList.Add(new Loan(1, 793, DateTime.Now, DateTime.Now.AddDays(10)));
            loansList.Add(new Loan(2, 778, DateTime.Now, DateTime.Now.AddDays(4)));
            loansList.Add(new Loan(3, 793, DateTime.Now, DateTime.Now.AddDays(10)));
            loansList.Add(new Loan(4, 793, DateTime.Now, DateTime.Now.AddDays(4)));
            loansList.Add(new Loan(5, 795, DateTime.Now, DateTime.Now.AddDays(7)));
            loansList.Add(new Loan(6, 796, DateTime.Now, DateTime.Now.AddDays(5)));


            CirculationManager manager = new CirculationManager();
            manager.CheckoutItem(loansList, new MediaItem(1, "Book 1", "Fiction"), 793, 7, 3);

            // Created Overdue Loan
            DateTime checkout = DateTime.Today.AddDays(-10); 
            DateTime due = DateTime.Today.AddDays(-5); 
            Loan loan = new Loan(8, 101, checkout, due);
            manager.ItemOverdue += manager.ItemOverDueNotification; manager.ProcessOverdue(loan);

            // Closure: OverDue Loan Rule
            Predicate<Loan> overdueRule = manager.CreateOverdueRule(7);
            Console.WriteLine($"Overdue: {overdueRule(loan)}");


            // Linq: Grouping 
            List<Loan> loans = new List<Loan> { 
                loan, 
                new Loan(9, 101, checkout, due), 
                new Loan(10, 102, checkout, due) 
            };
            manager.FindActiveLoans(loans);
            manager.GroupLoans(loans, 101);
            manager.CountActiveLoans(loans);
            Console.WriteLine($"Loan Count: {manager.LoanCountByPatron(loans, 101)}");
            manager.PatronBorrowingLimit(loans, 1);



            List<MediaItem> items = new List<MediaItem>();
            manager.AddItems(items);
            manager.CheckoutItem(loans, items[0], 101, 7,3);
            manager.ReturnItem(loan);

            MediaItem item = new MediaItem(1, "Sample Book", "Fiction");
            try
            {   
                manager.Reflection(item);
            }
            catch (ItemNotCirculatingException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                ReferenceMediaItem referenceItem = new ReferenceMediaItem(2, "Reference Book", "Reference");
                manager.CheckoutItem(loans, referenceItem, 101, 7,3);
            }
            catch (ItemNotCirculatingException ex)
            {
                Console.WriteLine(ex.Message);
            }

            using (CirculationLogger logger = new CirculationLogger("circulation.log"))
            {
                logger.Log("Circulation started");
                logger.Log("Checkout done");
                logger.Log("Return done");
                logger.Log("Circulation closed");
            }
        }
    }
}