using Fecomercio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fecomercio.Data.EntityConfig
{
    public class ComissaoConfig : IEntityTypeConfiguration<Comissao>
    {
        public void Configure(EntityTypeBuilder<Comissao> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                .IsRequired();

            builder.Property(b => b.NomeVendedor)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(b => b.DataDaVenda)
                .IsRequired();

            builder.Property(b => b.ValorDaVenda)
                .IsRequired();

            builder.Property(b => b.PercentualDeComissao)
               .IsRequired();

            builder.Property(b => b.ValorDaComissao)
               .IsRequired();
        }
    }
}