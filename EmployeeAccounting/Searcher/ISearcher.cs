using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAccounting.DataBase;

namespace EmployeeAccounting.Searcher
{
    public interface ISearcher<T> where T : class
    {
        IEnumerable<T> Search(IRepository<T> repository, params string[] request);
    }
}
