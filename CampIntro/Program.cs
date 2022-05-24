using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            String KategoriEtiketi = "kategori";
            //type safety = tip güvenliği
            // tek tırnak içinde string yazılır
            Console.WriteLine(KategoriEtiketi);
            int ogrenciSayisi = 320000;
            double faizOranı = 1.45;
            bool sistemeGiris = false;
            double dolarBugun = 7.50;
            double dolarDun = 7.80;
            if (sistemeGiris == false)
            {
                Console.WriteLine("sa");

            }
            else
            {
                Console.WriteLine("as"); 
            }
            if (dolarBugun < dolarDun)
            {
                Console.WriteLine("dolar düştü");
            }else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("dolar yükseldi");
            }
            else
            {
                Console.WriteLine("dolar kuru deişmedi");
            }
        }
    }
}
