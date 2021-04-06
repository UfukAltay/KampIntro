using System;

namespace j_OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Ufuk";
            musteri1.Soyadi = "Altay";
            musteri1.TcNo = "123456789";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "KodlamaIo";
            musteri2.VergiNo = "123456789";

            // Gerçek Müşteri - Tüzel Müşteri
            // SO L ID  -> Liskov Substitution Principle

            // Musteri class ı burada hem gerçek hem de tüzel müşteri classlarının referenlarını tutabiliyor ve aşağıdaki manager classında ekle metodunu çalıştırdığımız zaman musteri1 i ya da musteri2 yi rahatlıkla ekleyebiliyoruz.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
