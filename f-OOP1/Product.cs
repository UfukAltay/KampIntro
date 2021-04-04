using System;
using System.Collections.Generic;
using System.Text;

namespace f_OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } // Kod okunurluğunu artırmak için bu tür değişkenleri (foreign key) ikinci sırada yazarız. Bu bir kural değildir ancak faydalıdır.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock /*Ürün stok adedi*/ { get; set; }

        // CRUD operasyonları - Create, Read, Update, Delete
    }
}
