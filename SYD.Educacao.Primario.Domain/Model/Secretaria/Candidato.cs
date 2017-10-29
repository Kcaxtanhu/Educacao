using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Secretaria
{
    public class Candidato
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Genero Genero { get; set; }
        public DateTime DataNascimento { get; set; }
        public ICollection<Inscricao> Inscricoes { get; set; }

    }
}