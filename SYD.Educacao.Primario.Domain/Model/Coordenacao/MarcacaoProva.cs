using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Coordenacao
{
    public class MarcacaoProva
    {
        public Guid ProvaId { get; private set; }
        public TipoProva Prova { get; private set; }
        public Guid DisciplinaId { get; private set; }
        public Disciplina Disciplina { get; private set; }
        public DateTime DataProva { get; private set; }
    }
}