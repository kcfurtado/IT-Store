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
    public partial class frmProdutoCliente : Form
    {
        public frmProdutoCliente()
        {
            InitializeComponent();
        }


        public void pesquisa(string str)
        {
            ProdutoClienteNegocio produtoClienteNegocio = new ProdutoClienteNegocio();
            dataGridViewProdutoCliente.AutoGenerateColumns = false;
            ProdutoClienteColecao mntcN = produtoClienteNegocio.Consultar(str);

            if (mntcN == null) { MessageBox.Show("Nao ha dados na Base de Dados."); return; }

            dataGridViewProdutoCliente.DataSource = null;
            dataGridViewProdutoCliente.DataSource = mntcN;
            dataGridViewProdutoCliente.Update();
            dataGridViewProdutoCliente.Refresh();
        }

        private void buttonPesquisarProdutoCliente_Click(object sender, EventArgs e)
        {
           if (textBoxPesquisa.Text == "") { MessageBox.Show("Prencha o campo de pesquisa."); return; }
            pesquisa(textBoxPesquisa.Text);
        }

        private void buttonAlterarProdutoCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutoCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto Selecionada");
                return;
            }


            if ((dataGridViewProdutoCliente.SelectedRows[0].DataBoundItem as ProdutoCliente) == null)
            {
                MessageBox.Show(" linha vazia Selecionada");
                return;
            }
            ProdutoCliente datagriV = dataGridViewProdutoCliente.SelectedRows[0].DataBoundItem as ProdutoCliente;

            frmProdutoClienteAlterar produtoClienteAlterar = new frmProdutoClienteAlterar(datagriV, Accao.Alterar);
            DialogResult dr = produtoClienteAlterar.ShowDialog();

            if (dr == DialogResult.Yes)
            {
                pesquisa("%");
            }
        }

        private void buttonNovoProdutoCliente_Click(object sender, EventArgs e)
        {
            frmProdutoClienteAlterar produtoClienteAlterar = new frmProdutoClienteAlterar(null, Accao.Inserir);
            DialogResult dr = produtoClienteAlterar.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                pesquisa("%");
            }
        }

        private void buttonEliminarProdutoCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutoCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto Selecionada");
                return;
            }


            if ((dataGridViewProdutoCliente.SelectedRows[0].DataBoundItem as ProdutoCliente) == null)
            {
                MessageBox.Show(" linha vazia Selecionada");
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que quer eliminar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            //pegar pegar manutencao  no dataGrid
            ProdutoCliente ProdutoClienteSelecionado = (dataGridViewProdutoCliente.SelectedRows[0].DataBoundItem as ProdutoCliente);

            //Instancia a regara de negocio
            ProdutoClienteNegocio produtoClienteNegocio = new ProdutoClienteNegocio();

            //Chamar o metodo para eliminar
            string retorno = produtoClienteNegocio.Eliminar(ProdutoClienteSelecionado);

            //Verifica se eliminau com o sucesso
            //Se o retorno for um numero é porque deu certo, senao é a mensagem de erro
            try
            {
                int idProdutoCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Produto eliminado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pesquisa("%");
            }
            catch
            {

                MessageBox.Show("Não foi possivel eliminar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
