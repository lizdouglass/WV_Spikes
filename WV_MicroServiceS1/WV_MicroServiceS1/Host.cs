using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using Nancy;
using Nancy.Hosting.Wcf;

namespace WV_MicroServiceS1
{
    public class Host
    {
        private static readonly Uri BaseUri = new Uri("http://localhost:8000/");

        static void Main()
        {
            using (CreateAndOpenWebServiceHost())
            {
                Console.WriteLine("Service is now running on: {0}", BaseUri);
                Console.ReadLine();
            }
        }

        private static WebServiceHost CreateAndOpenWebServiceHost()
        {
            var host = new WebServiceHost(
                new NancyWcfGenericService(new DefaultNancyBootstrapper()),
                BaseUri);

            host.AddServiceEndpoint(typeof(NancyWcfGenericService), new WebHttpBinding(), "");
            host.Open();

            return host;
        }
    }
}
