using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeService.DataBase;
using JetBrains.Annotations;

namespace EmployeeService.Searcher
{
    public class EmployeeSearcherByString : IEmployeeSearcher
    {
        private readonly IEmployeeStorage storage;

        public EmployeeSearcherByString(IEmployeeStorage storage)
        {
            this.storage = storage;
        }

        [NotNull]
        [ItemNotNull]
        public IEnumerable<Employee> Search([NotNull] string searchRequest)
        {
            var keyWords = searchRequest.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            return storage.ReadAll().Where(employee => IsSuccessSearch(employee, keyWords));
        }

        private bool IsSuccessSearch([NotNull] Employee employee, [NotNull] [ItemNotNull] string[] keyWords)
        {
            return keyWords.Any(str =>
                employee.Name.StartsWith(str, StringComparison.OrdinalIgnoreCase) ||
                employee.Surname.StartsWith(str, StringComparison.OrdinalIgnoreCase) ||
                employee.MiddleName.StartsWith(str, StringComparison.OrdinalIgnoreCase));
        }
    }
}