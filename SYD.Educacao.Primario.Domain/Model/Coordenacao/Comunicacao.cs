using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Coordenacao
{
    public class Comunicacao
    {
        public Guid Id { get; set; }
        public string Informacao { get; set; }
        public TipoComunicacao Tipo { get; set; }
        public Guid DiarioId { get; set; }
        public Diario Diario { get; set; }
        public DateTime DataRegisto { get; set; }
    }
}