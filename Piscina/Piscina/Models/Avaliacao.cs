using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piscina.Models
{
    internal class Avaliacao
    {
        public List<Avaliado> Alunos;
        public Turma Turma;
        public FichaAvaliacao Fichaavaliacao;

        public Avaliacao(List<Avaliado> alunos, Turma turma, FichaAvaliacao ficha)
        {
            this.Alunos = alunos;
            this.Turma = turma;
            this.Fichaavaliacao = ficha;
        }
    }
}
