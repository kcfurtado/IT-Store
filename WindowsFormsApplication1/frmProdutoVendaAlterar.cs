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
    public partial class frmProdutoVendaAlterar : Form
    {
        Accao ason;
        public frmProdutoVendaAlterar(ProdutoVenda produtoVenda, Accao accao)
        {
            InitializeComponent();
            ason = accao;
            if (accao == Accao.Inserir)
            {

            }
            else if (accao == Accao.Alterar)
            {

                textBoxPrecoPro_Ven.Text = produtoVenda.preco.ToString();
                textBoxMarca_Prod_Vend.Text = produtoVenda.Marca_P;
                textBoxCodigo_Prod_Vend.Text = produtoVenda.Cod_P.ToString();
                textBoxModelo_Prod_Vend.Text = produtoVenda.Modelo_P;
                textBoxNome_Prod_Vend.Text = produtoVenda.Nome_P;
                textBoxQuantddVendd_Prod_Vend.Text = produtoVenda.quantidd_stock.ToString();
            }



        }

        private void buttonGuardar_Prod_Vend_Click(object sender, EventArgs e)
        {
            if (textBoxCodigo_Prod_Vend.Text == "")
            {
                MessageBox.Show("Prencha os campos vazio");
                return;
            }


            ProdutoVenda produtoVenda = new ProdutoVenda();
           
            produtoVenda.Cod_P = Convert.ToInt32(textBoxCodigo_Prod_Vend.Text);
            produtoVenda.Nome_P = Convert.ToString(textBoxNome_Prod_Vend.Text);
            produtoVenda.Marca_P = Convert.ToString(textBoxMarca_Prod_Vend.Text);
            produtoVenda.Modelo_P = Convert.ToString(textBoxModelo_Prod_Vend.Text);
            produtoVenda.quantidd_stock = Convert.ToInt32(textBoxQuantddVendd_Prod_Vend.Text);
            produtoVenda.preco = Convert.ToDecimal(textBoxPrecoPro_Ven.Text);

            if (ason == Accao.Inserir)
            {
                ProdutoVendaNegocio produtoVendaNegocio = new ProdutoVendaNegocio();
                string re = produtoVendaNegocio.Inserir(produtoVenda);
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
                ProdutoVendaNegocio produtoVendaNegocio = new ProdutoVendaNegocio();
                string re = produtoVendaNegocio.Alterar(produtoVenda);
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
