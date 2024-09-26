using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3_1
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string EType { get; set; }

        public Employee (int id, string name, string city, string phone, string eType)
        {
            Id = id;
            Name = name;
            City = city;
            Phone = phone;
            EType = eType;
        }
    }
}
