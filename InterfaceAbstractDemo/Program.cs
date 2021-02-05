using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concreate;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarBucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer{ DateOfBirth = 1994, FirstName = "Hayri Can",
                                               LastName = "Gündoğdu", NationalityId = 21987546431});

            Console.ReadLine();
        }
    }
}
