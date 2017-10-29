using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model;

namespace SYD.Educacao.Primario.Domain.Model.Pedagogia
{
    public class DocumentoAluno : Documento
    {
        public Guid Id { get; set; }
        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }
    }
}