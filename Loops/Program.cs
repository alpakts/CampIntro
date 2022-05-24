using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //array= diziler 
            string[] kurslar = new string[] { "yazılım geliştirici kursu", 
                "programlamaya başlangıç kursu", "java" };
                

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("sayfasonu");
            //foreach dizileri te tek gezer 

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            {

            }
        }
    }
}
