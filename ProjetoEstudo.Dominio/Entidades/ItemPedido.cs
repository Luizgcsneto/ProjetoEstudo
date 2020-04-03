using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Dominio.Entidades
{
   public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
            {
                AdicionarCritica("Não foi identificado a referência do produto.");
            }

            if (Quantidade == 0)
            {
                AdicionarCritica("Não foi informado a quantidade de produtos.");
            }
        }
    }
}
