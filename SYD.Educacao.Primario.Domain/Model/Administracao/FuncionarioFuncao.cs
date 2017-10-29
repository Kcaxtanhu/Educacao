using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Administracao
{
    public class FuncionarioFuncao
    {
        public Guid FuncionarioId { get; set; }
        public Guid FuncaoId { get; set; }
        public Funcionario Funcionario { get; set; }
        public Funcao Funcao { get; set; }
        public DateTime DataRegisto { get; set; }
    }
}