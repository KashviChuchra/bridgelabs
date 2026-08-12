using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class MovieNode
    {
        public string MovieTitle;
        public string Director;
        public int YearOfRelease;
        public double Rating;
        public MovieNode Next;
        public MovieNode Prev;

        public MovieNode(string movieTitle, string director, int yearOfRelease, double rating)
        {
            MovieTitle = movieTitle;
            Director = director;
            YearOfRelease = yearOfRelease;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }
    internal class MovieManagementSystem
    {
        MovieNode head;
        public void InsertAtBeginning(string movieTitle, string director, int yearOfRelease, double rating)
        {
            MovieNode newNode = new MovieNode(movieTitle,director, yearOfRelease, rating);
            if (head == null) head = newNode;
            else
            {
                newNode.Next = head;
                head.Prev=newNode;
                head = newNode;
            }
        }

        public void InsertAtEnd(string movieTitle, string director, int yearOfRelease, double rating)
        {
            MovieNode newNode =new MovieNode(movieTitle, director, yearOfRelease, rating);

            if (head == null)
            {
                head = newNode;
                return;
            }

            MovieNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
            newNode.Prev = temp;
            newNode.Next = null;

        }

        public void InsertAtIndex(int position, string movieTitle, string director, int yearOfRelease, double rating)
        {
            int count = 0;
            MovieNode temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            if (position == 1) InsertAtBeginning(movieTitle, director, yearOfRelease, rating);
            else if (position == count + 1) InsertAtEnd(movieTitle, director, yearOfRelease, rating);
            else if (position > count || position<=0) Console.WriteLine("Position Doesn't exist");
            else
            {
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    temp = temp.Next;
                }
                MovieNode newNode = new MovieNode(movieTitle, director, yearOfRelease, rating);
                newNode.Next = temp.Next;
                newNode.Next.Prev = newNode;
                temp.Next = newNode;
                newNode.Prev = temp;
            }

        }

        public void DeleteNode(string movieTitle)
        {
            MovieNode temp = head;
            MovieNode prev = null;
            while (temp!=null && temp.MovieTitle != movieTitle)
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Movie doesn't exist");
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
        public void SearchMovie(string director)
        {
            MovieNode temp = head;
            bool isFound = false;
            while (temp != null)
            {
                if (temp.Director == director)
                {
                    Console.WriteLine($"Found Movie. Details: {temp.MovieTitle},{temp.Director},{temp.Rating},{ temp.YearOfRelease}");
                    isFound = true;
                }
                temp = temp.Next;
            }
            if(!isFound)    Console.WriteLine(" Movie Title doesn't exist");
        }
        public void SearchMovie_Rating(double rating)
        {
            MovieNode temp = head;
            bool isFound = false;

            while (temp != null)
            {
                if (temp.Rating == rating)
                {
                    Console.WriteLine($"Found Movie. Details: {temp.MovieTitle},{temp.Director},{temp.Rating},{temp.YearOfRelease}");
                    isFound = true;
                }
                temp = temp.Next;
            }
            if(!isFound)    Console.WriteLine(" Movie Title doesn't exist");
        }

        public void UpdateMovieRating(string movieTitle, double rating)
        {
            MovieNode temp = head;
            while (temp != null)
            {
                if (temp.MovieTitle == movieTitle)
                {
                    temp.Rating = rating;
                    return;
                }
                temp = temp.Next;
            }
        }
        public void DisplayForwardOrder()
        {
            Console.WriteLine("Displaying Movie Details in Forward Order");
            MovieNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"{temp.MovieTitle},{temp.Director},{temp.Rating},{temp.YearOfRelease}");
                temp = temp.Next;
            }
        }
        public void DisplayBackwardOrder()
        {
            Console.WriteLine("Displaying Movie Details in Backward Order");

            MovieNode temp = head;
            while (temp.Next != null)
            {
                temp=temp.Next;
            }
            while (temp != null)
            {
                Console.WriteLine($"{temp.MovieTitle},{temp.Director},{temp.Rating},{temp.YearOfRelease}");
                temp = temp.Prev;
            }
        }
    }

}
//Add a movie record at the beginning, end, or at a specific position.
//Remove a movie record by Movie Title.
//Search for a movie record by Director or Rating.
//Display all movie records in both forward and reverse order.
//Update a movie's Rating based on the Movie Title.

