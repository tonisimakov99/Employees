using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class SearcherByString:IEmployeeSearcher
    {
        public IEnumerable<Employee> Search(IEnumerable<Employee> employees, string str)
        {
            return employees.Where(t => t.Name.Contains(str) || t.SurName.Contains(str) || t.Patronymic.Contains(str));
        }
    }
}
