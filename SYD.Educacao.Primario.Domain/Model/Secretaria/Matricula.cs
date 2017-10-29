using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model.Pedagogia;

namespace SYD.Educacao.Primario.Domain.Model.Secretaria
{
    public class Matricula
    {
        public Guid Id { get; set; }
        public string NumeroMatricula { get; set; }
        public DateTime DataMatricula { get; set; }
        public Guid InscricaoId { get; set; }
        public Inscricao Inscricao { get; set; }
        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int AnoLectivo { get; set; }
    }
}