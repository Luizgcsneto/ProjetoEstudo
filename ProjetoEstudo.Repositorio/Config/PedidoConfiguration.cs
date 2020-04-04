﻿using Microsoft.EntityFrameworkCore;
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
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("varchar");

            builder
                .Property(pe => pe.Estado)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("varchar");

            builder
               .Property(pe => pe.DataPedido)
               .IsRequired();

            builder
               .Property(pe => pe.DataPrevisaoEntrega)
               .IsRequired();

            builder
               .Property(pe => pe.EnderecoCompleto)
               .IsRequired()
               .HasMaxLength(100)
               .HasColumnType("varchar");

            builder
               .Property(pe => pe.CEP)
               .IsRequired()
               .HasMaxLength(10);
            

            builder
              .Property(pe => pe.NumeroEndereco)
              .IsRequired();
        }
    }
}
