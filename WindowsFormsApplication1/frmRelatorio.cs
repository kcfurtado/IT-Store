using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmRelatorio : Form
    {
     //  Relatorio relatorio;

        public frmRelatorio()
        {
            InitializeComponent();
            //relatorio = relatorioEscolhido;
        }

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.ListagemCliente' table. You can move, or remove it, as needed.
            this.ListagemClienteTableAdapter.Fill(this.DataSet1.ListagemCliente);
            this.reportViewer1.RefreshReport();
            
        }



    }
}
