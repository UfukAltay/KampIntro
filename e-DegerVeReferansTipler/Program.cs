using System;

namespace e_DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ?? cevap = 30

            int[] sayilar1 = new int[] { 10, 20, 30 }; // Buradaki new, heap te bir yer oluştur demek
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0] ?? cevap = 999

            // int, decimal, float, double, bool = değer tiplerdir. Değer tipler belleğin stack alanında saklanır.
            // interface, array, class = referans tiplerdir. Referans tipler belleğin heap alanında saklanır.
            // değer tipli değişkenler, yukarıdaki sayi1 ve iki değişkenlerinde olduğu gibi sadece o değişkenin  değerini tutarlar.
            // referans tipli değişkenler ile o değişkenin bellekteki referansını tutarlar. Yani belleğin heap alanındaki değeri..
        }
    }
}
