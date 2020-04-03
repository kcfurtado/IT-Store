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
    public class VendaNegocio
    {

        coneccao conect = new coneccao();

        public String Inserir(Venda venda)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@cod_Venda", venda.cod_Venda);
                conect.AdicionarParametro("@BI", venda.BI);
                conect.AdicionarParametro("@data", venda.data);
                conect.AdicionarParametro("@cod_Func", venda.cod_Func);
               
                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "vendaInserir").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public String Alterar(Venda venda)
        {
            try
            {

                conect.LimparParametro();
                conect.AdicionarParametro("@cod_Venda", venda.cod_Venda);
                conect.AdicionarParametro("@BI", venda.BI);
                conect.AdicionarParametro("@data", venda.data);
                conect.AdicionarParametro("@cod_Func", venda.cod_Func);

                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "vendaAlterar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public String Eliminar(Venda venda)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@cod_Venda", venda.cod_Venda);


                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "vendaEliminar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public VendaColecao Consultar(string pesquisa)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@cod_Venda", pesquisa);

               VendaColecao vendaColecao = new VendaColecao();

                DataTable dataTale = conect.ExecutarConsulta(CommandType.StoredProcedure, "vendaConsultarPorCodigo");

                foreach (DataRow Linha in dataTale.Rows)
                {
                    Venda venda = new Venda();

                    venda.cod_Venda = Convert.ToInt32(Linha["cod_Venda"]);
                    venda.BI = Convert.ToString(Linha["BI"]);
                    venda.cod_Func = Convert.ToInt32(Linha["cod_Func"]);
                    venda.data = Convert.ToDateTime(Linha["data"]);
                    

                    vendaColecao.Add(venda);
                }
                return vendaColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

    }
}
