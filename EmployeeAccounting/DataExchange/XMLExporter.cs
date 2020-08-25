using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EmployeeAccounting.DataBase;

namespace EmployeeAccounting.DataExchange
{
    public class XMLExporter : IExporter<Employee>
    {
        private readonly XmlSerializer serializer;

        public XMLExporter(XmlSerializer serializer)
        {
            this.serializer = serializer;
        }

        public void Export(IEnumerable<Employee> employees, Stream file)
        {
            serializer.Serialize(file, employees.ToArray());
        }
    }
}
