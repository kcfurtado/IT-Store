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
    public partial class frmManutencaoAlterar : Form
    {
        Accao ason;
        public frmManutencaoAlterar(Manutencao manutencao,Accao accao)
        {
            InitializeComponent();
            ason = accao;
            if (accao== Accao.Inserir)
            {

            }
            else if (accao == Accao.Alterar)
            {
                textBoxCod_Man.Text = manutencao.Cod_Man.ToString();
                textBoxDiagnostico.Text = manutencao.Diagnostico;
                textBoxOrcamento.Text = manutencao.Orcamento.ToString();
                textBoxCod_Func.Text = manutencao.Cod_Fun.ToString(); 
            }
            
        }

   

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxCod_Man.Text=="")
            {
                 MessageBox.Show("Prencha os campos vazio");
                return;
            }

            Manutencao manutencao = new Manutencao();
            manutencao.Cod_Fun = Convert.ToInt32(textBoxCod_Func.Text);
            manutencao.Cod_Man = Convert.ToInt32(textBoxCod_Man.Text);
            manutencao.Diagnostico  = textBoxDiagnostico.Text;
            manutencao.Orcamento = Convert.ToDecimal(textBoxOrcamento.Text);

            if (ason==Accao.Inserir)
            {
                ManutencaoNegocio manutencaoNegocio = new ManutencaoNegocio();
                string re = manutencaoNegocio.Inserir(manutencao);
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

          else  if (ason == Accao.Alterar)
            {
                ManutencaoNegocio manutencaoNegocio = new ManutencaoNegocio();
                string re = manutencaoNegocio.Alterar(manutencao);
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
