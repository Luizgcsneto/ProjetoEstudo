using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEstudo.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(fp => fp.Id);

            builder
                .Property(fp => fp.Nome)
                .IsRequired();


            builder
                .Property(fp => fp.Descricao)
                .IsRequired();
                
                
        }
    }
}
