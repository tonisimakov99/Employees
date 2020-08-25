using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using EmployeeAccounting.Controllers;
using EmployeeAccounting.DataBase;
using EmployeeAccounting.DataExchange;
using EmployeeAccounting.Searcher;

namespace EmployeeAccounting.Views
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serializer = new XmlSerializer(typeof(DataBase.Employee[]));
            var exporter = new XmlExporter(serializer, "Xml files (*.xml)");
            var importer = new XmlImporter(serializer, "Xml files (*.xml)");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var repository = new EmployeesEfRepository("DBConnection");
            var employer = new Employer();
            var searcher = new SearcherByString();
            var addNewEmployeeForm = new AddNewEmployeeForm();
            var addNewEmployeeController = new AddNewEmployeeController(addNewEmployeeForm);
            var mainForm = new MainForm();
            var mainController = new MainController(addNewEmployeeController, mainForm, repository, employer, searcher,
                exporter, importer);
            Application.Run(mainForm);

        }
    }
}
