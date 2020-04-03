namespace WindowsFormsApplication1
{
    partial class frmRelatorio5
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
            this.LojaInformaticaDataSet1 = new WindowsFormsApplication1.LojaInformaticaDataSet1();
            this.produtoMaisVendidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoMaisVendidoTableAdapter = new WindowsFormsApplication1.LojaInformaticaDataSet1TableAdapters.produtoMaisVendidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LojaInformaticaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoMaisVendidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.produtoMaisVendidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Report5ProdutoMaisVendido.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(554, 281);
            this.reportViewer1.TabIndex = 0;
            // 
            // LojaInformaticaDataSet1
            // 
            this.LojaInformaticaDataSet1.DataSetName = "LojaInformaticaDataSet1";
            this.LojaInformaticaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoMaisVendidoBindingSource
            // 
            this.produtoMaisVendidoBindingSource.DataMember = "produtoMaisVendido";
            this.produtoMaisVendidoBindingSource.DataSource = this.LojaInformaticaDataSet1;
            // 
            // produtoMaisVendidoTableAdapter
            // 
            this.produtoMaisVendidoTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 281);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorio5";
            this.Text = "frmRelatorio5";
            this.Load += new System.EventHandler(this.frmRelatorio5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LojaInformaticaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoMaisVendidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource produtoMaisVendidoBindingSource;
        private LojaInformaticaDataSet1 LojaInformaticaDataSet1;
        private LojaInformaticaDataSet1TableAdapters.produtoMaisVendidoTableAdapter produtoMaisVendidoTableAdapter;
    }
}