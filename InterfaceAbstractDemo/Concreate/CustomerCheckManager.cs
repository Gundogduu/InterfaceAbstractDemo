using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concreate
{   //bu bizim kendi servisimiz. Test ortamında kullanacağımız zaman direkt bunu kullanabilirim 
    public class CustomerCheckManager : ICustomerCheckService
    {
        
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
