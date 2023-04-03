using SistemaLocadora.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLocadora
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Conectando aguarde";
            stLogin.Refresh();
            Thread.Sleep(1500);
            

            VerificarLogFunc verificar = new VerificarLogFunc();
            verificar.acessar(txtLogin.Text , txtSenha.Text);
            if (verificar.tem) 
            {
                toolStripStatusLabel1.Text = "Pronto conectado";
                stLogin.Refresh();
                Thread.Sleep(1500);

                PagInicial form1 = new PagInicial();
                form1.Show();
                
               
            }
            else
            {
                lbErro.Text = "Login ou Senha incorreto";
            }

            Login login = new Login();
            this.Hide();
            login.Close();
        }

        
    }
}
