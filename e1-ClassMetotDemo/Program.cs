using System;

namespace e1_ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            Console.Write("Lütfen müşteri adını yazınız : ");
            musteri1.Adi = Console.ReadLine();

            Console.Write("Lütfen müşteri soyadını yazınız : ");
            musteri1.Soyadi = Console.ReadLine();

            Console.Write("Lütfen müşteri türünü yazınız (B)ireysel / (K)urumsal : ");
            musteri1.MusteriTipi = Console.ReadLine();

            musteriManager.Ekle(musteri1);

            //Musteri[] musteriler = new Musteri[] {musteri1};

            musteriManager.Listele(musteri1);

            musteriManager.Sil((musteri1));
        }

    }
}
