using PersonData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PersonService
{
    /// <summary>
    /// Summary description for AsmxService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AsmxService : System.Web.Services.WebService
    {
        List<Person> persons = new List<Person>();

        [WebMethod]
        public List<Person> QueryPersons()
        {
            return persons;
        }

        public AsmxService()
        {
            GenerateDummyData();
        }

        private void GenerateDummyData()
        {
            persons.Add(new Person("Massimiliano", "Esemplare",new Address("Via Toponimo 1", "Roma")));
            persons.Add(new Person("Mariella", "Esemclara", new Address("Via Topolino 2", "Trieste"))); ;
        }
    }
}
