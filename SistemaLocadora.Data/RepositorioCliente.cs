using Dapper;
using SistemaLocadora.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaLocadora.Data
{
	public class RepositorioCliente 
	{
		
		public void Save(ClienteFunc cliente)
		{

			var Sql = "EXEC dbo.SP_SalvarCliente  @AcNmNome, @AdNascimento " +
				"                          ,@AcGenero ,@AcEmail ,@AcTelefone ,@AcCelular ,@AcPessoa ,@AcCpf ,@AcRG " +
				"                          ,@AcOrgExp ,@AcUfExp ,@AcCep ,@AcEndereco ,@AcNumero ,@AcUF ,@AcBairro ,@AcCidade ,@AcComplemento ";

			using (var conn = new SqlConnection(Conn.StrCon))
			{
				conn.Open();
				using (var cmd = new SqlCommand(Sql, conn))
				{
					cmd.Parameters.AddWithValue("@AcNmNome", cliente.cNmNome);
					cmd.Parameters.AddWithValue("@AdNascimento", cliente.dNascimento);
					cmd.Parameters.AddWithValue("@AcGenero ", cliente.cGenero);
					cmd.Parameters.AddWithValue("@AcEmail", cliente.cEmail);
					cmd.Parameters.AddWithValue("@AcTelefone", cliente.cTelefone);
					cmd.Parameters.AddWithValue("@AcCelular ", cliente.cCelular);
					cmd.Parameters.AddWithValue("@AcPessoa ", cliente.cPessoa);
					cmd.Parameters.AddWithValue("@AcCpf", cliente.cCpf);
					cmd.Parameters.AddWithValue("@AcRG", cliente.cRG);
					cmd.Parameters.AddWithValue("@AcOrgExp", cliente.cOrgExp);
					cmd.Parameters.AddWithValue("@AcUfExp ", cliente.cUfExp);
					cmd.Parameters.AddWithValue("@AcCep", cliente.cCep);
					cmd.Parameters.AddWithValue("@AcEndereco", cliente.cEndereco);
					cmd.Parameters.AddWithValue("@AcNumero", cliente.cNumero);
					cmd.Parameters.AddWithValue("@AcUF", cliente.cUFresid);
					cmd.Parameters.AddWithValue("@AcBairro", cliente.cBairro);
					cmd.Parameters.AddWithValue("@AcCidade", cliente.cCidade);
					cmd.Parameters.AddWithValue("@AcComplemento ", cliente.cComplemento);

					cmd.ExecuteNonQuery();
				}
			}

		}

		public void update(ClienteFunc cliente)
		{
			var Sql = "EXEC dbo.SP_AlterarValores @AnCdCliente,  @AcNmNome, @AdNascimento " +
				"                          ,@AcGenero ,@AcEmail ,@AcTelefone ,@AcCelular ,@AcPessoa ,@AcCpf ,@AcRG " +
				"                          ,@AcOrgExp ,@AcUfExp ,@AcCep ,@AcEndereco ,@AcNumero ,@AcUF ,@AcBairro ,@AcCidade ,@AcComplemento ";

			using (var conn = new SqlConnection(Conn.StrCon))
			{
				conn.Open();
				using (var cmd = new SqlCommand(Sql, conn))
				{
					cmd.Parameters.AddWithValue("@AnCdCliente", cliente.nCdCliente);
					cmd.Parameters.AddWithValue("@AcNmNome", cliente.cNmNome);
					cmd.Parameters.AddWithValue("@AdNascimento", cliente.dNascimento);
					cmd.Parameters.AddWithValue("@AcGenero ", cliente.cGenero);
					cmd.Parameters.AddWithValue("@AcEmail", cliente.cEmail);
					cmd.Parameters.AddWithValue("@AcTelefone", cliente.cTelefone);
					cmd.Parameters.AddWithValue("@AcCelular ", cliente.cCelular);
					cmd.Parameters.AddWithValue("@AcPessoa ", cliente.cPessoa);
					cmd.Parameters.AddWithValue("@AcCpf", cliente.cCpf);
					cmd.Parameters.AddWithValue("@AcRG", cliente.cRG);
					cmd.Parameters.AddWithValue("@AcOrgExp", cliente.cOrgExp);
					cmd.Parameters.AddWithValue("@AcUfExp ", cliente.cUfExp);
					cmd.Parameters.AddWithValue("@AcCep", cliente.cCep);
					cmd.Parameters.AddWithValue("@AcEndereco", cliente.cEndereco);
					cmd.Parameters.AddWithValue("@AcNumero", cliente.cNumero);
					cmd.Parameters.AddWithValue("@AcUF", cliente.cUFresid);
					cmd.Parameters.AddWithValue("@AcBairro", cliente.cBairro);
					cmd.Parameters.AddWithValue("@AcCidade", cliente.cCidade);
					cmd.Parameters.AddWithValue("@AcComplemento ", cliente.cComplemento);

					cmd.ExecuteNonQuery();
				}
			}
		}


		public void Delet(ClienteFunc cliente)
		{
			var delet = "delete from Cliente where nCdCliente = @nCdCliente";

			using (var conn = new SqlConnection(Conn.StrCon))
			{
				conn.Open();

				using (var cmd = new SqlCommand(delet, conn))
				{
					cmd.Parameters.AddWithValue("@nCdCliente", cliente.nCdCliente);

					cmd.ExecuteNonQuery();
				}
			}
		}

	}
}
