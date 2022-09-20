using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICS_employees.Validation
{
    static class Validator
    {
        public static string DateValidation(string date)
        {
            try
            {
                DateTime.Parse(date);
                if (int.Parse(date.Split('.')[1]) == 2 && int.Parse(date.Split('.')[0]) == 32)
                    return ("Such a date does not exist.");
                else
                    return null;
            }
            catch (Exception)
            {
                return ("Date entered incorrectly, try a format like 19.02.2002.");
            }
        }
        public static string SalaryValidation(string date)
        {
            try
            {
                Convert.ToInt32(date);
                return null;
            }
            catch (Exception)
            {
                return ("Salary entered incorrectly, try again.");
            }
        }
    }
}
