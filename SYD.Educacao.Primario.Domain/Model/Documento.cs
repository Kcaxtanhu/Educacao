using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model
{
    public class Documento
    {
        public TipoDocumento Tipo { get; set; }
        public TipoDado Extensao { get; set; }
        public string NomeFicheiro { get; set; }
        public byte[] Binario { get; set; }
    }
}