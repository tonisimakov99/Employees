using System;
using EmployeeService.DataBase;
using JetBrains.Annotations;

namespace EmployeeService.Employer
{
    public class EmployeeManager : IEmployeeManager
    {
        [NotNull]
        public Employee Recruit([NotNull] Employee employee)
        {
            if (employee.RecruitDate == null || employee.DismissDate != null)
                employee.RecruitDate = DateTime.Today;
            employee.DismissDate = null;
            return employee;
        }

        [NotNull]
        public Employee Dismiss([NotNull] Employee employee)
        {
            if (employee.DismissDate == null)
                employee.DismissDate = DateTime.Today;
            return employee;
        }
    }
}