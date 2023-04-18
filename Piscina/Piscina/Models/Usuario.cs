using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piscina.Models
{
    internal class Usuario
    {
        public int Nif { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public List<Turma> Turmas { get; set; }


        public Usuario(int nif, string password, string name)
        {
            this.Nif = nif;
            this.Password = password;
            this.Name = name;
        }

        public Usuario(int nif, string password, string name, List<Turma> turmas)
        {
            this.Turmas = turmas;
            this.Nif = nif;
            this.Password = password;
            this.Name = name;
        }
    }

}
