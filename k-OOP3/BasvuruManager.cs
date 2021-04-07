using System;
using System.Collections.Generic;
using System.Text;

namespace k_OOP3
{
    class BasvuruManager
    {
        // Method Injection - Aşağıda bu işlemi yapıyoruz.
        public void BasvuruYap(List<IKrediManager> krediManagers, List<ILoggerService> loggerServices) // IKrediManager diğer tüm kredilerine referansını tuttuğu için onu buraya parametre olarak vererek aslında tüm krediler için başvurma imkanımız doğmuş olur.
        {
            // Başvuran bilgilerini değerlendirme


            // KonutKrediManager burada çalışır sorun yok ama bunu burada yazmamız demek, tüm başvuru yapanları konut kredisi olarak değerlendiriyorsun demek olur.
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            foreach (var krediManager in krediManagers)
            {
                krediManager.Hesapla(); //İster konut, ister taşıt, ister ihtiyaç kredisi gönder
            }
            //krediManager.Hesapla();   List<> yapmaz isek bu satırı kullanabiliriz.
            
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
