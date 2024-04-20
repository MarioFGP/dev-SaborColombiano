using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class detalleNFactura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumeroFacturacion",
                table: "Detalles",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroFacturacion",
                table: "Detalles");
        }
    }
}
