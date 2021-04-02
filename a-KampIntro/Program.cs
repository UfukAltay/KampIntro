using System;

namespace a_KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# ve Java "type safety" (Tip güvenliği) yüksek dillerdir. Yani değişken tanımlarken başına o değişkenin ne olduğunu belirtmeniz, ayrıca tanımlamanın sonuna da ; noktalı virgül koymanız gerekmektedir.

            // Do not repeat yourself - Kendini tekrar etme - Programlamadaki en temel unsurlardan biridir.

            string kategoriEtiketi = "Kategori"; // Burada kategorEtiketi bir değer tutucudur (alias = takma ad). string metinsel ifadeler tutan bir değişken türüdür.
            int ogrenciSayisi = 32000; // Tam sayı türünden değer tutan değişken türüdür.
            double faizOrani = 1.45; // Ondalıklı sayı türünden değer tutan değişken türüdür.
            bool sistemeGirisYapmisMi = false; // true yada false değerlerini tutan değişken türüdür.
            double dolarDun = 7.35;
            double dolarBugün = 7.45;

            if (dolarDun > dolarBugün)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugün)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            // Sayfa1
            Console.WriteLine(kategoriEtiketi);

            // Sayfa2
            Console.WriteLine(kategoriEtiketi);

            // Sayfa3
            Console.WriteLine(kategoriEtiketi);

            // Sayfa4
            Console.WriteLine(kategoriEtiketi);

            // Sayfa5
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
