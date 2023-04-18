using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piscina.Models
{
    public class Objetivo
    {
        public string Name { get; set; }
        public int ValorNota { get; set; }

        public Objetivo(string name, int valorNota)
        {
            Name = name;
            ValorNota = valorNota;
        }

        public Objetivo(string name)
        {
            Name = name;
            ValorNota = 0;
        }

        public override string ToString()
        {
            return String.Format("Objetivo:{0}, Valor da Nota:{1};", Name, ValorNota);
        }

    }
}
