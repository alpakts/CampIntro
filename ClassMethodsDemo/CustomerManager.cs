using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsDemo
{
    class CustomerManager
    {
        

        public void add(Customers customer)
        {
            Console.WriteLine("müşteri eklendi :" + customer.customerName);
        }
        public void delete(Customers customer)
        {
            Console.WriteLine("müşteri silindi:" + customer.customerName);

        }
        public void listIt(Customers customer)
        {
            Console.WriteLine("müşterielr listelendi :" + customer.customerName) ;
            
            
            {

            }
        }
    }
}
