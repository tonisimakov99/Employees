using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EmployeeAccounting.Controllers;
using EmployeeService.DataBase;

namespace EmployeeAccounting.Views
{
    public partial class AddNewEmployeeForm : Form
    {
        public AddNewEmployeeForm()
        {
            InitializeComponent();
            Employee = new Employee();
        }

        public Employee Employee { get; }

        private void SalaryNumericUpDownValidating(object sender, CancelEventArgs e)
        {
            if (SalaryNumericUpDown.Value == 0)
            {
                e.Cancel = true;
                ErrorProvider.SetError(SalaryNumericUpDown, "Can't be 0");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void PositionValidating(object sender, CancelEventArgs e)
        {
            TextValidating(PositionInput, e);
        }

        private void MiddleNameValidating(object sender, CancelEventArgs e)
        {
            TextValidating(MiddleNameInput, e);
        }

        private void SurnameValidating(object sender, CancelEventArgs e)
        {
            TextValidating(SurnameInput, e);
        }

        private void NameValidating(object sender, CancelEventArgs e)
        {
            TextValidating(NameInput, e);
        }

        private void TextValidating(TextBox text, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                e.Cancel = true;
                ErrorProvider.SetError(text, "Can't be Empty");
            }
            else if (NameInput.Text.Any(t => !char.IsLetter(t)))
            {
                e.Cancel = true;
                ErrorProvider.SetError(text, "Only letters");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void SurnameChanged(object sender, EventArgs e)
        {
            Employee.Surname = SurnameInput.Text;
        }

        private void NameChanged(object sender, EventArgs e)
        {
            Employee.Name = NameInput.Text;
        }

        private void MiddleNameChanged(object sender, EventArgs e)
        {
            Employee.MiddleName = MiddleNameInput.Text;
        }

        private void PositionChanged(object sender, EventArgs e)
        {
            Employee.Position = PositionInput.Text;
        }

        private void AddClick(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void SalaryNumericUpDownValueChanged(object sender, EventArgs e)
        {
            Employee.Salary = SalaryNumericUpDown.Value;
        }
    }
}