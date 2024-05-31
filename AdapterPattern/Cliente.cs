using System.Xml.Serialization;

namespace AdapterPattern
{
    public class Cliente
    {
        [XmlElement("nome")]
        public string? Nome { get; set; }
        [XmlElement("idade")]
        public int Idade { get; set; }

        public override string ToString()
        {
            return GerarXml();
        }

        public string SolicitarInformaçõesDaConta()
        {
            return GerarXml();
        }

        private string GerarXml()
        {
            // Remover namespaces
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", "");

            // Serializar XML
            var xmlSerializer = new XmlSerializer(typeof(Cliente));
            var textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, this, namespaces);

            return textWriter.ToString();
        }
    }
}
