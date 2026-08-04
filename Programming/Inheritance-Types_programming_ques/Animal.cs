using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Animal
    {
        public string name;
        public int age;
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
    class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Chirps");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}

