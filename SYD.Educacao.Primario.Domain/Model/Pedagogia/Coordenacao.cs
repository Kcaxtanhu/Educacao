using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model.Administracao;

namespace SYD.Educacao.Primario.Domain.Model.Pedagogia
{
    public class Coordenacao
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid FuncionarioFuncaoId { get; set; }
        public FuncionarioFuncao Coordenador { get; set; }
    }
}