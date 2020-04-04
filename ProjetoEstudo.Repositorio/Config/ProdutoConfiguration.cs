﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(20)
                .HasColumnType("varchar");

            builder
               .Property(p => p.Descricao)
               .IsRequired()
               .HasMaxLength(200)
               .HasColumnType("varchar");

            builder
               .Property(p => p.Preco)
               .IsRequired();
        }
    }
}
