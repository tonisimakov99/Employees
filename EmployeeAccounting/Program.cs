using System;
using System.Windows.Forms;
using EmployeeAccounting.Controllers;
using EmployeeAccounting.Views;
using EmployeeService.DataBase;
using EmployeeService.DataExchange;
using EmployeeService.Employer;
using EmployeeService.Searcher;
using GroboContainer.Core;
using GroboContainer.Impl;

namespace EmployeeAccounting
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            var container = new Container(new ContainerConfiguration(typeof(Employee).Assembly));
            ConfigureContainer(container);

            //var exporter = new XmlExporter();
            //var importer = new XmlImporter();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //var repository = new EmployeesEfRepository("DBConnection");
            //var employer = new Employer();
            //var searcher = new SearcherByString();
            //var addNewEmployeeForm = new AddNewEmployeeForm();
            //var addNewEmployeeController = new AddNewEmployeeController(addNewEmployeeForm);
            //var mainForm = new MainForm();
            //var mainController = new MainController(addNewEmployeeController, mainForm, repository, employer, searcher,
            //    exporter, importer);

            var mainController = container.Get<MainController>();
            var mainForm = container.Get<MainForm>();
            Application.Run(mainForm);
        }

        private static void ConfigureContainer(IContainer container)
        {
            container.Configurator.ForAbstraction<IAddNewEmployeeView>().UseType<AddNewEmployeeForm>();
            container.Configurator.ForAbstraction<IMainView>().UseType<MainForm>();
            container.Configurator.ForAbstraction<IRepository<Employee>>().UseInstances(new EmployeesEfRepository("DBConnection"));
        }
    }
}
