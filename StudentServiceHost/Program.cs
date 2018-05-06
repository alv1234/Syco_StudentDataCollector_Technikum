using StudentServiceDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StudentServiceHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WcfServiceDefinition));
            host.Open();
            Console.WriteLine("Student Service Host started");
            Console.ReadLine();
        }
    }
}
