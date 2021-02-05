using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concreate
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        public override void Save(Customer customer)
        {
            base.Save(customer);
        }
    }
}
