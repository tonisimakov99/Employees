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

        private void SalaryNumericUpDownValidating(object sender, CancelEventArgs e)
        {
            if (this.SalaryNumericUpDown.Value == 0)
            {
                e.Cancel = true;
                ErrorProvider.SetError(this.SalaryNumericUpDown, "Can't be 0");
            }
            else
            {
                e.Cancel = false;
            }

        }

        private void PositionValidating(object sender, CancelEventArgs e)
        {
            TextValidating(this.PositionInput,e);
        }

        private void MiddleNameValidating(object sender, CancelEventArgs e)
        {
            TextValidating(this.MiddleNameInput,e);
        }

        private void SurnameValidating(object sender, CancelEventArgs e)
        {
            TextValidating(this.SurnameInput,e);
        }

        private void NameValidating(object sender, CancelEventArgs e)
        {
            TextValidating(this.NameInput,e);
        }

        private void TextValidating(TextBox text, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(text.Text))
            {
                e.Cancel = true;
                ErrorProvider.SetError(text, "Can't be Empty");
            }
            else if (this.NameInput.Text.Any(t => !char.IsLetter(t)))
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
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SalaryNumericUpDownValueChanged(object sender, EventArgs e)
        {
            Controller.Salary = SalaryNumericUpDown.Value;
        }
    }
}
