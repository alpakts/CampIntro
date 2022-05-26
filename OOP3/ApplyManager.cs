using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    // dependency injections
    class ApplyManager
    {
        public void Apply( ICreditManager creditManager,List<ILoggerService> loggers)
        {
            
            //hangi classı yollarsam onun calculate metodu çalışır
            creditManager.Calculate();
            foreach (var logger in loggers)
            {
                logger.Log();
            }

        }
        public void CreditPreInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
                Console.WriteLine("the credit calculate  succesfully complete " + credit);
            }
        }
    }
}
