using System;
using System.Collections.Generic;
using System.Text;

namespace f_OOP1
{
    class ProductManager // Bu şekilde bir isimlendirme görürsek, yani Manager la biten, anlamalısın ki onunla ilgili operasyonların yazıldığı bir class içerisindesindir. Yani burada ProductManager classında Productla ilgili operasyonlar yapılacaktır, örneğin (CRUD) ekleme, silme, güncelleme işlemleri gibi...
    {
        public void Add(Product product) // void - sadece emir kipli işler yapar. Yani git, yap, bitir
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        public int Topla(int sayi1, int sayi2) // Burada void yerine int kullanmamızın sebebi işlemden gelen değeri sonra kullanacaksak void haricinde bir tanımlamaya ihtiyacımız var.
        {
            return sayi1 + sayi2; // Döndürülen değere sonradan ihtiyaç duyacaksak return kullanmalıyız.
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
