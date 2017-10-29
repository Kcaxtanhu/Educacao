using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Coordenacao
{
    public class Prova
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ICollection<ProvaDisciplina> Disciplinas { get; set; }
    }
}