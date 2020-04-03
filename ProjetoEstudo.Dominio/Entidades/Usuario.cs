using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("E-mail não informado");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Senha não informado");
            }
        }
    }
}
