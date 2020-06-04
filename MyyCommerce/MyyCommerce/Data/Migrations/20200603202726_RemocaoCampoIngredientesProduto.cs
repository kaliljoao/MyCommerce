using Microsoft.EntityFrameworkCore.Migrations;

namespace MyyCommerce.Data.Migrations
{
    public partial class RemocaoCampoIngredientesProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredientes",
                table: "Produtos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ingredientes",
                table: "Produtos",
                nullable: true);
        }
    }
}
