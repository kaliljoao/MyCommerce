using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyyCommerce.Data.Migrations
{
    public partial class statusPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "ProdutosImages");

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "ProdutosImages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusPagamento",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "ProdutosImages");

            migrationBuilder.DropColumn(
                name: "StatusPagamento",
                table: "Pedido");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "ProdutosImages",
                nullable: true);
        }
    }
}
