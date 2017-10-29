using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model.Coordenacao;

namespace SYD.Educacao.Primario.Domain.Model.Pedagogia
{
    public class Classe
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Turma> Turmas { get; set; }
        public ICollection<DisciplinaClasse> Disciplinas { get; set; }
        public Guid CoordenacaoId { get; set; }
        public Coordenacao Coordenacao { get; set; }
    }
}
