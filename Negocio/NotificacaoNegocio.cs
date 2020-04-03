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
   public class NotificacaoNegocio
    {
         coneccao conect = new coneccao();

        public string Novo(Notificacao notificacao)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@Nome", notificacao.Nome);
                conect.AdicionarParametro("@Messagem", notificacao.Mensagem);

                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "notificacaoInserir").ToString();
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Alterar(int cod)
        {
            try
            {
                conect.LimparParametro();
                conect.AdicionarParametro("@codigo", cod);

                return conect.ExecutarManipulacao(System.Data.CommandType.StoredProcedure, "notificacaoAlterar").ToString();
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public NotificacaoColecao Consultar()
        {
            try
            {
                DataTable tabelaDados = conect.ExecutarConsulta(System.Data.CommandType.StoredProcedure, "notificacaoConsultar");

                NotificacaoColecao notificacaoColecao = new NotificacaoColecao();

                foreach (DataRow linha in tabelaDados.Rows)
                {
                    Notificacao notificacao = new Notificacao();

                    notificacao.Codigo = Convert.ToInt32(linha["Codigo"]);
                    notificacao.Nome = linha["Nome"].ToString();
                    notificacao.Mensagem = linha["Messagem"].ToString();

                    notificacaoColecao.Add(notificacao);
                }
                return notificacaoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao Pesquisar as Notificações.\nErro: " + ex.Message);
            }
        }
    }
}

