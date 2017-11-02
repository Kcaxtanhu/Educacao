using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model;

namespace SYD.Educacao.Primario.Domain.Model.Administracao
{
    public class ContactoFuncionario : Contacto
    {
        #region Propriedades
        public Guid FuncionarioId { get; private set; }
        public Funcionario Funcionario { get; private set; }
        #endregion

        #region Construtores
        private ContactoFuncionario()
        {
        }

        public ContactoFuncionario(Funcionario funcionario, TipoContacto tipoContacto, string nContacto)
            :base(tipoContacto, nContacto)
        {
            Funcionario = funcionario;
        }
        #endregion
    }
}