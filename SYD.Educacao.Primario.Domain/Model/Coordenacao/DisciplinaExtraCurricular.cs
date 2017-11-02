using System;
using System.Collections;
using System.Collections.Generic;
using SYD.Educacao.Primario.Domain.Model.Administracao;

namespace SYD.Educacao.Primario.Domain.Model.Coordenacao
{
    public class DisciplinaExtraCurricular : Disciplina
    {
        #region Propriedades Proprias
        public ICollection<Funcionario> Professores { get; private set; }
        #endregion

        #region Construtores
        private DisciplinaExtraCurricular()
            :base()
        {
            Professores = new HashSet<Funcionario>();
        }

        public DisciplinaExtraCurricular(string nome)
            :base(nome)
        {
        }
        #endregion

        #region Metodos
        public void AdicionaProfessor(Funcionario professor)
        {
            Professores.Add(professor);
        }

        public void RemoveProfessor(Funcionario professor)
        {
            Professores.Remove(professor);
        }
        #endregion
    }
}