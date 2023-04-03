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
    public partial class PagInicial : Form
    {
        public PagInicial()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesquisarCliente cad = new PesquisarCliente();
            cad.ShowDialog();
        }

        private void cadastraClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente1 cli = new Cliente1(0); // chamando outro forms
            cli.ShowDialog();
        }

        private void cadastraFilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFilme cadFilme = new CadastroFilme();
            cadFilme.ShowDialog();
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoFilmes catalogoFilmes = new CatalogoFilmes();
            catalogoFilmes.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CasdastroFuncionariotoolStrip_Click(object sender, EventArgs e)
        {
            LogRh logRh = new LogRh();  
             logRh.ShowDialog();

           /* CadastroFunc cadastroFunc = new CadastroFunc();
            cadastroFunc.ShowDialog();*/
        }
    }
}
