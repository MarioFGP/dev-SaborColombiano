using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    NumeroFactura = table.Column<string>(type: "varchar(20)", nullable: false),
                    IDEmpleado = table.Column<string>(type: "varchar(15)", nullable: true),
                    NombreEmpleado = table.Column<string>(type: "varchar(50)", nullable: true),
                    Estado = table.Column<string>(type: "varchar(15)", nullable: true),
                    FechaFacturacion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Concepto = table.Column<string>(type: "varchar(20)", nullable: true),
                    Total = table.Column<decimal>(type: "Decimal(38,17)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.NumeroFactura);
                });

            migrationBuilder.CreateTable(
                name: "Insumos",
                columns: table => new
                {
                    Referencia = table.Column<string>(type: "varchar(15)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(20)", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(20)", nullable: true),
                    PrecioUnidad = table.Column<decimal>(type: "Decimal(38,17)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insumos", x => x.Referencia);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Identificacion = table.Column<string>(type: "varchar(15)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(10)", nullable: true),
                    Correo = table.Column<string>(type: "varchar(30)", nullable: true),
                    Estado = table.Column<string>(type: "varchar(10)", nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(30)", nullable: true),
                    TipoPersona = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "Platillos",
                columns: table => new
                {
                    Referencia = table.Column<string>(type: "varchar(15)", nullable: false),
                    Precio = table.Column<decimal>(type: "Decimal(38,17)", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(30)", nullable: true),
                    Disponibilidad = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platillos", x => x.Referencia);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<string>(type: "varchar(20)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(20)", nullable: true),
                    Contraseña = table.Column<string>(type: "varchar(20)", nullable: true),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Detalles",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "varchar(20)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ReferenciaInsumo = table.Column<string>(type: "varchar(15)", nullable: true),
                    ReferenciaPlatillo = table.Column<string>(type: "varchar(15)", nullable: true),
                    Total = table.Column<decimal>(type: "Decimal(38,17)", nullable: false),
                    FacturaNumeroFactura = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Detalles_Facturas_FacturaNumeroFactura",
                        column: x => x.FacturaNumeroFactura,
                        principalTable: "Facturas",
                        principalColumn: "NumeroFactura",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_FacturaNumeroFactura",
                table: "Detalles",
                column: "FacturaNumeroFactura");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalles");

            migrationBuilder.DropTable(
                name: "Insumos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Platillos");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Facturas");
        }
    }
}
