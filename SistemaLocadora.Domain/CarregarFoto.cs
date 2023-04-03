using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLocadora.Domain
{
    public class CarregarFoto
    {
       
        public void PegarFoto()
        {
            string caminhoFoto;

            var openFile = new OpenFileDialog();

            openFile.Title = "Funcionario";
            openFile.Filter = "Arquivos de imagens jpg e png|*.jpg; *.png";
            openFile.InitialDirectory = @"C:\Users\User\Documents\Nuvem3\Projeto Locadora - Copia\FotosFunc";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
                caminhoFoto = openFile.FileName;

            
               

        }
    }
}
