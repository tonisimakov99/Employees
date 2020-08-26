using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EmployeeAccounting.Controllers;
using EmployeeAccounting.Views;
using EmployeeService.DataBase;

namespace EmployeeAccounting.Views
{
    public partial class MainForm : Form, IMainView
    {
        private int selectedRow;
        public IMainController Controller { get; }
        public IEmployeeRepository Model { get; }
        public MainForm(IMainController controller, IEmployeeRepository model)
        {
            Controller = controller;
            Model = model;
            InitializeComponent();
            CustomInitializeComponent();
            Model.OnEmployeesChanged += UpdateView;
            this.EmployeesDataGrid.DataSource = model.GetAll();
        }

        public void UpdateView(IEnumerable<Employee> source)
        {
            var sourceArray = source.ToArray();
            this.EmployeesDataGrid.DataSource = sourceArray.ToList();
            UpdateStats(sourceArray);
        }

        private void UpdateStats(Employee[] source)
        {
            if (source.Length == 0) return;
            this.TotalLabel.Text = source.Count().ToString();
            this.CurrentLabel.Text = source.Count(t => t.DismissalDate == null).ToString();
            this.DismissedLabel.Text = source.Count(t => t.DismissalDate != null).ToString();
            this.MaxLabel.Text = source.Max(t => t.Salary).ToString(CultureInfo.InvariantCulture);
            this.MinLabel.Text = source.Min(t => t.Salary).ToString(CultureInfo.InvariantCulture);
            this.AverageLabel.Text = source.Average(t => t.Salary).ToString(CultureInfo.InvariantCulture);
        }

        private void SearchInputStrTextChanged(object sender, System.EventArgs e)
        {
            UpdateView(Controller.Search(SearchInputStr.Text));
        }

        private void GridContextMenuCall(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void OpenFromXmlButtonClick(object sender, System.EventArgs e)
        {
            using (var openForm = new OpenFileDialog())
            {
                if (openForm.ShowDialog() == DialogResult.Cancel) return;
                using (var fileStream = openForm.OpenFile())
                {
                    Controller.ImportFromXml(fileStream);
                }
            }
        }

        private void SaveToXmlButtonClick(object sender, System.EventArgs e)
        {
            using (var saveForm = new SaveFileDialog())
            {
                if (saveForm.ShowDialog() == DialogResult.Cancel) return;
                using (var fileStream = saveForm.OpenFile())
                {
                    Controller.ExportToXml(fileStream);
                }
            }
        }

        private void DismissMenuItemClick(object sender, EventArgs e)
        {
            Controller.Dismiss((int)EmployeesDataGrid[0, selectedRow].Value);
            this.EmployeesDataGrid.FirstDisplayedScrollingRowIndex = selectedRow;
        }
        private void RecruitMenuItemClick(object sender, EventArgs e)
        {
            Controller.Recruit((int)EmployeesDataGrid[0, selectedRow].Value);
            this.EmployeesDataGrid.FirstDisplayedScrollingRowIndex = selectedRow;
        }

        private void AddNewEmployeeButtonClick(object sender, EventArgs e)
        {
            var addNewEmployeeView = new AddNewEmployeeForm(new AddNewEmployeeController());
            if (addNewEmployeeView.ShowDialog() == DialogResult.Cancel) return;
            var employee = new Employee()
            {
                Name = addNewEmployeeView.Controller.Name,
                Surname = addNewEmployeeView.Controller.Surname,
                MiddleName = addNewEmployeeView.Controller.MiddleName,
                Position = addNewEmployeeView.Controller.Position,
                Salary = addNewEmployeeView.Controller.Salary,
                EmploymentDate = DateTime.Now
            };
            Controller.AddNewEmployee(employee);
        }
    }
}