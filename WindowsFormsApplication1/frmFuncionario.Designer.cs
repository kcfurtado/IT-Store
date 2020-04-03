namespace WindowsFormsApplication1
{
    partial class frmFuncionario
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
            this.buttonNovo = new System.Windows.Forms.Button();
            this.dataGridViewfuncionario = new System.Windows.Forms.DataGridView();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.cod_Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nif_Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.morada_Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bi_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_Supr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SteelBlue;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label27);
            this.panel9.Location = new System.Drawing.Point(12, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1067, 34);
            this.panel9.TabIndex = 4;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label27.Location = new System.Drawing.Point(3, 7);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 21);
            this.label27.TabIndex = 0;
            this.label27.Text = "Funcionario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.buttonNovo);
            this.panel1.Controls.Add(this.dataGridViewfuncionario);
            this.panel1.Controls.Add(this.buttonAlterar);
            this.panel1.Controls.Add(this.buttonEliminar);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 416);
            this.panel1.TabIndex = 5;
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonNovo.FlatAppearance.BorderSize = 0;
            this.buttonNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNovo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonNovo.Location = new System.Drawing.Point(791, 359);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(122, 31);
            this.buttonNovo.TabIndex = 73;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // dataGridViewfuncionario
            // 
            this.dataGridViewfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_Func,
            this.nome_func,
            this.Nif_Func,
            this.morada_Func,
            this.telefone_Func,
            this.email_Func,
            this.bi_func,
            this.tipo_func,
            this.cod_Supr,
            this.usuario,
            this.senha_func});
            this.dataGridViewfuncionario.Location = new System.Drawing.Point(8, 21);
            this.dataGridViewfuncionario.MultiSelect = false;
            this.dataGridViewfuncionario.Name = "dataGridViewfuncionario";
            this.dataGridViewfuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewfuncionario.Size = new System.Drawing.Size(967, 310);
            this.dataGridViewfuncionario.TabIndex = 68;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAlterar.FlatAppearance.BorderSize = 0;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAlterar.Location = new System.Drawing.Point(662, 359);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(100, 31);
            this.buttonAlterar.TabIndex = 72;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminar.Location = new System.Drawing.Point(942, 359);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(113, 31);
            this.buttonEliminar.TabIndex = 71;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // cod_Func
            // 
            this.cod_Func.DataPropertyName = "cod_Fun";
            this.cod_Func.HeaderText = "Codigo";
            this.cod_Func.Name = "cod_Func";
            this.cod_Func.ReadOnly = true;
            this.cod_Func.Width = 50;
            // 
            // nome_func
            // 
            this.nome_func.DataPropertyName = "nome";
            this.nome_func.HeaderText = "Nome";
            this.nome_func.Name = "nome_func";
            this.nome_func.ReadOnly = true;
            this.nome_func.Width = 110;
            // 
            // Nif_Func
            // 
            this.Nif_Func.DataPropertyName = "NIF";
            this.Nif_Func.HeaderText = "NIF";
            this.Nif_Func.Name = "Nif_Func";
            this.Nif_Func.ReadOnly = true;
            // 
            // morada_Func
            // 
            this.morada_Func.DataPropertyName = "Morada";
            this.morada_Func.HeaderText = "Morada";
            this.morada_Func.Name = "morada_Func";
            this.morada_Func.ReadOnly = true;
            // 
            // telefone_Func
            // 
            this.telefone_Func.DataPropertyName = "Telefone";
            this.telefone_Func.HeaderText = "Telefone";
            this.telefone_Func.Name = "telefone_Func";
            this.telefone_Func.ReadOnly = true;
            this.telefone_Func.Width = 70;
            // 
            // email_Func
            // 
            this.email_Func.DataPropertyName = "Email";
            this.email_Func.HeaderText = "Email";
            this.email_Func.Name = "email_Func";
            this.email_Func.ReadOnly = true;
            this.email_Func.Width = 150;
            // 
            // bi_func
            // 
            this.bi_func.DataPropertyName = "Num_BI";
            this.bi_func.HeaderText = "Bilhete";
            this.bi_func.Name = "bi_func";
            this.bi_func.ReadOnly = true;
            this.bi_func.Width = 60;
            // 
            // tipo_func
            // 
            this.tipo_func.DataPropertyName = "Tipo_Fun";
            this.tipo_func.HeaderText = "Cargo";
            this.tipo_func.Name = "tipo_func";
            this.tipo_func.ReadOnly = true;
            this.tipo_func.Width = 70;
            // 
            // cod_Supr
            // 
            this.cod_Supr.DataPropertyName = "cod_Supr";
            this.cod_Supr.HeaderText = "Suprivisor";
            this.cod_Supr.Name = "cod_Supr";
            this.cod_Supr.ReadOnly = true;
            this.cod_Supr.Width = 70;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "Usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 70;
            // 
            // senha_func
            // 
            this.senha_func.DataPropertyName = "Senha";
            this.senha_func.HeaderText = "Senha";
            this.senha_func.Name = "senha_func";
            this.senha_func.ReadOnly = true;
            this.senha_func.Width = 70;
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewfuncionario;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nif_Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn morada_Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn bi_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_Supr;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha_func;
    }
}