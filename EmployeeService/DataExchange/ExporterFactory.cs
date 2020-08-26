namespace EmployeeService.DataExchange
{
    public class ExporterFactory
    {
        public IExporter<TItem> CreateXmlExporter<TItem>()
        {
            return new XmlExporter<TItem>();
        }
    }
}