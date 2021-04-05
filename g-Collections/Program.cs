using System;
using System.Collections.Generic;

namespace g_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new[] {"Engin", "Murat", "Kerem","Halil" }; // Burada kaç değer verdiysek o kadar eleman ekleyebiliriz. Yani burada 4 adet eleman ekleyebiliriz.
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            ////isimler[4] = "İlker"; // Dizilerde sonradan diziye eleman ekleme işlemi yapılamaz. Bu yazım şeklinde, çalışma zamanında hata alırız.
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]); // Bu şekilde yazdığımızda ise isimler dizisine yeni bir heap alanı, yani referans yani adres vermiş oluruz. Çalıştırdığımızda sadece İlker yazar çünkü dizinin şuan sadece 4. elemanına değer verdik, diğer elemanları boş durumdadır.
            //Console.WriteLine(isimler[0]); // Bu satırda ekrana hiçbir şey yazdırmaz çünkü bir değeri yoktur.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" }; //Listlerde ekleme yapabiliriz.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker"); // .Add ile listeye ekleme yapabilir ve sonra bir alt satırdaki gibi yazdırabiliriz.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
