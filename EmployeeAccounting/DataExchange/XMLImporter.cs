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
    public class XMLImporter:IImporter<Employee>
    {
        private XmlSerializer serializer;
        public XMLImporter(XmlSerializer serializer)
        {
            this.serializer = serializer;
        }

        public IEnumerable<Employee> Import(Stream file)
        {
            IEnumerable<Employee> employees;

            employees = (IEnumerable<Employee>) serializer.Deserialize(file);

            return employees;
        }
    }
}
