using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class VenichleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("hesaplama kodları buraya");
        }

        public void pay()
        {
            throw new NotImplementedException();
        }
    }
}
