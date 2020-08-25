using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EmployeeAccounting.Controllers;
using EmployeeAccounting.DataBase;
using EmployeeAccounting.Views;

namespace EmployeeAccounting.Views
{
    public partial class MainForm : Form, IMainView
    {
        private readonly AddNewEmployeeController addNewEmployeeController;
        private int selectedRow;
        
        public event Action SaveToXmlCall;
        public event Action OpenFromXmlCall;
        public event Action<int> DismissCall;
        public event Action<int> RecruitCall;
        public event Action<Employee> AddNewEmployeeCall;
        public event Action<string> SearchInputTextChanged;
        
        public MainForm(AddNewEmployeeController addNewEmployeeController)
        {
            this.addNewEmployeeController = addNewEmployeeController;
            InitializeComponent();
            CustomInitializeComponent();
        }
        public void UpdateView(IEnumerable<Employee> source)
        {
            this.EmployeesDataGrid.DataSource = source.ToList();
            UpdateStats(source);
        }

        private void UpdateStats(IEnumerable<Employee> source)
        {
            this.TotalLabel.Text = source.Count().ToString();
            this.CurrentLabel.Text = source.Count(t => t.DismissalDate == null).ToString();
            this.DismissedLabel.Text = source.Count(t => t.DismissalDate != null).ToString();
            this.MaxLabel.Text = source.Max(t => t.Salary).ToString(CultureInfo.InvariantCulture);
            this.MinLabel.Text = source.Min(t => t.Salary).ToString(CultureInfo.InvariantCulture);
            this.AverageLabel.Text = source.Average(t => t.Salary).ToString(CultureInfo.InvariantCulture);
        }

        private void SearchInputStrTextChanged(object sender, System.EventArgs e)
        {
            SearchInputTextChanged?.Invoke(SearchInputStr.Text);
        }

        private void GridContextMenuCall(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void OpenFromXmlButtonClick(object sender, System.EventArgs e)
        {
            OpenFromXmlCall?.Invoke();
        }

        private void SaveToXmlButtonClick(object sender, System.EventArgs e)
        {
            SaveToXmlCall?.Invoke();
        }

        private void DismissMenuItemClick(object sender, EventArgs e)
        {
            DismissCall?.Invoke((int)EmployeesDataGrid[0,selectedRow].Value);
            this.EmployeesDataGrid.FirstDisplayedScrollingRowIndex = selectedRow;
        }
        private void RecruitMenuItemClick(object sender, EventArgs e)
        {
            RecruitCall?.Invoke((int)EmployeesDataGrid[0, selectedRow].Value);
            this.EmployeesDataGrid.FirstDisplayedScrollingRowIndex = selectedRow;
        }

        private void AddNewEmployeeButtonClick(object sender, EventArgs e)
        {
            if (addNewEmployeeController.addNewEmployeeView.ShowDialog() != DialogResult.Cancel)
            {
                var employee = new Employee()
                {
                    Name = addNewEmployeeController.Name,
                    SurName = addNewEmployeeController.Surname,
                    MiddleName = addNewEmployeeController.MiddleName,
                    Position = addNewEmployeeController.Position,
                    Salary = addNewEmployeeController.Salary,
                    EmploymentDate = DateTime.Now
                };
                AddNewEmployeeCall?.Invoke(employee);
            }
        }
    }
}