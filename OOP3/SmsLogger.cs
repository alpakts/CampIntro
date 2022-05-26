using System;

namespace OOP3
{
    class SmsLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms'e loglandı");
        }
    }
}
