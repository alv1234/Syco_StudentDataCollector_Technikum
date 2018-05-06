﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.SR_ServiecLayerWcf;
using TestConsole.SR_StudentServiceWcf;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to test console");
            //Testing StudentServiceHost
            WcfServiceDefinitionClient studentServiceClient = new WcfServiceDefinitionClient();
            Console.WriteLine("Testing Student Service");
            var result = studentServiceClient.QueryStudents();
            Console.WriteLine(result.ToString());

            //Testing ServiceLayer Service Host
            ServiceLayerWcfServiceDefinitionClient serviceLayerServiceClient = new ServiceLayerWcfServiceDefinitionClient();
            Console.WriteLine("Testing Service Layer Service");
            var result2 = serviceLayerServiceClient.QueryStudents();
            Console.WriteLine(result2.ToString());

        }
    }
}
