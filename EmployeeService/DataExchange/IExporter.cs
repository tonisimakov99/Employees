using System.IO;
using JetBrains.Annotations;

namespace EmployeeService.DataExchange
{
    public interface IExporter<in TItem>
    {
        void Export([NotNull] TItem item, [NotNull] Stream stream);
    }
}