using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyyCommerce.Data.Migrations
{
    public partial class pedidoCarrinho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PedidosCarrinho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosCarrinho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosCarrinho_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoCarrinho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantidade = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    PedidoCarrinhoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoCarrinho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoCarrinho_PedidosCarrinho_PedidoCarrinhoId",
                        column: x => x.PedidoCarrinhoId,
                        principalTable: "PedidosCarrinho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProdutoCarrinho_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidosCarrinho_UserId",
                table: "PedidosCarrinho",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCarrinho_PedidoCarrinhoId",
                table: "ProdutoCarrinho",
                column: "PedidoCarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoCarrinho_ProdutoId",
                table: "ProdutoCarrinho",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoCarrinho");

            migrationBuilder.DropTable(
                name: "PedidosCarrinho");
        }
    }
}
