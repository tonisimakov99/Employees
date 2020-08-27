using JetBrains.Annotations;

namespace EmployeeService.DataBase
{
    public interface IEmployeeStorage
    {
        void Write([NotNull] Employee employee);

        [NotNull]
        [ItemNotNull]
        Employee[] ReadAll();

        [CanBeNull]
        Employee TryReadById(int employeeId);
    }
}