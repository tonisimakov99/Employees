using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employer
    {
        private readonly IEmployeesData data;
        public Employer(IEmployeesData data)
        {
            this.data = data;
        }

        public void Recruite(int id, DateTime date)
        {
            var employee = data.GetEmployeeById(id);

            employee.EmploymentDate = date;
            employee.DismissalDate = null;
        }

        public void Dismiss(int id, DateTime date)
        {
            var employee = data.GetEmployeeById(id);

            employee.DismissalDate = date;
        }
    }
}
