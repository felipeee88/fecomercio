using Fecomercio.Data.EntityConfig;
using Fecomercio.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fecomercio.Data.Context
{
    public class FecomercioContext : DbContext
    {
        public FecomercioContext(DbContextOptions<FecomercioContext> options) : base(options)
        {
        }

        public DbSet<Boleto> Boletos { get; set; }
        public DbSet<Cobranca> Cobrancas { get; set; }
        public DbSet<Comissao> Comissoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                entityType.GetForeignKeys()
                    .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                    .ToList()
                    .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);
            }
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BoletoConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CobrancaConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ComissaoConfig).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FecomercioContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
