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
    public partial class frmRelatorioFunc : Form
    {
        public frmRelatorioFunc()
        {
            InitializeComponent();
        }

        private void frmRelatorioFunc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LojaInformaticaDataSet2.ListagemFuncionario' table. You can move, or remove it, as needed.
            this.ListagemFuncionarioTableAdapter.Fill(this.LojaInformaticaDataSet2.ListagemFuncionario);

            this.reportViewer1.RefreshReport();
        }
    }
}
