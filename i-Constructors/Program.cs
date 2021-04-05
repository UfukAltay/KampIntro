using System;

namespace i_Constructors // Constructor aslında bir class ı new lediğimizde çalışan bloktur. Bir class ilk kez oluştuğu zaman bir kere çalışır ve bir daha çalışmaz dediğimiz bloktur.
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Ufuk", LastName = "Altay", City = "İstanbul" }; // Burada newleme yaptığımızda aşağıdaki public Customer() bloğu çalışır.
            Customer customer2 = new Customer(2, "Zeliha", "Altay", "İstanbul");

            Customer customer3 = new Customer();
            customer3.Id = 3; // yazım şekli olarak customer1 = customer3

            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer() // Burayı yazarak Overloading yapmış olduk ve customer1 in bize kızmasını engellemiş olduk.
        {

        }
        // Default Constructor -> Yani biz bu bloğu yazsak ta yazmasak ta böyle bir blok oluşur ve çalışır. Biz yazdıysak bizim yazdığımız blok çalışır, yazmaz ise default olan çalışır.
        public Customer(int id, string firstName, string lastName, string city) // Constructor yazmak için ctor yazıp tab yaptığımızda class ın ismiyle bir metot oluşur. Constructor bir metot gibi çalışır. Burada metodun içerisine parametre vererek yukarıdaki customer2 nin bize kızmasını engellemiş olduk.
        {
            Console.WriteLine("Yapıcı blok çalıştı");
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
