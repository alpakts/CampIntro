using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Örnek: 1-100 arasındaki sayıların toplamını While Döngüsü kullanarak yapınız.
            int toplam = 0;
            int i = 0;

            while (i < 100)
            {
                toplam += i;
                i++;
            }

            Console.WriteLine("1-100 arası sayıların toplamı : " + toplam);
            //Örnek: Kullanıcının girmiş olduğu sayının basamak sayısını While Döngüsü kullanarak bulan programı yapınız.
            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamak = 0;

            while (sayi > 0)
            {
                basamak++;
                sayi = sayi / 10;
            }

            Console.WriteLine("Girdiğiniz sayı " + basamak.ToString() + "basamaklıdır.");
        }
    }
}
