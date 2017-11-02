using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model;

namespace SYD.Educacao.Primario.Domain.Model.Pedagogia
{
    public class ContactoEncarregado : Contacto
    {
        #region Propriedades
        public Guid EncarregadoId { get; set; }
        public Encarregado Encarregado { get; set; }
        #endregion

        #region Construtores
        private ContactoEncarregado(Encarregado encarregado, TipoContacto tipoContacto, string nConctacto)
            :base(tipoContacto, nConctacto)
        {
            Encarregado = encarregado;
        }
        #endregion
    }
}