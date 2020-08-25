using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAccounting.DataBase;

namespace EmployeeAccounting
{
    public class Employer:IEmployer
    {
        public Employee Recruite(Employee employee, DateTime date)
        {
            employee.EmploymentDate = date;
            employee.DismissalDate = null;
            return employee;
        }

        public Employee Dismiss(Employee employee, DateTime date)
        {
            employee.DismissalDate = date;
            return employee;
        }
    }
}
