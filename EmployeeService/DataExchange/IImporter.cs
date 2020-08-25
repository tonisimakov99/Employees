using System.Collections.Generic;
using System.IO;

namespace EmployeeService.DataExchange
{
    public interface IImporter<T> where T:class
    {
        IEnumerable<T> Import(Stream file);
    }
}
