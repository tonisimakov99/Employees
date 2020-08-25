using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeAccounting.DataBase;
using EmployeeAccounting.DataExchange;
using EmployeeAccounting.Searcher;

namespace EmployeeAccounting.Forms
{
    public class MainController
    {
        private Employer employer;
        private IRepository<Employee> repository;
        private ISearcher<Employee> searcher;
        private IExporter<Employee> exporter;
        private IImporter<Employee> importer;
        public IList<Employee> CurrentGridSource { get; private set; }

        public int SelectedEmployeeId;

        public MainController(IRepository<Employee> repository, Employer employer, ISearcher<Employee> searcher, IExporter<Employee> exporter, IImporter<Employee> importer)
        {
            this.repository = repository;
            this.employer = employer;
            this.searcher = searcher;
            this.exporter = exporter;
            this.importer = importer;
            CurrentGridSource = repository.GetAll().ToList();
        }

        public void AddNewEmployee(Employee employee)
        {
            repository.AddNew(employee);
            var source = CurrentGridSource.ToList();
            source.Add(employee);
            CurrentGridSource = source;
        }
        
        public void Search(string str)
        {
            var keyWords = str.Trim().Split(' ');
            var result = searcher.Search(repository, keyWords);
            CurrentGridSource = result.ToList();
        }

        public void Dismiss()
        {
            employer.Dismiss(SelectedEmployeeId, DateTime.Now);

            UpdateSelectedEmployeeInGridSource();
        }

        public void Recruite()
        {
            employer.Recruite(SelectedEmployeeId, DateTime.Now);

            UpdateSelectedEmployeeInGridSource();
        }

        public void SaveToXML(Stream file)
        {
            exporter.Export(repository.GetAll(), file);
        }

        public void OpenFromXML(Stream file)
        {
            var employes = importer.Import(file);
            repository.Clear();
            repository.AddRange(employes);
            CurrentGridSource = repository.GetAll().ToList();
        }
        private void UpdateSelectedEmployeeInGridSource()
        {
            var i = CurrentGridSource.IndexOf(CurrentGridSource.Single(t => t.Id == SelectedEmployeeId));
            CurrentGridSource[i] = repository.FindById(SelectedEmployeeId);
            CurrentGridSource = CurrentGridSource.ToList();
        }
    }
}
