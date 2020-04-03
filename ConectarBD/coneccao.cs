using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConectarBD.Properties;
using System.Data.SqlClient;

namespace ConectarBD
{
    public class coneccao
    {
        //Criar Conexao 
        private SqlConnection conecao_SQL_Server()
        {
            return new SqlConnection(Settings.Default.StringConecao);
        }

        //Parametros que vao para base de dados
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametro()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametro(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        //Persistencia - Inserir, Alterar e Excluir
        public Object ExecutarManipulacao(CommandType commandType, string SQLouProcedure)
        {
            try
            {
                //Criar a conexao
            SqlConnection sqlConnection = conecao_SQL_Server();
            //abrir conexao
            sqlConnection.Open();  
            //Criar Comando que vai levar informacao para o banco                 
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //Preencher o comando (dentro da caixa que vai navegar na conexao
            sqlCommand.CommandType = commandType;
            sqlCommand.CommandText = SQLouProcedure;
            sqlCommand.CommandTimeout = 2000;//em segundo

            foreach (SqlParameter sqlParameter in sqlParameterCollection)
            {
                sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

            }
            // Executar o comando, ou seja, mandar o comando ir até base de dados
        
            return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao " + ex.Message);
            }
           
        }

        //Executar Backup
        public object ExecutarBackup(CommandType commandType, string nomeProcedureOUComandoSQL)
        {
            try
            {
                //CommandType conjunto de objeto que não muda é um emumerador
                //criar a conexão
                SqlConnection sqlConnection = conecao_SQL_Server();
                //abrir uma conexão
                sqlConnection.Open();
                //criar comando que desejamos rializar no banco
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                //colocar os dados dentro do comando para trafegar na conexão
                //Que tipo de comando vamos executar
                sqlCommand.CommandType = commandType;
                //o que quero executar
                sqlCommand.CommandText = nomeProcedureOUComandoSQL;
                //tempo que a conexão fica aberta ou espera para exeutar o comando, passado o tempo fecha a conexão
                sqlCommand.CommandTimeout = 7200;//2hora

                //Adicionar os parametros no comando
                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //Executa os comandos e retorna a primeira linha que encontrar
                return sqlCommand.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                //Para enviar o erro para que estever usando este metodo
                throw new Exception(ex.Message);

            }

        }

        //Consultar registros base de dados
        public DataTable ExecutarConsulta(CommandType commandType, string SQLouProcedure)
        {

            try
            {
                SqlConnection sqlConnection = conecao_SQL_Server();
                sqlConnection.Open();

                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = SQLouProcedure;
                sqlCommand.CommandTimeout = 2000;//em segundo

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                }

                //  Criar Adptador

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //DataTable= Tabela de Dados vazia onde vou colocar os dados que ven do banco
                DataTable dataTable = new DataTable();

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
