using System;

namespace Methods
{
    class Program
    {
        // Do not repeat yourself-clean code
        static void Main(string[] args)
        {
            product urun1 = new product();
            urun1.Name = "elma";
            urun1.Price = 15;
            urun1.Description = "amasya elması";

            product urun2 = new product();
            urun2.Name = "karpuz";
            urun2.Price = 80;
            urun2.Description = "Diyarbakır karpuzu";

            product[] urunler = new product[] {urun1,urun2};
            foreach (product urun in urunler)
            {

                Console.WriteLine(urun.Name);
                Console.WriteLine(urun.Price);
                Console.WriteLine(urun.Description);
                
            }
            Console.WriteLine("----------------------------" );
            BascetManager manager = new BascetManager();
            manager.Add(urun1);
            manager.Add(urun2);

            //encapsulation 
            manager.Add2("armut", 15, "yeşil armut",8);
            manager.Add2("elma", 15, "yeşil elma",8);
            manager.Add2("karpuz", 15, "diyarbakır karpuzu",8);
        }
    }
}
