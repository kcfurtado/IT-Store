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
    public partial class frmClienteAlterar : Form
    {
        Accao ason;
        public frmClienteAlterar(Cliente  cliente, Accao accao)
        {
            InitializeComponent();
            ason = accao;
            if (accao == Accao.Inserir)
            {

            }
            else if (accao == Accao.Alterar)
            {
                textBoxCod_Func_Cliente.Text = cliente.cod_Func.ToString();
                textBoxNome_Cliente.Text = cliente.nome;
                textBoxMorada_Cliente.Text = cliente.morada;
                textBoxTelefone_Cliente.Text = cliente.telefone.ToString();
                textBoxEmail_Cliente.Text = cliente.email;
                textBoxBI_Cliente.Text = cliente.BI.ToString();
               
             
            }

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxBI_Cliente.Text == "")
            {
                MessageBox.Show("Prencha os campos obrigatorios");
                return;
            }

            Cliente cliente = new Cliente();

            cliente.cod_Func = Convert.ToInt32(textBoxCod_Func_Cliente.Text);
            cliente.nome = textBoxNome_Cliente.Text;
            cliente.morada = textBoxMorada_Cliente.Text;
            cliente.telefone = Convert.ToInt32(textBoxTelefone_Cliente.Text);
            cliente.email = textBoxEmail_Cliente.Text;
            cliente.BI = textBoxBI_Cliente.Text;

            if (ason == Accao.Inserir)
            {
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                string re = clienteNegocio.inserir(cliente);
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
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                string re = clienteNegocio.alterar(cliente);
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
