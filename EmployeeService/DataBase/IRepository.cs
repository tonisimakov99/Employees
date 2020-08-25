using System;
using System.Collections.Generic;

namespace EmployeeService.DataBase
{
    public interface IRepository<T> where T:class
    {
        int Count { get; }
        T FindById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Func<T, bool> predicate);
        void Remove(T item);
        void Update(T item);
        void AddNew(T item);
        void AddRange(IEnumerable<T> items);
        void Clear();
    }

}
