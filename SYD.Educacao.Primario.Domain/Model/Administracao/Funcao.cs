using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Administracao
{
    public class Funcao
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ICollection<FuncionarioFuncao> FuncionarioFuncao { get; set; }
    }
}