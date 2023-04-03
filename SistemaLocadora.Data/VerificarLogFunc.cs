using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora.Data
{
    public class VerificarLogFunc
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            LoginFunc loginDalComandos = new LoginFunc();
            tem = loginDalComandos.VerificarLog(login, senha);
            if (!loginDalComandos.mensagem.Equals(""))
            {
                this.mensagem = loginDalComandos.mensagem;
                // metodo para saber se ouve algum erro no codigo
            }
            return tem;
        }

        public bool acessarCad(String login, String senha)
        {
            LoginFunc loginDalComandos = new LoginFunc();
            tem = loginDalComandos.VerificarLogRh(login, senha);
            
            
              if (!loginDalComandos.mensagem.Equals(""))
              {
                this.mensagem = loginDalComandos.mensagem;
                // metodo para saber se ouve algum erro no codigo
              }
            

            return tem;
        }
    }
}
