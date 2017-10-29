using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Pedagogia
{
    public class AlunoEncarregado
    {
        public Guid AlunId { get; set; }
        public Aluno Aluno { get; set; }
        public Guid EncarregadoId { get; set; }
        public Encarregado Encarregado { get; set; }
    }
}