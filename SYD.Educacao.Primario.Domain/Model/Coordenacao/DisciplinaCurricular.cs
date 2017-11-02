using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Coordenacao
{
    public class DisciplinaCurricular : Disciplina
    {
        #region Construtores
        private DisciplinaCurricular()
            :base()
        {
        }

        public DisciplinaCurricular(string nome)
            :base(nome)
        {
        }
        #endregion
    }
}