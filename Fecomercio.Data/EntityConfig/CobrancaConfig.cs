using Fecomercio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fecomercio.Data.EntityConfig
{
    public class CobrancaConfig : IEntityTypeConfiguration<Cobranca>
    {
        public void Configure(EntityTypeBuilder<Cobranca> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                .IsRequired();

            builder.Property(b => b.DataDeEmissao)
                .IsRequired();

            builder.Property(b => b.DataDeVencimento)
                .IsRequired();

            builder.Property(b => b.Valor)
                .IsRequired();

            builder.Property(b => b.Emitente)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(b => b.Pagador)
               .HasMaxLength(100)
               .IsRequired();
        }
    }
}