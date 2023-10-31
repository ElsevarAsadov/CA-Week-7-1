using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    //here the problem is robot is not eating but it is forced to implement IWorker to solve this we can seperate Eat() function to another interface
    interface IWorker
    {
        void Work();
        void Eat();
    }

    class Worker : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working...");
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working like a robot...");
        }

        public void Eat()
        {
            // Robots don't eat, but they are forced to implement the method.
            Console.WriteLine("I don't eat. I'm a robot.");
        }
    }
}
