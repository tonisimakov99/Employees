using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Main : Form
    {
        private Employer employer { get; set; }
        private IEmployeesData data { get; set; }
        private int selectedEmployeeId { get; set; }
        public Main(Employer employer, IEmployeesData data)
        {
            this.employer = employer;
            this.data = data;
            InitializeComponent();
        }
        private void ShowSearchResult(object sender, EventArgs args)
        {
            var searcher = new SearcherByString();
            var result = data.SearchByStr(searcher,SearchInputStr.Text);
            this.EmployeesDataGrid.DataSource = result;
        }

        private void SelectEmployee(object sender, DataGridViewCellEventArgs e)
        {
            selectedEmployeeId = (int)this.EmployeesDataGrid[0, e.RowIndex].Value;
        }

        private void Dismiss(object sender, EventArgs e)
        {
            employer.Dismiss(selectedEmployeeId, DateTime.Now);
        }

        private void Recruite(object sender, EventArgs e)
        {
            employer.Recruite(selectedEmployeeId, DateTime.Now);
        }
    }
}
