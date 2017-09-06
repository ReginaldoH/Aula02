using Negocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola Aminguinho!!");
            
            try
            {
                ClienteNegocio clienetNegocio = new ClienteNegocio();


                Cliente cliente = new Cliente();
                cliente.Nome = "Ricardo " + DateTime.Now.Ticks;
                cliente.LimiteCompra = 500;
                cliente.DataNascimento = DateTime.Now;
                cliente.Sexo = true;

                decimal retorno = clienetNegocio.inserir(cliente);

                Console.WriteLine(string.Format("Renorno: {0:0.0}", retorno));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Falha: {0}", ex.Message));
            }
            


            Console.WriteLine("Fim");
            Console.ReadLine();
        }
    }
}
