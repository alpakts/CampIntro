using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {       // int,bool,double... değer tiptir
        // diziler,classlar,abstract classlar,interfaceler.. referans tiptir
         public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+"müşteri eklendi");

        }public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+"müşteri güncellendi");
        }
    }
}
