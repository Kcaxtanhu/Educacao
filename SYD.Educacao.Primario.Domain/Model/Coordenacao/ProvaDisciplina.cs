using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Coordenacao
{
    public class ProvaDisciplina
    {
        public Guid ProvaId { get; set; }
        public Prova Prova { get; set; }
        public Guid DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
        public DateTime DataProva { get; set; }
    }
}