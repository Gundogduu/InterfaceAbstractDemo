using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concreate
{
    public class StarBucksCustomerManager : BaseCustomerManager //ICustomerCheckService'i buraya da ekleyebilirdik ama
    {   //Dependency Injection
        ICustomerCheckService _customerCheckService;

        public StarBucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        //virtual ile ezdiğimiz save metodunu buraya override ettik
        public override void Save(Customer customer)
        {   //interfaceden aldığımız CheckIfRealPerson'ı burada kullandık.
            if (_customerCheckService.CheckIfRealPerson(customer))
            {

                base.Save(customer);  //veritabanına kaydettiğimiz kod
            }
            else
            {
                throw new Exception("Not a valid person");   //mernis doğrulamazsa vereceği hata.
            }
            
        }

        //burada kullanırsak sadece bu class kullanabilir. Biz yarın başka bir class için kullanabiliriz. O yüzden bu metodu bir Interface oluşturup ondan almamız gerekiyor.
        //private void CheckIfRealPerson(Customer customer)
        //{
          //  throw new NotImplementedException();
        //}
    }
}
