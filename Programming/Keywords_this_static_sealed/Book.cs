using System;
using System.Collections.Generic;
using System.Text;

namespace keywods_this_static_sealed
{
    internal class Book
    {
        public static string libraryName="Central Library";
        public string title;
        public string author;
        public readonly int ISBN;
        public static void DisplayLibraryName()
        {
            Console.WriteLine($"Library Name: {libraryName}");
        }

        public Book(string title, string author, int iSBN)
        {
            this.title = title;
            this.author = author;
            ISBN = iSBN;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("========================================================================");
            Console.WriteLine($"Library Name: {libraryName} Title: {title} Author: {author} ISBN:{ISBN}");
        }

    }
}
