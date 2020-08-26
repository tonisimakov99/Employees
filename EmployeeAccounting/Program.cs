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
            var container = new Container(new ContainerConfiguration(typeof(Employee).Assembly, typeof(MainForm).Assembly));
            ConfigureContainer(container);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Get<MainForm>());
        }

        private static void ConfigureContainer(IContainer container)
        {
            container.Configurator.ForAbstraction<ContextFactory>().UseInstances(new ContextFactory("DbConnection"));
        }
    }
}
