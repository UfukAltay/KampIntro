using System;
using System.Collections.Generic;

namespace k_OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demek ki Interface ler de onu implemente eden class ın referansını tutabiliyormuş.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });//İster konut, ister taşıt, ister ihtiyaç kredisi gönder. Logger olarak ta ister database ister file yazabiliriz.

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
