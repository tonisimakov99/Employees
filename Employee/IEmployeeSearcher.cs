using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public interface IEmployeeSearcher
    {
        IEnumerable<Employee> Search(IEnumerable<Employee> employees, string str);
    }
}
