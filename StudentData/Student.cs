using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    public class Student
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Address Address { get; set; }
        public int StudentId { get; set; }

        public Student()
        {
        }

        public Student(string firstname, string lastname, Address address, int studentId)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            StudentId = studentId;
        }
    }
}
