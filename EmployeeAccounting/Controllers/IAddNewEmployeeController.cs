using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.Controllers
{
    public interface IAddNewEmployeeController
    {
        string Name { get; set; }
        string Surname { get; set; }
        string MiddleName { get; set; }
        string Position { get; set; }
        decimal Salary { get; set; }
    }
}
