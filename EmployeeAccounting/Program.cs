using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EmployeeAccounting.Views;
using EmployeeService.DataBase;
using GroboContainer.Core;
using GroboContainer.Impl;

namespace EmployeeAccounting
{
    internal static class Program
    {
        /// <summary>
        ///     Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += Handler;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(BuildContainer().Get<MainForm>());
        }

        private static void Handler(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = (Exception) e.ExceptionObject;
            var message = $"{exception.Message} StackTrace:" +
                          $"{exception.StackTrace}";
            MessageBox.Show(message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private static IContainer BuildContainer()
        {
            var containerConfiguration = new ContainerConfiguration(typeof(Employee).Assembly, typeof(MainForm).Assembly);
            var container = new Container(containerConfiguration);

            ConfigureContainer(container);

            return container;
        }

        private static void ConfigureContainer(IContainer container)
        {
            container.Configurator.ForAbstraction<ContextFactory>().UseInstances(new ContextFactory("DbConnection"));
        }
    }
}