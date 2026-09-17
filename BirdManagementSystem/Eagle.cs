using System;
using System.Collections.Generic;
using System.Text;

namespace BirdManagementSystem
{
    internal class Eagle: Bird, IRunnable, IFlyable
    {
        public Eagle() { }
        public Eagle(int id,Gender gender) : base(id,gender) { }
        public override void func() { }
        
        public void CanRun()
        {
            Console.WriteLine("Can run");
        }
        public void CanFly()
        {
            Console.WriteLine("Can Fly");
        }
    }
    internal class Ostrich : Bird, IRunnable
    {
        public Ostrich() { }
        public Ostrich(int id, Gender gender) : base(id, gender) { }
        public override void func() { }
        public void CanRun()
        {
            Console.WriteLine("Can run");
        }
    }
    internal class Duck : Bird, IRunnable,IFlyable
    {
        public Duck() { }
        public Duck(int id, Gender gender) : base(id, gender) { }
        public override void func() { }
        public void CanRun()
        {
            Console.WriteLine("Can run");
        }
        public void CanFly()
        {
            Console.WriteLine("Can Fly");
        }
    }
}
