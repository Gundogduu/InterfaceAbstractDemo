using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {   //burayı değiştirerek ve tcno'yu string'den long'a, doğum tarihini datetime'dan int'e cevirerek "yapılandırma hatasını" çözdük. 
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(customer.NationalityId,customer.FirstName,customer.LastName,customer.DateOfBirth)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
