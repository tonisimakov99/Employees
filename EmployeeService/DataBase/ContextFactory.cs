namespace EmployeeService.DataBase
{
    public class ContextFactory
    {
        private readonly string connectionString;

        public ContextFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Context CreateContext()
        {
            return new Context(connectionString);
        }
    }
}