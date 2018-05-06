using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonData
{
    public class Person
    {
        public Person(string firstname, string lastname, Address address)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
        }

        public Person()
        {
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Address Address { get; set; }
    }
}
