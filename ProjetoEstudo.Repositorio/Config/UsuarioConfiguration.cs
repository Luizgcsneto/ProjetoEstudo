using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.Email)
                .IsRequired();


            builder
                .Property(u => u.Nome)
                .IsRequired();


            builder
               .Property(u => u.SobreNome)
               .IsRequired();


            builder
               .Property(u => u.Senha)
               .IsRequired();
              

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
