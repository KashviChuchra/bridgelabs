using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Inheritance
{
    internal class Book
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Publication Year: {PublicationYear}");

        }
    }
    internal class  Author: Book 
    {
        public string Name { get; set; }
        public string Bio { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("=================================================");
            Console.WriteLine($"Author: {Name}");
            Console.WriteLine($"Bio: {Bio}");
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Publication Year: {PublicationYear}");

        }


    }
}
