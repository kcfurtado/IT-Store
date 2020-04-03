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
   public class ProdutoVendaNegocio
    {
        coneccao conect = new coneccao();

        public String Inserir(ProdutoVenda produtoVenda)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Cod_P", produtoVenda.Cod_P);
                conect.AdicionarParametro("@Nome_P", produtoVenda.Nome_P);
                conect.AdicionarParametro("@Marca_P", produtoVenda.Marca_P);
                conect.AdicionarParametro("@Modelo_Po", produtoVenda.Modelo_P);
                conect.AdicionarParametro("@quantidd_stock", produtoVenda.quantidd_stock);
               
               

                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "produto_Venda_Inserir").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public String Alterar(ProdutoVenda produtoVenda)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Cod_P", produtoVenda.Cod_P);
                conect.AdicionarParametro("@Nome_P", produtoVenda.Nome_P);
                conect.AdicionarParametro("@Marca_P", produtoVenda.Marca_P);
                conect.AdicionarParametro("@Modelo_Po", produtoVenda.Modelo_P);
                conect.AdicionarParametro("@quantidd_stock", produtoVenda.quantidd_stock);



                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "produto_Venda_Alterar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public String Eliminar(ProdutoVenda produtoVenda)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Cod_P", produtoVenda.Cod_P);


                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "produto_Venda_Eliminar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public ProdutoVendaColecao Consultar(string pesquisa)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Nome_P", pesquisa);

                ProdutoVendaColecao produtoVendaColecao = new ProdutoVendaColecao();

                DataTable dataTale = conect.ExecutarConsulta(CommandType.StoredProcedure, "produto_Venda_Consulta");

                foreach (DataRow Linha in dataTale.Rows)
                {
                    ProdutoVenda produtoVenda = new ProdutoVenda();
                   
                    produtoVenda.Cod_P= Convert.ToInt32(Linha["Cod_P"]);
                    produtoVenda.Marca_P = Convert.ToString(Linha["Nome_P"]);
                    produtoVenda.Nome_P = Convert.ToString(Linha["Marca_P"]);
                    produtoVenda.Modelo_P = Convert.ToString(Linha["Modelo_P"]);
                    produtoVenda.quantidd_stock = Convert.ToInt32(Linha["quantidd_stock"]);

                    produtoVendaColecao.Add(produtoVenda);
                }
                return produtoVendaColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }
    }
}
