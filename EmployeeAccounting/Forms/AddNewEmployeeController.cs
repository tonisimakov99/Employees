using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAccounting.DataBase;

namespace EmployeeAccounting.Forms
{
    public class AddNewEmployeeController
    {
        private IRepository<Employee> repository;
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public AddNewEmployeeController(IRepository<Employee> repository)
        {
            this.repository = repository;
        }
    }
}
