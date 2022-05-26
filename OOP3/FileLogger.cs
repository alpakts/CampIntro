using System;

namespace OOP3
{
    class FileLogger : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
