using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{


    public abstract class Vehicle
    {
        public abstract void Drive();
    }

    public class Car : Vehicle
    {
        public override void Drive() => Console.WriteLine("Drive a car");
    }

    public class Truck : Vehicle
    {
        public override void Drive() => Console.WriteLine("Drive a truck");
    }

}
