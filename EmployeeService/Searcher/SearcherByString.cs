using System.Collections.Generic;
using EmployeeService.DataBase;

namespace EmployeeService.Searcher
{
    public class SearcherByString:ISearcher<Employee>
    { 
        public IEnumerable<Employee> Search(IRepository<Employee> repository, string[] request)
        {
            var result = new List<Employee>();
            var all = repository.GetAll();
            foreach (var employee in all)
            {
                foreach (var str in request)
                {
                    if (employee.Name.ToLower().Contains(str.ToLower()) || 
                        employee.SurName.ToLower().Contains(str.ToLower()) || 
                        employee.MiddleName.ToLower().Contains(str.ToLower()))
                    {
                        result.Add(employee);
                        break;
                    }
                }
            }

            return result;
        }
    }
}
