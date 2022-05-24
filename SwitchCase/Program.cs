using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // değişkenin durumuna göre if bloğu gibi çalışır  
            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            // Outputs "Looking forward to the Weekend."



        }
    }
}
