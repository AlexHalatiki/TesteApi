using Microsoft.EntityFrameworkCore;
using TesteApi.Entities;

namespace TesteApi.Repository.Context
{
    public class ApliccationDbContext : DbContext
    {
        public virtual DbSet<CredorC> CredorC { get; set; }
        public virtual DbSet<IndicadorB> IndicadorB { get; set; }
        public virtual DbSet<Ocorrencia05> Ocorrencia05 { get; set; }

        public ApliccationDbContext(DbContextOptions<ApliccationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("LogYamaha"));
        }*/
    }
}
