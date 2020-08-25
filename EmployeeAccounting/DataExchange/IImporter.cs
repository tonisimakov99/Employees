using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.DataExchange
{
    public interface IImporter<T> where T:class
    {
        string FileFilter { get; }
        IEnumerable<T> Import(Stream file);
    }
}
