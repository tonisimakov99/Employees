using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeAccounting.Controllers;
using EmployeeAccounting.Views;

namespace EmployeeAccounting.Views
{
    public partial class AddNewEmployeeForm : Form, IAddNewEmployeeView
    {
        public IAddNewEmployeeController Controller { get; }
        public AddNewEmployeeForm(IAddNewEmployeeController controller)
        {
            Controller = controller;
            InitializeComponent();
        }
        private void SurnameChanged(object sender, EventArgs e)
        {
            Controller.Surname = SurnameInput.Text;
        }

        private void NameChanged(object sender, EventArgs e)
        {
            Controller.Name = NameInput.Text;
        }

        private void MiddleNameChanged(object sender, EventArgs e)
        {
            Controller.MiddleName = MiddleNameInput.Text;
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
