using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NameSpace que contem as Classes que manipula dados
using System.Data;
using System.Data.SqlClient;

using AcessoBancoDados.Properties;

namespace AcessoBancoDados
{
   public class AcessoDadosSQLServer
    {
        //Cria a Conexao
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        //Paramenteos que vao para Banco Dados
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
        public void LimparParamnetros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParamentros(String nomeParamentro, object valorParamentro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParamentro, valorParamentro));
        }

        // Percistencia - Unserir - Alterar e Excluir
        public object ExcutarManipulacao(CommandType commandType, String nomeStoredProcedureOuTextoSql)
        {
            try
            {
                // Criar a Conexao
                SqlConnection sqlConnection = CriarConexao();
                //Abir Conexao
                sqlConnection.Open();
                //Criar Comando que vai levar informacoes para Banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do Comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;  // em Segundos 7200 = 2 horas

                //Adicionar os Paramentros no Comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Executa o Comando
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //Consultar registro do Banco de Dados
        public DataTable ExecutarConsulta(CommandType commandType, String nomeStoredProcedureOuTextoSql)
        {
            try
            {
                // Criar a Conexao
                SqlConnection sqlConnection = CriarConexao();
                //Abir Conexao
                sqlConnection.Open();
                //Criar Comando que vai levar informacoes para Banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //Colocando as coisas dentro do Comando
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;  // em Segundos 7200 = 2 horas

                //Adicionar os Paramentros no Comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Criar um Adptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //DataTable = Tabela de DAdos vazia onde vou colocar os dados que vem do Banco
                DataTable dataTable = new DataTable();

                //Mandar o comando ir  ate o bsnco buscar os dados e o Adptador preencher o datatable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
