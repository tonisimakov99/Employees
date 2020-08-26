namespace EmployeeService.DataExchange
{
    public class ImporterFactory
    {
        public IImporter<TItem> CreateXmlExporter<TItem>()
        {
            return new XmlImporter<TItem>();
        }
    }
}