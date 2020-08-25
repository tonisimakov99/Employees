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
        public event Action<string> OnSurnameChanged;
        public event Action<string> OnNameChanged;
        public event Action<string> OnMiddleNameChanged;
        public event Action<string> OnPositionChanged;
        public event Action<decimal> OnSalaryChanged;
        public AddNewEmployeeForm()
        {
            InitializeComponent();
        }
        private void SurnameChanged(object sender, EventArgs e)
        {
            OnSurnameChanged?.Invoke(SurnameInput.Text);
        }

        private void NameChanged(object sender, EventArgs e)
        {
            OnNameChanged?.Invoke(NameInput.Text);
        }

        private void MiddleNameChanged(object sender, EventArgs e)
        {
            OnMiddleNameChanged?.Invoke(MiddleNameInput.Text);
        }

        private void PositionChanged(object sender, EventArgs e)
        {
            OnPositionChanged?.Invoke(PositionInput.Text);
        }

        private void AddClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalaryNumericUpDownValueChanged(object sender, EventArgs e)
        {
            OnSalaryChanged?.Invoke(SalaryNumericUpDown.Value);
        }

    }
}
