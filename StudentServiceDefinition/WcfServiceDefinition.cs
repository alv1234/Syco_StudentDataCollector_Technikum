using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using StudentData;

namespace StudentServiceDefinition
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfServiceDefinition" in both code and config file together.
    public class WcfServiceDefinition : IWcfServiceDefinition
    {
        List<Student> students = new List<Student>();
        public List<Student> QueryStudents()
        {
            return students;
        }

        public WcfServiceDefinition()
        {
            GenerateDummyData();
        }

        private void GenerateDummyData()
        {
            students.Add(new Student("Max","Mustermann",new Address("Musterstrasse 1","Wien"),1671212));
            students.Add(new Student("Mari", "Musterfrau", new Address("Musterstrasse 2", "Villach"), 1523320));
        }
    }
}
