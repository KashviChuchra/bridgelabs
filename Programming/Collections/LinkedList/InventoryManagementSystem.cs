using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class InventoryNode
    {
        public string ItemName;
        public int ItemId;
        public int Quantity;
        public int Price;
        public InventoryNode Next;
        
        public InventoryNode(string itemname,int id,int q, int price)
        {
            ItemName = itemname;
            ItemId=id;
            Quantity = q;
            Price = price;
            Next = null;
        }
    }
    internal class InventoryManagementSystem
    {
        InventoryNode head;
        public bool IsIdUnique(int id)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.ItemId == id)
                {
                    Console.WriteLine("ID already exist. Can't insert");
                    return false;
                }
                temp = temp.Next;
            }
            return true;
        }
        public void InsertAtBeginning(string itemname, int id, int q, int price)
        {
            if (IsIdUnique(id))
            {
                InventoryNode newNode = new InventoryNode(itemname, id, q, price);
                if (head == null) head = newNode;
                else
                {
                    newNode.Next = head;
                    head = newNode;
                }
            }
        }

        public void InsertAtEnd(string itemname, int id, int q, int price)
        {
            if (IsIdUnique(id))
            {
                InventoryNode newNode = new InventoryNode(itemname, id, q, price);

                if (head == null)
                {
                    head = newNode;
                    return;
                }
                InventoryNode temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = null;
            }

        }

        public void InsertAtPosition(int position,string itemname, int id, int q, int price)
        {

            int count = 0;
            InventoryNode temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            if (position == 1) InsertAtBeginning(itemname, id, q, price);
            else if (position == count + 1) InsertAtEnd(itemname, id, q, price);
            else if (position > count || position <= 0) Console.WriteLine("Position Doesn't exist");
            else
            {
                if (IsIdUnique(id))
                {
                    temp = head;
                    for (int i = 1; i < position - 1; i++)
                    {
                        temp = temp.Next;
                    }
                    InventoryNode newNode = new InventoryNode(itemname, id, q, price);
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                }
            }

        }

        public void UpdateItemQuantity(int id, int q)   
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.ItemId == id)
                {
                    temp.Quantity = q;
                    return;
                }
                temp = temp.Next;
            }
        }
        public void SearchItemId(int id)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.ItemId == id)
                {
                    Console.WriteLine(temp.ItemName + " " + temp.ItemId + " " + temp.Quantity + " " + temp.Price);
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item doesn't exist");
        }
        public void SearchItemName(string name)
        {
            InventoryNode temp = head;
            while (temp != null)
            {
                if (temp.ItemName == name)
                {
                    Console.WriteLine(temp.ItemName + " " + temp.ItemId + " " + temp.Quantity + " " + temp.Price);
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Item doesn't exist");
        }
        public void DeleteNode(int id)
        {
            InventoryNode temp = head;
            InventoryNode prev = null;
            while (temp != null && temp.ItemId != id)
            {
                prev = temp;
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Item ID doesn't exist");
                return;
            }
            if (prev == null)
            {
                head = temp.Next;
            }
            else
            {
                prev.Next = temp.Next;
            }

        }
        public void Display()
        {
            InventoryNode temp = head;
            double sum = 0;
            while (temp != null)
            {
                Console.WriteLine($"{temp.ItemName} {temp.ItemId} {temp.Quantity} {temp.Price}");
                sum += temp.Price*temp.Quantity;
                temp = temp.Next;
            }
            Console.WriteLine($"Display Total Value of Inventory: "+sum);

        }


    }
}
