using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAccounting.Controllers;
using JetBrains.Annotations;

namespace EmployeeAccounting.Views
{
    public interface IAddNewEmployeeView
    {
        [NotNull] IAddNewEmployeeController Controller { get; }
    }
}
