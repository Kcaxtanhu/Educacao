using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model
{
    public abstract class Contacto
    {
        public TipoContacto Tipo { get; set; }
        public string NContacto { get; set; }
    }
}