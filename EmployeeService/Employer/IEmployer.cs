using System;
using EmployeeService.DataBase;

namespace EmployeeService.Employer
{
    public interface IEmployer
    {
        Employee Recruit(Employee employee, DateTime date);
        Employee Dismiss(Employee employee, DateTime date);
    }
}
