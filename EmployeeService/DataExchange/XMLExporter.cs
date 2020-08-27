using System.IO;
using System.Xml.Serialization;
using JetBrains.Annotations;

namespace EmployeeService.DataExchange
{
    public class XmlExporter<TItem> : IExporter<TItem>
    {
        private readonly XmlSerializer serializer;

        public XmlExporter()
        {
            serializer = new XmlSerializer(typeof(TItem));
        }

        public void Export([NotNull] TItem item, [NotNull] Stream stream)
        {
            serializer.Serialize(stream, item);
        }
    }
}