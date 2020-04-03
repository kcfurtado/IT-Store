namespace WindowsFormsApplication1
{
    partial class frmProdutoCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNovoProdutoCliente = new System.Windows.Forms.Button();
            this.buttonAlterarProdutoCliente = new System.Windows.Forms.Button();
            this.buttonEliminarProdutoCliente = new System.Windows.Forms.Button();
            this.dataGridViewProdutoCliente = new System.Windows.Forms.DataGridView();
            this.selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cod_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bi_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisarProdutoCliente = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoCliente)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonNovoProdutoCliente);
            this.panel1.Controls.Add(this.buttonAlterarProdutoCliente);
            this.panel1.Controls.Add(this.buttonEliminarProdutoCliente);
            this.panel1.Controls.Add(this.dataGridViewProdutoCliente);
            this.panel1.Controls.Add(this.textBoxPesquisa);
            this.panel1.Controls.Add(this.buttonPesquisarProdutoCliente);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 375);
            this.panel1.TabIndex = 7;
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
            // buttonNovoProdutoCliente
            // 
            this.buttonNovoProdutoCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonNovoProdutoCliente.FlatAppearance.BorderSize = 0;
            this.buttonNovoProdutoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoProdutoCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovoProdutoCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNovoProdutoCliente.Location = new System.Drawing.Point(578, 329);
            this.buttonNovoProdutoCliente.Name = "buttonNovoProdutoCliente";
            this.buttonNovoProdutoCliente.Size = new System.Drawing.Size(122, 31);
            this.buttonNovoProdutoCliente.TabIndex = 71;
            this.buttonNovoProdutoCliente.Text = "Novo";
            this.buttonNovoProdutoCliente.UseVisualStyleBackColor = false;
            this.buttonNovoProdutoCliente.Click += new System.EventHandler(this.buttonNovoProdutoCliente_Click);
            // 
            // buttonAlterarProdutoCliente
            // 
            this.buttonAlterarProdutoCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAlterarProdutoCliente.FlatAppearance.BorderSize = 0;
            this.buttonAlterarProdutoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarProdutoCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarProdutoCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAlterarProdutoCliente.Location = new System.Drawing.Point(449, 329);
            this.buttonAlterarProdutoCliente.Name = "buttonAlterarProdutoCliente";
            this.buttonAlterarProdutoCliente.Size = new System.Drawing.Size(100, 31);
            this.buttonAlterarProdutoCliente.TabIndex = 70;
            this.buttonAlterarProdutoCliente.Text = "Alterar";
            this.buttonAlterarProdutoCliente.UseVisualStyleBackColor = false;
            this.buttonAlterarProdutoCliente.Click += new System.EventHandler(this.buttonAlterarProdutoCliente_Click);
            // 
            // buttonEliminarProdutoCliente
            // 
            this.buttonEliminarProdutoCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEliminarProdutoCliente.FlatAppearance.BorderSize = 0;
            this.buttonEliminarProdutoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarProdutoCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarProdutoCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminarProdutoCliente.Location = new System.Drawing.Point(729, 329);
            this.buttonEliminarProdutoCliente.Name = "buttonEliminarProdutoCliente";
            this.buttonEliminarProdutoCliente.Size = new System.Drawing.Size(113, 31);
            this.buttonEliminarProdutoCliente.TabIndex = 69;
            this.buttonEliminarProdutoCliente.Text = "Eliminar";
            this.buttonEliminarProdutoCliente.UseVisualStyleBackColor = false;
            this.buttonEliminarProdutoCliente.Click += new System.EventHandler(this.buttonEliminarProdutoCliente_Click);
            // 
            // dataGridViewProdutoCliente
            // 
            this.dataGridViewProdutoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutoCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selecionar,
            this.cod_Prod,
            this.nomeFunc,
            this.marcaProd,
            this.modeloProd,
            this.quantidadeProd,
            this.cod_Func,
            this.bi_Cliente});
            this.dataGridViewProdutoCliente.Location = new System.Drawing.Point(105, 39);
            this.dataGridViewProdutoCliente.MultiSelect = false;
            this.dataGridViewProdutoCliente.Name = "dataGridViewProdutoCliente";
            this.dataGridViewProdutoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutoCliente.Size = new System.Drawing.Size(737, 260);
            this.dataGridViewProdutoCliente.TabIndex = 68;
            // 
            // selecionar
            // 
            this.selecionar.HeaderText = "";
            this.selecionar.Name = "selecionar";
            this.selecionar.Width = 40;
            // 
            // cod_Prod
            // 
            this.cod_Prod.DataPropertyName = "cod_Prod";
            this.cod_Prod.HeaderText = "Codigo";
            this.cod_Prod.Name = "cod_Prod";
            this.cod_Prod.ReadOnly = true;
            // 
            // nomeFunc
            // 
            this.nomeFunc.DataPropertyName = "nome";
            this.nomeFunc.HeaderText = "Nome";
            this.nomeFunc.Name = "nomeFunc";
            this.nomeFunc.ReadOnly = true;
            this.nomeFunc.Width = 90;
            // 
            // marcaProd
            // 
            this.marcaProd.DataPropertyName = "marca";
            this.marcaProd.HeaderText = "Marca";
            this.marcaProd.Name = "marcaProd";
            this.marcaProd.ReadOnly = true;
            this.marcaProd.Width = 90;
            // 
            // modeloProd
            // 
            this.modeloProd.DataPropertyName = "modelo";
            this.modeloProd.HeaderText = "Modelo";
            this.modeloProd.Name = "modeloProd";
            this.modeloProd.ReadOnly = true;
            this.modeloProd.Width = 90;
            // 
            // quantidadeProd
            // 
            this.quantidadeProd.DataPropertyName = "quantidade";
            this.quantidadeProd.HeaderText = "Quantidade";
            this.quantidadeProd.Name = "quantidadeProd";
            this.quantidadeProd.ReadOnly = true;
            this.quantidadeProd.Width = 80;
            // 
            // cod_Func
            // 
            this.cod_Func.DataPropertyName = "cod_Func";
            this.cod_Func.HeaderText = "Codigo Funcionario";
            this.cod_Func.Name = "cod_Func";
            this.cod_Func.ReadOnly = true;
            this.cod_Func.Width = 130;
            // 
            // bi_Cliente
            // 
            this.bi_Cliente.DataPropertyName = "BI";
            this.bi_Cliente.HeaderText = "Bilhete";
            this.bi_Cliente.Name = "bi_Cliente";
            this.bi_Cliente.ReadOnly = true;
            this.bi_Cliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bi_Cliente.Width = 70;
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(105, 8);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(623, 20);
            this.textBoxPesquisa.TabIndex = 67;
            // 
            // buttonPesquisarProdutoCliente
            // 
            this.buttonPesquisarProdutoCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPesquisarProdutoCliente.FlatAppearance.BorderSize = 0;
            this.buttonPesquisarProdutoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarProdutoCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarProdutoCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPesquisarProdutoCliente.Location = new System.Drawing.Point(734, 8);
            this.buttonPesquisarProdutoCliente.Name = "buttonPesquisarProdutoCliente";
            this.buttonPesquisarProdutoCliente.Size = new System.Drawing.Size(108, 25);
            this.buttonPesquisarProdutoCliente.TabIndex = 66;
            this.buttonPesquisarProdutoCliente.Text = "Pesquisar";
            this.buttonPesquisarProdutoCliente.UseVisualStyleBackColor = false;
            this.buttonPesquisarProdutoCliente.Click += new System.EventHandler(this.buttonPesquisarProdutoCliente_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SteelBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label24);
            this.panel7.Location = new System.Drawing.Point(12, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(849, 34);
            this.panel7.TabIndex = 6;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(3, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(135, 21);
            this.label24.TabIndex = 0;
            this.label24.Text = "Produtos Cliente";
            // 
            // frmProdutoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProdutoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                         Produto Cliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutoCliente)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNovoProdutoCliente;
        private System.Windows.Forms.Button buttonAlterarProdutoCliente;
        private System.Windows.Forms.Button buttonEliminarProdutoCliente;
        private System.Windows.Forms.DataGridView dataGridViewProdutoCliente;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Button buttonPesquisarProdutoCliente;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn bi_Cliente;
    }
}