using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model;

namespace SYD.Educacao.Primario.Domain.Model.Pedagogia
{
    public class DocumentoEncarregado : Documento
    {
        public Guid Id { get; set; }
        public Guid EncarregadoId { get; set; }
        public Encarregado Encarregado { get; set; }
    }
}