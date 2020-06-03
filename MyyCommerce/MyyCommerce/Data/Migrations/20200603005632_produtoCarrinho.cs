using Microsoft.EntityFrameworkCore.Migrations;

namespace MyyCommerce.Data.Migrations
{
    public partial class produtoCarrinho : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoCarrinho_PedidosCarrinho_PedidoCarrinhoId",
                table: "ProdutoCarrinho");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoCarrinho_Produtos_ProdutoId",
                table: "ProdutoCarrinho");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProdutoCarrinho",
                table: "ProdutoCarrinho");

            migrationBuilder.RenameTable(
                name: "ProdutoCarrinho",
                newName: "ProdutosCarrinho");

            migrationBuilder.RenameIndex(
                name: "IX_ProdutoCarrinho_ProdutoId",
                table: "ProdutosCarrinho",
                newName: "IX_ProdutosCarrinho_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_ProdutoCarrinho_PedidoCarrinhoId",
                table: "ProdutosCarrinho",
                newName: "IX_ProdutosCarrinho_PedidoCarrinhoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProdutosCarrinho",
                table: "ProdutosCarrinho",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosCarrinho_PedidosCarrinho_PedidoCarrinhoId",
                table: "ProdutosCarrinho",
                column: "PedidoCarrinhoId",
                principalTable: "PedidosCarrinho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutosCarrinho_Produtos_ProdutoId",
                table: "ProdutosCarrinho",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosCarrinho_PedidosCarrinho_PedidoCarrinhoId",
                table: "ProdutosCarrinho");

            migrationBuilder.DropForeignKey(
                name: "FK_ProdutosCarrinho_Produtos_ProdutoId",
                table: "ProdutosCarrinho");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProdutosCarrinho",
                table: "ProdutosCarrinho");

            migrationBuilder.RenameTable(
                name: "ProdutosCarrinho",
                newName: "ProdutoCarrinho");

            migrationBuilder.RenameIndex(
                name: "IX_ProdutosCarrinho_ProdutoId",
                table: "ProdutoCarrinho",
                newName: "IX_ProdutoCarrinho_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_ProdutosCarrinho_PedidoCarrinhoId",
                table: "ProdutoCarrinho",
                newName: "IX_ProdutoCarrinho_PedidoCarrinhoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProdutoCarrinho",
                table: "ProdutoCarrinho",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoCarrinho_PedidosCarrinho_PedidoCarrinhoId",
                table: "ProdutoCarrinho",
                column: "PedidoCarrinhoId",
                principalTable: "PedidosCarrinho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoCarrinho_Produtos_ProdutoId",
                table: "ProdutoCarrinho",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
