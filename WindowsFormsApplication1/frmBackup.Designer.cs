namespace WindowsFormsApplication1
{
    partial class frmBackup
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonSelecionarCaminho = new System.Windows.Forms.Button();
            this.textBoxCaminhoRestore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonBrowserBackup = new System.Windows.Forms.Button();
            this.textBoxCaminhoBackup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRestore);
            this.groupBox2.Controls.Add(this.buttonSelecionarCaminho);
            this.groupBox2.Controls.Add(this.textBoxCaminhoRestore);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(2, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 103);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore";
            // 
            // buttonRestore
            // 
            this.buttonRestore.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonRestore.FlatAppearance.BorderSize = 0;
            this.buttonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestore.ForeColor = System.Drawing.Color.White;
            this.buttonRestore.Location = new System.Drawing.Point(152, 65);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(75, 23);
            this.buttonRestore.TabIndex = 4;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = false;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // buttonSelecionarCaminho
            // 
            this.buttonSelecionarCaminho.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSelecionarCaminho.FlatAppearance.BorderSize = 0;
            this.buttonSelecionarCaminho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelecionarCaminho.ForeColor = System.Drawing.Color.White;
            this.buttonSelecionarCaminho.Location = new System.Drawing.Point(302, 28);
            this.buttonSelecionarCaminho.Name = "buttonSelecionarCaminho";
            this.buttonSelecionarCaminho.Size = new System.Drawing.Size(75, 23);
            this.buttonSelecionarCaminho.TabIndex = 2;
            this.buttonSelecionarCaminho.Text = "Browser";
            this.buttonSelecionarCaminho.UseVisualStyleBackColor = false;
            this.buttonSelecionarCaminho.Click += new System.EventHandler(this.buttonSelecionarCaminho_Click);
            // 
            // textBoxCaminhoRestore
            // 
            this.textBoxCaminhoRestore.Location = new System.Drawing.Point(73, 30);
            this.textBoxCaminhoRestore.Name = "textBoxCaminhoRestore";
            this.textBoxCaminhoRestore.Size = new System.Drawing.Size(223, 20);
            this.textBoxCaminhoRestore.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Caminho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBackup);
            this.groupBox1.Controls.Add(this.buttonBrowserBackup);
            this.groupBox1.Controls.Add(this.textBoxCaminhoBackup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 103);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // buttonBackup
            // 
            this.buttonBackup.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBackup.FlatAppearance.BorderSize = 0;
            this.buttonBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackup.ForeColor = System.Drawing.Color.White;
            this.buttonBackup.Location = new System.Drawing.Point(152, 63);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(75, 23);
            this.buttonBackup.TabIndex = 3;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = false;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonBrowserBackup
            // 
            this.buttonBrowserBackup.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBrowserBackup.FlatAppearance.BorderSize = 0;
            this.buttonBrowserBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowserBackup.ForeColor = System.Drawing.Color.White;
            this.buttonBrowserBackup.Location = new System.Drawing.Point(302, 28);
            this.buttonBrowserBackup.Name = "buttonBrowserBackup";
            this.buttonBrowserBackup.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowserBackup.TabIndex = 2;
            this.buttonBrowserBackup.Text = "Browser";
            this.buttonBrowserBackup.UseVisualStyleBackColor = false;
            this.buttonBrowserBackup.Click += new System.EventHandler(this.buttonBrowserBackup_Click);
            // 
            // textBoxCaminhoBackup
            // 
            this.textBoxCaminhoBackup.Location = new System.Drawing.Point(73, 30);
            this.textBoxCaminhoBackup.Name = "textBoxCaminhoBackup";
            this.textBoxCaminhoBackup.Size = new System.Drawing.Size(223, 20);
            this.textBoxCaminhoBackup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho";
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 234);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBackup";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonSelecionarCaminho;
        private System.Windows.Forms.TextBox textBoxCaminhoRestore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonBrowserBackup;
        private System.Windows.Forms.TextBox textBoxCaminhoBackup;
        private System.Windows.Forms.Label label1;
    }
}