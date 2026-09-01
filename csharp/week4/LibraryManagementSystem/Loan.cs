using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementSystem
{
    internal class Loan
    {
        public int ItemId { get; set; } 
        public int PatronId { get; set; } 
        public DateTime CheckoutDate { get; set; }
        public DateTime DueDate { get; set; } 
        public DateTime ReturnedDate {  get; set; }

        public Loan(int id, int patronid, DateTime checkoutdate, DateTime duedate)
        {
            ItemId=id;
            PatronId=patronid;
            CheckoutDate = checkoutdate;
            DueDate = duedate;
            ReturnedDate = DateTime.MinValue;
        }


    }
}
