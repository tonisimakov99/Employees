using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using EmployeeAccounting.DataBase;
using EmployeeAccounting.DataExchange;
using EmployeeAccounting.Forms;
using EmployeeAccounting.Searcher;

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
            var serializer = new XmlSerializer(typeof(DataBase.Employee[]));
            var exporter = new XMLExporter(serializer);
            var importer = new XMLImporter(serializer);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var repository = new EmployeesEfRepository("DBConnection");
            var employer = new Employer(repository);
            var searcher = new SearcherByString();
            var addNewEmployeeController = new AddNewEmployeeController(repository);
            var addNewEmployeeForm = new AddNewEmployeeForm(addNewEmployeeController);
            var mainController = new MainController(repository, employer, searcher, exporter, importer);

            Application.Run(new MainForm(repository, mainController, addNewEmployeeForm));

        }
    }
}
