using System;
using System.Collections.Generic;
using System.Text;

namespace k_OOP3
{
    class BasvuruManager
    {
        // Method Injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) // IKrediManager diğer tüm kredilerine referansını tuttuğu için onu buraya parametre olarak vererek aslında tüm krediler için başvurma imkanımız doğmuş olur.
        {
            // Başvuran bilgilerini değerlendirme


            // KonutKrediManager burada çalışır sorun yok ama bunu burada yazmamız demek, tüm başvuru yapanları konut kredisi olarak değerlendiriyorsun demek olur.
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            krediManager.Hesapla(); //İster konut, ister taşıt, ister ihtiyaç kredisi gönder
            
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }// Hangi loglayıcı seçilmişse logla yap diyoruz.
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi  in krediler) // Tüm kredileri hesaplatıyoruz ancak program.cs de hangi krediyi göstermek istersek o görünecek
            {
                kredi.Hesapla();
            }
        }

    }
}
