using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class PerCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("ihtiyaç kredisi kodları");
        }

        public void pay()
        {
            throw new NotImplementedException();
        }
    }
}
