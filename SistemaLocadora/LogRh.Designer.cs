namespace SistemaLocadora
{
    partial class LogRh
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
            this.txtLogRh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaRh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogRh
            // 
            this.txtLogRh.Location = new System.Drawing.Point(12, 69);
            this.txtLogRh.Name = "txtLogRh";
            this.txtLogRh.Size = new System.Drawing.Size(136, 20);
            this.txtLogRh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // txtSenhaRh
            // 
            this.txtSenhaRh.Location = new System.Drawing.Point(12, 115);
            this.txtSenhaRh.Name = "txtSenhaRh";
            this.txtSenhaRh.Size = new System.Drawing.Size(136, 20);
            this.txtSenhaRh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(41, 141);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(78, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // LogRh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 212);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenhaRh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLogRh);
            this.Name = "LogRh";
            this.Text = "LogRh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogRh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaRh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEntrar;
    }
}