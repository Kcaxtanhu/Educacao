using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model.Pedagogia;

namespace SYD.Educacao.Primario.Domain.Model.Coordenacao
{
    public class DisciplinaClasse
    {
        public Guid DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
        public Guid ClasseId { get; set; }
        public Classe Classe { get; set; }
    }
}