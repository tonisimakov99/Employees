using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Employee
{
    public interface IEmployeesData
    {
        void AddNewEmployee(Employee employee);
        Employee GetEmployeeById(int id);

        IList<Employee> GetAllEmployees();
        IList<Employee> SearchByStr(IEmployeeSearcher searcher, string str);
        void SerializeEmployeesToXML(XmlSerializer serializer, Stream stream);
        void SaveChanges();

    }

}
