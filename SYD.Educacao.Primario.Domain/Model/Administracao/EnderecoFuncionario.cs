using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Administracao
{
    public class EnderecoFuncionario
    {
        public Guid Id { get; set; }
        public Guid FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}