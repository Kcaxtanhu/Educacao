using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model.Pedagogia;

namespace SYD.Educacao.Primario.Domain.Model.Secretaria
{
    public class Inscricao
    {
        public Guid Id { get; set; }
        public string NumeroInscricao { get; set; }
        public Guid CandidatoId { get; set; }
        public Candidato Candidato { get; set; }
        public Guid ClasseId { get; set; }
        public Classe Classe { get; set; }
        public DateTime DataInscricao { get; set; }
        public ICollection<Matricula> Matricula { get; set; }
    }
}