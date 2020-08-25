using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EmployeeAccounting.DataBase;
using EmployeeAccounting.Forms;

namespace EmployeeAccounting
{
    public partial class MainForm : Form, IMainView
    {
        public event Action<Stream> SaveToXmlCall;
        public event Action<Stream> OpenFromXmlCall;
        public event Action<int> DismissCall;
        public event Action<int> RecruiteCall;
        public event Action<Employee> AddNewEmployeeCall;
        public event Action<string> SearchInputTextChanged;
        private readonly AddNewEmployeeForm addNewEmployeeForm;
        private int selectedRow;
        public MainForm(AddNewEmployeeForm addNewEmployeeForm)
        {
            this.addNewEmployeeForm = addNewEmployeeForm;
            InitializeComponent();
            CustomInitializeComponent();
        }
        public void UpdateView(IEnumerable<Employee> source)
        {
            this.EmployeesDataGrid.DataSource = source.ToList();
            UpdateStats(source);
        }

        public void UpdateStats(IEnumerable<Employee> source)
        {
            this.TotalLabel.Text = source.Count().ToString();
            this.CurrentLabel.Text = source.Count(t => t.DismissalDate == null).ToString();
            this.DismissedLabel.Text = source.Count(t => t.DismissalDate != null).ToString();
            this.MaxLabel.Text = source.Max(t => t.Salary).ToString();
            this.MinLabel.Text = source.Min(t => t.Salary).ToString();
            this.AverageLabel.Text = source.Average(t => t.Salary).ToString();
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
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    using (var file = openFileDialog.OpenFile())
                        OpenFromXmlCall?.Invoke(file);
                }
            }
        }

        private void SaveToXmlButtonClick(object sender, System.EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    using (var file = saveFileDialog.OpenFile())
                        SaveToXmlCall?.Invoke(file);
                }
            }
        }

        private void DismissMenuItemClick(object sender, EventArgs e)
        {
            DismissCall?.Invoke((int)EmployeesDataGrid[0,selectedRow].Value);
            this.EmployeesDataGrid.FirstDisplayedScrollingRowIndex = selectedRow;
        }
        private void RecruiteMenuItemClick(object sender, EventArgs e)
        {
            RecruiteCall?.Invoke((int)EmployeesDataGrid[0, selectedRow].Value);
            this.EmployeesDataGrid.FirstDisplayedScrollingRowIndex = selectedRow;
        }

        private void AddNewEmployeeButtonClick(object sender, EventArgs e)
        {
            if (addNewEmployeeForm.ShowDialog() != DialogResult.Cancel)
            {
                var employee = new Employee()
                {
                    Name = addNewEmployeeForm.Controller.Name,
                    SurName = addNewEmployeeForm.Controller.Surname,
                    MiddleName = addNewEmployeeForm.Controller.Patronymic,
                    Position = addNewEmployeeForm.Controller.Position,
                    Salary = addNewEmployeeForm.Controller.Salary,
                    EmploymentDate = DateTime.Now
                };
                AddNewEmployeeCall?.Invoke(employee);
            }
        }
    }
}