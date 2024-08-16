using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoLojaAPI.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoNasModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProdutoIds",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Produtos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PedidoId",
                table: "Produtos",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Pedidos_PedidoId",
                table: "Produtos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "PedidoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Pedidos_PedidoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_PedidoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Produtos");

            migrationBuilder.AddColumn<string>(
                name: "ProdutoIds",
                table: "Pedidos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
