using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Custom_API.Models
{
    public partial class ComicDBContext : DbContext
    {
        public ComicDBContext()
        {
        }

        public ComicDBContext(DbContextOptions<ComicDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Heroes> Heroes { get; set; }
        public virtual DbSet<Villains> Villains { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\mssqllocaldb;Initial Catalog = ComicDB;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Heroes>(entity =>
            {
                entity.HasKey(e => e.HeroId)
                    .HasName("PK__Heroes__3336324399CCC729");

                entity.Property(e => e.HeroId).HasColumnName("HeroID");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RealName).HasMaxLength(50);

                entity.Property(e => e.Team).HasMaxLength(50);

                entity.Property(e => e.VillainId).HasColumnName("VillainID");

                entity.HasOne(d => d.Villain)
                    .WithMany(p => p.Heroes)
                    .HasForeignKey(d => d.VillainId)
                    .HasConstraintName("FK__Heroes__VillainI__267ABA7A");
            });

            modelBuilder.Entity<Villains>(entity =>
            {
                entity.HasKey(e => e.VillainId)
                    .HasName("PK__Villains__28D2CDC73D76DFFB");

                entity.Property(e => e.VillainId).HasColumnName("VillainID");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HeroId).HasColumnName("HeroID");

                entity.Property(e => e.RealName).HasMaxLength(50);

                entity.Property(e => e.Team).HasMaxLength(50);

                entity.HasOne(d => d.Hero)
                    .WithMany(p => p.Villains)
                    .HasForeignKey(d => d.HeroId)
                    .HasConstraintName("FK__Villains__HeroID__25869641");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
