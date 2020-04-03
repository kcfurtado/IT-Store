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
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class frmMenuPrincipal : Form
    {
        string tipFuncionario;

        public frmMenuPrincipal()
        {
            
            InitializeComponent();

        }

         private void Form2_Load(object sender, EventArgs e)
        {
            bloquiarCampo(true);

            FuncionarioNegocio fn = new FuncionarioNegocio();
            //MessageBox.Show(Settings.Default.CodFuncionario.ToString() + "     jjjj   "+tipFuncionario);

            Funcionario ffuncionario = fn.ConsultarMeusDados(Settings.Default.CodFuncionario);

            textBoxBilhete.Text = ffuncionario.Num_BI.ToString();
            textBoxCodigo.Text = ffuncionario.cod_Fun.ToString();
            textBoxEmail.Text = ffuncionario.Email;
            textBoxMorada.Text = ffuncionario.Morada;
            textBoxNIF.Text = ffuncionario.NIF.ToString();
            textBoxNome.Text = ffuncionario.nome;
            textBoxSenha.Text = ffuncionario.Senha;
            textBoxTelefone.Text = ffuncionario.Telefone.ToString();
            textBoxUsuario.Text = ffuncionario.Usuario;
            textBoxSenha.Text = ffuncionario.Senha;

            dataGridViewManutencao.AutoGenerateColumns = false;
            if (tipFuncionario == "Gerente")
            {
                textBoxBilhete.ReadOnly = true;
                textBoxCodigo.ReadOnly = true;
                textBoxEmail.ReadOnly = true;
                textBoxMorada.ReadOnly = true;
                textBoxNIF.ReadOnly = true;
                textBoxNome.ReadOnly = true;
                textBoxTelefone.ReadOnly = true;
                notificacoa();
            }
            if (tipFuncionario == "Balconista")
            {

                textBoxBilhete.ReadOnly = true;
                textBoxCodigo.ReadOnly = true;
                textBoxEmail.ReadOnly = true;
                textBoxMorada.ReadOnly = true;
                textBoxNIF.ReadOnly = true;
                textBoxNome.ReadOnly = true;
                textBoxTelefone.ReadOnly = true;

                //notificações
                statusStrip2.Visible = false;
                dataGridViewNotificacao.Visible = false;
                buttonAtualizar.Visible = false;
                buttonBackup.Enabled = false;
                buttonRelatorio.Enabled = false;
                button9.Enabled = false;
            }
            if (tipFuncionario == "Tecnico")
            {

                textBoxBilhete.ReadOnly = true;
                textBoxCodigo.ReadOnly = true;
                textBoxEmail.ReadOnly = true;
                textBoxMorada.ReadOnly = true;
                textBoxNIF.ReadOnly = true;
                textBoxNome.ReadOnly = true;
                textBoxTelefone.ReadOnly = true;


                //notificações
                statusStrip2.Visible = false;
                dataGridViewNotificacao.Visible = false;
                buttonAtualizar.Visible = false;
                buttonCadastro.Enabled = false;
                
                buttonVenda.Enabled = false;
                buttonRelatorio.Enabled = false;
                buttonBackup.Enabled = false;



            }

        }

        public void notificacoa()
        {
            if (statusStrip2.Visible == true)
            {
                NotificacaoNegocio nn = new NotificacaoNegocio();
                NotificacaoColecao cn = nn.Consultar();
                dataGridViewNotificacao.AutoGenerateColumns =false;
                dataGridViewNotificacao.DataSource = null;
                dataGridViewNotificacao.DataSource = cn;
                dataGridViewNotificacao.Update();
                dataGridViewNotificacao.Refresh();
            }
        }

        public void pegarTipo(string tipo)

        {
            tipFuncionario = tipo;
        }

        public void SetCodFun(string cod)
        {
            //textBoxcodfunn.Text = cod;
        }


        public void bloquiarCampo(Boolean estado)
        {
           /* textBoxBilhete.ReadOnly = estado;
            textBoxCodigo.ReadOnly = estado;
            textBoxEmail.ReadOnly = estado;
            textBoxMorada.ReadOnly = estado;
            textBoxNIF.ReadOnly = estado;
            textBoxNome.ReadOnly = estado;
            textBoxTelefone.ReadOnly = estado;*/
            textBoxSenha.ReadOnly = estado;
            textBoxUsuario.ReadOnly = estado;
        }
   
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void pesquisa(string str)
        {
            ManutencaoNegocio manutencaoNegocio = new ManutencaoNegocio();

            ManutencaoColecao mntcN = manutencaoNegocio.Consultar(str);
            if (mntcN==null) { MessageBox.Show("Nao ha dados na Base de Dados."); return; }
            dataGridViewManutencao.DataSource = null;
            dataGridViewManutencao.DataSource = mntcN;
            dataGridViewManutencao.Update();
            dataGridViewManutencao.Refresh();
        }

        private void buttonMeusDados_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void buttonManutencao_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void buttonVenda_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            frmBackup backup = new frmBackup();
            backup.ShowDialog();
        }

        //boton de terminar sessao
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin formulario2 = new frmLogin();
            Hide();
            formulario2.ShowDialog();
        }
        //boton de Alterar dados do utilizador
        private void button6_Click(object sender, EventArgs e)
        {
            bloquiarCampo(false);
            this.button6.Text = "Guardar";
            Funcionario funcionario = new Funcionario();
           /* if (button)
            {
                funcionario.cod_Fun = Convert.ToInt32(textBoxCodigo.Text);
                funcionario.nome = textBoxNome.Text;
                funcionario.NIF = Convert.ToInt32(textBoxNIF.Text);
                funcionario.Telefone = Convert.ToInt32(textBoxTelefone.Text);
                funcionario.Email = textBoxEmail.Text;
                funcionario.Morada = textBoxMorada.Text;
                funcionario.Num_BI = Convert.ToInt32(textBoxBilhete.Text);
                //funcionario.Tipo_Fun = textBoxCargo.Text;
                //funcionario.cod_Supr = textBoxCodSupr_F.Text;
                funcionario.Usuario = textBoxUsuario.Text;
                funcionario.Senha = textBoxSenha.Text;


            }
            */


        }
        //boton de funcionario
        private void button9_Click(object sender, EventArgs e)
        {
            frmFuncionario funcionario = new frmFuncionario();
            funcionario.ShowDialog();
        }
        //boton de Cliente
        private void button7_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
        }

        private void buttonProdutoCliente_Click(object sender, EventArgs e)
        {
            frmProdutoCliente produtoCliente = new frmProdutoCliente();
            produtoCliente.ShowDialog();
        }

        private void buttonProdutoVenda_Click(object sender, EventArgs e)
        {
            frmProdutoVenda produtoVenda = new frmProdutoVenda();
            produtoVenda.ShowDialog();
        }

        private void buttonAlterarManutencao_Click(object sender, EventArgs e)
        {

            if (dataGridViewManutencao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Manutencao Selecionada");
                return;
            }


            if ((dataGridViewManutencao.SelectedRows[0].DataBoundItem as Manutencao) == null)
            {
                MessageBox.Show(" linha vazia Selecionada");
                return;
            }
            Manutencao datagriV = dataGridViewManutencao.SelectedRows[0].DataBoundItem as Manutencao;

            frmManutencaoAlterar manutencaoAlterar = new frmManutencaoAlterar(datagriV, Accao.Alterar);
            DialogResult dr = manutencaoAlterar.ShowDialog();

            if (dr == DialogResult.Yes)
            {
                pesquisa("%");
            }
        }

        private void buttonNovoManutencao_Click(object sender, EventArgs e)
        {

            frmManutencaoAlterar manutencaoAlterar = new frmManutencaoAlterar(null, Accao.Inserir);
            DialogResult dr = manutencaoAlterar.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                pesquisa("%");
            }
        }

        private void buttonEliminarManutencao_Click(object sender, EventArgs e)
        {
            if (dataGridViewManutencao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Manutencao Selecionada");
                return;
            }


            if ((dataGridViewManutencao.SelectedRows[0].DataBoundItem as Manutencao) == null)
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
            Manutencao manutencaoSelecionado = (dataGridViewManutencao.SelectedRows[0].DataBoundItem as Manutencao);

            //Instancia a regara de negocio
            ManutencaoNegocio manutencaoNegocio = new ManutencaoNegocio();

            //Chamar o metodo para eliminar
            string retorno = manutencaoNegocio.Eliminar(manutencaoSelecionado);

            //Verifica se eliminau com o sucesso
            //Se o retorno for um numero é porque deu certo, senao é a mensagem de erro
            try
            {
                int idManutencao = Convert.ToInt32(retorno);
                MessageBox.Show("Manutencao eliminado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pesquisa("%");
            }
            catch
            {

                MessageBox.Show("Não foi possivel eliminar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (textBoxPesquisa.Text == "") { MessageBox.Show("Prencha o campo de pesquisa."); return; }
            pesquisa(textBoxPesquisa.Text);
        }

        public void pesquisaVenda(string str)
        {
            VendaNegocio vendaNegocio = new VendaNegocio();
            dataGridViewVenda.AutoGenerateColumns = false;
            VendaColecao mntcN = vendaNegocio.Consultar(str);
            if (mntcN == null) { MessageBox.Show("Nao ha dados na Base de Dados."); return; }
            dataGridViewVenda.DataSource = null;
            dataGridViewVenda.DataSource = mntcN;
            dataGridViewVenda.Update();
            dataGridViewVenda.Refresh();
        }

        private void buttonVendaAlterar_Click(object sender, EventArgs e)
        {

            if (dataGridViewVenda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Venda Selecionada");
                return;
            }


            if ((dataGridViewVenda.SelectedRows[0].DataBoundItem as Venda) == null)
            {
                MessageBox.Show(" linha vazia Selecionada");
                return;
            }
                Venda datagriV = dataGridViewVenda.SelectedRows[0].DataBoundItem as Venda;

            frmVendaAlterar FrmVendaAlterar = new frmVendaAlterar(datagriV, Accao.Alterar);
            DialogResult dr = FrmVendaAlterar.ShowDialog();

            if (dr == DialogResult.Yes)
            {
                pesquisaVenda("%");
            }
        }

        private void buttonVendaNovo_Click(object sender, EventArgs e)
        {
            frmVendaAlterar vendaAlterar = new frmVendaAlterar(null, Accao.Inserir);
            DialogResult dr = vendaAlterar.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                pesquisaVenda("%");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridViewVenda.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Venda Selecionada");
                return;
            }


            if ((dataGridViewVenda.SelectedRows[0].DataBoundItem as Manutencao) == null)
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
            Venda vendaSelecionado = (dataGridViewVenda.SelectedRows[0].DataBoundItem as Venda);

            //Instancia a regara de negocio
            VendaNegocio vendaNegocio = new VendaNegocio();

            //Chamar o metodo para eliminar
            string retorno = vendaNegocio.Eliminar(vendaSelecionado);

            //Verifica se eliminau com o sucesso
            //Se o retorno for um numero é porque deu certo, senao é a mensagem de erro
            try
            {
                int idVenda = Convert.ToInt32(retorno);
                MessageBox.Show("Manutencao eliminado com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pesquisaVenda("%");
            }
            catch
            {

                MessageBox.Show("Não foi possivel eliminar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVendaPesquisar_Click(object sender, EventArgs e)
        {

            if (textBoxVendaPesquisa.Text == "") { MessageBox.Show("Prencha o campo de pesquisa."); return; }
            pesquisaVenda(textBoxVendaPesquisa.Text);
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            notificacoa();
        }

        private void buttonVendaManutencao_Click(object sender, EventArgs e)
        {
            frmPagamento pagamento = new frmPagamento();
            pagamento.ShowDialog();
        }

        private void buttonVendaPagamento_Click(object sender, EventArgs e)
        {
            frmPagamento pagamento = new frmPagamento();
            pagamento.ShowDialog();
        }

        private void buttonRelatorioManutencao_Click(object sender, EventArgs e)
        {
            frmRelatorioMan man = new frmRelatorioMan();
            man.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            frmRelatorio relatorio = new frmRelatorio();
            relatorio.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmRelatorioFunc func = new frmRelatorioFunc();
            func.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRelatorioProdClient cl = new frmRelatorioProdClient();
            cl.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRelatorioProdVen ven = new frmRelatorioProdVen();
            ven.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmRelatorio5 re = new frmRelatorio5();
            re.ShowDialog();
        }
    }

}