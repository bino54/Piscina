using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piscina.Models
{
    internal class Avaliado : Aluno
    {
        public List<Categoria> Ficha;


        public Avaliado(int nif, string name, List<Categoria> ficha) : base(nif, name)
        {
            Ficha = ficha;
        }

        public Avaliado(Aluno a1, List<Categoria> ficha) : base(a1.Nif, a1.Name)
        {
            Ficha = ficha;


        }

        public Avaliado(Avaliado a1):base(a1.Nif,a1.Name)
        {
            Ficha = a1.Ficha;
        }

        //public List<Categoria> devolverCategorias()
        //{
        //    List<Categoria> lista = new List<Categoria>();

        //    foreach(Categoria c1 in Ficha.Categorias)
        //    {
        //        lista.Add(c1);
        //    }
        //    return lista;
        //}

        public Categoria devolverCategoria(Categoria cat1)
        {
            Categoria resultado = null;
            foreach(Categoria c1 in Ficha)
            {
                if(c1.Descricao.Equals(cat1.Descricao))
                {
                    resultado = c1;
                }
            }
            return resultado;
        }
    }
}
