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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void buttonBrowserBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxCaminhoBackup.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            if (textBoxCaminhoBackup.Text != "")
            {


                try
                {
                    Backup_Restore_Negocio brS = new Backup_Restore_Negocio();
                    brS.Backup(textBoxCaminhoBackup.Text);
                    MessageBox.Show("Backup feito com sucesso.", "Sistema de Gestao de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Backup não foi feito.\n\nMensagen de Erro: " + ex.Message, "Sistema de Gestao de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Nenhum local para salvar o Backup foi selecionado.\nSelecione um local valido e tente novamente.", "Sistema de Gestao de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void buttonSelecionarCaminho_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Backup(*.bak)|*.bak|Todos Arquivos(*.*)|*.*";
            openFileDialog.FilterIndex = 0;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxCaminhoRestore.Text = openFileDialog.FileName;
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {

            if (textBoxCaminhoRestore.Text != "")
            {


                try
                {
                    Backup_Restore_Negocio brS = new Backup_Restore_Negocio();
                    brS.Restore(textBoxCaminhoRestore.Text);
                    MessageBox.Show("Restore feito com sucesso.", "Sistema de Gestão de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Restore não foi feito.\n\nMensagen de Erro: " + ex.Message, "Sistema de Gestão de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Nenhum Backup foi selecionado.\nSelecione um Backup valido e tente novamente.", "Sistema de Gestão de Loja Informatica", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
