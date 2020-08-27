using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EmployeeAccounting.Controllers;
using EmployeeService.DataBase;

namespace EmployeeAccounting.Views
{
    public partial class MainForm : Form
    {
        private int selectedRow;

        public MainForm(MainController controller)
        {
            Controller = controller;
            InitializeComponent();
            CustomInitializeComponent();
            UpdateView(Controller.Search(""));
        }

        public MainController Controller { get; }

        public void UpdateView(IEnumerable<Employee> source)
        {
            var sourceArray = source.ToArray();
            EmployeesDataGrid.DataSource = sourceArray.ToList();
            UpdateStats(sourceArray);
        }

        private void UpdateStats(Employee[] source)
        {
            if (source.Length == 0) return;
            TotalLabel.Text = source.Count().ToString();
            CurrentLabel.Text = source.Count(t => t.DismissDate == null).ToString();
            DismissedLabel.Text = source.Count(t => t.DismissDate != null).ToString();
            MaxLabel.Text = source.Max(t => t.Salary).ToString("F");
            MinLabel.Text = source.Min(t => t.Salary).ToString("F");
            AverageLabel.Text = source.Average(t => t.Salary).ToString("F");
        }

        private void SearchInputStrTextChanged(object sender, EventArgs e)
        {
            UpdateView(Controller.Search(SearchInputStr.Text));
        }

        private void GridContextMenuCall(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void SaveToXmlButtonClick(object sender, EventArgs e)
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
            Controller.Dismiss((int) EmployeesDataGrid[0, selectedRow].Value);
            UpdateView(Controller.Search(SearchInputStr.Text));
            EmployeesDataGrid.FirstDisplayedScrollingRowIndex = selectedRow;
        }

        private void RecruitMenuItemClick(object sender, EventArgs e)
        {
            Controller.Recruit((int) EmployeesDataGrid[0, selectedRow].Value);
            UpdateView(Controller.Search(SearchInputStr.Text));
            EmployeesDataGrid.FirstDisplayedScrollingRowIndex = selectedRow;
        }

        private void AddNewEmployeeButtonClick(object sender, EventArgs e)
        {
            var addNewEmployeeView = new AddNewEmployeeForm();
            if (addNewEmployeeView.ShowDialog() == DialogResult.Cancel)
                return;
            var employee = addNewEmployeeView.Employee;
            Controller.AddNewEmployee(employee);
            UpdateView(Controller.Search(SearchInputStr.Text));
        }
    }
}