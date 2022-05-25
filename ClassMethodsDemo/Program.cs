using System;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new Customers();
            customer1.customerName = "alper ";
            customer1.customerAge = 22;
            customer1.bankRate=1.45;
            Customers customer2 = new Customers();
            customer2.customerName = "turan ";
            customer2.customerAge = 19;
            customer2.bankRate = 1.10;
            Customers customer3 = new Customers();
            customer3.customerName = "türker ";
            customer3.customerAge = 14;
            customer3.bankRate = 1;
            CustomerManager manager = new CustomerManager();
            manager.add(customer1);
            manager.delete(customer2);
            manager.listIt(customer3);
        }
    }
}
