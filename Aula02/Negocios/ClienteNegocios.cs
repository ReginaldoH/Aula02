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


        public string alterar(Cliente cliente)
        {
            try
            {
                acessoDadosSQLServer.LimparParamnetros();
                acessoDadosSQLServer.AdicionarParamentros("@idCliente", cliente.IdCliente);
                acessoDadosSQLServer.AdicionarParamentros("@Nome", cliente.Nome);
                acessoDadosSQLServer.AdicionarParamentros("@DataNascimento", cliente.DataNascimento);
                acessoDadosSQLServer.AdicionarParamentros("@Sexo", cliente.Sexo);
                acessoDadosSQLServer.AdicionarParamentros("@LimiteCompra", cliente.LimiteCompra);

                string idCliente = acessoDadosSQLServer.ExcutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString();
                return idCliente;
            }
            catch (Exception exeption)
            {
                return exeption.Message;
            }
        }


        public string excluir(Cliente cliente)
        {
            try
            {
                acessoDadosSQLServer.LimparParamnetros();
                acessoDadosSQLServer.AdicionarParamentros("@idCliente", cliente.IdCliente);
                string idCliente = acessoDadosSQLServer.ExcutarManipulacao(CommandType.StoredProcedure, "uspClienteExcluir").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;

            }
        }

        public ClienteColecao consultarPorNome(string nome)
        {
            try
            {
                //Clia uma Colecao de Cliente vazia
                ClienteColecao clienteColecao = new ClienteColecao();
                acessoDadosSQLServer.LimparParamnetros();
                acessoDadosSQLServer.AdicionarParamentros("@Nome", nome);
                //Data = Dados e Table = Tabela
                DataTable dataTableCliente = acessoDadosSQLServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorNome");

                //Percorrer o DataTable e transformar em Colecao de Cliente
                //Cada Linha do DataTable eh um Cliente
                //For=Para e Rach=Cada
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //Criar cliente vazio
                    //coclocar os dados da linha nele
                    //Adicionar ele na colecao cliente
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = Convert.ToInt32(linha["idCLiente"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.Sexo = Convert.ToBoolean(linha["Sexo"]);
                    cliente.LimiteCompra = Convert.ToDecimal(linha["LimiteCompra"]);

                    clienteColecao.Add(cliente);

                }
   
                return clienteColecao;
            }
            catch (Exception exception)
            {

                throw new Exception("Nao foi possivel consultar por Nome. Detalhes: " + exception.Message);
            }
        }

        public ClienteColecao consultarPorId(int idCliente)
        {
            try
            {
                //Clia uma Colecao de Cliente vazia
                ClienteColecao clienteColecao = new ClienteColecao();
                acessoDadosSQLServer.LimparParamnetros();
                acessoDadosSQLServer.AdicionarParamentros("@idCliente", idCliente);
                //Data = Dados e Table = Tabela
                DataTable dataTableCliente = acessoDadosSQLServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorNome");

                //Percorrer o DataTable e transformar em Colecao de Cliente
                //Cada Linha do DataTable eh um Cliente
                //For=Para e Rach=Cada
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //Criar cliente vazio
                    //coclocar os dados da linha nele
                    //Adicionar ele na colecao cliente
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = Convert.ToInt32(linha["idCLiente"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.Sexo = Convert.ToBoolean(linha["Sexo"]);
                    cliente.LimiteCompra = Convert.ToDecimal(linha["LimiteCompra"]);

                    clienteColecao.Add(cliente);

                }

                return clienteColecao;
            }
            catch (Exception exception)
            {

                throw new Exception("Nao foi possivel consultar por Codigo. Detalhes: " + exception.Message);
            }
        }
    }
}
