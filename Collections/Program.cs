using System;
using System.Collections.Generic;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "alper", "fatih", "turan", "türker","nurcan" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            names[4] = "Nurcan";
            Console.WriteLine(names[4]);
            //dizilerde genişleme yapmak zor olduğu için koleksiyonlar kullanılır
            List<string> names2 = new List<string> { "alper", "fatih", "turan", "türker" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            names2.Add("ilker");
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);
        }
    }
}
