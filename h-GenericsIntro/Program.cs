using System;

namespace h_GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); // Burada listeyi string türünde belirledik, isimler.Add dediğimizde değer olarak string bir değer vermemiz gerekiyor. İstersen listeyi int türünde de oluşturabilirdik.
            isimler.Add("Ufuk");

            Console.WriteLine("Hello World!");

            MyDictionary<int, string> musteriler = new MyDictionary<int, string>();

            musteriler.Add(111, "Ufuk");
            musteriler.Add(222, "Zeliha");
            musteriler.Add(333, "Defne");

            musteriler.ToList();

        }
    }
}
