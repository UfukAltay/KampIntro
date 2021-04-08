using System;
using System.Collections.Generic;
using System.Text;

namespace l_AbstractClasses
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);    
    }
}
