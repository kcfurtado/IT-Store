using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBD;
using ProjetoTransferencia;
using System.Data;


namespace Negocio
{
    public class ClienteNegocio
    {
        coneccao conect = new coneccao();

        public string inserir(Cliente cliente)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@cod_Func", cliente.cod_Func);
                conect.AdicionarParametro("@nome", cliente.nome);
                conect.AdicionarParametro("@telefone", cliente.telefone);
                conect.AdicionarParametro("@morada", cliente.morada);
                conect.AdicionarParametro("@email", cliente.email);
                conect.AdicionarParametro("@BI	", cliente.BI);
                
                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "clienteInserir").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }
        }

        public string alterar(Cliente cliente)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@cod_Func", cliente.cod_Func);
                conect.AdicionarParametro("@nome", cliente.nome);
                conect.AdicionarParametro("@telefone", cliente.telefone);
                conect.AdicionarParametro("@morada", cliente.morada);
                conect.AdicionarParametro("@email", cliente.email);
                conect.AdicionarParametro("@BI	", cliente.BI);

                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "clienteAlterar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }
        }

        public string eliminar(Cliente cliente)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@BI", cliente.BI);


                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "clienteEliminar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }
        }

        public ClienteColecao consulta(string pesquisa)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@nome", pesquisa);

                ClienteColecao clienteColecao = new ClienteColecao();

                DataTable dataTale = conect.ExecutarConsulta(CommandType.StoredProcedure, "clienteConsultaPorNome&BI");

                foreach (DataRow Linha in dataTale.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.BI = Convert.ToString(Linha["BI"]);
                    cliente.nome = Convert.ToString(Linha["nome"]);
                    cliente.telefone = Convert.ToInt32(Linha["telefone"]);
                    cliente.morada = Convert.ToString(Linha["morada"]);
                    cliente.cod_Func = Convert.ToInt32(Linha["cod_Func"]);
                    cliente.email = Convert.ToString(Linha["email"]);

                    clienteColecao.Add(cliente);
                }
                return clienteColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }
        }
        
    }
}
