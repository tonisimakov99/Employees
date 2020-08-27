using System.Collections.Generic;
using EmployeeService.DataBase;
using JetBrains.Annotations;

namespace EmployeeService.Searcher
{
    public interface IEmployeeSearcher
    {
        [NotNull]
        [ItemNotNull]
        IEnumerable<Employee> Search([NotNull] string searchRequest);
    }
}