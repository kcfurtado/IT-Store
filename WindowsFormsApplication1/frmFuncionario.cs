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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
            dataGridViewfuncionario.AutoGenerateColumns = false;
            FuncionarioNegocio funcionarioNegocio = new FuncionarioNegocio();
            FuncionarioColecao funcionarioColecao = funcionarioNegocio.Consultar();
            dataGridViewfuncionario.DataSource = null;
            dataGridViewfuncionario.DataSource = funcionarioColecao;
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridViewfuncionario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Funcionario Selecionada");
                return;
            }
            if ((dataGridViewfuncionario.SelectedRows[0].DataBoundItem as Funcionario) == null)
            {
                MessageBox.Show(" linha vazia Selecionada");
                return;
            }

            Funcionario datagriV = dataGridViewfuncionario.SelectedRows[0].DataBoundItem as Funcionario;

           frmFuncionarioAlterar funcionarioAlterar = new frmFuncionarioAlterar(datagriV, Accao.Alterar);
            funcionarioAlterar.ShowDialog();

        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            frmFuncionarioAlterar funcionarioAlterar = new frmFuncionarioAlterar(null, Accao.Inserir);
            funcionarioAlterar.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridViewfuncionario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Manutencao Selecionada");
                return;
            }


            if ((dataGridViewfuncionario.SelectedRows[0].DataBoundItem as Funcionario) == null)
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
            Funcionario funcionarioSelecionado = (dataGridViewfuncionario.SelectedRows[0].DataBoundItem as Funcionario);

            //Instancia a regara de negocio
            FuncionarioNegocio funcionarioNegocio = new FuncionarioNegocio();

            //Chamar o metodo para eliminar
            string retorno = funcionarioNegocio.eliminar(funcionarioSelecionado);

            //Verifica se eliminau com o sucesso
            //Se o retorno for um numero é porque deu certo, senao é a mensagem de erro
            try
            {
                int idFuncionario = Convert.ToInt32(retorno);
                MessageBox.Show("Manutencao eliminado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewfuncionario.AutoGenerateColumns = false;

                FuncionarioNegocio funcionarioNegocio1 = new FuncionarioNegocio();
                FuncionarioColecao funcionarioColecao = funcionarioNegocio1.Consultar();
                dataGridViewfuncionario.DataSource = null;
                dataGridViewfuncionario.DataSource = funcionarioColecao;
            }
            catch
            {

                MessageBox.Show("Não foi possivel eliminar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

