using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //violates principle
    internal class Programmer1
    {
        public void Work() {
            Console.WriteLine("worker working...");
        }
    }

    internal class Department1
    {
        //here problem is WorkEmplooye method depends on Programmer class object directly
        public void WorkEmplooye(Programmer1 pr)
        {
            pr.Work();
        }
    }


    //correct one

    interface IEmplooye
    {
        void Work();
    }
    internal class Programmer2 : IEmplooye
    {
        public void Work()
        {
            Console.WriteLine("worker working...");
        }
    }

    internal class Designer : IEmplooye
    {
        public void Work()
        {
            Console.WriteLine("Designer working");
        }
    }

    internal class Department2
    {
        //here problem is WorkEmplooye method depends on Programmer class object directly
        public void WorkEmplooye(IEmplooye pr)
        {
            pr.Work();
        }
    }

}
