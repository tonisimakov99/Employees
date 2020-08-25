using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAccounting.DataBase;

namespace EmployeeAccounting
{
    public class Employer
    {
        private readonly IRepository<Employee> repository;
        public Employer(IRepository<Employee> repository)
        {
            this.repository = repository;
        }

        public void Recruite(int id, DateTime date)
        {
            var employee = repository.FindById(id);

            employee.EmploymentDate = date;
            employee.DismissalDate = null;

            repository.Update(employee);
        }

        public void Dismiss(int id, DateTime date)
        {
            var employee = repository.FindById(id);

            employee.DismissalDate = date;

            repository.Update(employee);
        }
    }
}
