using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ICS_employees.Validation;
using ICS_employees.Structures;

namespace ICS_employees.Forms
{
    public partial class frmMain : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter sqlDataAdapter = null;

        private DataTable table = new DataTable();

        private List<Employee> employees = new List<Employee>();

        private bool employeeAdded = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void ReadSingleRow(DataGridView dgw, Employee emp)
        {
            dgw.Rows.Add(new object[] {emp.Id, imageList1.Images[0], emp.Name, emp.Surname, emp.Position, emp.Birthday.ToShortDateString(), emp.Salary});
        }

        private DataTable GetTableOnRequest(string request)
        {
            sqlDataAdapter = new SqlDataAdapter(request, sqlConnection);

            table = new DataTable();

            sqlDataAdapter.Fill(table);

            return table;

        }
        private void LoadDatagrid(DataGridView dgw)
        {
            table = GetTableOnRequest("SELECT * FROM Employees");

            foreach (DataRow row in table.Rows)
            {
                var employee = new Employee((Convert.ToInt32(row["ID"])), row["Name"].ToString(), row["Surname"].ToString(), Convert.ToDateTime(row["Birthday"]), row["Position"].ToString(), Convert.ToInt32(row["Salary"]));
                employees.Add(employee);
                ReadSingleRow(dgw, employee);
            }
        }
        private void RefreshDatagrid(DataGridView dgw)
        {
            foreach (Employee emp in employees)
                ReadSingleRow(dgw, emp);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employees_db"].ConnectionString);
            sqlConnection.Open();

            LoadDatagrid(dataGridView);

            sqlConnection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            employeeAdded = true;
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand(
                    "INSERT INTO [Employees] (Name, Surname, Birthday, Position, Salary) VALUES (@Name, @Surname, @Birthday, @Position, @Salary)",
                    sqlConnection);

                var dateError = Validator.DateValidation(Birthday_txtBox.Text);
                var salaryError = Validator.SalaryValidation(Salary_txtBox.Text);

                if (salaryError == null && dateError == null)
                {
                    command.Parameters.AddWithValue("Name", Name_txtBox.Text);
                    command.Parameters.AddWithValue("Surname", Surname_txtBox.Text);
                    command.Parameters.AddWithValue("Birthday", Convert.ToDateTime(Birthday_txtBox.Text));
                    command.Parameters.AddWithValue("Position", Position_txtBox.Text);
                    command.Parameters.AddWithValue("Salary", Convert.ToInt32(Salary_txtBox.Text));

                    command.ExecuteNonQuery();

                    table = GetTableOnRequest("SELECT TOP 1 * FROM Employees ORDER BY ID DESC");

                    foreach (DataRow row in table.Rows)
                    {
                        var employee = new Employee((Convert.ToInt32(row["ID"])), row["Name"].ToString(), row["Surname"].ToString(), Convert.ToDateTime(row["Birthday"]), row["Position"].ToString(), Convert.ToInt32(row["Salary"]));
                        employees.Add(employee);
                        ReadSingleRow(dataGridView, employee);
                    }
                    MessageBox.Show("Employee added");

                    ErrorLabel.Text = null;

                    foreach (Control c in Controls)
                    {
                        var allTextBoxes = ChildControls.GetChildControls<TextBox>(c);
                        foreach (TextBox tb in allTextBoxes)
                            tb.Text = null;
                    }
                }
                else
                {
                    ErrorLabel.Text = dateError + '\n' + salaryError;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error");
            }
            finally
            {
                employeeAdded = false;
                sqlConnection.Close();
            }
        }


        private void deleteRow()
        {
            int index = dataGridView.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView.Rows[index].Cells["ID"].Value);

            sqlConnection.Open();

            var command = new SqlCommand("DELETE FROM Employees WHERE ID = @id", sqlConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.ExecuteNonQuery();

            sqlConnection.Close();  

            dataGridView.Rows.RemoveAt(index);


        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void Search_Position(DataGridView dgw)
        {
            bool dgwCLear = false;
            foreach (Employee emp in employees)
            {
                if (emp.Position == Filter_txtBox.Text.ToString())
                {
                    if (!dgwCLear)
                    {
                        dataGridView.Rows.Clear();
                        dgwCLear = true;
                    }
                    ReadSingleRow(dgw, emp);
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search_Position(dataGridView);
        }

        private void Filter_txtBox_TextChanged(object sender, EventArgs e)
        {
            if (Filter_txtBox.Text.ToString() == String.Empty && dataGridView.RowCount != employees.Count && !employeeAdded)
            {
                dataGridView.Rows.Clear();
                RefreshDatagrid(dataGridView);
            }
        }
    }
}
