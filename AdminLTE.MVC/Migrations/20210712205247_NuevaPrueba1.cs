using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminLTE.MVC.Migrations
{
    public partial class NuevaPrueba1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tarifario",
                schema: "Identity",
                table: "Clientes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tarifario",
                schema: "Identity",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
