using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(pe => pe.Id);

            builder
              .Property(pe => pe.Cidade)
              .IsRequired();

            builder
                .Property(pe => pe.Estado)
                .IsRequired();

            builder
               .Property(pe => pe.DataPedido)
               .IsRequired();

            builder
               .Property(pe => pe.DataPrevisaoEntrega)
               .IsRequired();

            builder
               .Property(pe => pe.EnderecoCompleto)
               .IsRequired();

            builder
               .Property(pe => pe.CEP)
               .IsRequired();


            builder
              .Property(pe => pe.NumeroEndereco)
              .IsRequired();

            builder.HasOne(pe => pe.FormaPagamento);
        }
    }
}
