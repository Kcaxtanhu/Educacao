using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Pedagogia
{
    public class Turma
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid ClasseId { get; set; }
        public Classe Classe { get; set; }
        public Guid SalaId { get; set; }
        public Sala Sala { get; set; }
        public ICollection<AlunoTurma> Alunos { get; set; }
    }
}