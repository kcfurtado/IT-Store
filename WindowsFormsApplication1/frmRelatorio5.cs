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
    public partial class frmRelatorio5 : Form
    {
        public frmRelatorio5()
        {
            InitializeComponent();
        }

        private void frmRelatorio5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LojaInformaticaDataSet1.produtoMaisVendido' table. You can move, or remove it, as needed.
            this.produtoMaisVendidoTableAdapter.Fill(this.LojaInformaticaDataSet1.produtoMaisVendido);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
