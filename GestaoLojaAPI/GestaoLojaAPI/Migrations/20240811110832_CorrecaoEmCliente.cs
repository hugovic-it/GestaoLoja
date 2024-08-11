using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoLojaAPI.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoEmCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Observacao",
                table: "Clientes",
                type: "TEXT",
                maxLength: 300,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Observacao",
                table: "Clientes");
        }
    }
}
