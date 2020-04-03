namespace WindowsFormsApplication1
{
    partial class frmRelatorioProdClient
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
            this.DataSet1 = new WindowsFormsApplication1.DataSet1();
            this.ListagemProdutoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListagemProdutoClienteTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.ListagemProdutoClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListagemProdutoClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ListagemProdutoClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report3ProdutoCliente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(759, 274);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListagemProdutoClienteBindingSource
            // 
            this.ListagemProdutoClienteBindingSource.DataMember = "ListagemProdutoCliente";
            this.ListagemProdutoClienteBindingSource.DataSource = this.DataSet1;
            // 
            // ListagemProdutoClienteTableAdapter
            // 
            this.ListagemProdutoClienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioProdClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 274);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioProdClient";
            this.Text = "frmRelatorioProdClient";
            this.Load += new System.EventHandler(this.frmRelatorioProdClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListagemProdutoClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListagemProdutoClienteBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.ListagemProdutoClienteTableAdapter ListagemProdutoClienteTableAdapter;
    }
}