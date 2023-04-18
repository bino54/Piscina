using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piscina.Models
{
    internal class Modelo:Avaliado
    {
        public List<Categoria> Listas;


        public Modelo(Avaliado a1,List<Categoria> lista1) : base(a1)
        {
            Listas = lista1;
        }

    }
}
