using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime checkout = new DateTime(2026, 9, 1);
            DateTime due = new DateTime(2026, 9, 7);

            Loan loan = new Loan(1, 101, checkout, due);

            CirculationManager manager = new CirculationManager();
            manager.ItemOverdue += manager.ItemOverDueNotification;
            manager.ProcessOverdue(loan);

            Predicate<Loan> overdueRule = manager.CreateOverdueRule(7);
            Console.WriteLine($"Overdue: {overdueRule(loan)}");

            List<Loan> loans = new List<Loan>
            {
                loan,new Loan(2, 101, checkout, due),new Loan(3, 102, checkout, due)
            };
            manager.FindActiveLoans(loans);

            manager.GroupLoans(loans, 101);
            manager.CountActiveLoans(loans);

            Console.WriteLine($"Loan Count: {manager.LoanCountByPatron(loans, 101)}");

            manager.PatronBorrowingLimit(loans, 1);

            List<MediaItem> items = new List<MediaItem>();

            manager.AddItems(items);
            manager.CheckoutItem(loans, items[0], 101, 7);
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
                manager.CheckoutItem(loans, referenceItem, 101, 7);
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