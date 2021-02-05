using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {   //virtual ile ezdik çünkü Starbucks'a özel bir durum var. Yani Mernis doğrulaması ekleyeceğiz save operasyonuna.
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db: " + customer.FirstName);
        }
    }
}
