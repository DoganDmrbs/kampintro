using System;
// veritabanına loglama yapıcak süreç
namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı.");
        }
    }
}
