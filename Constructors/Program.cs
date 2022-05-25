using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer = new Customers(1,"alper","aktaş");
            //Console.WriteLine(customer.Name);
            CustomerManager<string> manager = new CustomerManager<string>();
            manager.Add("alper");
            manager.Add("türker");
            

        }
    }
}
