using SistemaLocadora.Data;
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
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sqlQuery = "EXEC dbo.SP_ObterCliente @AnCdCliente = " + txtConId.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dtgCliente.DataSource = dt;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Falha\n\n" + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var nCdCliente =Convert.ToInt32(dtgCliente.Rows[dtgCliente.CurrentCell.RowIndex].Cells[0].Value);
            Cliente1 cadastro_Cliente = new Cliente1(nCdCliente);
            cadastro_Cliente.ShowDialog();
        }
    }
}
