using System.Collections.Generic;
using System.Linq;
using EmployeeService.DataBase;
using JetBrains.Annotations;

namespace EmployeeService.Searcher
{
    public class SearcherByString : IEmployeeSearcher
    {
        [NotNull, ItemNotNull]
        public IEnumerable<Employee> Search([NotNull, ItemNotNull] IEnumerable<Employee> employees, [NotNull, ItemNotNull] string[] request)
        {
            return employees.Where(employee =>
                request.Any(str =>
                    employee.Name.ToLower().Contains(str.ToLower()) ||
                    employee.Surname.ToLower().Contains(str.ToLower()) ||
                    employee.MiddleName.ToLower().Contains(str.ToLower()))).ToList();
        }
    }
}
