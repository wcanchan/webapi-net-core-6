using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClaseAcceso
{
    public partial class AcopioDbContext : DbContext
    {
        public AcopioDbContext()
        {
        }

        public AcopioDbContext(DbContextOptions<AcopioDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoDocumento)
                    .HasName("PK__TipoDocu__0CCCC78211FC73D6");

                entity.ToTable("TipoDocumento");

                entity.Property(e => e.CodigoTipoDocumento)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("codigoTipoDocumento")
                    .IsFixedLength();

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreCorto)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("nombreCorto");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.NroDocumento)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nroDocumento");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
