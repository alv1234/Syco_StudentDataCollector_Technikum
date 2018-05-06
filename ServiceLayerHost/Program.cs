using ServiceLayerServiceDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayerHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ServiceLayerWcfServiceDefinition));
            host.Open();
            Console.WriteLine("Service Layer Host started");
            Console.ReadLine();
            
        }
    }
}
