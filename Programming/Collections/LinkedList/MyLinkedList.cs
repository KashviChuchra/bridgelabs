using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class MyLinkedList
    {
        Node head;
        public void InsertAtBeginning(int value)
        {
            Node newNode = new Node(value);
            if (head == null) head = newNode;
            else
            {
                newNode.Next = head;
                head= newNode;
            }
        }

        public void InsertAtEnd(int value)
        {
            Node temp = head;
            while (temp.Next != null)
            {
                temp= temp.Next;
            }
            Node newNode = new Node(value);
            temp.Next = newNode;
            newNode.Next = null;
            
        }

        public void InsertAtIndex(int position, int value)
        {
            int count = 0;
            Node temp = head;

            while(temp!=null)
            {
                count++;
                temp= temp.Next;
            }
            if (position == 1) InsertAtBeginning(value);
            else if (position == count+1) InsertAtEnd(value);
            else if (position > count ) Console.WriteLine("Position Doesn't exist");
            else
            {
                temp = head;
                for(int i = 1; i < position-1; i++)
                {
                    temp=temp.Next;
                }
                Node newNode= new Node(value);
                newNode.Next = temp.Next;
                temp.Next= newNode;
            }

        }

        public void DeleteNode(int value)
        {
            Node temp = head;
            Node prev = null;
            while (temp.Data != value)
            {
                prev = temp;
                temp = temp.Next;
            }
            prev.Next = temp.Next;

        }
        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + "-->");
                temp= temp.Next;
            }
        }
    }
}
