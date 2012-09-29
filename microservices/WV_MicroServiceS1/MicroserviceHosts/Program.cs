using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Nancy;
using Nancy.Hosting.Wcf;

namespace MicroserviceHosts
{
    public class Host
    {
        //Remember to add  the backslash
        //private static readonly Uri BaseUri = new Uri("http://localhost:8000/");

        static void Main()
        {
            //using (CreateAndOpenWebServiceHost())
            //{
            //    Console.WriteLine("Service is now running on: {0}", BaseUri);
            //    Console.ReadLine();
            //}
        }

        private static WebServiceHost CreateAndOpenWebServiceHost()
        {
            //var host = new WebServiceHost(
            //    new NancyWcfGenericService(new DefaultNancyBootstrapper()),
            //    BaseUri);

            //host.AddServiceEndpoint(typeof(NancyWcfGenericService), new WebHttpBinding(), "");
            //host.Open();

            //return host;
            return null;
        }
    }
}
