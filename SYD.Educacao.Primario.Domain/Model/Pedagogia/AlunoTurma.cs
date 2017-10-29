using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model.Secretaria;

namespace SYD.Educacao.Primario.Domain.Model.Pedagogia
{
    public class AlunoTurma
    {
        public Guid AlunoId { get; set; }
        public Guid TurmaId { get; set; }
        public Aluno Aluno { get; set; }
        public Turma Turma { get; set; }
        public DateTime DataRegisto { get; set; }
        public int Ano { get; set; }
    }
}