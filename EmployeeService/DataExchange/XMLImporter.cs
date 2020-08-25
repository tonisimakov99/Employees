using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using EmployeeService.DataBase;

namespace EmployeeService.DataExchange
{
    public class XmlImporter:IImporter<Employee>
    {
        private readonly XmlSerializer serializer;
        public XmlImporter()
        {
            serializer = new XmlSerializer(typeof(Employee[]));
        }

        public IEnumerable<Employee> Import(Stream file)
        {
            var employees = (IEnumerable<Employee>) serializer.Deserialize(file);

            return employees;
        }
    }
}
