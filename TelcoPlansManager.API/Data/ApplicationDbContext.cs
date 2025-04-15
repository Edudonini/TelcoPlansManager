using Microsoft.EntityFrameworkCore;
using TelcoPlansManager.API.Entities;

namespace TelcoPlansManager.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Plan> Plans { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração do Plan
            modelBuilder.Entity<Plan>()
                .HasMany(p => p.Customers)
                .WithOne(c => c.Plan)
                .HasForeignKey(c => c.PlanId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Plan>()
                .HasMany(p => p.Subscriptions)
                .WithOne(s => s.Plan)
                .HasForeignKey(s => s.PlanId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Plan>()
                .Property(p => p.Price)
                .HasPrecision(10, 2);

            // Configuração do Customer
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Subscriptions)
                .WithOne(s => s.Customer)
                .HasForeignKey(s => s.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuração do Subscription
            modelBuilder.Entity<Subscription>()
                .Property(s => s.StartDate)
                .IsRequired();

            modelBuilder.Entity<Subscription>()
                .Property(s => s.IsActive)
                .IsRequired();
        }
    }
} 