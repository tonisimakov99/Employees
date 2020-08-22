using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(string connectionStr):base(connectionStr)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        //protected override void OnModelCreating(DbModelBuilder builder)
        //{
            
        //}
    }
}
