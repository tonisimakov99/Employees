using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccounting.Views
{
    public interface ISaveOpenView: IDialog, IDisposable
    {
        Stream OpenFile();
    }
}
