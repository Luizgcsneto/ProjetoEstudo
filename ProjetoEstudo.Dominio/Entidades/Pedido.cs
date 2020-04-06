using ProjetoEstudo.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Dominio.Entidades
{
   public class Pedido : Entidade
    {
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public virtual FormaPagamento FormaPagamento { get; set; }

        public String Estado { get; set; }

        public String Cidade { get; set; }

        public String EnderecoCompleto { get; set; }

        public String CEP { get; set; }
      
        public int NumeroEndereco { get; set; }

        public override void Validate()
        {
           if(UsuarioId == 0)
            {
                AdicionarCritica("Faltando a identificação do usuário!");
            }

            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("O CEP não pode estar vazio");
            }
        }
    }
}
