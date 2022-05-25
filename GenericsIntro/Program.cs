using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("alper");
            names.Add("türker");
           
            foreach ( var  items in names.items1)
            {
                Console.WriteLine(items);
            }
        }
    }
}
