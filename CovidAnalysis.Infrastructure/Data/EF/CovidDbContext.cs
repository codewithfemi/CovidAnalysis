using CovidAnalysis.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CovidAnalysis.Infrastructure.Data.EF
{
    public partial class CovidDbContext : DbContext
    {
        public CovidDbContext(DbContextOptions<CovidDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CovidStatistic> CovidStatistics { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CovidStatistic>(entity =>
            {
                entity.ToTable("CovidStatistic");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveCases).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.DeathsPer1Mpopulation).HasColumnName("DeathsPer1MPopulation");

                entity.Property(e => e.NewCases).HasMaxLength(50);

                entity.Property(e => e.NewDeaths).HasMaxLength(50);

                entity.Property(e => e.NewRecovered).HasMaxLength(50);

                entity.Property(e => e.Population).HasMaxLength(50);

                entity.Property(e => e.SeriousCritical).HasMaxLength(50);

                entity.Property(e => e.TestsPer1Mpopulation)
                    .HasMaxLength(50)
                    .HasColumnName("TestsPer1MPopulation");

                entity.Property(e => e.TotalCases).HasMaxLength(50);

                entity.Property(e => e.TotalCasesPer1Mpopulation).HasColumnName("TotalCasesPer1MPopulation");

                entity.Property(e => e.TotalDeaths).HasMaxLength(50);

                entity.Property(e => e.TotalRecovered).HasMaxLength(50);

                entity.Property(e => e.TotalTests).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
