using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Configuration;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ServiceManager
    {

        public static T CreateServiceClient<T>(string configName)
        {
            string _assemblyLocation = Assembly.GetExecutingAssembly().Location;
            var pluginConfig = ConfigurationManager.OpenExeConfiguration(_assemblyLocation);
            ConfigurationChannelFactory<T> channelFactory = new ConfigurationChannelFactory<T>(configName, pluginConfig, null);
            var client = channelFactory.CreateChannel();
            return client;
        }
    }
}
