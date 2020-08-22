using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Employee
{
    public class EmployeesDataFromEF:IEmployeesData
    {
        private EmployeeContext db;
        public EmployeesDataFromEF(EmployeeContext db)
        {
            this.db = db;
        }

        public void AddNewEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = db.Employees.Find(id);
            if (employee == null)
                throw new NullReferenceException("Employee not found");
            return employee;
        }

        public IList<Employee> GetAllEmployees()
        {
            return db.Employees.ToArray();
        }

        public IList<Employee> SearchByStr(IEmployeeSearcher searcher, string str)
        {
            return searcher.Search(db.Employees.ToArray(), str).ToList();
        }

        public void SerializeEmployeesToXML(XmlSerializer serializer, Stream stream)
        {
            serializer.Serialize(stream, db.Employees.ToArray());
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
