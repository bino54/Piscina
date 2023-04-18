using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piscina.Models
{
    class Sistema
    {
        public List<Usuario> Usuarios { get; set; }

        public Sistema() {
            Usuarios = new List<Usuario> { };
        }

        public Sistema(List<Usuario> usuarios)
        {
            Usuarios = usuarios;
        }   
    }
}
