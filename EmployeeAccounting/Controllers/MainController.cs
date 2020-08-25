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
using EmployeeAccounting.Views;

namespace EmployeeAccounting.Controllers
{
    public class MainController
    {
        private readonly IEmployer employer;
        private readonly IRepository<Employee> repository;
        private readonly ISearcher<Employee> searcher;
        private readonly IExporter<Employee> exporter;
        private readonly IImporter<Employee> importer;
        private IList<Employee> currentGridSource;
        public IMainView MainView { get; private set; }
        public MainController(IMainView mainView, IRepository<Employee> repository, IEmployer employer,
            ISearcher<Employee> searcher, IExporter<Employee> exporter, IImporter<Employee> importer)
        {
            this.MainView = mainView;
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
            MainView.OpenFromXmlCall += OpenFromXml;
            MainView.SaveToXmlCall += SaveToXml;
            MainView.AddNewEmployeeCall += AddNewEmployee;
            MainView.RecruitCall += Recruit;
            MainView.DismissCall += Dismiss;
            MainView.SearchInputTextChanged += Search;
        }

        public void AddNewEmployee(Employee employee)
        {
            repository.AddNew(employee);
            currentGridSource.Add(employee);
            MainView.UpdateView(currentGridSource);
        }
        
        public void Search(string str)
        {
            var keyWords = str.Trim().Split(' ');
            var result = searcher.Search(repository, keyWords);
            currentGridSource = result.ToList();
            MainView.UpdateView(currentGridSource);
        }

        public void Dismiss(int id)
        {
            var employee = repository.FindById(id);
            employer.Dismiss(employee, DateTime.Today);
            repository.Update(employee);
            employer.Dismiss(currentGridSource.Single(t=>t.Id==id),DateTime.Today);
            MainView.UpdateView(currentGridSource);
        }

        public void Recruit(int id)
        {
            var employee = repository.FindById(id);
            employer.Recruite(employee, DateTime.Today);
            repository.Update(employee);
            employer.Recruite(currentGridSource.Single(t => t.Id == id), DateTime.Today);
            MainView.UpdateView(currentGridSource);
        }

        public void SaveToXml()
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = exporter.FileFilter;
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
                using (var file = saveFileDialog.OpenFile())
                {
                    exporter.Export(repository.GetAll(), file);
                }
            }
        }

        public void OpenFromXml()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = importer.FileFilter;
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
                using (var file = openFileDialog.OpenFile())
                {
                    var employes = importer.Import(file);
                    repository.Clear();
                    repository.AddRange(employes);
                    currentGridSource = repository.GetAll().ToList();
                    MainView.UpdateView(currentGridSource);
                }
            }
        }
    }
}
