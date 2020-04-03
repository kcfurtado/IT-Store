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
    public class ManutencaoNegocio
    {
        coneccao conect = new coneccao();

        public String Inserir(Manutencao manutencao)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Cod_Man", manutencao.Cod_Man);
                conect.AdicionarParametro("@Orçamento", manutencao.Orcamento);
                conect.AdicionarParametro("@Cod_Fun", manutencao.Cod_Fun);
                conect.AdicionarParametro("@Diagnostico", manutencao.Diagnostico);

               return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "manutencaoInserir").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao"+ ex.Message);
            }
          

        }

        public String Alterar(Manutencao manutencao)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Cod_Man", manutencao.Cod_Man);
                conect.AdicionarParametro("@Orçamento", manutencao.Orcamento);
                conect.AdicionarParametro("@Cod_Fun", manutencao.Cod_Fun);
                conect.AdicionarParametro("@Diagnostico", manutencao.Diagnostico);

                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "manutencaoAlterar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public String Eliminar(Manutencao manutencao)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Cod_Man", manutencao.Cod_Man);
              

                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "manutencaoEliminar").ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

        public ManutencaoColecao Consultar(string pesquisa)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Diagnostico", pesquisa);

                ManutencaoColecao manutencaoColecao = new ManutencaoColecao(); 

                DataTable dataTale = conect.ExecutarConsulta(CommandType.StoredProcedure, "manutencaoConsultarPorDiagnostico");

                foreach (DataRow Linha in dataTale.Rows)
                {
                    Manutencao manutencao = new Manutencao();
                    manutencao.Cod_Man = Convert.ToInt32(Linha["Cod_Man"]);
                    manutencao.Orcamento = Convert.ToDecimal(Linha["Orçamento"]);
                    manutencao.Cod_Fun = Convert.ToInt32(Linha["Cod_Fun"]);
                    manutencao.Diagnostico = Convert.ToString(Linha["Diagnostico"]);

                    manutencaoColecao.Add(manutencao);
                }
                return manutencaoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro na conexao" + ex.Message);
            }


        }

    }
}
