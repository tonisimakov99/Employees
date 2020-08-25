using System.Collections.Generic;
using System.IO;

namespace EmployeeService.DataExchange
{
    public interface IExporter<T> where T:class
    {
        void Export(IEnumerable<T> employees, Stream file);
    }
}
