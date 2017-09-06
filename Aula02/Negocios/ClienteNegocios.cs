using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class ClienteNegocios
    {
        //Instanciar = criar um novo objeto base ado em um modelo
        AcessoDadosSQLServer acessoDadosSQLServer = new AcessoDadosSQLServer();
        public string inserir(Cliente cliente)
        {
            try
            {
                acessoDadosSQLServer.LimparParamnetros();
                acessoDadosSQLServer.AdicionarParamentros("@Nome", cliente.Nome);
                acessoDadosSQLServer.AdicionarParamentros("@DataNascimento", cliente.DataNascimento);
                acessoDadosSQLServer.AdicionarParamentros("@Sexo", cliente.Sexo);
                acessoDadosSQLServer.AdicionarParamentros("@LimiteCompra", cliente.LimiteCompra);

                string idCliente = acessoDadosSQLServer.ExcutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();
                return idCliente;
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return ex.Message;
            }
        }

    }
}
