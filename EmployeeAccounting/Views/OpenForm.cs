using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeAccounting.Views
{
    class OpenForm:ISaveOpenView
    {
        private readonly OpenFileDialog openFileDialog;
        public OpenForm(string filter)
        {
            openFileDialog = new OpenFileDialog { Filter = filter };
        }
        public DialogResult ShowDialog()
        {
            return openFileDialog.ShowDialog();
        }

        public Stream OpenFile()
        {
            return openFileDialog.OpenFile();
        }

        public void Dispose()
        {
            openFileDialog.Dispose();
        }
    }
}
