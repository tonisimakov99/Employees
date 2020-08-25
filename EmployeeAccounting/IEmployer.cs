using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAccounting.DataBase;

namespace EmployeeAccounting
{
    public interface IEmployer
    {
        Employee Recruite(Employee employee, DateTime date);
        Employee Dismiss(Employee employee, DateTime date);
    }
}
