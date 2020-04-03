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
    public class ProdutoClienteNegocio
    {
        coneccao conect = new coneccao();

        public String Inserir(ProdutoCliente produtoCliente)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@cod_Prod ", produtoCliente.cod_Prod);
                conect.AdicionarParametro("@nome", produtoCliente.nome);
                conect.AdicionarParametro("@marca", produtoCliente.marca);
                conect.AdicionarParametro("@modelo", produtoCliente.modelo);
                conect.AdicionarParametro("@quantidade", produtoCliente.quantidade);
                conect.AdicionarParametro("@cod_Func", produtoCliente.cod_Func);
                conect.AdicionarParametro("@BI", produtoCliente.BI);

                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "produtoInserir").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public String Alterar(ProdutoCliente produtoCliente)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@cod_Prod ", produtoCliente.cod_Prod);
                conect.AdicionarParametro("@nome", produtoCliente.nome);
                conect.AdicionarParametro("@marca", produtoCliente.marca);
                conect.AdicionarParametro("@modelo", produtoCliente.modelo);
                conect.AdicionarParametro("@quantidade", produtoCliente.quantidade);
                conect.AdicionarParametro("@cod_Func", produtoCliente.cod_Func);
                conect.AdicionarParametro("@BI", produtoCliente.BI);

                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "produtoAlterar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public String Eliminar(ProdutoCliente produtoCliente)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@cod_Prod ", produtoCliente.cod_Prod);


                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "produtoEliminar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public ProdutoClienteColecao Consultar(string pesquisa)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@nome", pesquisa);

                ProdutoClienteColecao produtoClienteColecao = new ProdutoClienteColecao();

                DataTable dataTale = conect.ExecutarConsulta(CommandType.StoredProcedure, "produtoConsultaPorNome&Cod");

                foreach (DataRow Linha in dataTale.Rows)
                {
                    ProdutoCliente produtoCliente = new ProdutoCliente();
                    produtoCliente.BI = Convert.ToString(Linha["BI"]);
                    produtoCliente.cod_Func = Convert.ToInt32(Linha["cod_Func"]);
                    produtoCliente.cod_Prod = Convert.ToString(Linha["cod_Prod"]);
                    produtoCliente.marca = Convert.ToString(Linha["marca"]);
                    produtoCliente.nome = Convert.ToString(Linha["nome"]);
                    produtoCliente.modelo = Convert.ToString(Linha["modelo"]);
                    produtoCliente.quantidade = Convert.ToInt32(Linha["quantidade"]);

                    produtoClienteColecao.Add(produtoCliente);
                }
                return produtoClienteColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

    }
}
