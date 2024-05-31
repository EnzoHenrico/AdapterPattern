using Newtonsoft.Json;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace AdapterPattern
{
    public class AdaptadorCliente : IClientes
    {
        private readonly Cliente _cliente;

        public AdaptadorCliente(Cliente cliente)
        {
            _cliente = cliente;
        }

        public string SolicitarInformaçõesDaConta()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(_cliente.SolicitarInformaçõesDaConta());

            return JsonConvert.SerializeXmlNode(xmlDoc.DocumentElement, Formatting.Indented);
        }
    }
}
