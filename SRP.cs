using System;

namespace ConsoleApp3
{
    //violates the SPR principle
    internal class Order1
    {
        public double Price { get; set; }
        public int Count { get; set; }
        public Order1(double price, int count)
        {
            Price = price;
            Count = count;
        }

        public double CalcTotalPrice() => Price * Count;

        public void PrintInvoice() {
            Console.WriteLine("Amount: {0} \nThanks for choosing us", CalcTotalPrice());
        }
    }

    //Correct one
    internal class Order2
    {
        public double Price { get; set; }
        public int Count { get; set; }

        public Order2(double price, int count)
        {
            Price = price;
            Count = count;
        }

        public double CalcTotalPrice() => Price * Count;

    }

    internal class InvoicePrinter
    {
        public static void PrintInvoice(Order2 order) {
            Console.WriteLine("Amount: {0} \nThanks for choosing us", order.CalcTotalPrice());
        }
    };
}
