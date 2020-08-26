using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms.VisualStyles;
using EmployeeService.DataBase;
using EmployeeService.DataExchange;
using EmployeeService.Employer;
using EmployeeService.Searcher;
using JetBrains.Annotations;

namespace EmployeeAccounting.Controllers
{
    public class MainController : IMainController
    {
        private readonly IEmployeeManager employeeManager;
        private readonly IEmployeeSearcher searcher;
        private readonly IEmployeeRepository repository;
        private readonly ExporterFactory exporterFactory;
        private readonly ImporterFactory importerFactory;

        public MainController(
            IEmployeeRepository repository,
            IEmployeeManager employeeManager,
            IEmployeeSearcher searcher,
            ExporterFactory exporterFactory,
            ImporterFactory importerFactory)
        {
            this.repository = repository;
            this.employeeManager = employeeManager;
            this.searcher = searcher;
            this.exporterFactory = exporterFactory;
            this.importerFactory = importerFactory;
        }

        public void AddNewEmployee([NotNull] Employee employee)
        {
            repository.AddNew(employee);
        }

        [NotNull]
        [ItemNotNull]
        public IEnumerable<Employee> Search([NotNull] string str)
        {
            var keyWords = str.Trim().Split(' ');
            return searcher.Search(repository.GetAll(), keyWords);
        }

        public void Dismiss(int id)
        {
            var employee = repository.FindById(id) ?? throw new Exception("Bug, employee not found");
            employeeManager.Dismiss(employee, DateTime.Today);
            repository.Update(employee);
        }

        public void Recruit(int id)
        {
            var employee = repository.FindById(id) ?? throw new Exception("Bug, employee not found");
            employeeManager.Recruit(employee, DateTime.Today);
            repository.Update(employee);
        }

        public void ExportToXml([NotNull] Stream fileStream)
        {
            exporterFactory.CreateXmlExporter<Employee[]>().Export(repository.GetAll(), fileStream);
        }

        public void ImportFromXml([NotNull] Stream fileStream)
        {
            var employes = importerFactory.CreateXmlExporter<Employee[]>().Import(fileStream);
            repository.Clear();
            repository.AddRange(employes);
        }
    }
}