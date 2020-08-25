using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeAccounting.Forms;

namespace EmployeeAccounting
{
    public partial class AddNewEmployeeForm:Form
    {
        public AddNewEmployeeController Controller { get; }

        public AddNewEmployeeForm(AddNewEmployeeController addNewEmployeeController)
        {
            Controller = addNewEmployeeController;
            InitializeComponent();
        }

        private void NameChanged(object sender, EventArgs e)
        {
            Controller.Name = NameInput.Text;
        }

        private void SurnameChanged(object sender, EventArgs e)
        {
            Controller.Surname = SurnameInput.Text;
        }

        private void PatronymicChanged(object sender, EventArgs e)
        {
            Controller.Patronymic = MiddleNameInput.Text;
        }

        private void PositionChanged(object sender, EventArgs e)
        {
            Controller.Position = PositionInput.Text;
        }

        private void AddClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalaryNumericUpDownValueChanged(object sender, EventArgs e)
        {
            Controller.Salary = SalaryNumericUpDown.Value;
        }
    }
}
