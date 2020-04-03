namespace WindowsFormsApplication1
{
    partial class frmRelatorioProdVen
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
            this.ListagemProdutoVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListagemProdutoVendaTableAdapter = new WindowsFormsApplication1.DataSet1TableAdapters.ListagemProdutoVendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListagemProdutoVendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ListagemProdutoVendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report4ProdutoVenda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(691, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListagemProdutoVendaBindingSource
            // 
            this.ListagemProdutoVendaBindingSource.DataMember = "ListagemProdutoVenda";
            this.ListagemProdutoVendaBindingSource.DataSource = this.DataSet1;
            // 
            // ListagemProdutoVendaTableAdapter
            // 
            this.ListagemProdutoVendaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioProdVen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioProdVen";
            this.Text = "frmRelatorioProdVen";
            this.Load += new System.EventHandler(this.frmRelatorioProdVen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListagemProdutoVendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListagemProdutoVendaBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.ListagemProdutoVendaTableAdapter ListagemProdutoVendaTableAdapter;
    }
}