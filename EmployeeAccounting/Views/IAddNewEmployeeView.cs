using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.Views
{
    public interface IAddNewEmployeeView:IDialog
    {
        event Action<string> OnSurnameChanged;
        event Action<string> OnNameChanged;
        event Action<string> OnMiddleNameChanged;
        event Action<string> OnPositionChanged;
        event Action<decimal> OnSalaryChanged;
    }
}
