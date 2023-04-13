using SistemaLocadora.Data;
using SistemaLocadora.Domain;
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
    public partial class CadastroFunc : Form
    {
        string caminhoFoto = "";
        public CadastroFunc()
        {
            InitializeComponent();
        }

        private void CadastroFunc_Load(object sender, EventArgs e)
        {
            txtSecao.MaxLength = 3; 
            txtZona.MaxLength = 3;
            txtAgencia.MaxLength = 4;
        }

        RepositorioFunc Func = new RepositorioFunc();
        private void btnCriaSenhaFunc_Click(object sender, EventArgs e)
        {
            CriarSenhaFunc criarSenha = new CriarSenhaFunc();
            criarSenha.ShowDialog();
        }
        
        private void btnSalvarFunc_Click(object sender, EventArgs e)
        {
            Func.cNmNome = txtNome.Text;
            Func.dNascimento = txtDataNasc.Text;
            Func.cGenero = Convert.ToString(cbGenero.SelectedIndex + 1);
            Func.Naturalidade = Convert.ToString(cbNaturalidade.SelectedIndex + 1);
            Func.UFnasc = Convert.ToString(cbUFnasc.SelectedIndex + 1);
            Func.cTelefone = txtTelefone.Text;
            Func.cCelular = txtCelular.Text;
            Func.cCep = txtCep.Text;
            Func.cEndereco = txtEnd.Text;
            Func.cNumero = Convert.ToInt32(txtNumEnd.Text);
            Func.cComplemento = txtComplemento.Text;
            Func.cUFresid = Convert.ToString(cbUFresid.SelectedIndex + 1);
            Func.cBairro = txtBairro.Text;
            Func.cCidade = txtCidade.Text;
            Func.cEmail = txtEmail.Text;
            Func.Estado_Civil = Convert.ToString(cbEstadoCivil.SelectedIndex + 1);
            Func.cCpf = txtCpf.Text;
            Func.cRG = txtRg.Text;
            Func.cUfExp = Convert.ToString(cbUfDoc.SelectedIndex + 1);
            Func.Titulo_Eleitor = txtTitulo.Text;
            Func.Secao = txtSecao.Text;
            Func.Zona = txtZona.Text;
            Func.PIS = txtPis.Text;
            Func.Banco = Convert.ToString(cbBanco.SelectedIndex + 1);
            Func.Agencia = txtAgencia.Text;
            Func.Conta = txtConta.Text;
            Func.Tipo_Conta = Convert.ToString(cbTipoConta.SelectedIndex + 1);
            Func.CaminhoFoto = caminhoFoto;

            Func.Salvar(Func);
            MessageBox.Show("Funcionario salvo");


        }


        private void btnLimparFunc_Click(object sender, EventArgs e)
        {
            
    
        }

        private void btnCarregaFoto_Click(object sender, EventArgs e)
        {


            var openFile = new OpenFileDialog();

            openFile.Title = "Funcionario";
            openFile.Filter = "Arquivos de imagens jpg e png|*.jpg; *.png";
            openFile.InitialDirectory = @"C:\Users\User\Documents\Nuvem3\Projeto Locadora - Copia\FotosFunc";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
                caminhoFoto = openFile.FileName;

            if (caminhoFoto != "")
                picFotoFunc.Load(caminhoFoto);


        }

        private void btnEditarFunc_Click(object sender, EventArgs e)
        {

        }
    }
}
