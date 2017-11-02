using System;
using System.Collections;
using System.Collections.Generic;

namespace SYD.Educacao.Primario.Domain.Model.Coordenacao
{
    public class TipoProva
    {
        #region Propriedades
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public ICollection<MarcacaoProva> Marcacoes { get; private set; }
        #endregion

        #region Construtores
        private TipoProva()
        {
        }

        public TipoProva(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
        }
        #endregion

        #region Metodos
        public void AdicionaMarcacao(MarcacaoProva marcacao)
        {
            Marcacoes.Add(marcacao);
        }

        public void RemoveMarcacao(MarcacaoProva marcacao)
        {
            Marcacoes.Remove(marcacao);
        }

        #endregion
    
    }
}