using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAccounting.DataBase;

namespace EmployeeAccounting.Forms
{
    public interface IMainView
    {
        void UpdateView(IEnumerable<Employee> source);

        event Action<Stream> SaveToXmlCall;
        event Action<Stream> OpenFromXmlCall;
        event Action<int> DismissCall;
        event Action<int> RecruiteCall;
        event Action<Employee> AddNewEmployeeCall;
        event Action<string> SearchInputTextChanged;
    }
}
