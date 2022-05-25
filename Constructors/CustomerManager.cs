using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class CustomerManager <T>
    {
        T[] items;
        public CustomerManager()
        {
            items = new T[0];
        }
        


        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                
                tempArray[i] = items[i];
                
                
            }
            items[items.Length - 1] = item;

            Console.WriteLine("müşteri eklendi");
            Console.WriteLine(items[items.Length - 1]);
            Console.WriteLine(items[0]);
            
        }

        

       }
        

    }

