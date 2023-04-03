using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadora.Domain
{
    public class Filme
    {
        public int nCdDVD { get; set; }
        public string cNmNome { get; set; }
        public string cGenero { get; set; }
        public string cClassificacao { get; set; }
        public Int32 iQtd { get; set; }
        public string CaminhoFoto { get; set; }
        public string CaminhoSinopse { get; set; }
        public byte[] cFoto { get; set; }
        public string Sinopse { get; set; }
    }
}
