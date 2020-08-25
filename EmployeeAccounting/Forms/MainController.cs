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
        private IEmployer employer;
        private IRepository<Employee> repository;
        private ISearcher<Employee> searcher;
        private IExporter<Employee> exporter;
        private IImporter<Employee> importer;
        private IMainView mainView;
        private IList<Employee> currentGridSource { get; set; }
        public MainController(IMainView mainView, IRepository<Employee> repository, IEmployer employer,
            ISearcher<Employee> searcher, IExporter<Employee> exporter, IImporter<Employee> importer)
        {
            this.mainView = mainView;
            this.repository = repository;
            this.employer = employer;
            this.searcher = searcher;
            this.exporter = exporter;
            this.importer = importer;
            SubscribeToView();
            currentGridSource = repository.GetAll().ToList();
            mainView.UpdateView(currentGridSource);
        }

        private void SubscribeToView()
        {
            mainView.OpenFromXmlCall += OpenFromXml;
            mainView.SaveToXmlCall += SaveToXml;
            mainView.AddNewEmployeeCall += AddNewEmployee;
            mainView.RecruiteCall += Recruite;
            mainView.DismissCall += Dismiss;
            mainView.SearchInputTextChanged += Search;
        }

        public void AddNewEmployee(Employee employee)
        {
            repository.AddNew(employee);
            currentGridSource.Add(employee);
            mainView.UpdateView(currentGridSource);
        }
        
        public void Search(string str)
        {
            var keyWords = str.Trim().Split(' ');
            var result = searcher.Search(repository, keyWords);
            currentGridSource = result.ToList();
            mainView.UpdateView(currentGridSource);
        }

        public void Dismiss(int id)
        {
            var employee = repository.FindById(id);
            employer.Dismiss(employee, DateTime.Today);
            repository.Update(employee);
            employer.Dismiss(currentGridSource.Single(t=>t.Id==id),DateTime.Today);
            mainView.UpdateView(currentGridSource);
        }

        public void Recruite(int id)
        {
            var employee = repository.FindById(id);
            employer.Recruite(employee, DateTime.Today);
            repository.Update(employee);
            employer.Recruite(currentGridSource.Single(t => t.Id == id), DateTime.Today);
            mainView.UpdateView(currentGridSource);
        }

        public void SaveToXml(Stream file)
        {
            exporter.Export(repository.GetAll(), file);
        }

        public void OpenFromXml(Stream file)
        {
            var employes = importer.Import(file);
            repository.Clear();
            repository.AddRange(employes);
            currentGridSource = repository.GetAll().ToList();
            mainView.UpdateView(currentGridSource);
        }
    }
}
