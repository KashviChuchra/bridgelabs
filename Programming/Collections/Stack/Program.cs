using System;
namespace Stack;

class Program
{
    public static void Main(string[] args)
    {
        //ImplementStackUsingArray stack = new ImplementStackUsingArray(5);
        //Console.WriteLine(stack.IsFull());
        //Console.WriteLine(stack.IsEmpty());

        //stack.Push(1);
        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(5);
        //stack.Push(6);
        //Console.WriteLine(stack.Pop());
        //Console.WriteLine(stack.Pop());
        //Console.WriteLine(stack.Peek());

        ImplementStackUsingLinkedList stack = new ImplementStackUsingLinkedList();
        stack.Push(1);
        stack.Push(1);
        stack.Push(2);
        stack.Push(5);
        stack.Push(6);
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Peek());




    }
}