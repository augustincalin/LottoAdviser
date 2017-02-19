
using Microsoft.EntityFrameworkCore;

using LACore.Model;

namespace LAInfrastructure.Data
{
    public partial class LOTTODBContext : DbContext
    {
        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<Extraction> Extraction { get; set; }
        public virtual DbSet<Factor> Factor { get; set; }
        public virtual DbSet<Number> Number { get; set; }
        public LOTTODBContext(DbContextOptions<LOTTODBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.Property(e => e.KeyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Extraction>(entity =>
            {
                entity.Property(e => e.ExtractionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Factor>(entity =>
            {
                entity.Property(e => e.Factor1).HasColumnType("decimal");

                entity.Property(e => e.Factor2).HasColumnType("decimal");

                entity.HasOne(d => d.Extraction)
                    .WithMany(p => p.Factor)
                    .HasForeignKey(d => d.ExtractionId)
                    .HasConstraintName("FK_Factor_Extraction");
            });

            modelBuilder.Entity<Number>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Number1).HasColumnName("Number");
            });
        }
    }
}