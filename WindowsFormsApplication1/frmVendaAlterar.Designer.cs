namespace WindowsFormsApplication1
{
    partial class frmVendaAlterar
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
            this.buttonVendaGuardar = new System.Windows.Forms.Button();
            this.textBoxCod_Venda = new System.Windows.Forms.TextBox();
            this.textBoxCod_Func_Ven = new System.Windows.Forms.TextBox();
            this.textBoxDataVenda = new System.Windows.Forms.TextBox();
            this.textBoxBI_Venda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVendaGuardar
            // 
            this.buttonVendaGuardar.Location = new System.Drawing.Point(217, 226);
            this.buttonVendaGuardar.Name = "buttonVendaGuardar";
            this.buttonVendaGuardar.Size = new System.Drawing.Size(98, 31);
            this.buttonVendaGuardar.TabIndex = 0;
            this.buttonVendaGuardar.Text = "Guardar";
            this.buttonVendaGuardar.UseVisualStyleBackColor = true;
            this.buttonVendaGuardar.Click += new System.EventHandler(this.buttonVendaGuardar_Click);
            // 
            // textBoxCod_Venda
            // 
            this.textBoxCod_Venda.Location = new System.Drawing.Point(118, 27);
            this.textBoxCod_Venda.Name = "textBoxCod_Venda";
            this.textBoxCod_Venda.Size = new System.Drawing.Size(124, 20);
            this.textBoxCod_Venda.TabIndex = 1;
            // 
            // textBoxCod_Func_Ven
            // 
            this.textBoxCod_Func_Ven.Location = new System.Drawing.Point(118, 77);
            this.textBoxCod_Func_Ven.Name = "textBoxCod_Func_Ven";
            this.textBoxCod_Func_Ven.Size = new System.Drawing.Size(124, 20);
            this.textBoxCod_Func_Ven.TabIndex = 1;
            // 
            // textBoxDataVenda
            // 
            this.textBoxDataVenda.Location = new System.Drawing.Point(118, 125);
            this.textBoxDataVenda.Name = "textBoxDataVenda";
            this.textBoxDataVenda.Size = new System.Drawing.Size(124, 20);
            this.textBoxDataVenda.TabIndex = 1;
            // 
            // textBoxBI_Venda
            // 
            this.textBoxBI_Venda.Location = new System.Drawing.Point(118, 175);
            this.textBoxBI_Venda.Name = "textBoxBI_Venda";
            this.textBoxBI_Venda.Size = new System.Drawing.Size(124, 20);
            this.textBoxBI_Venda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo Venda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo Funcionario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bilhete de Cliente";
            // 
            // frmVendaAlterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 264);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBI_Venda);
            this.Controls.Add(this.textBoxDataVenda);
            this.Controls.Add(this.textBoxCod_Func_Ven);
            this.Controls.Add(this.textBoxCod_Venda);
            this.Controls.Add(this.buttonVendaGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmVendaAlterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVendaGuardar;
        private System.Windows.Forms.TextBox textBoxCod_Venda;
        private System.Windows.Forms.TextBox textBoxCod_Func_Ven;
        private System.Windows.Forms.TextBox textBoxDataVenda;
        private System.Windows.Forms.TextBox textBoxBI_Venda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}