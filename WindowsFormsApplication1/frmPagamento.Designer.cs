namespace WindowsFormsApplication1
{
    partial class frmPagamento
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
            this.buttonPagamentoAlterar = new System.Windows.Forms.Button();
            this.buttonPagamentoNovo = new System.Windows.Forms.Button();
            this.buttonPagamentoEliminar = new System.Windows.Forms.Button();
            this.dataGridViewPagamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPagamentoCodigo = new System.Windows.Forms.TextBox();
            this.textBoxPagamentoPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPagamentoPesquisa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Cod_Pag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPagamentoCod_Func = new System.Windows.Forms.TextBox();
            this.textBoxPagamentoCod_Prod = new System.Windows.Forms.TextBox();
            this.textBoxPagamentoData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBI = new System.Windows.Forms.TextBox();
            this.textBoxPagamentoTipo = new System.Windows.Forms.TextBox();
            this.textBoxPagamentoQuantia = new System.Windows.Forms.TextBox();
            this.textBoxPagamentoHora = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPagamentoAlterar
            // 
            this.buttonPagamentoAlterar.Location = new System.Drawing.Point(584, 353);
            this.buttonPagamentoAlterar.Name = "buttonPagamentoAlterar";
            this.buttonPagamentoAlterar.Size = new System.Drawing.Size(75, 31);
            this.buttonPagamentoAlterar.TabIndex = 0;
            this.buttonPagamentoAlterar.Text = "Alterar";
            this.buttonPagamentoAlterar.UseVisualStyleBackColor = true;
            this.buttonPagamentoAlterar.Click += new System.EventHandler(this.buttonPagamentoAlterar_Click);
            // 
            // buttonPagamentoNovo
            // 
            this.buttonPagamentoNovo.Location = new System.Drawing.Point(483, 353);
            this.buttonPagamentoNovo.Name = "buttonPagamentoNovo";
            this.buttonPagamentoNovo.Size = new System.Drawing.Size(77, 29);
            this.buttonPagamentoNovo.TabIndex = 1;
            this.buttonPagamentoNovo.Text = "Novo";
            this.buttonPagamentoNovo.UseVisualStyleBackColor = true;
            this.buttonPagamentoNovo.Click += new System.EventHandler(this.buttonPagamentoNovo_Click);
            // 
            // buttonPagamentoEliminar
            // 
            this.buttonPagamentoEliminar.Location = new System.Drawing.Point(681, 353);
            this.buttonPagamentoEliminar.Name = "buttonPagamentoEliminar";
            this.buttonPagamentoEliminar.Size = new System.Drawing.Size(75, 31);
            this.buttonPagamentoEliminar.TabIndex = 3;
            this.buttonPagamentoEliminar.Text = "Eliminar";
            this.buttonPagamentoEliminar.UseVisualStyleBackColor = true;
            this.buttonPagamentoEliminar.Click += new System.EventHandler(this.buttonPagamentoEliminar_Click);
            // 
            // dataGridViewPagamento
            // 
            this.dataGridViewPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod_Pag,
            this.Column1,
            this.cod_Prod,
            this.quntia,
            this.data,
            this.tipo,
            this.Column2});
            this.dataGridViewPagamento.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewPagamento.Name = "dataGridViewPagamento";
            this.dataGridViewPagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPagamento.Size = new System.Drawing.Size(474, 223);
            this.dataGridViewPagamento.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo";
            // 
            // textBoxPagamentoCodigo
            // 
            this.textBoxPagamentoCodigo.Location = new System.Drawing.Point(634, 49);
            this.textBoxPagamentoCodigo.Name = "textBoxPagamentoCodigo";
            this.textBoxPagamentoCodigo.Size = new System.Drawing.Size(122, 20);
            this.textBoxPagamentoCodigo.TabIndex = 6;
            // 
            // textBoxPagamentoPesquisa
            // 
            this.textBoxPagamentoPesquisa.Location = new System.Drawing.Point(116, 51);
            this.textBoxPagamentoPesquisa.Name = "textBoxPagamentoPesquisa";
            this.textBoxPagamentoPesquisa.Size = new System.Drawing.Size(282, 20);
            this.textBoxPagamentoPesquisa.TabIndex = 6;
            this.textBoxPagamentoPesquisa.TextChanged += new System.EventHandler(this.textBoxPagamentoPesquisa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo/CodProduto";
            // 
            // buttonPagamentoPesquisa
            // 
            this.buttonPagamentoPesquisa.Location = new System.Drawing.Point(404, 49);
            this.buttonPagamentoPesquisa.Name = "buttonPagamentoPesquisa";
            this.buttonPagamentoPesquisa.Size = new System.Drawing.Size(75, 23);
            this.buttonPagamentoPesquisa.TabIndex = 0;
            this.buttonPagamentoPesquisa.Text = "Pesquisa";
            this.buttonPagamentoPesquisa.UseVisualStyleBackColor = true;
            this.buttonPagamentoPesquisa.Click += new System.EventHandler(this.buttonPagamentoPesquisa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-211, -256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label1";
            // 
            // Cod_Pag
            // 
            this.Cod_Pag.HeaderText = "Codigo";
            this.Cod_Pag.Name = "Cod_Pag";
            this.Cod_Pag.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Funcionario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // cod_Prod
            // 
            this.cod_Prod.HeaderText = "Codigo Produto";
            this.cod_Prod.Name = "cod_Prod";
            this.cod_Prod.ReadOnly = true;
            this.cod_Prod.Width = 60;
            // 
            // quntia
            // 
            this.quntia.HeaderText = "Quantia";
            this.quntia.Name = "quntia";
            this.quntia.ReadOnly = true;
            this.quntia.Width = 50;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 50;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tipo.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bilhete de Cliente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // textBoxPagamentoCod_Func
            // 
            this.textBoxPagamentoCod_Func.Location = new System.Drawing.Point(634, 93);
            this.textBoxPagamentoCod_Func.Name = "textBoxPagamentoCod_Func";
            this.textBoxPagamentoCod_Func.Size = new System.Drawing.Size(122, 20);
            this.textBoxPagamentoCod_Func.TabIndex = 6;
            // 
            // textBoxPagamentoCod_Prod
            // 
            this.textBoxPagamentoCod_Prod.Location = new System.Drawing.Point(634, 133);
            this.textBoxPagamentoCod_Prod.Name = "textBoxPagamentoCod_Prod";
            this.textBoxPagamentoCod_Prod.Size = new System.Drawing.Size(122, 20);
            this.textBoxPagamentoCod_Prod.TabIndex = 6;
            // 
            // textBoxPagamentoData
            // 
            this.textBoxPagamentoData.Location = new System.Drawing.Point(634, 171);
            this.textBoxPagamentoData.Name = "textBoxPagamentoData";
            this.textBoxPagamentoData.Size = new System.Drawing.Size(122, 20);
            this.textBoxPagamentoData.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Codigo Funcionario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Codigo Produto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Bilhete de Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(516, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Quantia";
            // 
            // textBoxBI
            // 
            this.textBoxBI.Location = new System.Drawing.Point(634, 249);
            this.textBoxBI.Name = "textBoxBI";
            this.textBoxBI.Size = new System.Drawing.Size(122, 20);
            this.textBoxBI.TabIndex = 6;
            // 
            // textBoxPagamentoTipo
            // 
            this.textBoxPagamentoTipo.Location = new System.Drawing.Point(634, 211);
            this.textBoxPagamentoTipo.Name = "textBoxPagamentoTipo";
            this.textBoxPagamentoTipo.Size = new System.Drawing.Size(122, 20);
            this.textBoxPagamentoTipo.TabIndex = 6;
            // 
            // textBoxPagamentoQuantia
            // 
            this.textBoxPagamentoQuantia.Location = new System.Drawing.Point(634, 285);
            this.textBoxPagamentoQuantia.Name = "textBoxPagamentoQuantia";
            this.textBoxPagamentoQuantia.Size = new System.Drawing.Size(122, 20);
            this.textBoxPagamentoQuantia.TabIndex = 6;
            // 
            // textBoxPagamentoHora
            // 
            this.textBoxPagamentoHora.Location = new System.Drawing.Point(634, 12);
            this.textBoxPagamentoHora.Name = "textBoxPagamentoHora";
            this.textBoxPagamentoHora.Size = new System.Drawing.Size(122, 20);
            this.textBoxPagamentoHora.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 394);
            this.Controls.Add(this.textBoxPagamentoPesquisa);
            this.Controls.Add(this.textBoxPagamentoQuantia);
            this.Controls.Add(this.textBoxPagamentoData);
            this.Controls.Add(this.textBoxPagamentoTipo);
            this.Controls.Add(this.textBoxPagamentoCod_Func);
            this.Controls.Add(this.textBoxBI);
            this.Controls.Add(this.textBoxPagamentoCod_Prod);
            this.Controls.Add(this.textBoxPagamentoHora);
            this.Controls.Add(this.textBoxPagamentoCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPagamento);
            this.Controls.Add(this.buttonPagamentoEliminar);
            this.Controls.Add(this.buttonPagamentoPesquisa);
            this.Controls.Add(this.buttonPagamentoNovo);
            this.Controls.Add(this.buttonPagamentoAlterar);
            this.MaximizeBox = false;
            this.Name = "frmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPagamentoAlterar;
        private System.Windows.Forms.Button buttonPagamentoNovo;
        private System.Windows.Forms.Button buttonPagamentoEliminar;
        private System.Windows.Forms.DataGridView dataGridViewPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPagamentoCodigo;
        private System.Windows.Forms.TextBox textBoxPagamentoPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPagamentoPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Pag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn quntia;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox textBoxPagamentoCod_Func;
        private System.Windows.Forms.TextBox textBoxPagamentoCod_Prod;
        private System.Windows.Forms.TextBox textBoxPagamentoData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBI;
        private System.Windows.Forms.TextBox textBoxPagamentoTipo;
        private System.Windows.Forms.TextBox textBoxPagamentoQuantia;
        private System.Windows.Forms.TextBox textBoxPagamentoHora;
        private System.Windows.Forms.Timer timer1;
    }
}