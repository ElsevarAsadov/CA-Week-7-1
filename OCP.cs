using System;


namespace ConsoleApp3
{
    //violates OCP principle
    internal class Bird1
    {
        public void Fly()
        {
            Console.WriteLine("Bird Flying");
        }
    }

    internal class ControlBird
    {
        public void Fly(Bird1 b)
        {
            b.Fly();
        }
    }

    internal abstract class FlyingEntity
    {
        public abstract void Fly();
    }
    internal class Bird2 : FlyingEntity
    {
        public override void Fly()
        {
            Console.WriteLine("Bird Flyies..");
        }
    }

    
}
