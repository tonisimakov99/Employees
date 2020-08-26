using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace EmployeeService.DataBase
{
    public interface IEmployeeRepository
    {
        event Action<IList<Employee>> OnEmployeesChanged;
        [CanBeNull] 
        Employee FindById(int id);
        Employee[] GetAll();
        void Remove(int id);
        void Update([NotNull] Employee employee);
        void AddNew([NotNull] Employee employee);
        void AddRange([NotNull,ItemNotNull] IEnumerable<Employee> employees);
        void Clear();
    }

}
