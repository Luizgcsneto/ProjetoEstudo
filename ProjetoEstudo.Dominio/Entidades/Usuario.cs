using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String SobreNome { get; set; }

        public String Email { get; set; }

        public String Senha { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

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
