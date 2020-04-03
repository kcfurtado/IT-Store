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
    public partial class frmFuncionarioAlterar : Form
    {
        Accao ason;
        public frmFuncionarioAlterar(Funcionario funcionario, Accao accao)
        {
            InitializeComponent();
            ason = accao;
            if (accao == Accao.Inserir)
            {

            }
            else if (accao == Accao.Alterar)
            {
                textBoxCod_Func.Text = funcionario.cod_Fun.ToString();
                textBoxNome_F.Text = funcionario.nome;
                textBoxNif_F.Text = funcionario.NIF.ToString();
                textBoxMorada_F.Text = funcionario.Morada;
                textBoxTelefone_F.Text = funcionario.Telefone.ToString();
                textBoxEmail_F.Text = funcionario.Email;
                textBoxBI_F.Text = funcionario.Num_BI.ToString();
                textBoxCargo_F.Text = funcionario.Tipo_Fun;
                textBoxCodSupr_F.Text = funcionario.cod_Supr.ToString();
                textBoxUsuario_F.Text = funcionario.Usuario;
                textBoxSenha_F.Text = funcionario.Senha;



            }
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCod_Func.Text == "")
                {
                    MessageBox.Show("Prencha os campos obrigatorios");
                    return;
                }

                Funcionario funcionario = new Funcionario();

                funcionario.cod_Fun = Convert.ToInt32(textBoxCod_Func.Text);
                funcionario.nome = textBoxNome_F.Text;
                funcionario.NIF = Convert.ToInt32(textBoxNif_F.Text);
                funcionario.Telefone = Convert.ToInt32(textBoxTelefone_F.Text);
                funcionario.Email = textBoxEmail_F.Text;
                funcionario.Morada = textBoxMorada_F.Text;
                funcionario.Num_BI = Convert.ToInt32(textBoxBI_F.Text);
                funcionario.Tipo_Fun = textBoxCargo_F.Text;
                funcionario.cod_Supr = textBoxCodSupr_F.Text;
                funcionario.Usuario = textBoxUsuario_F.Text;
                funcionario.Senha = textBoxSenha_F.Text;


                if (ason == Accao.Inserir)
                {
                    FuncionarioNegocio funcionarioNegocio = new FuncionarioNegocio();
                    string re = funcionarioNegocio.inserir(funcionario);
                    try
                    {
                        int x = Convert.ToInt32(re);
                        this.DialogResult = DialogResult.Yes;
                        Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("erro" + re);
                    }
                }

                else if (ason == Accao.Alterar)
                {
                    FuncionarioNegocio funcionarioNegocio = new FuncionarioNegocio();
                    string re = funcionarioNegocio.alterar(funcionario);
                    try
                    {
                        int x = Convert.ToInt32(re);
                        this.DialogResult = DialogResult.Yes;
                        Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("erro" + re);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("erro na conexao" + ex);
            }

        }
    }
}
