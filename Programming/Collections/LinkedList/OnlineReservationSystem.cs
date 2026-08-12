using System;

namespace LinkedList
{
    class TicketNode
    {
        public int TicketId;
        public string CustomerName;
        public string MovieName;
        public int SeatNumber;
        public DateTime BookingTime;
        public TicketNode Next;

        public TicketNode(int ticketId, string customerName, string movieName, int seatNumber, DateTime bookingTime)
        {
            TicketId = ticketId;
            CustomerName = customerName;
            MovieName = movieName;
            SeatNumber = seatNumber;
            BookingTime = bookingTime;
            Next = null;
        }
    }

    internal class OnlineReservationSystem
    {
        TicketNode head;

        public bool IsTicketIdUnique(int ticketId)
        {
            if (head == null)
                return true;

            TicketNode temp = head;
            do
            {
                if (temp.TicketId == ticketId)
                {
                    Console.WriteLine("Ticket ID already exists");
                    return false;
                }

                temp = temp.Next;

            } while (temp != head);

            return true;
        }

        public void AddTicket(int ticketId, string customerName, string movieName, int seatNumber, DateTime bookingTime)
        {
            if (!IsTicketIdUnique(ticketId))
                return;

            TicketNode newNode = new TicketNode(ticketId, customerName, movieName,seatNumber,bookingTime);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                return;
            }

            TicketNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
        }

        public void RemoveTicketById(int ticketId)
        {
            if (head == null)
            {
                Console.WriteLine("Tcket Id Not Presnet");
                return;
            }

            TicketNode temp = head;
            TicketNode prev = null;

            if (head.TicketId == ticketId)
            {
                if (head.Next == head)
                {
                    head = null;
                    return;
                }
                TicketNode last = head;

                while (last.Next != head)
                {
                    last = last.Next;
                }

                head = head.Next;
                last.Next = head;

                return;
            }

            do
            {
                prev = temp;
                temp = temp.Next;

            } while (temp != head && temp.TicketId != ticketId);

            if (temp == head)
            {
                Console.WriteLine("Ticket ID doesn't exist.");
                return;
            }

            prev.Next = temp.Next;
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked");
                return;
            }

            TicketNode temp = head;

            do
            {
                Console.WriteLine($"{temp.TicketId} {temp.CustomerName} {temp.MovieName} " +$"{temp.SeatNumber} {temp.BookingTime}");

                temp = temp.Next;

            } while (temp != head);
        }

        public void SearchByCustomerName(string customerName)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available.");
                return;
            }

            TicketNode temp = head;
            bool isFound = false;

            do
            {
                if (temp.CustomerName == customerName)
                {
                    Console.WriteLine($"Found Ticket: {temp.TicketId}, {temp.CustomerName}, {temp.MovieName}, {temp.SeatNumber}, {temp.BookingTime}");

                    isFound = true;
                }

                temp = temp.Next;

            } while (temp != head);

            if (!isFound)
                Console.WriteLine("Customer doesn't have any booked ticket.");
        }

        public void SearchByMovieName(string movieName)
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available.");
                return;
            }

            TicketNode temp = head;
            bool isFound = false;

            do
            {
                if (temp.MovieName == movieName)
                {
                    Console.WriteLine($"Found Ticket: {temp.TicketId}, {temp.CustomerName}, {temp.MovieName}, {temp.SeatNumber}, {temp.BookingTime}");

                    isFound = true;
                }

                temp = temp.Next;

            } while (temp != head);

            if (!isFound)
                Console.WriteLine("Movie doesn't have any booked ticket.");
        }

        public void CountTickets()
        {
            if (head == null)
            {
                Console.WriteLine("Total Booked Tickets: 0");
                return;
            }

            int count = 0;
            TicketNode temp = head;

            do
            {
                count++;
                temp = temp.Next;

            } while (temp != head);

            Console.WriteLine($"Total Booked Tickets: {count}");
        }
    }
}