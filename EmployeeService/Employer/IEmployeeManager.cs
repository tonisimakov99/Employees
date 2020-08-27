using System;
using EmployeeService.DataBase;
using JetBrains.Annotations;

namespace EmployeeService.Employer
{
    public interface IEmployeeManager
    {
        [NotNull]
        Employee Recruit([NotNull] Employee employee);

        [NotNull]
        Employee Dismiss([NotNull] Employee employee);
    }
}