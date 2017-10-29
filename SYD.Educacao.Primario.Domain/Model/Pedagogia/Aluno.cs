using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model.Secretaria;

namespace SYD.Educacao.Primario.Domain.Model.Pedagogia
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public ICollection<AlunoEncarregado> Encarregados { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
        public ICollection<DocumentoAluno> Documentos { get; set; }
        public ICollection<AlunoTurma> Turmas { get; set; }
    }
}