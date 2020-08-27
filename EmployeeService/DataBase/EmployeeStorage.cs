using System.Data.Entity.Migrations;
using System.Linq;
using JetBrains.Annotations;

namespace EmployeeService.DataBase
{
    public class EmployeeStorage : IEmployeeStorage
    {
        private readonly ContextFactory contextFactory;

        public EmployeeStorage(ContextFactory contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public void Write([NotNull] Employee employee)
        {
            using (var dbContext = contextFactory.CreateContext())
            {
                dbContext.Employees.AddOrUpdate(employee);
                dbContext.SaveChanges();
            }
        }

        [NotNull]
        [ItemNotNull]
        public Employee[] ReadAll()
        {
            using (var dbContext = contextFactory.CreateContext())
            {
                return dbContext.Employees.ToArray();
            }
        }

        [CanBeNull]
        public Employee TryReadById(int employeeId)
        {
            using (var dbContext = contextFactory.CreateContext())
            {
                return dbContext.Employees.Find(employeeId);
            }
        }
    }
}