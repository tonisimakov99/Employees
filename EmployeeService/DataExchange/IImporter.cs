using System.IO;
using JetBrains.Annotations;

namespace EmployeeService.DataExchange
{
    public interface IImporter<out TItem>
    {
        [NotNull]
        TItem Import([NotNull] Stream stream);
    }
}