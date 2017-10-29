using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model;

namespace SYD.Educacao.Primario.Domain.Model.Pedagogia
{
    public class Encarregado
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid TituloId { get; set; }
        public Titulo Tritulo { get; set; }
        public DateTime DataNascimento { get; set; }
        public Genero Genero { get; set; }
        public TipoParentesco Parentesco { get; set; }
        public ICollection<ContactoEncarregado> Contactos { get; set; }
        public ICollection<EnderecoEncarregado> Enderecos { get; set; }
        public ICollection<AlunoEncarregado> Alunos { get; set; }
        public ICollection<DocumentoEncarregado> Documentos { get; set; }
    }
}