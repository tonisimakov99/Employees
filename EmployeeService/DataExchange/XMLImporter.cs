using System.IO;
using System.Xml.Serialization;
using EmployeeService.DataBase;
using JetBrains.Annotations;

namespace EmployeeService.DataExchange
{
    public class XmlImporter<TItem> : IImporter<TItem>
    {
        private readonly XmlSerializer serializer;

        public XmlImporter()
        {
            serializer = new XmlSerializer(typeof(TItem));
        }

        [NotNull]
        public TItem Import([NotNull] Stream file)
        {
            return (TItem) serializer.Deserialize(file);
        }
    }
}