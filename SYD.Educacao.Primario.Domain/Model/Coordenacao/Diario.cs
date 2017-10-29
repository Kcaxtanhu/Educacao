using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model.Pedagogia;

namespace SYD.Educacao.Primario.Domain.Model.Coordenacao
{
    public class Diario
    {
        public Guid Id { get; set; }
        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public ICollection<Comunicacao> Comunicacoes { get; set; }
    }
}