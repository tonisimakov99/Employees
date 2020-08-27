using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using EmployeeAccounting.Controllers;
using EmployeeAccounting.Views;
using EmployeeService.DataBase;
using EmployeeService.DataExchange;
using EmployeeService.Employer;
using EmployeeService.Searcher;
using GroboContainer.Core;
using GroboContainer.Impl;
using GroboContainer.Impl.Exceptions;

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
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(Handler);
            var container = new Container(new ContainerConfiguration(typeof(Employee).Assembly, typeof(MainForm).Assembly));
            ConfigureContainer(container);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Get<MainForm>());
        }

        private static void Handler(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = (Exception)e.ExceptionObject;
            var message = $"{exception.Message} StackTrace:" +
                          $"{exception.StackTrace}";
            MessageBox.Show(message, "Exception", MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
        }

        private static void ConfigureContainer(IContainer container)
        {
            container.Configurator.ForAbstraction<ContextFactory>().UseInstances(new ContextFactory("DbConnection"));
        }
    }
}
