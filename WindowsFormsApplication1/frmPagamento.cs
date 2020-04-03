using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoTransferencia;
using Negocio;
 

namespace WindowsFormsApplication1
{
    public partial class frmPagamento : Form
    {
        
        public frmPagamento()
        {
            InitializeComponent();
        }

        public void pesquisaPagamento(string str)
        {
            PagamentoNegocio pagamentoNegocio = new PagamentoNegocio();
            PagamentoColecao mntcN = pagamentoNegocio.Consultar(str);
            dataGridViewPagamento.AutoGenerateColumns = false;
            if (mntcN == null) { MessageBox.Show("Nao ha dados na Base de Dados."); return; }
            dataGridViewPagamento.DataSource = null;
            dataGridViewPagamento.DataSource = mntcN;
            dataGridViewPagamento.Update();
            dataGridViewPagamento.Refresh();
        }

        private void buttonPagamentoNovo_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();

            try
            {

                pagamento.cod_Func = Convert.ToInt32(textBoxPagamentoCod_Func.Text);
                pagamento.Cod_Pag = Convert.ToInt32(textBoxPagamentoCodigo.Text);
                pagamento.cod_Prod = Convert.ToString(textBoxPagamentoCod_Prod.Text);
                pagamento.data = Convert.ToDateTime(textBoxPagamentoData.Text);
                pagamento.Hora = Convert.ToDateTime(textBoxPagamentoHora.Text);
                pagamento.quantia = Convert.ToDecimal(textBoxPagamentoQuantia.Text);
                pagamento.tipo = Convert.ToString(textBoxPagamentoTipo.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhuma Linha foi atualizada.\n\nOs dados da linha não foram atualizadas.\nMensagem de Erro: " + ex.Message + "\n\nCorrija o erro e tente novamente ou pressione ESC para cancelar", "Sistema de Gestão de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            PagamentoNegocio pagamentoNegocio = new PagamentoNegocio();

            String retorno = pagamentoNegocio.Inserir(pagamento);

            try
            {


                int sucesso = Convert.ToInt32(retorno);
                MessageBox.Show("Uma Linha foi atualizada.\n\nOs dados da linha forom incluida com sucesso.\n\nPressione ESC para voltar", "Sistema Gestão de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pesquisaPagamento("%");

            }
            catch (Exception)
            {
                DialogResult dr = MessageBox.Show("Nenhuma Linha foi atualizada.\n\nOs dados da linha não foram atualizadas.\nMensagem de Erro: " + retorno + "\n\nCorrija o erro e tente novamente ou pressione ESC para cancelar", "Sistema de Gestão de Loja Informatica", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void buttonPagamentoAlterar_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();

            try
            {

                pagamento.cod_Func = Convert.ToInt32(textBoxPagamentoCod_Func.Text);
                pagamento.Cod_Pag = Convert.ToInt32(textBoxPagamentoCodigo.Text);
                pagamento.cod_Prod = Convert.ToString(textBoxPagamentoCod_Prod.Text);
                pagamento.data = Convert.ToDateTime(textBoxPagamentoData.Text);
                pagamento.Hora = Convert.ToDateTime(textBoxPagamentoHora.Text);
                pagamento.quantia = Convert.ToDecimal(textBoxPagamentoQuantia.Text);
                pagamento.tipo = Convert.ToString(textBoxPagamentoTipo.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhuma Linha foi atualizada.\n\nOs dados da linha não foram atualizadas.\nMensagem de Erro: " + ex.Message + "\n\nCorrija o erro e tente novamente ou pressione ESC para cancelar", "Sistema de Gestão de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            PagamentoNegocio pagamentoNegocio = new PagamentoNegocio();

            String retorno = pagamentoNegocio.Alterar(pagamento);

            try
            {


                int sucesso = Convert.ToInt32(retorno);
                MessageBox.Show("Uma Linha foi atualizada.\n\nOs dados da linha forom incluida com sucesso.\n\nPressione ESC para voltar", "Sistema Gestão de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pesquisaPagamento("%");

            }
            catch (Exception)
            {
                DialogResult dr = MessageBox.Show("Nenhuma Linha foi atualizada.\n\nOs dados da linha não foram atualizadas.\nMensagem de Erro: " + retorno + "\n\nCorrija o erro e tente novamente ou pressione ESC para cancelar", "Sistema de Gestão de Loja Informatica", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void buttonPagamentoEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPagamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum pagamento selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if ((dataGridViewPagamento.SelectedRows[0].DataBoundItem as Pagamento) == null)
            {
                MessageBox.Show("Uma linha vazia foi selecionada.\nPesquise o pagamento desejado e tente novamente.", "Sistema de Gestão de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //perguntar se quer excluir
            DialogResult result = MessageBox.Show("Você esta preste a excluir 1 Linha.\nClique em Sim para excluir permanentimente esta Linha.", "Sistema de Gestão de Loja Informatica", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result.Equals(DialogResult.No))
            {
                return;
            }


            PagamentoNegocio pagamentoNegocio = new PagamentoNegocio();
            Pagamento Selecionado = (dataGridViewPagamento.SelectedRows[0].DataBoundItem as Pagamento);//as => é um cliente dataBoundItem => item de dados caregado
            int x = dataGridViewPagamento.SelectedRows[0].Index;
            String retorno = pagamentoNegocio.Eliminar(Selecionado);


            try
            {
                int converter = Convert.ToInt32(retorno);
                pesquisaPagamento("%");

            }
            catch (Exception)
            {

                MessageBox.Show("Nenhuma Linha foi excluida.\n\nProblemas ao excluir a Linha " + (x + 1) + ". \nMensagem de Erro: " + retorno + "\n\nCorrija o erro e tente excluir a linha novamente ou pressione ESC para cancelar", "Sistema de Gestão de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonPagamentoPesquisa_Click(object sender, EventArgs e)
        {
            pesquisaPagamento(textBoxPagamentoPesquisa.Text);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {/*
            if (dataGridViewPagamento.SelectedRows.Count != 0)
            {
                buttonPagamentoAlterar.Enabled = true;
                buttonPagamentoEliminar.Enabled = true;
            }
            else
            {
                buttonPagamentoAlterar.Enabled = false;
                buttonPagamentoEliminar.Enabled = false;
            }*/
        }

        private void textBoxPagamentoPesquisa_TextChanged(object sender, EventArgs e)
        {
            pesquisaPagamento(textBoxPagamentoPesquisa.Text);
        }
    }
}
