using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DycsysApi.Models
{
    public partial class GastAppDBContext : DbContext
    {
        public GastAppDBContext()
        {
        }

        public GastAppDBContext(DbContextOptions<GastAppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Gasto> Gastos { get; set; } = null!;
        public virtual DbSet<Ingreso> Ingresos { get; set; } = null!;
        public virtual DbSet<NombreGasto> NombreGastos { get; set; } = null!;
        public virtual DbSet<NombreIngreso> NombreIngresos { get; set; } = null!;
        public virtual DbSet<TablaTemporal> TablaTemporals { get; set; } = null!;
        public virtual DbSet<TipoGasto> TipoGastos { get; set; } = null!;
        public virtual DbSet<TipoIngreso> TipoIngresos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.Property(e => e.Detalle).HasDefaultValueSql("(N'')");

                entity.Property(e => e.Pagado).HasColumnName("pagado");

                entity.Property(e => e.UsuarioId).HasMaxLength(450);
            });

            modelBuilder.Entity<Ingreso>(entity =>
            {
                entity.Property(e => e.Detalle).HasColumnName("detalle");

                entity.Property(e => e.UsuarioId).HasMaxLength(450);
            });

            modelBuilder.Entity<NombreGasto>(entity =>
            {
                entity.Property(e => e.Icono).HasDefaultValueSql("(N'')");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<NombreIngreso>(entity =>
            {
                entity.Property(e => e.Icono).HasDefaultValueSql("(N'')");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<TablaTemporal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tabla_temporal");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<TipoGasto>(entity =>
            {
                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoIngreso>(entity =>
            {
                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("('')");

                entity.Property(e => e.NombreUsuario).HasColumnName("Nombre_Usuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
