using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAccounting.Views;
using EmployeeService.DataBase;
using JetBrains.Annotations;

namespace EmployeeAccounting.Controllers
{
    public interface IMainController
    {
        void Dismiss(int id);
        void Recruit(int id);
        void AddNewEmployee([NotNull] Employee employee);
        [NotNull, ItemNotNull] IEnumerable<Employee> Search([NotNull] string str);
        void ExportToXml([NotNull] Stream fileStream);
        void ImportFromXml([NotNull] Stream fileStream);
    }
}
