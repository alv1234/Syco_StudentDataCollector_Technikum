using DataLayer.SR_PersonAsmx;
using DataLayer.SR_StudentWcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataServiceConsumer
    {
        List<PeopleModel> people = new List<PeopleModel>();

        public List<PeopleModel> QueryAll()
        {
            //clean alternative
            //var result = ServiceManager.CreateServiceClient<IWcfServiceDefinitionChannel>("BasicHttpBinding_IWcfServiceDefinition").QueryStudents();

            //Quick'n'dirty alternative (copy config to client exe config)
            WcfServiceDefinitionClient client = new WcfServiceDefinitionClient();
            var result = client.QueryStudents();

            foreach (var item in result)
            {
                people.Add(new PeopleModel(item.Firstname, item.Lastname, item.Address.Street, item.Address.City));
            }
            //TODO set endpoint config (here or in service layer?)
            AsmxServiceSoapClient personServiceClient = new AsmxServiceSoapClient();
            var result2 = personServiceClient.QueryPersons();
            foreach (var item in result2)
            {
                people.Add(new PeopleModel(item.Firstname,item.Lastname,item.Address.Street,item.Address.City));
            }
            return people;
        }

        public DataServiceConsumer()
        {

        }
    }
}
