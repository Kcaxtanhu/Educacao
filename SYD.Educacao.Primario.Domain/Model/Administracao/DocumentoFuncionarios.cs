using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model;

namespace SYD.Educacao.Primario.Domain.Model.Administracao
{
    public class DocumentoFuncionario : Documento
    {
        public Guid Id { get; set; }
        public Guid FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}