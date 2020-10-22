using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SistemaWebPizzaria.Models
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
        public virtual DbSet<Itempedido> Itempedido { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Produtoestoque> Produtoestoque { get; set; }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cardapiopizza>(entity =>
            {
                entity.HasKey(e => e.IdCardapio);

                entity.ToTable("cardapiopizza");

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

                entity.Property(e => e.Nome).HasColumnType("varchar(45)");

                entity.Property(e => e.Telefone).HasColumnType("varchar(11)");
            });

            modelBuilder.Entity<Despesa>(entity =>
            {
                entity.HasKey(e => e.IdDespesa);

                entity.ToTable("despesa");

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

                entity.HasIndex(e => e.ClienteIdCliente)
                    .HasName("fk_Endereco_Cliente1_idx");

                entity.Property(e => e.Bairro).HasColumnType("varchar(45)");

                entity.Property(e => e.Cep)
                    .HasColumnName("CEP")
                    .HasColumnType("varchar(9)");

                entity.Property(e => e.Cidade).HasColumnType("varchar(45)");

                entity.Property(e => e.ClienteIdCliente).HasColumnName("Cliente_IdCliente");

                entity.Property(e => e.Complemento).HasColumnType("varchar(45)");

                entity.Property(e => e.Numero).HasColumnType("varchar(10)");

                entity.Property(e => e.Rua).HasColumnType("varchar(45)");

                entity.HasOne(d => d.ClienteIdClienteNavigation)
                    .WithMany(p => p.Endereco)
                    .HasForeignKey(d => d.ClienteIdCliente)
                    .HasConstraintName("fk_Endereco_Cliente1");
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario);

                entity.ToTable("funcionario");

                entity.HasIndex(e => e.Cpf)
                    .HasName("CPF_Func_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdLogin)
                    .HasName("fk_Funcionario_Login1_idx");

                entity.Property(e => e.Ativo).HasColumnType("varchar(1)");

                entity.Property(e => e.Celular).HasColumnType("varchar(14)");

                entity.Property(e => e.Cpf)
                    .IsRequired()
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.DataCadastro).HasColumnType("date");

                entity.Property(e => e.DataInativacao).HasColumnType("date");

                entity.Property(e => e.Email).HasColumnType("varchar(60)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Salario).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Tipo).HasColumnType("varchar(45)");

                entity.HasOne(d => d.IdLoginNavigation)
                    .WithMany(p => p.Funcionario)
                    .HasForeignKey(d => d.IdLogin)
                    .HasConstraintName("fk_Funcionario_Login1");
            });

            modelBuilder.Entity<Itempedido>(entity =>
            {
                entity.ToTable("itempedido");

                entity.HasIndex(e => e.CardapioPizzaIdCardapio)
                    .HasName("fk_ItemPedido_CardapioPizza1_idx");

                entity.HasIndex(e => e.PedidoIdPedido)
                    .HasName("fk_ItemPedido_Pedido1_idx");

                entity.HasIndex(e => e.ProdutoEstoqueIdProduto)
                    .HasName("fk_ItemPedido_ProdutoEstoque1_idx");

                entity.Property(e => e.CardapioPizzaIdCardapio).HasColumnName("CardapioPizza_IdCardapio");

                entity.Property(e => e.PedidoIdPedido).HasColumnName("Pedido_IdPedido");

                entity.Property(e => e.PrecoUnidade).HasColumnType("decimal(10,2)");

                entity.Property(e => e.Produto)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.ProdutoEstoqueIdProduto).HasColumnName("ProdutoEstoque_IdProduto");

                entity.Property(e => e.Total).HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.CardapioPizzaIdCardapioNavigation)
                    .WithMany(p => p.Itempedido)
                    .HasForeignKey(d => d.CardapioPizzaIdCardapio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ItemPedido_CardapioPizza1");

                entity.HasOne(d => d.PedidoIdPedidoNavigation)
                    .WithMany(p => p.Itempedido)
                    .HasForeignKey(d => d.PedidoIdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ItemPedido_Pedido1");

                entity.HasOne(d => d.ProdutoEstoqueIdProdutoNavigation)
                    .WithMany(p => p.Itempedido)
                    .HasForeignKey(d => d.ProdutoEstoqueIdProduto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ItemPedido_ProdutoEstoque1");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.IdLogin);

                entity.ToTable("login");

                entity.Property(e => e.Ativo).HasColumnType("char(1)");

                entity.Property(e => e.DataCriacao).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Perfil)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.SenhaPadrao).HasColumnType("char(1)");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido);

                entity.ToTable("pedido");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("fk_tbPedido_tbCliente1_idx");

                entity.HasIndex(e => e.IdFuncioario)
                    .HasName("fk_tbPedido_tbFuncionario1_idx");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("IdPedido_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.DataHora).HasColumnType("datetime");

                entity.Property(e => e.FormaPagamento)
                    .IsRequired()
                    .HasColumnType("varchar(15)");

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

                entity.Property(e => e.UnidadeMedida)
                    .IsRequired()
                    .HasColumnType("char(3)");

                entity.Property(e => e.Validade).HasColumnType("date");

                entity.Property(e => e.Vende)
                    .IsRequired()
                    .HasColumnType("char(1)");
            });
        }
    }
}
