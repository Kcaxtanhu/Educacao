using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model.Pedagogia;

namespace SYD.Educacao.Primario.Domain.Model.Coordenacao
{
    public class Prova
    {
        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public Guid MarcacaoId { get; set; }
        public MarcacaoProva Marcacao { get; set; }
        public int Resultado { get; set; }
    }
}