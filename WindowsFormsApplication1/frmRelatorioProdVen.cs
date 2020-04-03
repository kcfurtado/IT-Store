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
    public partial class frmRelatorioProdVen : Form
    {
        public frmRelatorioProdVen()
        {
            InitializeComponent();
        }

        private void frmRelatorioProdVen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.ListagemProdutoVenda' table. You can move, or remove it, as needed.
            this.ListagemProdutoVendaTableAdapter.Fill(this.DataSet1.ListagemProdutoVenda);

            this.reportViewer1.RefreshReport();
        }
    }
}
