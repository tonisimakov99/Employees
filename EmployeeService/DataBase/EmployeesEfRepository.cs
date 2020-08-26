using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using JetBrains.Annotations;

namespace EmployeeService.DataBase
{
    public class EmployeesEfRepository : IEmployeeRepository
    {
        private readonly ContextFactory contextFactory;

        public EmployeesEfRepository(ContextFactory contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public event Action<IList<Employee>> OnEmployeesChanged;

        [CanBeNull]
        public Employee FindById(int id)
        {
            using (var dbContext = contextFactory.CreateContext())
            {
                return dbContext.Employees.Find(id);
            }
        }

        [NotNull]
        [ItemNotNull]
        public Employee[] GetAll()
        {
            using (var dbContext = contextFactory.CreateContext())
            {
                return dbContext.Employees.AsNoTracking().ToArray();
            }
        }

        public void Remove(int id)
        {
            using (var dbContext = contextFactory.CreateContext())
            {
                var item = FindById(id);
                if (item == null) return;
                dbContext.Employees.Remove(item);
                dbContext.SaveChanges();
                OnEmployeesChanged?.Invoke(dbContext.Employees.ToList());
            }
        }

        public void Update([NotNull] Employee item)
        {
            using (var dbContext = contextFactory.CreateContext())
            {
                dbContext.Entry(item).State = EntityState.Modified;
                dbContext.SaveChanges();
                OnEmployeesChanged?.Invoke(dbContext.Employees.ToList());
            }
        }

        public void AddNew([NotNull] Employee employee)
        {
            using (var dbContext = contextFactory.CreateContext())
            {
                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
                OnEmployeesChanged?.Invoke(dbContext.Employees.ToList());
            }
        }

        public void AddRange([NotNull] [ItemNotNull] IEnumerable<Employee> employees)
        {
            using (var dbContext = contextFactory.CreateContext())
            {
                dbContext.Employees.AddRange(employees);
                dbContext.SaveChanges();
                OnEmployeesChanged?.Invoke(dbContext.Employees.ToList());
            }
        }

        public void Clear()
        {
            using (var dbContext = contextFactory.CreateContext())
            {
                dbContext.Employees.RemoveRange(dbContext.Employees);
                dbContext.SaveChanges();
                OnEmployeesChanged?.Invoke(dbContext.Employees.ToList());
            }
        }
    }
}