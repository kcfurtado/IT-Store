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
    public partial class frmRelatorioProdClient : Form
    {
        public frmRelatorioProdClient()
        {
            InitializeComponent();
        }

        private void frmRelatorioProdClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.ListagemProdutoCliente' table. You can move, or remove it, as needed.
            this.ListagemProdutoClienteTableAdapter.Fill(this.DataSet1.ListagemProdutoCliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
