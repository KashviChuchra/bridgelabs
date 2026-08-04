using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    interface IWorker
    {
        void PerformDuties();
    }
    internal class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public virtual void Info()
        {
            Console.WriteLine("=====================");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Id: {Id}");
        }
    }
    internal class Chef : Person, IWorker
    {
        public Chef(string name, int id) : base(name, id)
        {
        }
        public void PerformDuties()
        {
            Console.WriteLine("Chef is preparing the meal.");
        }

        public override void Info()
        {
            Console.WriteLine("=====================");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine("Role: Chef");
        }
    }
    internal class Waiter : Person, IWorker
    {
        public Waiter(string name, int id) : base(name, id)
        {
        }
        public void PerformDuties()
        {
            Console.WriteLine("Waiter is serving the customers.");
        }
        public override void Info()
        {
            Console.WriteLine("=====================");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine("Role: Waiter");
        }
    }

}
