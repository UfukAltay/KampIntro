using System;

namespace f_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            // Üstteki yazım şekli bu şekilde de yazılabilir.
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };


            //case sensitive - C# büyük küçük harf duyarlı bir dildir.
            //PascalCase   //camelCase            
            ProductManager productManager = new ProductManager(); // Instance creation = Örnek oluşturma
            
            productManager.Add(product1);

        }
    }
}
