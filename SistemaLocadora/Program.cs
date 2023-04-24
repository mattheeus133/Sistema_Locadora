using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLocadora
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 
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
        [STAThread]


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PagInicial());
        }
    }
}
