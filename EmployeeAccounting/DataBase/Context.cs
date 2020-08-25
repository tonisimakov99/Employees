using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.DataBase
{
    public class Context<T>:DbContext where T:class
    {
        public Context(string connectionStr):base(connectionStr)
        {

        }

        public DbSet<T> Employees { get; set; }
    }
}
