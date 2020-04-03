using Microsoft.EntityFrameworkCore;
using ProjetoEstudo.Dominio.Entidades;
using ProjetoEstudo.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Repositorio.Contexto
{
   public class ProjetoEstudoContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<ItemPedido> ItensPedidos { get; set; }

        public DbSet<FormaPagamento> FormaPagamento { get; set; }
    }
}
