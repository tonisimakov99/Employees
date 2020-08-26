using System;
using EmployeeService.DataBase;
using JetBrains.Annotations;

namespace EmployeeService.Employer
{
    public class EmployeeManager : IEmployeeManager
    {
        [NotNull]
        public Employee Recruit([NotNull] Employee employee, DateTime date)
        {
            employee.EmploymentDate = date;
            employee.DismissalDate = null;
            return employee;
        }

        [NotNull]
        public Employee Dismiss([NotNull] Employee employee, DateTime date)
        {
            employee.DismissalDate = date;
            return employee;
        }
    }
}
