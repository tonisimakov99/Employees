using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAccounting.Controllers;
using EmployeeService.DataBase;
using JetBrains.Annotations;

namespace EmployeeAccounting.Views
{
    public interface IMainView
    {
        [NotNull] IMainController Controller { get; }
        [NotNull] IEmployeeRepository Model { get; }
  
    }
}
