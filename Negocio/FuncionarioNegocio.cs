using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConectarBD;
using ProjetoTransferencia;
using Negocio.Properties;

namespace Negocio
{
    public class FuncionarioNegocio
    {
        coneccao conect = new coneccao();

        public Funcionario login(String Usuario, String Senha)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Usuario", Usuario);
                conect.AdicionarParametro("@Senha", Senha);
               

                DataTable tabelaLogin = conect.ExecutarConsulta(System.Data.CommandType.StoredProcedure, "FuncionarioLogin");
                Funcionario funcionario = new Funcionario();
                foreach (DataRow Linha in tabelaLogin.Rows)
                {    
                    
                    funcionario.Usuario = Convert.ToString(Linha["Usuario"]);
                    funcionario.Senha = Convert.ToString(Linha["Senha"]);
                    funcionario.Tipo_Fun = Convert.ToString(Linha["Tipo_Fun"]);
                    funcionario.cod_Fun = Convert.ToInt32(Linha["cod_Func"]);
                }
                return funcionario;

            }
            catch (Exception ex)
            {

                throw new Exception("err" +ex.Message);
            }
                   }

        public string inserir(Funcionario funcionario)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@cod_Func", funcionario.cod_Fun);
                conect.AdicionarParametro("@nome", funcionario.nome);
                conect.AdicionarParametro("@NIF", funcionario.NIF);
                conect.AdicionarParametro("@telefone", funcionario.Telefone);
                conect.AdicionarParametro("@morada", funcionario.Morada);
                conect.AdicionarParametro("@email", funcionario.Email);
                conect.AdicionarParametro("@num_BI", funcionario.Num_BI);
                conect.AdicionarParametro("@Tipo_Fun", funcionario.Tipo_Fun);
                conect.AdicionarParametro("@cod_Supr", funcionario.cod_Supr);
                conect.AdicionarParametro("@Usuario", funcionario.Usuario);
                conect.AdicionarParametro("@Senha", funcionario.Senha);
               // conect.AdicionarParametro("@Confirmacao_senha", funcionario.Conf_Senha);

                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "funcionarioInserir").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }
        }

        public string alterar(Funcionario funcionario)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@cod_Func", funcionario.cod_Fun);
                conect.AdicionarParametro("@nome", funcionario.nome);
                conect.AdicionarParametro("@NIF", funcionario.NIF);
                conect.AdicionarParametro("@telefone", funcionario.Telefone);
                conect.AdicionarParametro("@morada", funcionario.Morada);
                conect.AdicionarParametro("@email", funcionario.Email);
                conect.AdicionarParametro("@num_BI", funcionario.Num_BI);
                conect.AdicionarParametro("@Tipo_Fun", funcionario.Tipo_Fun);
                conect.AdicionarParametro("@cod_Supr", funcionario.cod_Supr);
                conect.AdicionarParametro("@Usuario", funcionario.Usuario);
                conect.AdicionarParametro("@Senha", funcionario.Senha);
                //conect.AdicionarParametro("@Confirmacao_senha", funcionario.Conf_Senha);

                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "funcionarioAlterar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao " + ex.Message);
            }
        }

        public string eliminar(Funcionario funcionario)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@cod_Func", funcionario.cod_Fun);


                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "funcionarioEliminar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }
        }

        public Funcionario ConsultarMeusDados(int nif)
        {


            FuncionarioColecao funcionarioColecao = new FuncionarioColecao();
            conect.LimparParametro();
            conect.AdicionarParametro("@cod_Func", nif);

            DataTable dataTale = conect.ExecutarConsulta(CommandType.StoredProcedure, "funcionarioMeusDados");

            Funcionario funcionario = new Funcionario();
            foreach (DataRow Linha in dataTale.Rows)
            {

            
            funcionario.cod_Fun = Convert.ToInt32(Linha["cod_Func"]);
            funcionario.nome = Convert.ToString(Linha["nome"]);
            funcionario.NIF = Convert.ToInt32(Linha["nif"]);
            funcionario.Telefone = Convert.ToInt32(Linha["telefone"]);
            funcionario.Morada = Convert.ToString(Linha["morada"]);
            funcionario.Email = Convert.ToString(Linha["email"]);
            funcionario.Num_BI = Convert.ToInt32(Linha["num_BI"]);
            funcionario.Tipo_Fun = Convert.ToString(Linha["Tipo_Fun"]);
            funcionario.cod_Supr = Convert.ToString(Linha["cod_Supr"]);
            funcionario.Usuario = Convert.ToString(Linha["Usuario"]);
            funcionario.Senha = Convert.ToString(Linha["Senha"]);
           // funcionario.Conf_Senha = Convert.ToString(Linha["Confirmacao_senha"]);
            
            }
            return funcionario;
        } 

        public FuncionarioColecao Consultar()
        {
            try
            {
              
                FuncionarioColecao funcionarioColecao = new FuncionarioColecao();

                DataTable dataTale = conect.ExecutarConsulta(CommandType.StoredProcedure, "funcionarioConsultar");

                foreach (DataRow Linha in dataTale.Rows)
                {
                    Funcionario funcionario = new Funcionario();
                    
                    funcionario.cod_Fun = Convert.ToInt32(Linha["cod_Func"]);
                    funcionario.nome = Convert.ToString(Linha["nome"]);
                    funcionario.NIF = Convert.ToInt32(Linha["nif"]);
                    funcionario.Telefone = Convert.ToInt32(Linha["telefone"]);
                    funcionario.Morada = Convert.ToString(Linha["morada"]);
                    funcionario.Email = Convert.ToString(Linha["email"]);
                    funcionario.Num_BI = Convert.ToInt32(Linha["num_BI"]);
                    funcionario.Tipo_Fun = Convert.ToString(Linha["Tipo_Fun"]);
                    funcionario.cod_Supr= Convert.ToString(Linha["cod_Supr"]);
                    funcionario.Usuario = Convert.ToString(Linha["Usuario"]);
                    funcionario.Senha = Convert.ToString(Linha["Senha"]);
                    //funcionario.Conf_Senha = Convert.ToString(Linha["Confirmacao_senha"]);

                    funcionarioColecao.Add(funcionario);
                }
                return funcionarioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na conexao" + ex.Message);
            }

        }
    }
}
