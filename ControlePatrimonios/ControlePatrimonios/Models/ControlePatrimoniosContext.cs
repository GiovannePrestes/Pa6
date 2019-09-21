using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ControlePatrimonios.Models
{
    public partial class ControlePatrimoniosContext : DbContext
    {
        public ControlePatrimoniosContext()
        {
        }

        public ControlePatrimoniosContext(DbContextOptions<ControlePatrimoniosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbBloco> TbBloco { get; set; }
        public virtual DbSet<TbEncerramento> TbEncerramento { get; set; }
        public virtual DbSet<TbEstado> TbEstado { get; set; }
        public virtual DbSet<TbItem> TbItem { get; set; }
        public virtual DbSet<TbSetor> TbSetor { get; set; }
        public virtual DbSet<TbTipo> TbTipo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:controledepatrimonios.database.windows.net,1433;Initial Catalog=ControlePatrimonios;Persist Security Info=False;User ID=adm;Password=P@trimonio;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbBloco>(entity =>
            {
                entity.HasKey(e => e.IdBloco);

                entity.ToTable("tb_Bloco");

                entity.Property(e => e.IdBloco).HasColumnName("idBloco");

                entity.Property(e => e.NomeBloco)
                    .IsRequired()
                    .HasColumnName("nomeBloco")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbEncerramento>(entity =>
            {
                entity.HasKey(e => e.IdEncerramento);

                entity.ToTable("tb_Encerramento");

                entity.Property(e => e.IdEncerramento).HasColumnName("idEncerramento");

                entity.Property(e => e.DataEncerramento)
                    .HasColumnName("dataEncerramento")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdItem).HasColumnName("idItem");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasColumnName("motivo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdItemNavigation)
                    .WithMany(p => p.TbEncerramento)
                    .HasForeignKey(d => d.IdItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tb_Encerr__idIte__571DF1D5");
            });

            modelBuilder.Entity<TbEstado>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.ToTable("tb_Estado");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.DescricaoEstado)
                    .IsRequired()
                    .HasColumnName("descricaoEstado")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbItem>(entity =>
            {
                entity.HasKey(e => e.IdItem);

                entity.ToTable("tb_Item");

                entity.Property(e => e.IdItem).HasColumnName("idItem");

                entity.Property(e => e.DataCriacao)
                    .HasColumnName("dataCriacao")
                    .HasColumnType("datetime");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnName("descricao")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdSetor).HasColumnName("idSetor");

                entity.Property(e => e.IdTipo).HasColumnName("idTipo");

                entity.Property(e => e.Patrimonio)
                    .HasColumnName("patrimonio")
                    .HasColumnType("decimal(7, 0)");

                entity.Property(e => e.ServiceTag)
                    .IsRequired()
                    .HasColumnName("serviceTag")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TbItem)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tb_Item__idEstad__5535A963");

                entity.HasOne(d => d.IdSetorNavigation)
                    .WithMany(p => p.TbItem)
                    .HasForeignKey(d => d.IdSetor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tb_Item__idSetor__5629CD9C");

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.TbItem)
                    .HasForeignKey(d => d.IdTipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tb_Item__idTipo__5441852A");
            });

            modelBuilder.Entity<TbSetor>(entity =>
            {
                entity.HasKey(e => e.IdSetor);

                entity.ToTable("tb_Setor");

                entity.Property(e => e.IdSetor).HasColumnName("idSetor");

                entity.Property(e => e.IdBloco).HasColumnName("idBloco");

                entity.Property(e => e.NomeSetor)
                    .IsRequired()
                    .HasColumnName("nomeSetor")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBlocoNavigation)
                    .WithMany(p => p.TbSetor)
                    .HasForeignKey(d => d.IdBloco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tb_Setor__idBloc__534D60F1");
            });

            modelBuilder.Entity<TbTipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo);

                entity.ToTable("tb_Tipo");

                entity.Property(e => e.IdTipo).HasColumnName("idTipo");

                entity.Property(e => e.DescricaoTipo)
                    .IsRequired()
                    .HasColumnName("descricaoTipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
