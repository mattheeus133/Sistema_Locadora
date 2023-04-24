
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLocadora.Domain
{
    public class Opcoes
    {
        public class Conn
        {
            private static string server = @"DESKTOP-G2HQT10\SQLEXPRESS";
            private static string dataBase = "Dados_Locadora";
            private static string user = "DESKTOP-G2HQT10";
            private static string password = "senha";

            public static string StrCon
            {
                get { return $"Data Source={server}; Integrated Security=true;Initial Catalog={dataBase}; User ID={user}; Password={password}"; }

            }
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public byte Nivel { get; set; }

        public Opcoes(string nome, string descricao, byte nivel)
        {
            Nome = nome;
            Descricao = descricao;
            Nivel = nivel;
        }

        public static HashSet<Opcoes> Criar(MenuStrip Menu)
        {
            var hashSetOpcoes = new HashSet<Opcoes>();

            // Nivel 1
            foreach (ToolStripMenuItem item in Menu.Items)
            {
                var descricao1 = item.Text;

                if (item.HasDropDownItems)
                {

                    //Nivel 2
                    foreach (ToolStripMenuItem opcao in item.DropDownItems)
                    {

                        var descricao2 = descricao1 + " / " + opcao.Text;

                        if (opcao.HasDropDownItems)
                        {
                            //Nivel 3
                            foreach (ToolStripMenuItem subOpcao in opcao.DropDownItems)
                            {
                                var descricao3 = descricao2 + " / " + subOpcao.Text;
                                hashSetOpcoes.Add(new Opcoes(subOpcao.Name, descricao3, 3));
                            }
                        }
                        else
                        {
                            hashSetOpcoes.Add(new Opcoes(opcao.Name, descricao2, 2));
                        }
                    }

                }
                else
                {
                    hashSetOpcoes.Add(new Opcoes(item.Name, descricao1, 1));
                }
            }
            return hashSetOpcoes;
        }

        public static bool SalvarMenu(HashSet<Opcoes> opcoes)
        {
         

            var sql = "insert into MenuOpcoes(Nome, Descricao, Nivel) values (@Nome, @Descricao, @Nivel)";

            try
            {
                using (var cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                        cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                        cmd.Parameters.Add("@Nivel", SqlDbType.TinyInt);

                        foreach (var item in opcoes)
                        {
                            cmd.Parameters["@Nome"].Value = item.Nome;
                            cmd.Parameters["@Descricao"].Value = item.Descricao;
                            cmd.Parameters["@Nivel"].Value = item.Nivel;

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }



}
