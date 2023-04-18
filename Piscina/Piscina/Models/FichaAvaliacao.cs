using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piscina.Models
{
    internal class FichaAvaliacao
    {
        public List<Categoria> Categorias;


        public FichaAvaliacao(List<Categoria> categorias)
        {
            this.Categorias = categorias;
        }


        public override string ToString()
        {
            string combinedString = string.Join("\n", Categorias);
            return String.Format("Categorias:{0}", combinedString);
        }


    }
}
