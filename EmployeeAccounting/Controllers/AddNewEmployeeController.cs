using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAccounting.Views;
using JetBrains.Annotations;

namespace EmployeeAccounting.Controllers
{
    public class AddNewEmployeeController:IAddNewEmployeeController
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
    }
}
