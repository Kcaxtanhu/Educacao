using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model.Pedagogia;

namespace SYD.Educacao.Primario.Domain.Model.Coordenacao
{
    public class ProvaAluno
    {
        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public Guid ProvaDisciplinaId { get; set; }
        public ProvaDisciplina ProvaDisciplina { get; set; }
        public int Resultado { get; set; }
    }
}