using System;
using System.Collections.Generic;
using System.Text;

namespace class_objects2
{
    class Book
    {
        protected string Title { get; set; }
        private string Author { get; set; }
        public int Price { get; set; }
        public int ISBN { get; set; }
        public bool Available { get; set; }

        public void setAuthorName(string authorName)
        {
            this.Author = authorName;
        }
        public string getAuthorName() { return this.Author; }
        public void setTitleName(string Title) { this.Title = Title; }    
        public string getTitleName() { return this.Title; }
        public Book()
        {
            Title = string.Empty;
            Author = string.Empty;
            Price = 0;
            Available = true;
        }
        public Book(string title, string author, int price)
        {
            Title = title;
            Author = author;
            Price = price;
            Available = true;
        }
        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"{Title} is borrowed");
            }
            else
            {
                Console.WriteLine($"{Title} is not available");
            }
        }
        public void displayDetails()
        {
            Console.WriteLine("===============================================");
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nPrice:{Price}");
        }
    }

    class EBook: Book
    {
        public void display()
        {
            Console.WriteLine("==============================");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
        }
    }
}
