using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Administracao
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public ICollection<Contacto> Contactos { get; set; }
        public ICollection<Endereco> Enderecos { get; set; }
        public ICollection<FuncionarioFuncao> Funcoes { get; set; }
        public ICollection<DocumentoFuncionario> Documentos { get; set; }
    }
}