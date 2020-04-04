using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoEstudo.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<String> _mensagensValidacao { get; set; }

        private List<String> mensagemValidacao
        {

            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<String>()); }
        }

        protected void AdicionarCritica(String mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        public void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }
    }
}
