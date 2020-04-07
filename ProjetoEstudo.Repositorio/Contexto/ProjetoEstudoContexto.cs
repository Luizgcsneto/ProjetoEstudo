using Microsoft.EntityFrameworkCore;
using ProjetoEstudo.Dominio.Entidades;
using ProjetoEstudo.Dominio.ObjetoDeValor;
using ProjetoEstudo.Repositorio.Config;
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

        public ProjetoEstudoContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());


            modelBuilder.Entity<FormaPagamento>().HasData(
                                                           new FormaPagamento()
                                                           {
                                                               Id = 1,
                                                               Nome = "Boleto",
                                                               Descricao = "Forma de pagamento por boleto"
                                                           },

                                                            new FormaPagamento()
                                                            {
                                                                Id = 2,
                                                                Nome = "Cartão de Crédito",
                                                                Descricao = "Forma de pagamento no cartão"
                                                            },

                                                            new FormaPagamento()
                                                            {
                                                                Id = 3,
                                                                Nome = "Depósito",
                                                                Descricao = "Forma de pagamento depósito"
                                                            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
