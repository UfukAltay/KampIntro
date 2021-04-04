using System;
using System.Collections.Generic;
using System.Text;

namespace e1_ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Tebrikler, müşteri sisteme eklendi");
            Console.WriteLine("-----------------------------------------");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri listeleme işlemi gerçekleştirildi");
            //Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Müşteri Adı = " + musteri.Adi);
            Console.WriteLine("Müşteri Soyadı = " + musteri.Soyadi);
            Console.WriteLine("Müşteri Türü = " + musteri.MusteriTipi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " silindi.");
            Console.WriteLine("-----------------------------------------");
        }
    }
}
