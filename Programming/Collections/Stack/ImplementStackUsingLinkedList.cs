using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Node
    {
        public int value;
        public Node next;
        public Node(int value)
        {
            this.value = value;
            next = null;
        }
    }
    internal class ImplementStackUsingLinkedList
    {
        private LinkedList<int> list;
        private Node top;
        private Node head;
        
        public ImplementStackUsingLinkedList(){
            list= new LinkedList<int>();
            top = null;
            head = null;
        }

        public void Push(int element) 
        {
            Node newNode= new Node(element);
            if (head == null)
            {
                head = newNode;
                top= newNode;
                return;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp= temp.next;
            }
            temp.next= newNode;
            top= newNode;
        
        }
        public int Pop() 
        {
            if(head == null)
            {
                Console.WriteLine("Stack Empty! Can't POP");
                return head.value;
            }
            if (head.next == null) return -1;

            Node temp = head;
            Node prev = null;
            while (temp.next != null)
            {
                prev = temp;
                temp = temp.next;
            }
            Node poppedNode= top;
            prev.next = null;
            top = prev;
            return poppedNode.value;
        }
        public int Peek() 
        {
            if (head == null) return -1;
            return top.value;
        }

    }
}
