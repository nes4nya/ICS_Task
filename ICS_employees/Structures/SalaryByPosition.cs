using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS_employees.Structures
{
    internal class SalaryByPosition : IInfoPosition
    {
        public string Position { get; set; }
        public int Salary { get; set; }

        public SalaryByPosition(string position, int salary)
        {
            Position = position;
            Salary = salary;
        }
    }
}
