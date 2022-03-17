using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BrayanRojasRojas_Parcial1_Progra6_2022_1APIRest.Models
{
    public partial class P6Assets20221Context : DbContext
    {
        public P6Assets20221Context()
        {
        }

        public P6Assets20221Context(DbContextOptions<P6Assets20221Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Activo> Activos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("SERVER = DESKTOP-L5BN9MV;DATABASE= P6Assets20221;User Id =AnswersUser;Password = 123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Activo>(entity =>
            {
                entity.HasKey(e => e.Idactivo)
                    .HasName("PK__Activo__4D2680440C3F3DC4");

                entity.ToTable("Activo");

                entity.Property(e => e.Idactivo).HasColumnName("IDActivo");

                entity.Property(e => e.CostoActivo).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoActivo)
                    .IsRequired()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NombreActivo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSerie)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
