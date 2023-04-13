using SistemaLocadora.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora.Data
{
    public class RepositorioFunc : ClienteFunc
    {
        
        public void Salvar(ClienteFunc clienteFunc)
        {
            byte[] foto = GetFoto(clienteFunc.CaminhoFoto); 

            var sql = "INSERT INTO Funcionario(cNmNome,dNascimento,cGenero,Naturalidade,UFnasc,cTelefone,cCelular,cCep,cEndereco,cNumero,cComplemento,cBairro ,cCidade,UFresid,cEmail,Estado_Civil,cCPF,cRG,cUfExp ,Titulo_Eleitor ,Secao,Zona ,PIS ,Banco ,Agencia ,Conta ,Tipo_Conta, FotoFunc) values (@cNmNome,@dNascimento,@cGenero,@Naturalidade,@UFnasc,@cTelefone,@cCelular,@cCep,@cEndereco,@cNumero,@cComplemento,@cBairro ,@cCidade,@UFresid,@cEmail,@Estado_Civil,@cCPF,@cRG,@cUfExp ,@Titulo_Eleitor ,@Secao,@Zona ,@PIS ,@Banco ,@Agencia ,@Conta ,@Tipo_Conta, @FotoFunc)";

            using (var con = new SqlConnection(Conn.StrCon))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql,con))
                {
                    cmd.Parameters.AddWithValue("@cNmNome", clienteFunc.cNmNome );
                    cmd.Parameters.AddWithValue("@dNascimento", clienteFunc.dNascimento);
                    cmd.Parameters.AddWithValue("@cGenero", clienteFunc.cGenero);
                    cmd.Parameters.AddWithValue("@Naturalidade", clienteFunc.Naturalidade);
                    cmd.Parameters.AddWithValue("@UFnasc", clienteFunc.UFnasc);
                    cmd.Parameters.AddWithValue("@cTelefone", clienteFunc.cTelefone);
                    cmd.Parameters.AddWithValue("@cCelular", clienteFunc.cCelular);
                    cmd.Parameters.AddWithValue("@cCep", clienteFunc.cCep);
                    cmd.Parameters.AddWithValue("@cEndereco", clienteFunc.cEndereco);
                    cmd.Parameters.AddWithValue("@cNumero", clienteFunc.cNumero);
                    cmd.Parameters.AddWithValue("@cComplemento", clienteFunc.cComplemento);
                    cmd.Parameters.AddWithValue("@cBairro", clienteFunc.cBairro);
                    cmd.Parameters.AddWithValue("@cCidade", clienteFunc.cCidade);
                    cmd.Parameters.AddWithValue("@UFresid", clienteFunc.cUFresid);
                    cmd.Parameters.AddWithValue("@cEmail", clienteFunc.cEmail);
                    cmd.Parameters.AddWithValue("@Estado_Civil", clienteFunc.Estado_Civil);
                    cmd.Parameters.AddWithValue("@cCPF", clienteFunc.cCpf);
                    cmd.Parameters.AddWithValue("@cRG", clienteFunc.cRG);
                    cmd.Parameters.AddWithValue("@cUfExp", clienteFunc.cUfExp);
                    cmd.Parameters.AddWithValue("@Titulo_Eleitor", clienteFunc.Titulo_Eleitor);
                    cmd.Parameters.AddWithValue("@Secao", clienteFunc.Secao);
                    cmd.Parameters.AddWithValue("@Zona", clienteFunc.Zona);
                    cmd.Parameters.AddWithValue("@PIS", clienteFunc.PIS);
                    cmd.Parameters.AddWithValue("@Banco", clienteFunc.Banco);
                    cmd.Parameters.AddWithValue("@Agencia", clienteFunc.Agencia);
                    cmd.Parameters.AddWithValue("@Conta", clienteFunc.Conta);
                    cmd.Parameters.AddWithValue("@Tipo_Conta", clienteFunc.Tipo_Conta);
                    cmd.Parameters.Add("@FotoFunc", System.Data.SqlDbType.Image, foto.Length).Value = foto;

                    cmd.ExecuteNonQuery();
                    

                }
            }
        }

        public void SalvarLog(ClienteFunc clienteFunc)
        {
            var Sql = "insert into LoginFunc (RAFunc , cSenha, Cargo) values (@RAFunc, @cSenha, @Cargo)";

            using (var con = new SqlConnection(Conn.StrCon))
            {
                con.Open();
                using (var cmd = new SqlCommand(Sql,con))
                {
                    cmd.Parameters.AddWithValue("@RAFunc", clienteFunc.RAFunc);
                    cmd.Parameters.AddWithValue("@cSenha", clienteFunc.cSenha);
                    cmd.Parameters.AddWithValue("@Cargo", clienteFunc.Cargo);

                    cmd.ExecuteNonQuery();

                }

            }
        }

        public byte[] GetFoto(string caminhoFoto) 
        {
            byte[] foto;
            using (var stream = new FileStream(caminhoFoto, FileMode.Open, FileAccess.Read)) 
            {
                using (var reader = new BinaryReader(stream))
                {
                    foto = reader.ReadBytes((int)stream.Length);
                }
            }
            return foto;
        }

        public void Delet(decimal RAFunc)
        {
            var sql = "Delet Funcionario where RAFunc = @RAFunc";

            using (var con = new SqlConnection(Conn.StrCon))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql,con))
                {
                    cmd.Parameters.AddWithValue("RAFunc", RAFunc);

                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
