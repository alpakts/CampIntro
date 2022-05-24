using System;

namespace ClassIntro
{//Classlar 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin demiroğ";
            kurs1.IzlenmeOrani = 25;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "engin";
            kurs2.IzlenmeOrani = 54;
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berkay";
            kurs3.IzlenmeOrani = 75;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (Kurs  kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : " + kurs.Egitmen);
            }
            Console.WriteLine("-----------");
            Console.WriteLine(kurs1.KursAdi);
            Console.WriteLine(kurs2.KursAdi);
            Console.WriteLine(kurs3.KursAdi);

        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public  int  IzlenmeOrani{ get; set; }

        }
    }

}
