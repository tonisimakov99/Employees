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
    public class XmlExporter : IExporter<Employee>
    {
        private readonly XmlSerializer serializer;
        public string FileFilter { get; }

        public XmlExporter(XmlSerializer serializer, string fileFilter)
        {
            this.serializer = serializer;
            FileFilter = fileFilter;
        }

        public void Export(IEnumerable<Employee> employees, Stream file)
        {
            serializer.Serialize(file, employees.ToArray());
        }
    }
}
