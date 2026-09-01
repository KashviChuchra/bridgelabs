using System;
using System.Collections.Generic;
using System.Text;

namespace AnnotationReflection.Annotation
{
    internal class Animal
    {
        public Animal() { }
        public virtual void MakeSound() { Console.WriteLine("Animal sound.."); }
    }

    internal class Dog: Animal
    {
        public Dog() { }
        public override void MakeSound() { Console.WriteLine("Dog sound.."); }

    }
}
