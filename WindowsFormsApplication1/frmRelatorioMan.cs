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
    public partial class frmRelatorioMan : Form
    {
        public frmRelatorioMan()
        {
            InitializeComponent();
        }

        private void frmRelatorioMan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.ListagemManutencao' table. You can move, or remove it, as needed.
            this.ListagemManutencaoTableAdapter.Fill(this.DataSet1.ListagemManutencao);

            this.reportViewer1.RefreshReport();
        }
    }
}
