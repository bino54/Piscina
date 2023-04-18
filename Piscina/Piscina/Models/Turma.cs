using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piscina.Models
{
    internal class Turma
    {
        public string Name { get; set; }
        public DateTime DiadaInscricao { get; set; }
        public List<Avaliado> Alunos { get; set; }
        public FichaAvaliacao Ficha { get; set; }


        public Turma(string name)
        {
            this.Name = name;
            this.DiadaInscricao= DateTime.Now;
        }

        public Turma(string name, List<Avaliado> a1)
        {
            this.Name = name;
            this.Alunos = a1;
            this.DiadaInscricao = DateTime.Now;
        }
        public Turma(string name, DateTime diadaInscricao)
        {
            this.Name = name;
            this.DiadaInscricao = diadaInscricao;
        }


        public Turma(string name, DateTime diadaInscricao, List<Avaliado> alunos, FichaAvaliacao ficha)
        {
            this.Name = name;
            this.DiadaInscricao = diadaInscricao;
            this.Alunos = alunos;
            this.Ficha = ficha;
        }

        public Turma(string name, List<Avaliado> alunos, FichaAvaliacao ficha)
        {
            this.Name = name;
            this.DiadaInscricao = DateTime.Now;
            this.Alunos = alunos;
            this.Ficha = ficha;
        }


        public override string ToString()
        {
            string combinedString = string.Join(",", Alunos);
            return String.Format("Name:{0}, Alunos: [{1} ]", Name, combinedString);
        }


    }
}
