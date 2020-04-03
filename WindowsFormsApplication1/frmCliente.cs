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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            dataGridViewCliente.AutoGenerateColumns = false;
        }

        private void buttonAlterarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Manutencao Selecionada");
                return;
            }
            if ((dataGridViewCliente.SelectedRows[0].DataBoundItem as Cliente) == null)
            {
                MessageBox.Show(" linha vazia Selecionada");
                return;
            }

            Cliente datagriV = dataGridViewCliente.SelectedRows[0].DataBoundItem as Cliente;

            frmClienteAlterar clienteAlterar = new frmClienteAlterar(datagriV, Accao.Alterar);
            clienteAlterar.ShowDialog();

        }

        private void buttonNovoCliente_Click(object sender, EventArgs e)
        {
            frmClienteAlterar clienteAlterar = new frmClienteAlterar(null, Accao.Inserir);
            clienteAlterar.ShowDialog();
        }

        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente Selecionada");
                return;
            }


            if ((dataGridViewCliente.SelectedRows[0].DataBoundItem as Cliente) == null)
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
            Cliente clienteSelecionado = (dataGridViewCliente.SelectedRows[0].DataBoundItem as Cliente);

            //Instancia a regara de negocio
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            //Chamar o metodo para eliminar
            string retorno = clienteNegocio.eliminar(clienteSelecionado);

            //Verifica se eliminau com o sucesso
            //Se o retorno for um numero é porque deu certo, senao é a mensagem de erro
            try
            {
                int idCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Cliente eliminado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pesquisaCliente("%");
            }
            catch
            {

                MessageBox.Show("Não foi possivel eliminar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // funcoa para fazer uma pesquisa
        public void pesquisaCliente(string str)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            ClienteColecao mntcN = clienteNegocio.consulta(str);
            if (mntcN == null) { MessageBox.Show("Nao ha dados na Base de Dados."); return; }
            dataGridViewCliente.DataSource = null;
            dataGridViewCliente.DataSource = mntcN;
            dataGridViewCliente.Update();
            dataGridViewCliente.Refresh();
        }
        //boton de fazer pesquisa
        private void buttonPesquisarCliente_Click(object sender, EventArgs e)
        {
            if (textBoxPesquisaCliente.Text == "") { MessageBox.Show("Prencha o campo de pesquisa."); return; }
            pesquisaCliente(textBoxPesquisaCliente.Text);
        }
    }
}
