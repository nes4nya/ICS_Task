using ICS_employees.Structures;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS_employees.Forms
{
    public partial class frmPrint : Form
    {
        private List<SalaryByPosition> sbPositions= new List<SalaryByPosition>();

        private List<Employee> employees = new List<Employee>();
        public frmPrint(List<Employee> emp)
        {
            InitializeComponent();
            employees = emp;
        }

        private void frpPrint_Load(object sender, EventArgs e)
        {
            reportViewer.LocalReport.DataSources.Clear();
            sbPositions = GetsbPositions(employees);
            ReportDataSource source = new ReportDataSource("DataSetByPosition", sbPositions);
            string reportPath = GetPathToReport();
            reportViewer.LocalReport.ReportPath = reportPath + @"PositionReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(source);
            reportViewer.RefreshReport();
        }
        private List<SalaryByPosition> GetsbPositions(List<Employee> emps)
        {
            var appliancesByType = emps
            .GroupBy(item => item.Position)
            .ToDictionary(grp => grp.Key, grp => grp.ToList());

            List<string> PositionTypes = appliancesByType.Keys.ToList();
            List<SalaryByPosition> sbPos = new List<SalaryByPosition>();

            foreach (string pos in PositionTypes)
            {
                int AvarageSalary = emps.Where(p => p.Position == pos).Sum(p => p.Salary)/emps.Where(p => p.Position == pos).Count();
                sbPos.Add(new SalaryByPosition(pos, AvarageSalary));
            }

            return sbPos;
        }
        private string GetPathToReport()
        {
            var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            int indexOfChar = appDir.IndexOf("\\bin");
            appDir = appDir.Remove(indexOfChar, appDir.Length - indexOfChar);

            return appDir + @"\Report\";
        }
    }
}