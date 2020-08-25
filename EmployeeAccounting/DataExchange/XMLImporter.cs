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
    public class XmlImporter:IImporter<Employee>
    {
        private XmlSerializer serializer;
        public string FileFilter { get; }
        public XmlImporter(XmlSerializer serializer, string fileFilter)
        {
            this.serializer = serializer;
            FileFilter = fileFilter;
        }

        public IEnumerable<Employee> Import(Stream file)
        {
            IEnumerable<Employee> employees;

            employees = (IEnumerable<Employee>) serializer.Deserialize(file);

            return employees;
        }
    }
}
