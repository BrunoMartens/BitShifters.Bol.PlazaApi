using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BitShifters.Bol.PlazaApi.Helpers
{
    public static class BolXmlSerializer
    {
        public static T Deserialize<T>(string data, XmlRootAttribute xmlRootAttribute)
        {
            using(var reader = new StringReader(data))
            {
                var serializer = new XmlSerializer(typeof(T), xmlRootAttribute);
                return (T)serializer.Deserialize(reader);
            } 
        }

        public static string Serialize<T>(T obj, string defaultNamespace)
        {
            var settings = new XmlWriterSettings()
            {
                Encoding = Encoding.UTF8,
                Indent = false,
                OmitXmlDeclaration = false
            };

            using (var stream = new MemoryStream())
            {
                using (var xmlWriter = XmlWriter.Create(stream, settings))
                {
                    var serializer = new XmlSerializer(typeof(T), defaultNamespace);
                    serializer.Serialize(xmlWriter, obj);
                    return Encoding.UTF8.GetString(stream.ToArray());
                }     
            }
        }

        public static XmlRootAttribute GetXmlRootAttribute(string data)
        {
            var xdoc = XDocument.Parse(data);

            return new XmlRootAttribute(xdoc.Root.Name.LocalName)
            {
                Namespace = xdoc.Root.Name.Namespace.NamespaceName
            };
        }
    }
}
