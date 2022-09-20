using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS_employees.Structures
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime Birthday { get; set; }

        public string Position { get; set; }

        public int Salary { get; set; }
        public Employee(int id, string name, string surname, DateTime birthday, string position, int salary)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Position = position;
            Salary = salary;
        }
    }
}
