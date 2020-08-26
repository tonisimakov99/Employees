using System.IO;
using System.Linq;
using System.Xml.Serialization;
using EmployeeService.DataBase;
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