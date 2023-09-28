using Fecomercio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fecomercio.Data.EntityConfig
{
    public class BoletoConfig : IEntityTypeConfiguration<Boleto>
    {
        public void Configure(EntityTypeBuilder<Boleto> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                .IsRequired();

            builder.Property(b => b.Cedente)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(b => b.Numero)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(b => b.Vencimento)
               .IsRequired();

            builder.Property(b => b.Valor)
               .IsRequired();

            builder.Property(b => b.Documento)
               .HasMaxLength(14)
               .IsRequired();

            builder.Property(b => b.Sacado)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(b => b.NossoNumero)
               .HasMaxLength(100)
               .IsRequired();

            builder.Property(b => b.Agencia)
              .HasMaxLength(10)
              .IsRequired();

            builder.Property(b => b.Conta)
              .HasMaxLength(15)
              .IsRequired();

            builder.Property(b => b.CodigoDeBarras)
              .HasMaxLength(150)
              .IsRequired();

            builder.Property(b => b.LinhaDigitavel)
              .HasMaxLength(200)
              .IsRequired();
        }
    }
}