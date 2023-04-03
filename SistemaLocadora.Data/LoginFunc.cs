using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora.Data
{
    public class LoginFunc
    {
        public bool tem = false;
        public string mensagem = "";
        Conn conn = new Conn();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public bool VerificarLog(string login, string senha)
        {
            cmd.CommandText = "Select RAFunc , cSenha From LoginFunc where RAFunc = @RAFunc and cSenha = @cSenha ";
            cmd.Parameters.AddWithValue("@RAFunc", login);
            cmd.Parameters.AddWithValue("@cSenha", senha);

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        tem = true;
                    }
                }
            }
            catch(Exception ex)
            {
                
            }
            return tem;
        }

        public bool VerificarLogRh(string login, string senha)
        {

                cmd.CommandText = "Select RAFunc , cSenha From LoginFunc where RAFunc = @RAFunc and cSenha = @cSenha and Cargo = 2";
                cmd.Parameters.AddWithValue("@RAFunc", login);
                cmd.Parameters.AddWithValue("@cSenha", senha);

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        tem = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return tem;
        }

    }
}
