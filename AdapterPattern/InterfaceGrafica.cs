using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AdapterPattern
{
    public class InterfaceGrafica
    {
        public static void ImprimirCliente(string strJson)
        {
            try
            {
                var json = JObject.Parse(strJson);
                Console.WriteLine(json.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nERROR: {e.Message}");
            }
        }
    }
}
