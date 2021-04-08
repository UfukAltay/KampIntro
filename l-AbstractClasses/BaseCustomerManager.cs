using System;
using System.Collections.Generic;
using System.Text;

namespace l_AbstractClasses
{
    public abstract class BaseCustomerManager : ICustormerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı kişi veritabanına Kaydedildi ");
        }
    }
}
