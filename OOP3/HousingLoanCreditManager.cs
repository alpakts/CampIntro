using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class HousingLoanCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("konut kredisi kodları");
        }

        public void pay()
        {
            throw new NotImplementedException();
        }
    }
}
