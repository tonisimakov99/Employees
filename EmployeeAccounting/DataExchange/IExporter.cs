using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.DataExchange
{
    public interface IExporter<T> where T:class
    {
        string FileFilter { get; }
        void Export(IEnumerable<T> employees, Stream file);
    }
}
