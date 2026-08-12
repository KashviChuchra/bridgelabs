using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace LinkedList
{
    class LibraryNode
    {
        public string BookTitle;
        public string Author;
        public string Genre;
        public int BookID;
        public string AvailabilityStatus;
        public LibraryNode Next;
        public LibraryNode Prev;

        public LibraryNode(string bookTitle, string author, string genre, int bookID, string availabilityStatus)
        {
            BookTitle = bookTitle;
            Author = author;
            Genre = genre;
            BookID = bookID;
            AvailabilityStatus = availabilityStatus;
            Next = null;
            Prev = null;
        }
    }
    internal class LibraryManagementSystem
    {
        LibraryNode head;
        public void InsertAtBeginning(string bookTitle, string author, string genre, int bookID, string availabilityStatus)
        {
            LibraryNode newNode = new LibraryNode(bookTitle, author, genre, bookID, availabilityStatus);
            if (head == null) head = newNode;
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }
        }

        public void InsertAtEnd(string bookTitle, string author, string genre, int bookID, string availabilityStatus)
        {
            LibraryNode newNode = new LibraryNode(bookTitle, author, genre, bookID, availabilityStatus);

            if (head == null)
            {
                head = newNode;
                return;
            }

            LibraryNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Prev = temp;
            newNode.Next = null;

        }

        public void InsertAtIndex(int position, string bookTitle, string author, string genre, int bookID, string availabilityStatus)
        {
            int count = 0;
            LibraryNode temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            if (position == 1) InsertAtBeginning(bookTitle, author, genre, bookID, availabilityStatus);
            else if (position == count + 1) InsertAtEnd(bookTitle, author, genre, bookID, availabilityStatus);
            else if (position > count || position <= 0) Console.WriteLine("Position Doesn't exist");
            else
            {
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    temp = temp.Next;
                }
                LibraryNode newNode = new LibraryNode(bookTitle, author, genre, bookID, availabilityStatus);
                newNode.Next = temp.Next;
                newNode.Next.Prev = newNode;
                temp.Next = newNode;
                newNode.Prev = temp;
            }

        }

        public void RemoveBookByBookId(int bookId)
        {
            LibraryNode temp = head;
            LibraryNode prev = null;
            while (temp != null && temp.BookID != bookId)
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Book doesn't exist");
                return;
            }
            if (temp.Prev == null)
            {
                head = temp.Next;

                if (head != null)
                    head.Prev = null;
            }
            else
            {
                temp.Prev.Next = temp.Next;

                if (temp.Next != null)
                    temp.Next.Prev = temp.Prev;
            }

        }
        public void SearchBook_BookTitle(string bookTitle)
        {
            LibraryNode temp = head;
            bool isFound = false;
            while (temp != null)
            {
                if (temp.BookTitle == bookTitle)
                {
                    Console.WriteLine($"Found Book. Details: {temp.BookTitle},{temp.Author},{temp.BookID},{temp.Genre},{temp.AvailabilityStatus}");
                    isFound = true;
                }
                temp = temp.Next;
            }
            if (!isFound) Console.WriteLine("Book doesn't exist");
        }
        public void SearchBook_BookAuthor(string author)
        {
            LibraryNode temp = head;
            bool isFound = false;

            while (temp != null)
            {
                if (temp.Author == author)
                {
                    Console.WriteLine($"Found Book. Details: {temp.BookTitle},{temp.Author},{temp.BookID},{temp.Genre},{temp.AvailabilityStatus}");
                    isFound = true;
                }
                temp = temp.Next;
            }
            if (!isFound) Console.WriteLine("Book doesn't exist");
        }

        public void UpdateBookStatus(string bookName, string status)
        {
            LibraryNode temp = head;
            while (temp != null)
            {
                if (temp.BookTitle == bookName)
                {
                    temp.AvailabilityStatus = status;
                    return;
                }
                temp = temp.Next;
            }
        }
        public void DisplayForwardOrder()
        {
            Console.WriteLine("Displaying Book Details in Forward Order");
            LibraryNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"{temp.BookTitle},{temp.Author},{temp.BookID},{temp.Genre},{temp.AvailabilityStatus}");
                temp = temp.Next;
            }
        }
        public void DisplayBackwardOrder()
        {
            Console.WriteLine("Displaying Book Details in Backward Order");

            LibraryNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            while (temp != null)
            {
                Console.WriteLine($"{temp.BookTitle},{temp.Author},{temp.BookID},{temp.Genre},{temp.AvailabilityStatus}");
                temp = temp.Prev;
            }
        }
        public void Count()
        {
            LibraryNode temp = head;
            int count = 0;
            while (temp!= null)
            {
                count++;
                temp = temp.Next;
            }
            Console.WriteLine($"Books Count: {count}");
        }
    }
}
