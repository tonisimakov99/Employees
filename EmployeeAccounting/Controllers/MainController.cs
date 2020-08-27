using System;
using System.Collections.Generic;
using System.IO;
using EmployeeService.DataBase;
using EmployeeService.DataExchange;
using EmployeeService.Employer;
using EmployeeService.Searcher;
using JetBrains.Annotations;

namespace EmployeeAccounting.Controllers
{
    public class MainController
    {
        private readonly IEmployeeStorage employeeStorage;
        private readonly IEmployeeManager employeeManager;
        private readonly ExporterFactory exporterFactory;
        private readonly IEmployeeSearcher searcher;

        public MainController(
            IEmployeeStorage employeeStorage,
            IEmployeeManager employeeManager,
            IEmployeeSearcher searcher,
            ExporterFactory exporterFactory)
        {
            this.employeeStorage = employeeStorage;
            this.employeeManager = employeeManager;
            this.searcher = searcher;
            this.exporterFactory = exporterFactory;
        }

        public void AddNewEmployee([NotNull] Employee employee)
        {
            employeeManager.Recruit(employee);
            employeeStorage.Write(employee);
        }

        [NotNull]
        [ItemNotNull]
        public IEnumerable<Employee> Search([NotNull] string searchRequest)
        {
            return searcher.Search(searchRequest);
        }

        public void Dismiss(int id)
        {
            var employee = employeeStorage.TryReadById(id) ?? throw new Exception("Bug, employee not found");
            employeeManager.Dismiss(employee);
            employeeStorage.Write(employee);
        }

        public void Recruit(int id)
        {
            var employee = employeeStorage.TryReadById(id) ?? throw new Exception("Bug, employee not found");
            employeeManager.Recruit(employee);
            employeeStorage.Write(employee);
        }

        public void ExportToXml([NotNull] Stream fileStream)
        {
            exporterFactory.CreateXmlExporter<Employee[]>().Export(employeeStorage.ReadAll(), fileStream);
        }
    }
}