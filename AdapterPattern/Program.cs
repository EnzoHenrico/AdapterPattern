
namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente
            {
                Nome = "Enzo",
                Idade = 24
            };

            Console.WriteLine("\nUtilizando a nova funcionalidade sem adaptador: ");
            InterfaceGrafica.ImprimirCliente(cliente.SolicitarInformaçõesDaConta());
            Console.WriteLine("\n--------------------------------------------------------------------------------");

            Console.WriteLine("\nUtilizando o padrão de adaptador para adequar as novas funcionalidades: ");
            IClientes adaptador = new AdaptadorCliente(cliente);
            InterfaceGrafica.ImprimirCliente(adaptador.SolicitarInformaçõesDaConta());
            Console.WriteLine("\n--------------------------------------------------------------------------------");
            
            Console.WriteLine("\nA funcionalidade original do Cliente se mantém sem alterar o código do mesmo: ");
            Console.WriteLine(cliente);
        }
    }
}
