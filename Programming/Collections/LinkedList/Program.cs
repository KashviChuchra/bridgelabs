using System;
using System.Xml.Linq;
namespace LinkedList;


class Program
{
    static void Main(string[] args)
    {

        //LinkedList<int> l = new LinkedList<int>();

        //l.AddLast(10);
        //l.AddLast(20);
        //l.AddLast(30);
        //LinkedListNode<int> node = l.Find(20);
        //l.AddAfter(node, 25);



        //MyLinkedList list = new MyLinkedList();
        //list.InsertAtBeginning(10);
        //list.InsertAtBeginning(20);
        //list.InsertAtBeginning(30);
        //list.InsertAtBeginning(40);
        //list.InsertAtBeginning(50);


        //list.InsertAtEnd(32);
        //list.InsertAtEnd(12);
        //list.InsertAtEnd(40);

        //list.InsertAtIndex(4,11);

        //list.DeleteNode(30);

        //list.Display();


        //StudentRecordManagement list = new StudentRecordManagement();
        //list.InsertAtBeginning(1,"Aryan",21,'A');
        //list.InsertAtBeginning(2, "Bhumi", 20, 'D');
        //list.InsertAtBeginning(3, "Catherine", 18, 'A');
        //list.InsertAtBeginning(4, "Deepansh", 20, 'B');
        //list.InsertAtBeginning(5, "Elli", 21, 'A');
        //list.InsertAtEnd(6, "Firoz", 21, 'B');
        //list.InsertAtEnd(7, "Gia", 21, 'B');
        //list.InsertAtEnd(8, "Himanshi", 20, 'D');
        //list.InsertAtPosition(4, 1, "Iia", 21, 'A');
        //list.DeleteNode(7);
        //list.SearchStudent(4);
        //list.UpdateStudentGrade(3, 'F');
        //list.Display();

        //MovieManagementSystem movie=new MovieManagementSystem();
        //movie.InsertAtBeginning("Movie1", "D1", 2001, 5.6);
        //movie.InsertAtBeginning("Movie2", "D2", 2011, 8.6);
        //movie.InsertAtBeginning("Movie3", "D3", 2013, 5.9);
        //movie.DisplayForwardOrder();

        //movie.InsertAtEnd("Movie4", "D4", 2011, 4);
        //movie.InsertAtEnd("Movie5", "D5", 2001, 4.9);
        //movie.InsertAtIndex(2, "Movie6", "D6", 1993, 5.9);
        //movie.DisplayForwardOrder();

        //movie.SearchMovie("D3");
        //movie.SearchMovie("D9");
        //movie.SearchMovie_Rating(4);
        //movie.SearchMovie_Rating(3);
        //movie.UpdateMovieRating("Movie1", 6);
        //movie.DisplayForwardOrder();



        //TaskScheduler task=new TaskScheduler();
        //task.InsertAtBeginning(1, "A", 10, new DateTime(2026, 12, 21));
        //task.InsertAtBeginning(2, "B", 10, new DateTime(2026, 12, 14));
        //task.InsertAtBeginning(3, "C", 10, new DateTime(2026, 12, 1));
        //task.Display();
        //task.InsertAtEnd(4, "D", 90, new DateTime(2026, 1, 1));
        //task.InsertAtEnd(5, "E", 00, new DateTime(2026, 12, 1));
        //task.Display();
        //task.SearchTask(3);
        //task.RemoveTaskById(2);
        //task.Display();
        //task.ViewCurrentTask();
        //task.MoveToNextTask();
        //task.ViewCurrentTask();


        //InventoryManagementSystem inventory = new InventoryManagementSystem();
        //inventory.InsertAtBeginning("A", 1, 2, 100);
        //inventory.InsertAtBeginning("B", 2, 1, 200);
        //inventory.InsertAtEnd("C", 3, 3, 100);
        //inventory.InsertAtPosition(1, "D", 4, 3, 300);
        //inventory.DeleteNode(2);
        //inventory.UpdateItemQuantity(3, 9);
        //inventory.Display();
        //Sort the inventory based on Item Name or Price in ascending or descending order.


        //LibraryManagementSystem library=new LibraryManagementSystem();
        //library.InsertAtBeginning("a", "a", "Fiction", 101, "Available");
        //library.InsertAtEnd("b", "b", "Drama", 102, "Available");
        //library.InsertAtBeginning("c", "c", "Comedy", 103, "Issued");
        //library.InsertAtIndex(2, "d", "a", "Fantasy", 104, "Available");
        //library.DisplayForwardOrder();
        //library.DisplayBackwardOrder();

        //library.SearchBook_BookTitle("b");
        //library.SearchBook_BookAuthor("a");
        //library.UpdateBookStatus("a", "Issued");
        //library.DisplayForwardOrder();

        //library.RemoveBookByBookId(104);
        //library.DisplayForwardOrder();
        //library.Count();

        OnlineReservationSystem ticket = new OnlineReservationSystem();

        ticket.AddTicket(1, "a", "a", 10, new DateTime(2026, 12, 21));
        ticket.AddTicket(2, "b", "b", 11, new DateTime(2026, 12, 21));
        ticket.AddTicket(3, "c", "a", 12, new DateTime(2026, 12, 22));
        ticket.Display();
        ticket.SearchByCustomerName("b");
        ticket.SearchByMovieName("a");
        ticket.CountTickets();
        ticket.RemoveTicketById(2);
        ticket.Display();
        ticket.CountTickets();

    }
}
