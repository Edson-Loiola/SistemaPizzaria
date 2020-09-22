using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SistemaWebPizzaria.Models;

namespace SistemaWebPizzaria.Data
{
    public partial class BancoPizzariaContext : DbContext
    {
        public BancoPizzariaContext()
        {
        }

        public BancoPizzariaContext(DbContextOptions<BancoPizzariaContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Cardapiopizza> Cardapiopizza { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Despesa> Despesa { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Funcionario> Funcionario { get; set; }
        public virtual DbSet<Itemcardapio> Itemcardapio { get; set; }
        public virtual DbSet<Itemproduto> Itemproduto { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Produtoestoque> Produtoestoque { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;user=jose;password=458236;database=bancopizzaria");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cardapiopizza>(entity =>
            {
                entity.HasKey(e => e.IdCardapio);

                entity.ToTable("cardapiopizza");

                entity.Property(e => e.IdCardapio).HasColumnType("int(11)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Sabor)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Tamanho).HasColumnType("varchar(10)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("cliente");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("IdCliente_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Nome).HasColumnType("varchar(45)");

                entity.Property(e => e.Telefone).HasColumnType("varchar(45)");

                //entity.HasOne(d => d.TbEnderecoIdEnderecoNavigation)
                //    .WithMany(p => p.Cliente)
                //    .HasForeignKey(d => d.TbEnderecoIdEndereco)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("fk_tbCliente_tbEndereco1");
            });

            modelBuilder.Entity<Despesa>(entity =>
            {
                entity.HasKey(e => e.IdDespesa);

                entity.ToTable("despesa");

                entity.Property(e => e.IdDespesa).HasColumnType("int(11)");

                entity.Property(e => e.DataDespesa).HasColumnType("date");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.NomeDespesa)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Valor).HasColumnType("decimal(10,2)");
            });

            modelBuilder.Entity<Endereco>(entity =>
            {
                entity.HasKey(e => e.IdEndereco);

                entity.ToTable("endereco");

                entity.Property(e => e.IdEndereco).HasColumnType("int(11)");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasColumnName("CEP")
                    .HasColumnType("varchar(9)");

                entity.Property(e => e.Cidade).HasColumnType("varchar(45)");

                entity.Property(e => e.Complemento).HasColumnType("varchar(45)");

                entity.Property(e => e.Numero).HasColumnType("varchar(10)");

                entity.Property(e => e.Rua)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.HasOne(d => d.ClienteIdClienteNavigation)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.ClienteIdCliente)
                    .HasConstraintName("fk_Endereco_Cliente1")
                    .HasConstraintName("ON DELETE CASCADE");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario);

                entity.ToTable("funcionario");

                entity.Property(e => e.IdFuncionario).HasColumnType("int(11)");

                entity.Property(e => e.Ativo).HasColumnType("varchar(1)");

                entity.Property(e => e.Celular).HasColumnType("varchar(11)");

                entity.Property(e => e.Cpf).HasColumnType("varchar(14)");

                entity.Property(e => e.Email).HasColumnType("varchar(60)");

                entity.Property(e => e.Nome).HasColumnType("varchar(45)");

                entity.Property(e => e.Salario)
                    .HasColumnName("salario")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Itemcardapio>(entity =>
            {
                entity.ToTable("itemcardapio");

                entity.HasIndex(e => e.IdCardapio)
                    .HasName("fk_tbCardapio_has_tbPedido_tbCardapio1");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("fk_tbCardapio_has_tbPedido_tbPedido1");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdCardapio).HasColumnType("int(11)");

                entity.Property(e => e.IdPedido).HasColumnType("int(11)");

                entity.Property(e => e.PrecoUnidade).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Quantidade).HasColumnType("int(11)");

                entity.Property(e => e.Total).HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdCardapioNavigation)
                    .WithMany(p => p.Itemcardapio)
                    .HasForeignKey(d => d.IdCardapio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbCardapio_has_tbPedido_tbCardapio1");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.Itemcardapio)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbCardapio_has_tbPedido_tbPedido1");
            });

            modelBuilder.Entity<Itemproduto>(entity =>
            {
                entity.ToTable("itemproduto");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("fk_tbPedido_has_tbProduto_tbPedido1");

                entity.HasIndex(e => e.IdProduto)
                    .HasName("fk_tbPedido_has_tbProduto_tbProduto1");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.IdPedido).HasColumnType("int(11)");

                entity.Property(e => e.IdProduto).HasColumnType("int(11)");

                entity.Property(e => e.PrecoUnidade).HasColumnType("decimal(10,2)");

                entity.Property(e => e.QtdeProduto).HasColumnType("int(11)");

                entity.Property(e => e.Total).HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.Itemproduto)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbPedido_has_tbProduto_tbPedido1");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.Itemproduto)
                    .HasForeignKey(d => d.IdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbPedido_has_tbProduto_tbProduto1");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.IdLogin);

                entity.ToTable("login");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("fk_Login_Funcionario1");

                entity.Property(e => e.IdLogin).HasColumnType("int(11)");

                entity.Property(e => e.DataCriacao).HasColumnType("date");

                entity.Property(e => e.Email).HasColumnType("varchar(60)");

                entity.Property(e => e.IdFuncionario).HasColumnType("int(11)");

                entity.Property(e => e.Perfil).HasColumnType("varchar(20)");

                entity.Property(e => e.Senha).HasColumnType("varchar(45)");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("fk_Login_Funcionario1");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido);

                entity.ToTable("pedido");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("fk_tbPedido_tbCliente1");

                entity.HasIndex(e => e.IdFuncioario)
                    .HasName("fk_tbPedido_tbFuncionario1");

                entity.Property(e => e.IdPedido).HasColumnType("int(11)");

                entity.Property(e => e.DataHora).HasColumnType("datetime");

                entity.Property(e => e.FormaPagamento)
                    .IsRequired()
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.IdCliente).HasColumnType("int(11)");

                entity.Property(e => e.IdFuncioario).HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.TipoEntrega)
                    .IsRequired()
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.TotalPedido).HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbPedido_tbCliente1");

                entity.HasOne(d => d.IdFuncioarioNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdFuncioario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_tbPedido_tbFuncionario1");
            });

            modelBuilder.Entity<Produtoestoque>(entity =>
            {
                entity.HasKey(e => e.IdProduto);

                entity.ToTable("produtoestoque");

                entity.Property(e => e.IdProduto).HasColumnType("int(11)");

                entity.Property(e => e.Categoria).HasColumnType("varchar(15)");

                entity.Property(e => e.DataCompra).HasColumnType("date");

                entity.Property(e => e.Descricao).HasColumnType("varchar(100)");

                entity.Property(e => e.Marca).HasColumnType("varchar(45)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NomeFornecedor).HasColumnType("varchar(50)");

                entity.Property(e => e.NotaFiscal).HasColumnType("varchar(20)");

                entity.Property(e => e.PrecoCompra).HasColumnType("decimal(10,2)");

                entity.Property(e => e.PrecoVenda).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Quantidade).HasColumnType("int(11)");

                entity.Property(e => e.Validade).HasColumnType("date");

                entity.Property(e => e.ValorTributos).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Vende)
                    .IsRequired()
                    .HasColumnType("char(1)");
            });
        }
    }
}
