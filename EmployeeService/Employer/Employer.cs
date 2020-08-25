using System;
using EmployeeService.DataBase;

namespace EmployeeService.Employer
{
    public class Employer : IEmployer
    {
        public Employee Recruit(Employee employee, DateTime date)
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
