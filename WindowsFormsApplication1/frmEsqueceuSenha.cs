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
    public partial class frmEsqueceuSenha : Form
    {
        public frmEsqueceuSenha()
        {
            InitializeComponent();
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {

            if (textBoxMensagem.Text == "" || textBoxNome.Text == "")
            {
                MessageBox.Show("Preencha todos os campos", "Sistema de Gestao de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Notificacao not = new Notificacao();
            not.Nome = textBoxNome.Text;
            not.Mensagem = textBoxMensagem.Text;

            NotificacaoNegocio nn = new NotificacaoNegocio();

            string retorno = nn.Novo(not);


            try
            {
                int sucesso = Convert.ToInt32(retorno);
                MessageBox.Show("Menssagem enviada.\n\n\nPressione ESC para cancelar", "Sistema de Gestao de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            catch (Exception)
            {
                DialogResult dr = MessageBox.Show("Nenhuma Menssagem foi enviada.\nMensagem de Erro: " + retorno + "\n\nCorrija o erro e tente novamente ou pressione ESC para cancelar", "Sistema de Gestao de Loja Informatica", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }
    }
}
