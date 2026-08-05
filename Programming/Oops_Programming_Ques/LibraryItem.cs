using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation_Polymorphism_Interface_AbstractClass
{
    interface IReservable
    {
        void ReserveItem();
        void CheckAvailability();
    }
    abstract internal class LibraryItem
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public LibraryItem(int id, string title, string author)
        {
            ItemId = id;
            Title = title;
            Author= author;
        }
        public abstract void GetLoanDuration();
        public void GetItemDetails()
        {
            Console.WriteLine("========================");
            Console.WriteLine($"Item Id: {ItemId}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
        }
    }

    internal class Book: LibraryItem, IReservable
    {
        private bool isAvailable=true;
        public Book(int id, string title, string author): base(id,title,author)
        {
            
        }
        public override void GetLoanDuration()
        {
            Console.WriteLine("Loan Duration: 1 Month");
        }
        public void GetBookDetails()
        {
            base.GetItemDetails();
            Console.WriteLine("Item Type: Book");
        }
        public void CheckAvailability()
        {
            if (isAvailable)
            {
                Console.WriteLine("Item is Available");
            }
            else
            {
                Console.WriteLine("Item is not Available");

            }

        }
        public void ReserveItem()
        {
            if (isAvailable)
            {
                Console.WriteLine("Item Reserved!");
                isAvailable = false;
            }
            else
            {
                Console.WriteLine("Item is Free!");
            }
        }
    }
    internal class Magazine : LibraryItem, IReservable
    {
        private bool isAvailable = true;

        public Magazine(int id, string title, string author) : base(id, title, author)
        {

        }
        public override void GetLoanDuration()
        {
            Console.WriteLine("Loan Duration: 15 Days");
        }
        public void GetBookDetails()
        {
            base.GetItemDetails();
            Console.WriteLine("Item Type: Magazine");
        }
        public void CheckAvailability()
        {
            if (isAvailable)
            {
                Console.WriteLine("Item is Available");
            }
            else
            {
                Console.WriteLine("Item is not Available");

            }

        }
        public void ReserveItem()
        {
            if (isAvailable)
            {
                Console.WriteLine("Item Reserved!");
                isAvailable = false;
            }
            else
            {
                Console.WriteLine("Item is Free!");
            }
        }
    }
    internal class DVD : LibraryItem, IReservable
    {
        private bool isAvailable=true;
        public DVD(int id, string title, string author) : base(id, title, author)
        {

        }
        public override void GetLoanDuration()
        {
            Console.WriteLine("Loan Duration: 2 Month");
        }
        public void GetBookDetails()
        {
            base.GetItemDetails();
            Console.WriteLine("Item Type: DVD");
        }
        public void CheckAvailability()
        {
            if (isAvailable)
            {
                Console.WriteLine("Item is Available");
            }
            else
            {
                Console.WriteLine("Item is not Available");

            }

        }
        public void ReserveItem()
        {
            if (isAvailable)
            {
                Console.WriteLine("Item Reserved!");
                isAvailable = false;
            }
            else
            {
                Console.WriteLine("Item is not Available");
            }
        }

    }
}
