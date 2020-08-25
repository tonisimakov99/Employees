using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using EmployeeService.DataBase;

namespace EmployeeService.DataExchange
{
    public class XmlExporter : IExporter<Employee>
    {
        private readonly XmlSerializer serializer;
        public XmlExporter()
        {
            serializer = new XmlSerializer(typeof(Employee[]));
        }

        public void Export(IEnumerable<Employee> employees, Stream file)
        {
            serializer.Serialize(file, employees.ToArray());
        }
    }
}
