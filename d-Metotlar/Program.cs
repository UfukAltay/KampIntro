using System;

namespace d_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            // type-safe -- tip güvenli -> Yani çalışacağın veri tipini söylemelisin, belirtmelisin demek
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("-----------Metotlar------------");

            // instance - örnek
            // Encapsulation (Aşağıdaki 2 örnekte, YAZIM SEKLİ 1 encapsulationdur ve yazılım dünyasında olması gereken yazım şeklidir.)
            SepetManager sepetManager = new SepetManager();

            //YAZIM ŞEKLİ 1
            // Sayfa1
            sepetManager.Ekle(urun1); // Metotlar bu şekilde çağırılır.
            // Sayfa2
            sepetManager.Ekle(urun2);

            //YAZIM ŞEKLİ 2
            // Sayfa1
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            // Sayfa2
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            // Sayfa3
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80, 8);

        }
    }
    }
}

// Don't repeat yourself = Kendini tekrar etme - DRY
// Clean Code (Temiz kod yazma teknikleri)
// Best Practice (Doğru uygulama teknikleri)