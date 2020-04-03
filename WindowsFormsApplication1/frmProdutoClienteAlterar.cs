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
    public partial class frmProdutoClienteAlterar : Form
    {
        Accao ason;
        public frmProdutoClienteAlterar(ProdutoCliente produtoCliente, Accao accao)
        {
            InitializeComponent();
            ason = accao;
            if (accao == Accao.Inserir)
            {

            }
            else if (accao == Accao.Alterar)
            {
                textBoxProd_Client_CodFunc.Text = produtoCliente.cod_Func.ToString();
                textBoxClienteBi.Text = produtoCliente.BI;
               
                textBoxMarca_Prod.Text = produtoCliente.marca;
                textBoxCod_Produto.Text = produtoCliente.cod_Prod.ToString();
                textBoxModelo_Prod.Text = produtoCliente.modelo;
                textBoxNome_Prod.Text = produtoCliente.nome;
                textBoxQuantdd.Text = produtoCliente.quantidade.ToString();
            }

        }

        private void buttonGuardar_Prod_Cliente_Click(object sender, EventArgs e)
        {
            if (textBoxCod_Produto.Text == "")
            {
                MessageBox.Show("Prencha os campos vazio");
                return;
            }

            ProdutoCliente produtoCliente = new ProdutoCliente();
            produtoCliente.BI = Convert.ToString(textBoxClienteBi.Text);
            produtoCliente.cod_Func = Convert.ToInt32(textBoxProd_Client_CodFunc.Text);
            produtoCliente.cod_Prod = Convert.ToString(textBoxCod_Produto.Text);
            produtoCliente.marca = Convert.ToString(textBoxMarca_Prod.Text);
            produtoCliente.modelo = Convert.ToString(textBoxModelo_Prod.Text);
            produtoCliente.nome = Convert.ToString(textBoxNome_Prod.Text);
            produtoCliente.quantidade = Convert.ToInt32(textBoxQuantdd.Text);

            if (ason == Accao.Inserir)
            {
                ProdutoClienteNegocio produtoClienteNegocio = new ProdutoClienteNegocio();
                string re = produtoClienteNegocio.Inserir(produtoCliente);
                try
                {
                    int x = Convert.ToInt32(re);
                    this.DialogResult = DialogResult.Yes;
                    Close();
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro na conexao" + re);
                }
            }

            else if (ason == Accao.Alterar)
            {
                ProdutoClienteNegocio produtoClienteNegocio = new ProdutoClienteNegocio();
                string re = produtoClienteNegocio.Alterar(produtoCliente);
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

      
    }
}
