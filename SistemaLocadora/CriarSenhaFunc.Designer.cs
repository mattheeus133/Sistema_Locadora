namespace SistemaLocadora
{
    partial class CriarSenhaFunc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRaFunc = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesqFunc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadFunc = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirma senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Senha:";
            // 
            // txtRaFunc
            // 
            this.txtRaFunc.Location = new System.Drawing.Point(12, 284);
            this.txtRaFunc.Name = "txtRaFunc";
            this.txtRaFunc.Size = new System.Drawing.Size(100, 20);
            this.txtRaFunc.TabIndex = 5;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(118, 284);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Location = new System.Drawing.Point(224, 284);
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(100, 20);
            this.txtConfSenha.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(12, 77);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(194, 20);
            this.txtNomeFunc.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome Funcionario:";
            // 
            // btnPesqFunc
            // 
            this.btnPesqFunc.Location = new System.Drawing.Point(212, 74);
            this.btnPesqFunc.Name = "btnPesqFunc";
            this.btnPesqFunc.Size = new System.Drawing.Size(75, 23);
            this.btnPesqFunc.TabIndex = 11;
            this.btnPesqFunc.Text = "Pesquisar";
            this.btnPesqFunc.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(177, 310);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadFunc
            // 
            this.btnCadFunc.Location = new System.Drawing.Point(15, 310);
            this.btnCadFunc.Name = "btnCadFunc";
            this.btnCadFunc.Size = new System.Drawing.Size(75, 23);
            this.btnCadFunc.TabIndex = 13;
            this.btnCadFunc.Text = "Cadastrar ";
            this.btnCadFunc.UseVisualStyleBackColor = true;
            this.btnCadFunc.Click += new System.EventHandler(this.btnCadFunc_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(96, 310);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // cbCargo
            // 
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "1-Gerente",
            "2-Rh",
            "3-Atendente"});
            this.cbCargo.Location = new System.Drawing.Point(330, 284);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(121, 21);
            this.cbCargo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cargo";
            // 
            // CriarSenhaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 359);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadFunc);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesqFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtRaFunc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CriarSenhaFunc";
            this.Text = "CriarSenhaFunc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRaFunc;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesqFunc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadFunc;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label4;
    }
}