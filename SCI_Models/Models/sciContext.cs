using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SCI_Models.Models
{
    public partial class sciContext : DbContext
    {
        public sciContext()
        {
        }

        public sciContext(DbContextOptions<sciContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Evento> Eventos { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Ingresso> Ingressos { get; set; }
        public virtual DbSet<Local> Locals { get; set; }
        public virtual DbSet<Pagamentoboleto> Pagamentoboletos { get; set; }
        public virtual DbSet<Pagamentocartao> Pagamentocartaos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=sci;Username=postgres;Password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.Codcategoria)
                    .HasName("categoria_pkey");

                entity.ToTable("categoria");

                entity.Property(e => e.Codcategoria)
                    .HasColumnName("codcategoria")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nome");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Codcliente)
                    .HasName("cliente_pkey");

                entity.ToTable("cliente");

                entity.Property(e => e.Codcliente)
                    .HasColumnName("codcliente")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("cpf");

                entity.Property(e => e.Datanascimento)
                    .HasColumnType("date")
                    .HasColumnName("datanascimento");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nome");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("senha");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(11)
                    .HasColumnName("telefone");
            });

            modelBuilder.Entity<Evento>(entity =>
            {
                entity.HasKey(e => e.Codevento)
                    .HasName("evento_pkey");

                entity.ToTable("evento");

                entity.Property(e => e.Codevento)
                    .HasColumnName("codevento")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Artista)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("artista");

                entity.Property(e => e.Codcategoria).HasColumnName("codcategoria");

                entity.Property(e => e.Codlocal).HasColumnName("codlocal");

                entity.Property(e => e.Data)
                    .HasColumnType("date")
                    .HasColumnName("data");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(500)
                    .HasColumnName("descricao");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nome");

                entity.Property(e => e.Numeroingressos).HasColumnName("numeroingressos");

                entity.Property(e => e.Valoringresso).HasColumnName("valoringresso");

                entity.HasOne(d => d.CodcategoriaNavigation)
                    .WithMany(p => p.Eventos)
                    .HasForeignKey(d => d.Codcategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("evento_codcategoria_fkey");

                entity.HasOne(d => d.CodlocalNavigation)
                    .WithMany(p => p.Eventos)
                    .HasForeignKey(d => d.Codlocal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("evento_codlocal_fkey");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.Codfuncionario)
                    .HasName("funcionario_pkey");

                entity.ToTable("funcionario");

                entity.Property(e => e.Codfuncionario)
                    .HasColumnName("codfuncionario")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Admin)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasColumnName("admin");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("cpf");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("nome");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("senha");
            });

            modelBuilder.Entity<Ingresso>(entity =>
            {
                entity.HasKey(e => e.Codingresso)
                    .HasName("ingresso_pkey");

                entity.ToTable("ingresso");

                entity.Property(e => e.Codingresso)
                    .HasColumnName("codingresso")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Codcliente).HasColumnName("codcliente");

                entity.Property(e => e.Codevento).HasColumnName("codevento");

                entity.Property(e => e.Valorinteiro)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasColumnName("valorinteiro");

                entity.HasOne(d => d.CodclienteNavigation)
                    .WithMany(p => p.Ingressos)
                    .HasForeignKey(d => d.Codcliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ingresso_codcliente_fkey");

                entity.HasOne(d => d.CodeventoNavigation)
                    .WithMany(p => p.Ingressos)
                    .HasForeignKey(d => d.Codevento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ingresso_codevento_fkey");
            });

            modelBuilder.Entity<Local>(entity =>
            {
                entity.HasKey(e => e.Codlocal)
                    .HasName("local_pkey");

                entity.ToTable("local");

                entity.Property(e => e.Codlocal)
                    .HasColumnName("codlocal")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cidade");

                entity.Property(e => e.Endereco)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("endereco");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("estado");
            });

            modelBuilder.Entity<Pagamentoboleto>(entity =>
            {
                entity.HasKey(e => e.Codpagamento)
                    .HasName("pagamentoboleto_pkey");

                entity.ToTable("pagamentoboleto");

                entity.Property(e => e.Codpagamento)
                    .HasColumnName("codpagamento")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Codingresso).HasColumnName("codingresso");

                entity.Property(e => e.Datavencimento)
                    .HasColumnType("date")
                    .HasColumnName("datavencimento");

                entity.Property(e => e.Numeroboleto)
                    .IsRequired()
                    .HasMaxLength(44)
                    .HasColumnName("numeroboleto");

                entity.Property(e => e.Valorapagar).HasColumnName("valorapagar");

                entity.HasOne(d => d.CodingressoNavigation)
                    .WithMany(p => p.Pagamentoboletos)
                    .HasForeignKey(d => d.Codingresso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pagamentoboleto_codingresso_fkey");
            });

            modelBuilder.Entity<Pagamentocartao>(entity =>
            {
                entity.HasKey(e => e.Codpagamento)
                    .HasName("pagamentocartao_pkey");

                entity.ToTable("pagamentocartao");

                entity.Property(e => e.Codpagamento)
                    .HasColumnName("codpagamento")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Codingresso).HasColumnName("codingresso");

                entity.Property(e => e.Codseguranca)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("codseguranca");

                entity.Property(e => e.Datavalidade)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("datavalidade");

                entity.Property(e => e.Nometitular)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("nometitular");

                entity.Property(e => e.Numerocartao)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("numerocartao");

                entity.Property(e => e.Transacaoaprovada)
                    .IsRequired()
                    .HasColumnType("bit(1)")
                    .HasColumnName("transacaoaprovada");

                entity.Property(e => e.Valorapagar).HasColumnName("valorapagar");

                entity.HasOne(d => d.CodingressoNavigation)
                    .WithMany(p => p.Pagamentocartaos)
                    .HasForeignKey(d => d.Codingresso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pagamentocartao_codingresso_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
