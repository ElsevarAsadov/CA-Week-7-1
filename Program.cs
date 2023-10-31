namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order2 o = new Order2(10, 3);
            InvoicePrinter.PrintInvoice(o);

            Bird2 b = new Bird2();
            b.Fly();

            var car = new Car();
            car.Drive();

            var truck = new Truck();
            truck.Drive();

            Programmer2 pg = new();
            Designer dg = new();

            Department2  dp = new();


            dp.WorkEmplooye(pg);
            dp.WorkEmplooye(dg);


        }
    }
}