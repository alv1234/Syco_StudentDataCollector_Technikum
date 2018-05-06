using DataLayer.SR_StudentWcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentServiceConsumer
    {
        //WcfServiceDefinitionClient client = new WcfServiceDefinitionClient();


        public List<Student> QueryStudents()
        {
            return ServiceManager.CreateServiceClient<IWcfServiceDefinitionChannel>("BasicHttpBinding_IWcfServiceDefinition").QueryStudents();
            //return client.QueryStudents();
        }

        public StudentServiceConsumer()
        {

        }
    }
}
