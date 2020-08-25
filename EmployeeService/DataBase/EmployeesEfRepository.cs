using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EmployeeService.DataBase
{
    public class EmployeesEfRepository : IRepository<Employee>
    {
        private readonly string connectionStr;

        public EmployeesEfRepository(string connectionStr)
        {
            this.connectionStr = connectionStr;
        }

        public int Count
        {
            get
            {
                using (var db = new Context(connectionStr))
                {
                    return db.Employees.Count();
                }
            }
        }

        public Employee FindById(int id)
        {
            using (var db = new Context(connectionStr))
            {
                return db.Employees.Find(id);
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            using (var db = new Context(connectionStr))
            {
                return db.Employees.AsNoTracking().ToList();
            }
        }

        public IEnumerable<Employee> GetAll(Func<Employee, bool> predicate)
        {
            using (var db = new Context(connectionStr))
            {
                return db.Employees.AsNoTracking().Where(predicate).ToList();
            }
        }

        public void Remove(Employee item)
        {
            using (var db = new Context(connectionStr))
            {
                db.Employees.Remove(item);
                db.SaveChanges();
            }
        }

        public void Update(Employee item)
        {
            using (var db = new Context(connectionStr))
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void AddNew(Employee employee)
        {
            using (var db = new Context(connectionStr))
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }

        public void AddRange(IEnumerable<Employee> employees)
        {
            using (var db = new Context(connectionStr))
            {
                db.Employees.AddRange(employees);
                db.SaveChanges();
            }
        }

        public void Clear()
        {
            using (var db = new Context(connectionStr))
            {
                db.Employees.RemoveRange(db.Employees);
                db.SaveChanges();
            }
        }
    }
}