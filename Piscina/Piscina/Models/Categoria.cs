using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piscina.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Objetivo> Objetivos;

        public Categoria(string descricao, List<Objetivo> objetivos)
        {
            Descricao = descricao;
            Objetivos = objetivos;
        }

        public override string ToString()
        {
            string combinedString = string.Join(", ", Objetivos);
            return String.Format("Descrição:{0}, Objetivos:[{1}],\n", Descricao, combinedString);
        }

    }
}
