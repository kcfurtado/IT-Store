namespace WindowsFormsApplication1
{
    partial class frmCliente
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNovoCliente = new System.Windows.Forms.Button();
            this.buttonAlterarCliente = new System.Windows.Forms.Button();
            this.buttonEliminarCliente = new System.Windows.Forms.Button();
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.SelecionarCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BI_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_Func_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPesquisaCliente = new System.Windows.Forms.TextBox();
            this.buttonPesquisarCliente = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SteelBlue;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label27);
            this.panel9.Location = new System.Drawing.Point(12, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(826, 34);
            this.panel9.TabIndex = 4;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label27.Location = new System.Drawing.Point(3, 7);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 21);
            this.label27.TabIndex = 0;
            this.label27.Text = "Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonNovoCliente);
            this.panel1.Controls.Add(this.buttonAlterarCliente);
            this.panel1.Controls.Add(this.buttonEliminarCliente);
            this.panel1.Controls.Add(this.dataGridViewCliente);
            this.panel1.Controls.Add(this.textBoxPesquisaCliente);
            this.panel1.Controls.Add(this.buttonPesquisarCliente);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 367);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "BI/Nome";
            // 
            // buttonNovoCliente
            // 
            this.buttonNovoCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonNovoCliente.FlatAppearance.BorderSize = 0;
            this.buttonNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovoCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovoCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNovoCliente.Location = new System.Drawing.Point(541, 319);
            this.buttonNovoCliente.Name = "buttonNovoCliente";
            this.buttonNovoCliente.Size = new System.Drawing.Size(122, 31);
            this.buttonNovoCliente.TabIndex = 70;
            this.buttonNovoCliente.Text = "Novo";
            this.buttonNovoCliente.UseVisualStyleBackColor = false;
            this.buttonNovoCliente.Click += new System.EventHandler(this.buttonNovoCliente_Click);
            // 
            // buttonAlterarCliente
            // 
            this.buttonAlterarCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAlterarCliente.FlatAppearance.BorderSize = 0;
            this.buttonAlterarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterarCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAlterarCliente.Location = new System.Drawing.Point(412, 319);
            this.buttonAlterarCliente.Name = "buttonAlterarCliente";
            this.buttonAlterarCliente.Size = new System.Drawing.Size(100, 31);
            this.buttonAlterarCliente.TabIndex = 69;
            this.buttonAlterarCliente.Text = "Alterar";
            this.buttonAlterarCliente.UseVisualStyleBackColor = false;
            this.buttonAlterarCliente.Click += new System.EventHandler(this.buttonAlterarCliente_Click);
            // 
            // buttonEliminarCliente
            // 
            this.buttonEliminarCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEliminarCliente.FlatAppearance.BorderSize = 0;
            this.buttonEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminarCliente.Location = new System.Drawing.Point(692, 319);
            this.buttonEliminarCliente.Name = "buttonEliminarCliente";
            this.buttonEliminarCliente.Size = new System.Drawing.Size(113, 31);
            this.buttonEliminarCliente.TabIndex = 68;
            this.buttonEliminarCliente.Text = "Eliminar";
            this.buttonEliminarCliente.UseVisualStyleBackColor = false;
            this.buttonEliminarCliente.Click += new System.EventHandler(this.buttonEliminarCliente_Click);
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelecionarCliente,
            this.BI_Cliente,
            this.nomeCliente,
            this.moradaCliente,
            this.telefoneCliente,
            this.emailCliente,
            this.cod_Func_Cliente});
            this.dataGridViewCliente.Location = new System.Drawing.Point(58, 51);
            this.dataGridViewCliente.MultiSelect = false;
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.ReadOnly = true;
            this.dataGridViewCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCliente.Size = new System.Drawing.Size(745, 231);
            this.dataGridViewCliente.TabIndex = 66;
            // 
            // SelecionarCliente
            // 
            this.SelecionarCliente.HeaderText = "";
            this.SelecionarCliente.Name = "SelecionarCliente";
            this.SelecionarCliente.ReadOnly = true;
            this.SelecionarCliente.Width = 20;
            // 
            // BI_Cliente
            // 
            this.BI_Cliente.DataPropertyName = "BI";
            this.BI_Cliente.HeaderText = "Bilhete";
            this.BI_Cliente.Name = "BI_Cliente";
            this.BI_Cliente.ReadOnly = true;
            // 
            // nomeCliente
            // 
            this.nomeCliente.DataPropertyName = "nome";
            this.nomeCliente.HeaderText = "Nome";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            // 
            // moradaCliente
            // 
            this.moradaCliente.DataPropertyName = "morada";
            this.moradaCliente.HeaderText = "Morada";
            this.moradaCliente.Name = "moradaCliente";
            this.moradaCliente.ReadOnly = true;
            // 
            // telefoneCliente
            // 
            this.telefoneCliente.DataPropertyName = "telefone";
            this.telefoneCliente.HeaderText = "Telefone";
            this.telefoneCliente.Name = "telefoneCliente";
            this.telefoneCliente.ReadOnly = true;
            // 
            // emailCliente
            // 
            this.emailCliente.DataPropertyName = "email";
            this.emailCliente.HeaderText = "Email";
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.ReadOnly = true;
            this.emailCliente.Width = 150;
            // 
            // cod_Func_Cliente
            // 
            this.cod_Func_Cliente.DataPropertyName = "cod_Func";
            this.cod_Func_Cliente.HeaderText = "Codigo Funcionario";
            this.cod_Func_Cliente.Name = "cod_Func_Cliente";
            this.cod_Func_Cliente.ReadOnly = true;
            this.cod_Func_Cliente.Width = 130;
            // 
            // textBoxPesquisaCliente
            // 
            this.textBoxPesquisaCliente.Location = new System.Drawing.Point(110, 20);
            this.textBoxPesquisaCliente.Name = "textBoxPesquisaCliente";
            this.textBoxPesquisaCliente.Size = new System.Drawing.Size(591, 20);
            this.textBoxPesquisaCliente.TabIndex = 65;
            // 
            // buttonPesquisarCliente
            // 
            this.buttonPesquisarCliente.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.buttonPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisarCliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPesquisarCliente.Location = new System.Drawing.Point(707, 20);
            this.buttonPesquisarCliente.Name = "buttonPesquisarCliente";
            this.buttonPesquisarCliente.Size = new System.Drawing.Size(96, 25);
            this.buttonPesquisarCliente.TabIndex = 64;
            this.buttonPesquisarCliente.Text = "Pesquisar";
            this.buttonPesquisarCliente.UseVisualStyleBackColor = false;
            this.buttonPesquisarCliente.Click += new System.EventHandler(this.buttonPesquisarCliente_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.TextBox textBoxPesquisaCliente;
        private System.Windows.Forms.Button buttonPesquisarCliente;
        private System.Windows.Forms.Button buttonNovoCliente;
        private System.Windows.Forms.Button buttonAlterarCliente;
        private System.Windows.Forms.Button buttonEliminarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelecionarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn BI_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Func_Cliente;
    }
}