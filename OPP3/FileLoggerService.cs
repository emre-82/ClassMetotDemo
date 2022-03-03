using System;

namespace OPP3
{
    class FileLoggerService : ILoggerService
    {

        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }

    }
}
