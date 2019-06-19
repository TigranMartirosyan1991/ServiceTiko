using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using ServiceTiko;

namespace ServiseContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri _uri = new Uri("http://Localhost:8088/ServiseRelasietion");
            BasicHttpBinding basic = new BasicHttpBinding();
            Type contract = typeof(IContract);
            ServiceHost host = new ServiceHost(typeof(ServiseRelasietion));
            host.AddServiceEndpoint(contract, basic, _uri);
            host.Open();
            Console.WriteLine("alloooo");
            Console.ReadLine();

        }
        
    }
}
