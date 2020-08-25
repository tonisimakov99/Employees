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
        public DbSet<T> Employees { get; set; }
        public Context(string connectionStr):base(connectionStr)
        {

        }

    }
}
