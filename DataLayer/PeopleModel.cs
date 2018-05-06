using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PeopleModel
    {
        public PeopleModel()
        {
        }

        public PeopleModel(string firstname, string lastname, string street, string city)
        {
            Firstname = firstname;
            Lastname = lastname;
            Street = street;
            City = city;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

    }
}
