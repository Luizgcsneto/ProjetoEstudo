using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Descricao { get; set; }

        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (Preco == 0)
            {
                AdicionarCritica("É preciso informar um valor.");
            }

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarCritica("Precisa informar o nome do produto.");
            }
        }
    }
}
