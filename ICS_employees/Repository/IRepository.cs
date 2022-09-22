using ICS_employees.Structures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS_employees.Repository
{
    internal interface IRepository : IDisposable
    {
        void SetSqlConnection(string NameDB);
        DataTable GetDataTable(string request);
        void AddEmployee(string request, Employee emp);
        void Delete(int id);
    }
}
