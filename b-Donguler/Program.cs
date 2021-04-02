using System;

namespace b_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir e-ticaret sitesi yazdığınızı düşünün ve  yüzlerce hatta binlerce ürün olduğunu düşünün. Bunun için aşağıdaki gibi tek tek değişken tanımlamak pek mümkün olmayacaktır. Bu sebeple bu tür durumlarda aşağıdaki örnekteki gibi dizi (array) ya da liste (list) değişkenini kullanırız.

            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            //string kurs2 = "Programlamaya başlangıç için temel kurs";
            //string kurs3 = "Java kursu";

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java Kursu", "Python Kursu", "C# Kursu" };

            for (int i = 0; i < kurslar.Length; i++) //Burada lenght özelliği ile dizinin kaç elemanı var ise döngünün o kadar dönmesini sağlarız. Çünkü kaç kurs olduğunu bilemeyebiliriz.
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For döngüsü bitti");
            Console.WriteLine("------------------");

            foreach (string kurs in kurslar) // Dizi temelli yapıları tek tek dönmeye yarayan döngüdür. kurs burada aliastır yani takma addır, istersek kurs yerine abc ya da herhangi başka bir isim de koyabiliriz.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
