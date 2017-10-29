using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Pedagogia
{
    public class Sala
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Turma> Turmas { get; set; }
    }
}