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
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {

            DialogResult dailogResult = MessageBox.Show("Tem certeza que queres sair. ", "INFO-TECNICO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dailogResult == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            frmLogin formulario1 = new frmLogin();
            Hide();
            formulario1.Show();
        }

       
    }
}
