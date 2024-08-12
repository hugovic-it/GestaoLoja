using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoLojaAPI.Migrations
{
    /// <inheritdoc />
    public partial class ModificacaoEmProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagemUrl",
                table: "Produtos",
                type: "TEXT",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "Produtos",
                type: "TEXT",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Produtos",
                type: "TEXT",
                maxLength: 20,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemUrl",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Produtos");
        }
    }
}
