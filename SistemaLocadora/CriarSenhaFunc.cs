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
    public partial class CriarSenhaFunc : Form
    {
        public CriarSenhaFunc()
        {
            InitializeComponent();
        }
        RepositorioFunc func = new RepositorioFunc();
        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            try
            {
                func.RAFunc = Convert.ToInt32(txtRaFunc.Text);
                func.cSenha = txtSenha.Text;
                func.Cargo = Convert.ToString(cbCargo.SelectedIndex + 1);
                if (txtConfSenha.Text == txtSenha.Text)
                {
                    func.SalvarLog(func);
                    MessageBox.Show("Senha cadastrada com sucesso");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO", ex.Message);
            }

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRaFunc.Clear();
            txtSenha.Clear();
            txtConfSenha.Clear();
            cbCargo.SelectedIndex = -1;
        }
    }
}
