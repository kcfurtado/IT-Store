namespace WindowsFormsApplication1
{
    partial class frmProdutoVenda
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNovoProdutoVenda = new System.Windows.Forms.Button();
            this.buttonAlterarProdutoVenda = new System.Windows.Forms.Button();
            this.buttonEliminarProdutoVenda = new System.Windows.Forms.Button();
            this.dataGridViewProdutoVenda = new System.Windows.Forms.DataGridView();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisarProdutoVenda = new System.Windows.Forms.Button();
            this.selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cod_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SteelBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label24);
            this.panel7.Location = new System.Drawing.Point(12, 21);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(748, 34);
            this.panel7.TabIndex = 4;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(3, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(130, 21);
            this.label24.TabIndex = 0;
            this.label24.Text = "Produtos Venda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonNovoProdutoVenda);
            this.panel1.Controls.Add(this.buttonAlterarProdutoVenda);
            this.panel1.Controls.Add(this.buttonEliminarProdutoVenda);
            this.panel1.Controls.Add(this.dataGridViewProdutoVenda);
            this.panel1.Controls.Add(this.textBoxPesquisa);
            this.panel1.Controls.Add(this.buttonPesquisarProdutoVenda);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 375);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Nome/Codigo";
            // 
            // buttonNovoProdutoVenda
            // 
            this.buttonNovoProdutoVenda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonNovoProdutoVenda.FlatAppearance.BorderSize = 0;
            this.buttonNovoProdutoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoProdutoVenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovoProdutoVenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNovoProdutoVenda.Location = new System.Drawing.Point(473, 325);
            this.buttonNovoProdutoVenda.Name = "buttonNovoProdutoVenda";
            this.buttonNovoProdutoVenda.Size = new System.Drawing.Size(122, 31);
            this.buttonNovoProdutoVenda.TabIndex = 71;
            this.buttonNovoProdutoVenda.Text = "Novo";
            this.buttonNovoProdutoVenda.UseVisualStyleBackColor = false;
            this.buttonNovoProdutoVenda.Click += new System.EventHandler(this.buttonNovoProdutoVenda_Click);
            // 
            // buttonAlterarProdutoVenda
            // 
            this.buttonAlterarProdutoVenda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAlterarProdutoVenda.FlatAppearance.BorderSize = 0;
            this.buttonAlterarProdutoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarProdutoVenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarProdutoVenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAlterarProdutoVenda.Location = new System.Drawing.Point(344, 325);
            this.buttonAlterarProdutoVenda.Name = "buttonAlterarProdutoVenda";
            this.buttonAlterarProdutoVenda.Size = new System.Drawing.Size(100, 31);
            this.buttonAlterarProdutoVenda.TabIndex = 70;
            this.buttonAlterarProdutoVenda.Text = "Alterar";
            this.buttonAlterarProdutoVenda.UseVisualStyleBackColor = false;
            this.buttonAlterarProdutoVenda.Click += new System.EventHandler(this.buttonAlterarProdutoVenda_Click);
            // 
            // buttonEliminarProdutoVenda
            // 
            this.buttonEliminarProdutoVenda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEliminarProdutoVenda.FlatAppearance.BorderSize = 0;
            this.buttonEliminarProdutoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarProdutoVenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarProdutoVenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminarProdutoVenda.Location = new System.Drawing.Point(624, 325);
            this.buttonEliminarProdutoVenda.Name = "buttonEliminarProdutoVenda";
            this.buttonEliminarProdutoVenda.Size = new System.Drawing.Size(113, 31);
            this.buttonEliminarProdutoVenda.TabIndex = 69;
            this.buttonEliminarProdutoVenda.Text = "Eliminar";
            this.buttonEliminarProdutoVenda.UseVisualStyleBackColor = false;
            this.buttonEliminarProdutoVenda.Click += new System.EventHandler(this.buttonEliminarProdutoVenda_Click);
            // 
            // dataGridViewProdutoVenda
            // 
            this.dataGridViewProdutoVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutoVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionar,
            this.cod_Prod,
            this.nomeFunc,
            this.marcaProd,
            this.modeloProd,
            this.quantidadeProd,
            this.precoVenda});
            this.dataGridViewProdutoVenda.Location = new System.Drawing.Point(114, 34);
            this.dataGridViewProdutoVenda.MultiSelect = false;
            this.dataGridViewProdutoVenda.Name = "dataGridViewProdutoVenda";
            this.dataGridViewProdutoVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutoVenda.Size = new System.Drawing.Size(623, 260);
            this.dataGridViewProdutoVenda.TabIndex = 68;
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(105, 8);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(513, 20);
            this.textBoxPesquisa.TabIndex = 67;
            // 
            // buttonPesquisarProdutoVenda
            // 
            this.buttonPesquisarProdutoVenda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPesquisarProdutoVenda.FlatAppearance.BorderSize = 0;
            this.buttonPesquisarProdutoVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarProdutoVenda.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarProdutoVenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPesquisarProdutoVenda.Location = new System.Drawing.Point(629, 8);
            this.buttonPesquisarProdutoVenda.Name = "buttonPesquisarProdutoVenda";
            this.buttonPesquisarProdutoVenda.Size = new System.Drawing.Size(108, 25);
            this.buttonPesquisarProdutoVenda.TabIndex = 66;
            this.buttonPesquisarProdutoVenda.Text = "Pesquisar";
            this.buttonPesquisarProdutoVenda.UseVisualStyleBackColor = false;
            this.buttonPesquisarProdutoVenda.Click += new System.EventHandler(this.buttonPesquisarProdutoVenda_Click);
            // 
            // selecionar
            // 
            this.selecionar.HeaderText = " ";
            this.selecionar.Name = "selecionar";
            this.selecionar.Width = 40;
            // 
            // cod_Prod
            // 
            this.cod_Prod.DataPropertyName = "Cod_P";
            this.cod_Prod.HeaderText = "Codigo";
            this.cod_Prod.Name = "cod_Prod";
            this.cod_Prod.ReadOnly = true;
            this.cod_Prod.Width = 50;
            // 
            // nomeFunc
            // 
            this.nomeFunc.DataPropertyName = "Nome_P ";
            this.nomeFunc.HeaderText = "Nome";
            this.nomeFunc.Name = "nomeFunc";
            this.nomeFunc.ReadOnly = true;
            // 
            // marcaProd
            // 
            this.marcaProd.DataPropertyName = "Marca_P";
            this.marcaProd.HeaderText = "Marca";
            this.marcaProd.Name = "marcaProd";
            this.marcaProd.ReadOnly = true;
            // 
            // modeloProd
            // 
            this.modeloProd.DataPropertyName = "Modelo_P";
            this.modeloProd.HeaderText = "Modelo";
            this.modeloProd.Name = "modeloProd";
            this.modeloProd.ReadOnly = true;
            // 
            // quantidadeProd
            // 
            this.quantidadeProd.DataPropertyName = "quantidd_stock";
            this.quantidadeProd.HeaderText = "Quantidade stock";
            this.quantidadeProd.Name = "quantidadeProd";
            this.quantidadeProd.ReadOnly = true;
            this.quantidadeProd.Width = 120;
            // 
            // precoVenda
            // 
            this.precoVenda.DataPropertyName = "preco";
            this.precoVenda.HeaderText = "Preço";
            this.precoVenda.Name = "precoVenda";
            this.precoVenda.ReadOnly = true;
            this.precoVenda.Width = 70;
            // 
            // frmProdutoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProdutoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                    Produto Venda";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Button buttonPesquisarProdutoVenda;
        private System.Windows.Forms.DataGridView dataGridViewProdutoVenda;
        private System.Windows.Forms.Button buttonNovoProdutoVenda;
        private System.Windows.Forms.Button buttonAlterarProdutoVenda;
        private System.Windows.Forms.Button buttonEliminarProdutoVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoVenda;
    }
}