using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EmployeeAccounting.DataBase;
using EmployeeAccounting.Forms;

namespace EmployeeAccounting
{
    public partial class MainForm : Form
    {
        public MainController Controller { get; }
        private IRepository<Employee> repository { get; }
        private readonly AddNewEmployeeForm addNewEmployeeForm;
        public MainForm(IRepository<Employee> repository, MainController controller, AddNewEmployeeForm addNewEmployeeForm)
        {
            this.repository = repository;
            this.Controller = controller;
            this.addNewEmployeeForm = addNewEmployeeForm;
            InitializeComponent();
            CustomInitializeComponent();
        }


        private void SearchInputStrTextChanged(object sender, System.EventArgs e)
        {
            Controller.Search(SearchInputStr.Text);
            this.EmployeesDataGrid.DataSource = Controller.CurrentGridSource;
        }

        private void GridContextMenuCall(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            Controller.SelectedEmployeeId = (int)EmployeesDataGrid[0, e.RowIndex].Value;
        }

        private void OpenFromXMLButtonClick(object sender, System.EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    var file = openFileDialog.OpenFile();
                    Controller.OpenFromXML(file);
                    this.EmployeesDataGrid.DataSource = Controller.CurrentGridSource;
                }
            }
        }

        private void SaveToXMLButtonClick(object sender, System.EventArgs e)
        {
            using (var saveFileDialog = new OpenFileDialog())
            {
                if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                {
                    saveFileDialog.ShowDialog();
                    var file = saveFileDialog.OpenFile();
                    Controller.SaveToXML(file);
                }
            }
        }

        private void Dissmiss(object sender, EventArgs e)
        {
            Controller.Dismiss();
            this.EmployeesDataGrid.DataSource = Controller.CurrentGridSource;
        }
        private void Recruite(object sender, EventArgs e)
        {
            Controller.Recruite();
            this.EmployeesDataGrid.DataSource = Controller.CurrentGridSource;
        }

        private void AddNewEmployeeButtonClick(object sender, EventArgs e)
        {
            if (addNewEmployeeForm.ShowDialog() != DialogResult.Cancel)
            {
                Controller.AddNewEmployee(new Employee()
                {
                    Name = addNewEmployeeForm.Controller.Name,
                    SurName = addNewEmployeeForm.Controller.Surname,
                    MiddleName = addNewEmployeeForm.Controller.Patronymic,
                    Position = addNewEmployeeForm.Controller.Position,
                    EmploymentDate = DateTime.Now
                });
                this.EmployeesDataGrid.DataSource = Controller.CurrentGridSource;
            }
        }
    }
}