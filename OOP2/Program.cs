using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            IndCustomer customer1 = new IndCustomer();
            customer1.Name = "alper";
            customer1.Surname = "aktaş";
            customer1.Customerno = "12354";
            customer1.IdNumber = "1856541654";

            CorpCustomer customer2 = new CorpCustomer();
            customer2.Id = 2;
            customer2.Customerno = "565";
            customer2.TaxNo = "2155445";
            customer2.CompanyName = "softsof";

            Customer customer3 = new IndCustomer();
            Customer customer4 = new CorpCustomer();
            CustomerManager manager = new CustomerManager();
            manager.Add(customer4);





        }
    }
}
