using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model
{
    public abstract class Endereco
    {
        public TipoEndereco Tipo { get; set; }
        public string NEndereco { get; set; }
    }
}