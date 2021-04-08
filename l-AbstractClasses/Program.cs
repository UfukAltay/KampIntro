using System;

namespace l_AbstractClasses
{
    class Program
    {

        //SENARYO
        //Starbucks ve Nero firmaları içinyönetimi yapan bir sistem yazmak istiyoruz.
        //İki firma da müşterilerini veri tabanına kaydetmek istiyor.
        //Starbucks müşterileri kaydederken, mutlaka mernis doğrulaması istiyor. Buna karşılık Nero böyle bir şey istemiyor.
        //Starbucks müşterileri için her kahve alımında yıldız kazandırmak istiyor ama Nero da böyle bir istek yok.
             

        //Abstract sınıflarda metot bildirimi yapabilmek için erişim belirtecinden sonra “abstract” anahtar sözcüğünü yazmamız gerekmektedir.

        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985), FirstName = "Ufuk", LastName = "ALTAY", NationalityId = "54331490504" });
            Console.ReadLine();
        }
    }

    abstract class MevzuatBase  // Abstract sınıflarda birer sınıftırlar. İnterfaceler ile virtual metotların birleşimi gibi düşünebiliriz. Abstractlarda tamamlanmış yada tamamlanmamış operasyonlar bulunabilir. Dolayısıyla Newlenemezler. Tamamen Inheritance amacıyla kullanılır.
    {
        protected MevzuatBase() //Constructor bloğu içerebilirler ancak protected olabilir.
        {

        }

        public abstract void Degerlendir(); // Bu tamamlanmamış metotdur ve her operasyonda farklı olabilir.
        public void Kaydet() // Ama buradakki gibi yazıldığında kaydetme bütün işlemlerde aynı olacak demektir. Bu tamamlanmış metottur.
        {
            Console.WriteLine("Kaydedildi");
        }
    }

    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A Mevuzatına göre değerlendirildi");
        }
    }

    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B Mevuzatına göre değerlendirildi");
        }
    }


    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Eklendi");
        }
        public void Delete()
        {
            Console.WriteLine("Silindi");
        }
    }
}
