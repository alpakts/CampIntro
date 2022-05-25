using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        // sayısal veri tipleri int bool
        // decimal gibi tipler değer tiplerdir
        //array,class,interface gibi olanlar referans tiptir birbirine
        //eşitlendiğinde heriki kısımda aynı referanası tutar
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; // değer atanır
            sayi2 = 65; 
            // cevap30
            Console.WriteLine(sayi1);
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2; // referans atanır
            sayilar2[0] = 999;
            Console.WriteLine(sayilar2[0]);
            //cevap 999


        }
    }
}
