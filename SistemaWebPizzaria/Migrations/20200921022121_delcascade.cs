using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebPizzaria.Migrations
{
    public partial class delcascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cardapiopizza",
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
                    table.PrimaryKey("PK_cardapiopizza", x => x.IdCardapio);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(45)", nullable: true),
                    Telefone = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.IdCliente);

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
                name: "funcionario",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cpf = table.Column<string>(type: "varchar(14)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(45)", nullable: false),
                    Celular = table.Column<string>(type: "varchar(11)", nullable: true),
                    Email = table.Column<string>(type: "varchar(60)", nullable: true),
                    Ativo = table.Column<string>(type: "varchar(1)", nullable: true),
                    Salario = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionario", x => x.IdFuncionario);
                });

            migrationBuilder.CreateTable(
                name: "produtoestoque",
                columns: table => new
                {
                    IdProduto = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    PrecoCompra = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    DataCompra = table.Column<DateTime>(type: "date", nullable: true),
                    Validade = table.Column<DateTime>(type: "date", nullable: true),
                    Marca = table.Column<string>(type: "varchar(45)", nullable: true),
                    NomeFornecedor = table.Column<string>(type: "varchar(50)", nullable: true),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: true),
                    NotaFiscal = table.Column<string>(type: "varchar(20)", nullable: true),
                    ValorTributos = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Categoria = table.Column<string>(type: "varchar(15)", nullable: true),
                    Vende = table.Column<string>(type: "char(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtoestoque", x => x.IdProduto);
                });

            migrationBuilder.CreateTable(
                name: "endereco",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CEP = table.Column<string>(type: "varchar(9)", nullable: true),
                    Rua = table.Column<string>(type: "varchar(45)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(10)", nullable: true),
                    Complemento = table.Column<string>(type: "varchar(45)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(45)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(45)", nullable: true),
                    Cliente_IdCliente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_endereco", x => x.IdEndereco);
                    table.ForeignKey(
                        name: "ON DELETE CASCADE",
                        column: x => x.Cliente_IdCliente,
                        principalTable: "cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    IdLogin = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "varchar(60)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(45)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "date", nullable: false),
                    Perfil = table.Column<string>(type: "varchar(20)", nullable: false),
                    IdFuncionario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_login", x => x.IdLogin);
                    table.ForeignKey(
                        name: "fk_Login_Funcionario1",
                        column: x => x.IdFuncionario,
                        principalTable: "funcionario",
                        principalColumn: "IdFuncionario",
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
                    TotalPedido = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Status = table.Column<string>(type: "varchar(30)", nullable: false)
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
                        principalTable: "cardapiopizza",
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
                        principalTable: "produtoestoque",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fk_Endereco_Cliente1_idx",
                table: "endereco",
                column: "Cliente_IdCliente");

            migrationBuilder.CreateIndex(
                name: "CPF_Func_UNIQUE",
                table: "funcionario",
                column: "Cpf",
                unique: true);

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
                name: "fk_Login_Funcionario1_idx",
                table: "login",
                column: "IdFuncionario");

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
                name: "endereco");

            migrationBuilder.DropTable(
                name: "itemcardapio");

            migrationBuilder.DropTable(
                name: "itemproduto");

            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropTable(
                name: "cardapiopizza");

            migrationBuilder.DropTable(
                name: "pedido");

            migrationBuilder.DropTable(
                name: "produtoestoque");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "funcionario");
        }
    }
}
