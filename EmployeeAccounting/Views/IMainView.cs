﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAccounting.DataBase;

namespace EmployeeAccounting.Views
{
    public interface IMainView
    {
        void UpdateView(IEnumerable<Employee> source);

        event Action SaveToXmlCall;
        event Action OpenFromXmlCall;
        event Action<int> DismissCall;
        event Action<int> RecruitCall;
        event Action AddNewEmployeeCall;
        event Action<string> SearchInputTextChanged;
    }
}
