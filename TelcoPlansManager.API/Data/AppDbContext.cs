using Microsoft.EntityFrameworkCore;
using TelcoPlansManager.API.Entities;

namespace TelcoPlansManager.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Contrato> Contratos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração do Plano
            modelBuilder.Entity<Plano>()
                .Property(p => p.ValorMensal)
                .HasPrecision(10, 2);

            // Configuração do Contrato
            modelBuilder.Entity<Contrato>()
                .HasOne(c => c.Cliente)
                .WithMany()
                .HasForeignKey(c => c.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Contrato>()
                .HasOne(c => c.Plano)
                .WithMany()
                .HasForeignKey(c => c.PlanoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
} 