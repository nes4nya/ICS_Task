using ICS_employees.Structures;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS_employees.Repository
{
    public class SQLEmployeeRepository : IRepository
    {
        private SqlConnection sqlConnection = null;

        private bool disposed = false;

        public void AddEmployee(string request, Employee emp)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(
                request,
                sqlConnection);
            command.Parameters.AddWithValue("Name", emp.Name);
            command.Parameters.AddWithValue("Surname", emp.Surname);
            command.Parameters.AddWithValue("Birthday",emp.Birthday);
            command.Parameters.AddWithValue("Position",emp.Position);
            command.Parameters.AddWithValue("Salary",emp.Salary);

            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void Delete(int id)
        {
            sqlConnection.Open();

            var command = new SqlCommand("DELETE FROM Employees WHERE ID = @id", sqlConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public DataTable GetDataTable(string request)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(request, sqlConnection);

            DataTable table = new DataTable();

            sqlDataAdapter.Fill(table);

            sqlConnection.Close();
            return table;
        }

        public void SetSqlConnection(string NameDb)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[NameDb].ConnectionString);
        }
    }
}
