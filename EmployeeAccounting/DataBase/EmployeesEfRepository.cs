using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EmployeeAccounting.DataBase
{
    public class EmployeesEfRepository:IRepository<Employee>
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
                using (var db = new Context<Employee>(connectionStr))
                {
                    return db.Employees.Count();
                }
            }
        }

        public Employee FindById(int id)
        {
            using (var db = new Context<Employee>(connectionStr))
            {
                return db.Employees.Find(id);
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            using (var db = new Context<Employee>(connectionStr))
            {
                return db.Employees.AsNoTracking().ToList();
            }
        }

        public IEnumerable<Employee> GetAll(Func<Employee, bool> predicate)
        {
            using (var db = new Context<Employee>(connectionStr))
            {
                return db.Employees.AsNoTracking().Where(predicate).ToList();
            }
        }

        public void Remove(Employee item)
        {
            using (var db = new Context<Employee>(connectionStr))
            {
                db.Employees.Remove(item);
                db.SaveChanges();
            }
        }

        public void Update(Employee item)
        {
            using (var db = new Context<Employee>(connectionStr))
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void AddNew(Employee employee)
        {
            using (var db = new Context<Employee>(connectionStr))
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }
        }

        public void AddRange(IEnumerable<Employee> employees)
        {
            using (var db = new Context<Employee>(connectionStr))
            {
                db.Employees.AddRange(employees);
                db.SaveChanges();
            }
        }

        public void Clear()
        {
            using (var db = new Context<Employee>(connectionStr))
            {
                foreach (var entity in db.Employees)
                    db.Employees.Remove(entity);
                db.SaveChanges();
            }
        }
    }
}
