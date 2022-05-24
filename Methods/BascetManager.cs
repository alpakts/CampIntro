using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class BascetManager
    {
        public void Add(product urun)
        {
            Console.WriteLine("sepete eklendi : " + urun.Name);

        }
        public void Add2(string productName,
            int productPrice,string productDescription,
            int stokAdetiStockAmount)
        {
            Console.WriteLine("sepete eklendi : " + productName);
        }
    }
    
}
