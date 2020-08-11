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
        public virtual DbSet<Teams> Teams { get; set; }
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
                    .HasName("PK__Heroes__3336324352AE8090");

                entity.Property(e => e.HeroId).HasColumnName("HeroID");

                entity.Property(e => e.Alias).HasMaxLength(50);

                entity.Property(e => e.RealName).HasMaxLength(50);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.VillainTeamId).HasColumnName("VillainTeamID");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.HeroesTeam)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK__Heroes__TeamID__25869641");

                entity.HasOne(d => d.VillainTeam)
                    .WithMany(p => p.HeroesVillainTeam)
                    .HasForeignKey(d => d.VillainTeamId)
                    .HasConstraintName("FK__Heroes__VillainT__267ABA7A");
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.HasKey(e => e.TeamId)
                    .HasName("PK__Teams__123AE7B941D4F3E6");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.TeamName).HasMaxLength(50);
            });

            modelBuilder.Entity<Villains>(entity =>
            {
                entity.HasKey(e => e.VillainId)
                    .HasName("PK__Villains__28D2CDC73EF1E8B1");

                entity.Property(e => e.VillainId).HasColumnName("VillainID");

                entity.Property(e => e.Alias).HasMaxLength(50);

                entity.Property(e => e.HeroId).HasColumnName("HeroID");

                entity.Property(e => e.HeroTeamId).HasColumnName("HeroTeamID");

                entity.Property(e => e.RealName).HasMaxLength(50);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.HasOne(d => d.Hero)
                    .WithMany(p => p.Villains)
                    .HasForeignKey(d => d.HeroId)
                    .HasConstraintName("FK__Villains__HeroID__2B3F6F97");

                entity.HasOne(d => d.HeroTeam)
                    .WithMany(p => p.VillainsHeroTeam)
                    .HasForeignKey(d => d.HeroTeamId)
                    .HasConstraintName("FK__Villains__HeroTe__2A4B4B5E");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.VillainsTeam)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK__Villains__TeamID__29572725");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
