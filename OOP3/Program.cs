using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager manager = new PerCreditManager();
            ICreditManager vManager = new VenichleCreditManager();
            ICreditManager iManager = new HousingLoanCreditManager();
            ILoggerService databaseLogger = new DatabaseLogger();
            ILoggerService fileLogger = new FileLogger();

            List<ILoggerService> loggers = new List<ILoggerService> { databaseLogger, fileLogger };
            ApplyManager applyManager = new ApplyManager();

            applyManager.Apply(manager,loggers);


            List<ICreditManager> credits = new List<ICreditManager> () {manager,vManager };
            
            applyManager.CreditPreInfo(credits);

        }
    }
}
