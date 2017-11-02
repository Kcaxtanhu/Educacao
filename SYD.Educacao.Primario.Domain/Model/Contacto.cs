using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model
{
    public abstract class Contacto
    {
        #region Propriedades
        protected Guid Id { get; private set; }
        protected TipoContacto Tipo { get; private set; }
        protected string NContacto { get; private set; }
        #endregion

        #region Construtores
        public Contacto()
        {
        }

        public Contacto(TipoContacto tipoContacto, string nContacto)
            :this()
        {
            Id = Guid.NewGuid();
            Tipo = tipoContacto;
            NContacto = nContacto;
        }
        #endregion
    }
}