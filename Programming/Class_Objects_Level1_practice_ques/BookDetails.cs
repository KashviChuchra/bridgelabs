using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Objects_level1
{
    public class BookDetails
    {
        private string title;
        private string author;
        private long price;


        public BookDetails(string t, string a, int p)
        {
            this.title = t;
            this.author = a;
            this.price = p;
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public long Price
        {
            get { return price; }
            set { price = value; }
        }

        public void display()
        {
            Console.WriteLine($"Book Title:\t{title}\nAuthor:\t{author}\nPrice:\t{Price}");
        }
    }
}
