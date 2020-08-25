using System.Data.Entity;

namespace EmployeeService.DataBase
{
    [DbConfigurationType(typeof(Configuration))]
    public class Context:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public Context(string connectionStr):base(connectionStr)
        {

        }

    }
}
