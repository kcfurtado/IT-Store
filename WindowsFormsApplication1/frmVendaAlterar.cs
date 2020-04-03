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
    public partial class frmVendaAlterar : Form
    {
        Accao ason;
        public frmVendaAlterar(Venda venda, Accao accao) {
          
            InitializeComponent();
            ason = accao;
            if (accao == Accao.Inserir)
            {

            }
            else if (accao == Accao.Alterar)
            {
                textBoxCod_Venda.Text = venda.cod_Venda.ToString();
                textBoxCod_Func_Ven.Text = venda.cod_Func.ToString();
                textBoxDataVenda.Text = venda.data.ToString();
                textBoxBI_Venda.Text = venda.BI;
            }



        }

        private void buttonVendaGuardar_Click(object sender, EventArgs e)
        {

            if (textBoxCod_Venda.Text == "")
            {
                MessageBox.Show("Prencha os campos vazio");
                return;
            }

            Venda venda = new Venda();
            venda.cod_Func = Convert.ToInt32(textBoxCod_Func_Ven.Text);
            venda.cod_Venda = Convert.ToInt32(textBoxCod_Venda.Text);
            venda.data = Convert.ToDateTime(textBoxDataVenda.Text);
            venda.BI = textBoxBI_Venda.Text;

            if (ason == Accao.Inserir)
            {
                VendaNegocio vendaNegocio = new VendaNegocio();
                string re = vendaNegocio.Inserir(venda);
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
                VendaNegocio vendaNegocio = new VendaNegocio();
                string re = vendaNegocio.Alterar(venda);
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


