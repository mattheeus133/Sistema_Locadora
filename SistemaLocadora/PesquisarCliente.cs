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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLocadora
{
    public partial class PesquisarCliente : Form
    {
        public PesquisarCliente()
        {
            InitializeComponent();
        }
        Conn conn = new Conn();


        public void Buscar()
        {
            try
            {
                var sql = "Select * from Cliente";

                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();


                    using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dtgCliente.DataSource = dt;
                        }
                    }
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha\n\n" + ex.Message);
            }
        }

        private void ExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Retorno(Operacao.Excluir);
            Buscar();
        }

        private void alterartoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Retorno(Operacao.Alterar);
            Buscar();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Retorno(Operacao.Adicionar);
            Buscar();
        }

        public void Retorno(Operacao operacao)
        {
            if (operacao == Operacao.Alterar)
            {
                var nCdCliente = Convert.ToInt32(dtgCliente.Rows[dtgCliente.CurrentCell.RowIndex].Cells[0].Value);
                Cliente1 cadastro_Cliente = new Cliente1(nCdCliente, Operacao.Alterar);
                cadastro_Cliente.ShowDialog();
            }
            if (operacao == Operacao.Excluir)
            {
                var nCdCliente = Convert.ToInt32(dtgCliente.Rows[dtgCliente.CurrentCell.RowIndex].Cells[0].Value);
                Cliente1 cadastro_Cliente = new Cliente1(nCdCliente, Operacao.Excluir);
                cadastro_Cliente.ShowDialog();
            }
            if (operacao == Operacao.Adicionar)
            {
                Cliente1 cli = new Cliente1(0, Operacao.Adicionar);
                cli.ShowDialog();
            }
        }
        
    }
}
