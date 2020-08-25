using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAccounting.Views;

namespace EmployeeAccounting.Controllers
{
    public class AddNewEmployeeController
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public IAddNewEmployeeView addNewEmployeeView { get; set; }
        public AddNewEmployeeController(IAddNewEmployeeView addNewEmployeeView)
        {
            this.addNewEmployeeView = addNewEmployeeView;
            SubscribeOnView();
        }

        private void SubscribeOnView()
        {
            addNewEmployeeView.OnSurnameChanged += surname => Surname = surname;
            addNewEmployeeView.OnNameChanged += name => Name = name;
            addNewEmployeeView.OnMiddleNameChanged += middleName => MiddleName = middleName;
            addNewEmployeeView.OnPositionChanged += position => Position = position;
            addNewEmployeeView.OnSalaryChanged += salary => Salary = salary;
        }
    }
}
