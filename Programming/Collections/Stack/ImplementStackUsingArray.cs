using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class ImplementStackUsingArray
    {
        private int[] arr;
        private int top;
        public ImplementStackUsingArray(int size)
        {
            arr = new int[size];
            this.top = -1;
        }
        public void Push(int element)
        {
            if (!IsFull())
            {
                arr[++top]= element;
                Console.WriteLine($"{element} pushed!");
                return;
            }            
        }
        public int Pop()
        {
            if (!IsEmpty())
            {
                return arr[top--];
            }
            Console.WriteLine("Array is Empty. Can't Remove!");
            return -1;
        }
        public int Peek()
        {
            if (!IsEmpty())
            {
                return arr[top];
            }
            Console.WriteLine("Array is Empty");
            return -1;
        }
        public bool IsEmpty()
        {
            return top==-1;
        }
        public bool IsFull()
        {
            return arr.Length== top;
        }
    }
}
