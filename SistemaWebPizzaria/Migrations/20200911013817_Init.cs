using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace SistemaWebPizzaria.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cardapio",
                columns: table => new
                {
                    IdCardapio = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Sabor = table.Column<string>(type: "varchar(50)", nullable: false),
                    Tipo = table.Column<string>(type: "varchar(45)", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Tamanho = table.Column<string>(type: "varchar(10)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cardapio", x => x.IdCardapio);
                });

            migrationBuilder.CreateTable(
                name: "despesa",
                columns: table => new
                {
                    IdDespesa = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeDespesa = table.Column<string>(type: "varchar(50)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DataDespesa = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_despesa", x => x.IdDespesa);
                });

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(type: "varchar(9)", nullable: false),
                    Rua = table.Column<string>(type: "varchar(45)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(10)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(45)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(45)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.IdEndereco);
                });

            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    IdLogin = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(60)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(45)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_login", x => x.IdLogin);
                });

            migrationBuilder.CreateTable(
                name: "perfil",
                columns: table => new
                {
                    idPerfil = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoPerfil = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_perfil", x => x.idPerfil);
                });

            migrationBuilder.CreateTable(
                name: "produto",
                columns: table => new
                {
                    IdProduto = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    PrecoCompra = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    UnidadeMedida = table.Column<string>(type: "varchar(5)", nullable: true),
                    DataCompra = table.Column<DateTime>(type: "date", nullable: true),
                    Validade = table.Column<DateTime>(type: "date", nullable: true),
                    Marca = table.Column<string>(type: "varchar(45)", nullable: true),
                    NomeFornecedor = table.Column<string>(type: "varchar(50)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: true),
                    NotaFiscal = table.Column<string>(type: "varchar(20)", nullable: true),
                    ValorTributos = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Categoria = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produto", x => x.IdProduto);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(45)", nullable: true),
                    Telefone = table.Column<string>(type: "varchar(45)", nullable: true),
                    tbEndereco_IdEndereco = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.IdCliente);
                    table.ForeignKey(
                        name: "fk_tbCliente_tbEndereco1",
                        column: x => x.tbEndereco_IdEndereco,
                        principalTable: "endereco",
                        principalColumn: "IdEndereco",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "funcionario",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cpf = table.Column<string>(type: "varchar(14)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(45)", nullable: false),
                    Celular = table.Column<string>(type: "varchar(11)", nullable: true),
                    Email = table.Column<string>(type: "varchar(60)", nullable: false),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: true),
                    IdLogin = table.Column<int>(nullable: false),
                    IdPerfil = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionario", x => x.IdFuncionario);
                    table.ForeignKey(
                        name: "fk_tbFuncionario_tbLogin",
                        column: x => x.IdLogin,
                        principalTable: "login",
                        principalColumn: "IdLogin",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_tbFuncionario_tbPerfil1",
                        column: x => x.IdPerfil,
                        principalTable: "perfil",
                        principalColumn: "idPerfil",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pedido",
                columns: table => new
                {
                    IdPedido = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataHora = table.Column<DateTime>(type: "datetime", nullable: false),
                    TipoEntrega = table.Column<string>(type: "varchar(15)", nullable: false),
                    FormaPagamento = table.Column<string>(type: "varchar(15)", nullable: false),
                    IdFuncioario = table.Column<int>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    TotalPedido = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedido", x => x.IdPedido);
                    table.ForeignKey(
                        name: "fk_tbPedido_tbCliente1",
                        column: x => x.IdCliente,
                        principalTable: "cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_tbPedido_tbFuncionario1",
                        column: x => x.IdFuncioario,
                        principalTable: "funcionario",
                        principalColumn: "IdFuncionario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "itemcardapio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCardapio = table.Column<int>(nullable: false),
                    IdPedido = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: true),
                    PrecoUnidade = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemcardapio", x => x.Id);
                    table.ForeignKey(
                        name: "fk_tbCardapio_has_tbPedido_tbCardapio1",
                        column: x => x.IdCardapio,
                        principalTable: "cardapio",
                        principalColumn: "IdCardapio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_tbCardapio_has_tbPedido_tbPedido1",
                        column: x => x.IdPedido,
                        principalTable: "pedido",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "itemproduto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdPedido = table.Column<int>(nullable: false),
                    IdProduto = table.Column<int>(nullable: false),
                    QtdeProduto = table.Column<int>(nullable: true),
                    PrecoUnidade = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemproduto", x => x.Id);
                    table.ForeignKey(
                        name: "fk_tbPedido_has_tbProduto_tbPedido1",
                        column: x => x.IdPedido,
                        principalTable: "pedido",
                        principalColumn: "IdPedido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_tbPedido_has_tbProduto_tbProduto1",
                        column: x => x.IdProduto,
                        principalTable: "produto",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IdCliente_UNIQUE",
                table: "cliente",
                column: "IdCliente",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_tbCliente_tbEndereco1_idx",
                table: "cliente",
                column: "tbEndereco_IdEndereco");

            migrationBuilder.CreateIndex(
                name: "CPF_Func_UNIQUE",
                table: "funcionario",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_tbFuncionario_tbLogin_idx",
                table: "funcionario",
                column: "IdLogin");

            migrationBuilder.CreateIndex(
                name: "fk_tbFuncionario_tbPerfil1_idx",
                table: "funcionario",
                column: "IdPerfil");

            migrationBuilder.CreateIndex(
                name: "fk_tbCardapio_has_tbPedido_tbCardapio1_idx",
                table: "itemcardapio",
                column: "IdCardapio");

            migrationBuilder.CreateIndex(
                name: "fk_tbCardapio_has_tbPedido_tbPedido1_idx",
                table: "itemcardapio",
                column: "IdPedido");

            migrationBuilder.CreateIndex(
                name: "fk_tbPedido_has_tbProduto_tbPedido1_idx",
                table: "itemproduto",
                column: "IdPedido");

            migrationBuilder.CreateIndex(
                name: "fk_tbPedido_has_tbProduto_tbProduto1_idx",
                table: "itemproduto",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "fk_tbPedido_tbCliente1_idx",
                table: "pedido",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "fk_tbPedido_tbFuncionario1_idx",
                table: "pedido",
                column: "IdFuncioario");

            migrationBuilder.CreateIndex(
                name: "IdPedido_UNIQUE",
                table: "pedido",
                column: "IdPedido",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "despesa");

            migrationBuilder.DropTable(
                name: "itemcardapio");

            migrationBuilder.DropTable(
                name: "itemproduto");

            migrationBuilder.DropTable(
                name: "cardapio");

            migrationBuilder.DropTable(
                name: "pedido");

            migrationBuilder.DropTable(
                name: "produto");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "funcionario");

            migrationBuilder.DropTable(
                name: "endereco");

            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "perfil");
        }
    }
}
