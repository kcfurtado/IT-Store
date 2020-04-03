using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using ProjetoTransferencia;

using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();


        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            DialogResult dailogResult= MessageBox.Show("Tem certeza que queres sair. ", "INFO-TECNICO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dailogResult==DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
          
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
          FuncionarioNegocio funcionarioNegocio = new FuncionarioNegocio();

            Funcionario funcionario = funcionarioNegocio.login(textBoxUsuario.Text, textBoxSenha.Text);         

                if (funcionario.Usuario == textBoxUsuario.Text && funcionario.Senha == textBoxSenha.Text)
                {
                    Hide();
                    frmMenuPrincipal formulario1 = new frmMenuPrincipal();
                    formulario1.pegarTipo(funcionario.Tipo_Fun);
                    Settings.Default.CodFuncionario = funcionario.cod_Fun;
                    formulario1.SetCodFun(funcionario.cod_Fun.ToString());
                    formulario1.ShowDialog();                    
                }
                else
                {
                    MessageBox.Show("Dados de login incorretos", "INFO-TECNICO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      linkLabel1.Visible = true;
                }
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum dados retornados.\n\nMessagen de Erro: " + ex.Message, "INFO-TECNICO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            frmTelaInicial formulario1 = new frmTelaInicial();
            Hide();
            formulario1.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEsqueceuSenha esqueceuSenha = new frmEsqueceuSenha();
            esqueceuSenha.ShowDialog();
        }
    }
}
