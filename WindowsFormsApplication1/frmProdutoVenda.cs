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
    public partial class frmProdutoVenda : Form
    {
        public frmProdutoVenda()
        {
            InitializeComponent();
        }

        public void pesquisa(string str)
        {
             ProdutoVendaNegocio produtoVendaNegocio = new ProdutoVendaNegocio();
            dataGridViewProdutoVenda.AutoGenerateColumns = false;
            ProdutoVendaColecao mntcN = produtoVendaNegocio.Consultar(str);

            if (mntcN == null) { MessageBox.Show("Nao ha dados na Base de Dados."); return; }

            dataGridViewProdutoVenda.DataSource = null;
            dataGridViewProdutoVenda.DataSource = mntcN;
            dataGridViewProdutoVenda.Update();
            dataGridViewProdutoVenda.Refresh();
        }

        private void buttonNovoProdutoVenda_Click(object sender, EventArgs e)
        {

            frmProdutoVendaAlterar produtoVendaAlterar = new frmProdutoVendaAlterar(null, Accao.Inserir);
            DialogResult dr = produtoVendaAlterar.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                pesquisa("%");
            }
        }

        private void buttonAlterarProdutoVenda_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutoVenda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto Selecionada");
                return;
            }


            if ((dataGridViewProdutoVenda.SelectedRows[0].DataBoundItem as ProdutoVenda) == null)
            {
                MessageBox.Show(" linha vazia Selecionada");
                return;
            }
            ProdutoVenda datagriV = dataGridViewProdutoVenda.SelectedRows[0].DataBoundItem as ProdutoVenda;

            frmProdutoVendaAlterar produtoVendaAlterar = new frmProdutoVendaAlterar(datagriV, Accao.Alterar);
            DialogResult dr = produtoVendaAlterar.ShowDialog();

            if (dr == DialogResult.Yes)
            {
                pesquisa("%");
            }
        }

        private void buttonEliminarProdutoVenda_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutoVenda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto Selecionada");
                return;
            }


            if ((dataGridViewProdutoVenda.SelectedRows[0].DataBoundItem as ProdutoVenda) == null)
            {
                MessageBox.Show(" linha vazia Selecionada");
                return;
            }

            DialogResult resultado = MessageBox.Show("Tem certeza que quer eliminar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            //pegar pegar produto venda  no dataGrid
            ProdutoVenda ProdutoVendaSelecionado = (dataGridViewProdutoVenda.SelectedRows[0].DataBoundItem as ProdutoVenda);

            //Instancia a regara de negocio
            ProdutoVendaNegocio produtoVendaNegocio = new ProdutoVendaNegocio();

            //Chamar o metodo para eliminar
            string retorno = produtoVendaNegocio.Eliminar(ProdutoVendaSelecionado);

            //Verifica se eliminau com o sucesso
            //Se o retorno for um numero é porque deu certo, senao é a mensagem de erro
            try
            {
                int idProdutoVenda = Convert.ToInt32(retorno);
                MessageBox.Show("Produto eliminado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pesquisa("%");
            }
            catch
            {

                MessageBox.Show("Não foi possivel eliminar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPesquisarProdutoVenda_Click(object sender, EventArgs e)
        {
            if (textBoxPesquisa.Text == "") { MessageBox.Show("Prencha o campo de pesquisa."); return; }
            pesquisa(textBoxPesquisa.Text);
        }
    }
    }

