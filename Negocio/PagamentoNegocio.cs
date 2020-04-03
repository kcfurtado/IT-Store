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
   public class PagamentoNegocio 
    {
        coneccao conect = new coneccao();

        public String Inserir(Pagamento pagamento)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Cod_Pag", pagamento.Cod_Pag);
                conect.AdicionarParametro("@cod_Func", pagamento.cod_Func);
                conect.AdicionarParametro("@cod_Prod", pagamento.cod_Prod);
                conect.AdicionarParametro("@quantia", pagamento.quantia);
                conect.AdicionarParametro("@Hora", pagamento.Hora);
                conect.AdicionarParametro("@data", pagamento.data);
                conect.AdicionarParametro("@tipo", pagamento.tipo);
               


                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "pagamentoNovo").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public String Alterar(Pagamento pagamento)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Cod_Pag", pagamento.Cod_Pag);
                conect.AdicionarParametro("@cod_Func", pagamento.cod_Func);
                conect.AdicionarParametro("@cod_Prod", pagamento.cod_Prod);
                conect.AdicionarParametro("@quantia", pagamento.quantia);
                conect.AdicionarParametro("@Hora", pagamento.Hora);
                conect.AdicionarParametro("@data", pagamento.data);
                conect.AdicionarParametro("@tipo", pagamento.tipo);
               


                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "pagamentoAlterar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public String Eliminar(Pagamento pagamento)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Cod_Pag", pagamento.Cod_Pag);

                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "pagamentoEliminar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public PagamentoColecao Consultar(string str)
        {
            
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Cod_Pag ", str);

                PagamentoColecao pagamentoColecao = new PagamentoColecao();

                DataTable dataTale = conect.ExecutarConsulta(CommandType.StoredProcedure, "pagamentoPesquisar");

                foreach (DataRow Linha in dataTale.Rows)
                {
                    Pagamento pagamento = new Pagamento();
                    pagamento.Cod_Pag = Convert.ToInt32(Linha["Cod_Pag"]);
                    pagamento.cod_Prod = Convert.ToString(Linha["cod_Prod"]);
                    
                    pagamento.cod_Func = Convert.ToInt32(Linha["cod_Func"]);
                    pagamento.data = Convert.ToDateTime(Linha["Data"]);
                    //pagamento.Hora = Convert.ToDateTime(Linha["Hora"]);
                    pagamento.quantia = Convert.ToDecimal(Linha["quantia"]);
                    pagamento.tipo = Convert.ToString(Linha["tipo"]);

                    pagamentoColecao.Add(pagamento);
                }
                return pagamentoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

    }
}

