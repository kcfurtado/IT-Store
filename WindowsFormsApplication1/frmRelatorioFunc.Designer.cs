namespace WindowsFormsApplication1
{
    partial class frmRelatorioFunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LojaInformaticaDataSet2 = new WindowsFormsApplication1.LojaInformaticaDataSet2();
            this.ListagemFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListagemFuncionarioTableAdapter = new WindowsFormsApplication1.LojaInformaticaDataSet2TableAdapters.ListagemFuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LojaInformaticaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListagemFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ListagemFuncionarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report3Funcionario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(697, 303);
            this.reportViewer1.TabIndex = 0;
            // 
            // LojaInformaticaDataSet2
            // 
            this.LojaInformaticaDataSet2.DataSetName = "LojaInformaticaDataSet2";
            this.LojaInformaticaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListagemFuncionarioBindingSource
            // 
            this.ListagemFuncionarioBindingSource.DataMember = "ListagemFuncionario";
            this.ListagemFuncionarioBindingSource.DataSource = this.LojaInformaticaDataSet2;
            // 
            // ListagemFuncionarioTableAdapter
            // 
            this.ListagemFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 303);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioFunc";
            this.Text = "frmRelatorioFunc";
            this.Load += new System.EventHandler(this.frmRelatorioFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LojaInformaticaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListagemFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListagemFuncionarioBindingSource;
        private LojaInformaticaDataSet2 LojaInformaticaDataSet2;
        private LojaInformaticaDataSet2TableAdapters.ListagemFuncionarioTableAdapter ListagemFuncionarioTableAdapter;
    }
}