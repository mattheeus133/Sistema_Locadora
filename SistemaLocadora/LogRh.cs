using SistemaLocadora.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLocadora
{
    public partial class LogRh : Form
    {
        public LogRh()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            VerificarLogFunc verificar = new VerificarLogFunc();
            verificar.acessarCad(txtLogRh.Text, txtSenhaRh.Text);

            Login login = new Login();
            this.Hide();
            login.Close();


            if (verificar.tem)
                {

                    CadastroFunc cadastro = new CadastroFunc();
                    cadastro.ShowDialog();

                }
                
            else
            {
                MessageBox.Show("Login ou Senha incorreto");
                txtLogRh.Clear();
                txtSenhaRh.Clear();
                txtLogRh.Focus();
            }

        }
    }
}
