using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EmployeeAccounting.DataBase
{
    public interface IRepository<T> where T:class
    {
        int Count { get; }
        T FindById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Func<T, bool> predicate);
        void Remove(T item);
        void Update(T item);
        void AddNew(T employee);
        void AddRange(IEnumerable<T> employees);
        void Clear();
    }

}
