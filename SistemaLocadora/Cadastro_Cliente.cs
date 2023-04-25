using SistemaLocadora.Data;
using SistemaLocadora.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaLocadora
{
    public partial class Cliente1 : Form
    {
        RepositorioCliente repositorioCliente = new RepositorioCliente();

        ClienteFunc clienteFunc = new ClienteFunc();

        int nCdCliente = 0;
        public Cliente1(int nCdCliente, Operacao operacao)
        {
            InitializeComponent();
           // this.clienteFunc = clienteFunc;

            this.nCdCliente = nCdCliente;

            if (this.nCdCliente > 0)
               GetCliente(nCdCliente);

            if (operacao == Operacao.Excluir)
            {
                this.Text += " - Excluir Cliente";
                TravarTxt();
                btnCadastra.Visible = false;
                btnExcluir.Visible = true;
                
            }
            if(operacao == Operacao.Adicionar)
            {
                this.Text += " - Cadastra Cliente ";
                btnCadastra.Visible = true;
                btnExcluir.Visible = false;
            }
            if (operacao == Operacao.Alterar)
            {
                this.Text += " - Alterar Cliente ";
                btnCadastra.Visible = true;
                btnExcluir.Visible = false;
            }

        }

       
            




        private void Cliente1_Load(object sender, EventArgs e)
        {
           
            cbGenero.SelectedIndex = 0;
            cbPessoa.SelectedIndex = 0;
       
        }
       

        #region Botao Cadastra Cliente
        private void btnCadastra_Click(object sender, EventArgs e)
        {
            var novoCliente = new ClienteFunc();

            #region Verificando os TextBox

            

            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Entre com um nome!");
                txtNome.Focus();
                return;

            }
            else if (txtCpf.Text == String.Empty)
            {
                MessageBox.Show("Entre com um Cpf!");
                return;
            }
            else if (txtEnd.Text == String.Empty)
            {
                MessageBox.Show("Entre com um endereço!");
                return;
            }
            else if (txtTel.Text == String.Empty)
            {
                MessageBox.Show("Entre com um Telefone!");
                return;
            }
            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Entre com um email!");
                return;
            }
            else if (txtCep.Text == String.Empty)
            {
                MessageBox.Show("Entre com um Cep!");
                return;
            }
           

            #endregion

            #region Valores nos TextBox
            
            
            try
            { 
                if (txtId.Text != String.Empty)
                {
                    novoCliente.nCdCliente = Convert.ToDecimal(txtId.Text);
                    novoCliente.cNmNome = txtNome.Text;
                    novoCliente.dNascimento = txtNasc.Text;
                    novoCliente.cGenero = Convert.ToString(cbGenero.SelectedIndex + 1);
                    novoCliente.cEmail = txtEmail.Text;
                    novoCliente.cTelefone = txtTel.Text;
                    novoCliente.cCelular = txtCel.Text;
                    novoCliente.cPessoa = Convert.ToString(cbPessoa.SelectedIndex + 1);
                    novoCliente.cCpf = txtCpf.Text;
                    novoCliente.cRG = txtRg.Text;
                    novoCliente.cOrgExp = txtOrg.Text;
                    novoCliente.cUfExp = txtUf.Text;
                    novoCliente.cCep = txtCep.Text;
                    novoCliente.cEndereco = txtEnd.Text;
                    novoCliente.cNumero = Convert.ToInt32(txtNumCasa.Text);
                    novoCliente.cUFresid = txtUf.Text;
                    novoCliente.cBairro = txtBairro.Text;
                    novoCliente.cCidade = txtCidade.Text;
                    novoCliente.cComplemento = txtComplemento.Text;

                    repositorioCliente.update(novoCliente);
                    Limpar();
                    
                }

                else
                {

                    
                    novoCliente.cNmNome = txtNome.Text;
                    novoCliente.dNascimento = txtNasc.Text;
                    novoCliente.cGenero = Convert.ToString(cbGenero.SelectedIndex + 1);
                    novoCliente.cEmail = txtEmail.Text;
                    novoCliente.cTelefone = txtTel.Text;
                    novoCliente.cCelular = txtCel.Text;
                    novoCliente.cPessoa = Convert.ToString(cbPessoa.SelectedIndex + 1);
                    novoCliente.cCpf = txtCpf.Text;
                    novoCliente.cRG = txtRg.Text;
                    novoCliente.cOrgExp = txtOrg.Text;
                    novoCliente.cUfExp = txtUf.Text;
                    novoCliente.cCep = txtCep.Text;
                    novoCliente.cEndereco = txtEnd.Text;
                    novoCliente.cNumero = Convert.ToInt32(txtNumCasa.Text);
                    novoCliente.cUFresid = txtUf.Text;
                    novoCliente.cBairro = txtBairro.Text;
                    novoCliente.cCidade = txtCidade.Text;
                    novoCliente.cComplemento = txtComplemento.Text;

                    repositorioCliente.Save(novoCliente);
                    txtId.Text = novoCliente.nCdCliente.ToString();
                    Limpar();
                }
            }
            catch
            {
                MessageBox.Show("Erro");
            }
           
            #endregion


            #region toolStrip
           

            Processar( "Salvando cliente");

            MessageBox.Show("Cliente Cadastrado com sucesso");
            toolStripStatusLabel1.Text = "Agurdando";
            toolStripProgressBar1.Value = 0;

            #endregion

        }
        #endregion

        #region Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
           this.Close(); 
        }
        #endregion

        #region Metodo de Limpar os TextBox
        private void Limpar()
        {
            txtNome.Clear();
            txtNasc.Clear();
            txtId.Clear();
            txtTel.Clear();
            txtCel.Clear();
            txtEnd.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            txtCep.Clear();
            txtOrg.Clear();
            txtUf.Clear();
            txtNumCasa.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUfend.Clear();
            txtComplemento.Clear();
            cbGenero.SelectedIndex = 0;
            cbPessoa.SelectedIndex = 0;
        }

        #endregion

        #region Metodo toolStrip Processar
        public void Processar(string msg)
        {
            toolStripStatusLabel1.Text = msg;
            statusStrip1.Refresh();

            for (int i = 1; i <= 100; i++)
            {
                toolStripProgressBar1.Value = i;
                Thread.Sleep(50);
            }
        }
        #endregion

        #region Botão delete
       
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var delet = new ClienteFunc();

            delet.nCdCliente = Convert.ToDecimal(txtId.Text);

            repositorioCliente.Delet(delet);

            MessageBox.Show("Cliente Excluido");
            this.Close();

        }
        #endregion


        #region Metodos

        public void TravarTxt() // Metodo de Travar os txt pra nao entra nenhum dado
        {
            txtNome.Enabled = false;
            txtNasc.Enabled = false;
            cbGenero.Enabled = false;
            txtEmail.Enabled = false;
            txtTel.Enabled = false;
            txtCel.Enabled = false;
            cbPessoa.Enabled = false;
            txtCpf.Enabled = false;
            txtRg.Enabled = false;
            txtOrg.Enabled = false;
            txtUf.Enabled = false;
            txtCep.Enabled = false;
            txtEnd.Enabled = false;
            txtNumCasa.Enabled = false;
            txtUfend.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtComplemento.Enabled = false;

        }

        public void GetCliente(int nCdCliente) //metodo de Preencher os TextBox
        {

            try
            {
                using (SqlConnection con = new SqlConnection(Conn.StrCon))
                {
                    con.Open();

                    var sql = "Select * from Cliente where nCdCliente= " + nCdCliente;

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtId.Text = dr["nCdCliente"].ToString();
                                    txtNome.Text = dr["cNmNome"].ToString();
                                    txtNasc.Text = dr["dNascimento"].ToString();

                                    switch (dr["cGenero"]) 
                                    { 
                                        case 1:
                                        cbGenero.Text = "1- Masculino";
                                        break;

                                        case 2:
                                        cbGenero.Text = "2- Feminino";
                                        break;

                                        case 3:
                                        cbGenero.Text = "3- Outros";
                                        break;

                                    }

                                    txtEmail.Text = dr["cEmail"].ToString();
                                    txtTel.Text = dr["cTelefone"].ToString();
                                    txtCel.Text = dr["cCelular"].ToString();
                                    
                                    switch (dr["cPessoa"])
                                    {
                                        case 1:
                                            cbPessoa.Text = "1-Fisica";
                                            break;
                                        case 2:
                                            cbPessoa.Text = "2-Juridica";
                                            break;
                                    }

                                    txtCpf.Text = dr["cCpf"].ToString();
                                    txtRg.Text = dr["cRG"].ToString();
                                    txtOrg.Text = dr["cOrgExp"].ToString();
                                    txtUf.Text = dr["cUfExp"].ToString();
                                    txtCep.Text = dr["cCep"].ToString();
                                    txtEnd.Text = dr["cEndereco"].ToString();
                                    txtNumCasa.Text = dr["cNumero"].ToString();
                                    txtUfend.Text = dr["cUf"].ToString();
                                    txtBairro.Text = dr["cBairro"].ToString();
                                    txtCidade.Text = dr["cCidade"].ToString();
                                    txtComplemento.Text = dr["cComplemento"].ToString();



                                }
                                
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", ex.Message);
            }


        }
        #endregion
    }
}

