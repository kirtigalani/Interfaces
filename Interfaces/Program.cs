using System;

namespace Interfaces
{
    interface ICustomer1
    {
        void print1();
    }
    interface ICustomer2 : ICustomer1
    {
        void print2();
    }
    public class Customer : ICustomer2
    {
        public void print2()
        {
            Console.WriteLine("print 2");
        }
        public void print1()
        {
            Console.WriteLine("print 1");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomer1 Cust = new Customer();
            Cust.print1();
        }
    }
}
