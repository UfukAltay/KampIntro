using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace l_AbstractClasses
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();

            //return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);



            //KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            //Task response = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId),
            //                                              customer.FirstName.ToUpper(),
            //                                              customer.LastName.ToUpper(),
            //                                              customer.DateOfBirth.Year);
            //response.Wait();
            //return response.Result.Body.TCKimlikNoDogrulaResult;


            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            return client.TCKimlikNoDogrulaAsync(
                Convert.ToInt64(customer.NationalityId),
                customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),
                customer.DateOfBirth/*Year*/).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
