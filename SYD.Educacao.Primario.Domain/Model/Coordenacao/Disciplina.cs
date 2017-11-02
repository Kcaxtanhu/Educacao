using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Coordenacao
{
    public abstract class Disciplina
    {
        #region Propriedades
        protected Guid Id { get; private set; }
        protected string Nome { get; private set; }
        protected ICollection<DisciplinaClasse> Classes { get; private set; }
        #endregion

        #region Construtores
        protected Disciplina()
        {
            Classes = new HashSet<DisciplinaClasse>();
        }

        public Disciplina(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }
        #endregion

        #region Metodos
        protected void AdicionaClasse(DisciplinaClasse dc)
        {
            Classes.Add(dc);
        }

        protected void RemoveClasse(DisciplinaClasse dc)
        {
            Classes.Remove(dc);
        }
        #endregion
    }
}