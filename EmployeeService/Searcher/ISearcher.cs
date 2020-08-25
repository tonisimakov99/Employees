using System.Collections.Generic;
using EmployeeService.DataBase;

namespace EmployeeService.Searcher
{
    public interface ISearcher<T> where T : class
    {
        IEnumerable<T> Search(IRepository<T> repository, params string[] request);
    }
}
