using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeAccounting.Views
{
    class SaveForm : ISaveOpenView
    {
        private readonly SaveFileDialog saveFileDialog;
        public SaveForm()
        {
            saveFileDialog = new SaveFileDialog();
        }
        public DialogResult ShowDialog()
        {
            return saveFileDialog.ShowDialog();
        }

        public Stream OpenFile()
        {
            return saveFileDialog.OpenFile();
        }

        public void Dispose()
        {
            saveFileDialog.Dispose();
        }
    }
}
