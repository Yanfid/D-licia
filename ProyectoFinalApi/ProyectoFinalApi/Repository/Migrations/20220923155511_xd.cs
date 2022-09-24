using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class xd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id_Cargo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id_Cargo);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id_Categoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id_Categoria);
                });

            migrationBuilder.CreateTable(
                name: "Uni_Medida",
                columns: table => new
                {
                    Id_Medida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    T_Medida = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uni_Medida", x => x.Id_Medida);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id_Empleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Id_Cargo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Id_Empleado);
                    table.ForeignKey(
                        name: "FK_Empleado_Cargo_Id_Cargo",
                        column: x => x.Id_Cargo,
                        principalTable: "Cargo",
                        principalColumn: "Id_Cargo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materia_Prima",
                columns: table => new
                {
                    id_MPrima = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Id_Medida = table.Column<int>(type: "int", nullable: false),
                    Id_Empleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia_Prima", x => x.id_MPrima);
                    table.ForeignKey(
                        name: "FK_Materia_Prima_Empleado_Id_Empleado",
                        column: x => x.Id_Empleado,
                        principalTable: "Empleado",
                        principalColumn: "Id_Empleado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Materia_Prima_Uni_Medida_Id_Medida",
                        column: x => x.Id_Medida,
                        principalTable: "Uni_Medida",
                        principalColumn: "Id_Medida",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id_Producto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    Id_Categoria = table.Column<int>(type: "int", nullable: false),
                    Id_MPrima = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id_Producto);
                    table.ForeignKey(
                        name: "FK_Productos_Categoria_Id_Categoria",
                        column: x => x.Id_Categoria,
                        principalTable: "Categoria",
                        principalColumn: "Id_Categoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Materia_Prima_Id_MPrima",
                        column: x => x.Id_MPrima,
                        principalTable: "Materia_Prima",
                        principalColumn: "id_MPrima",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id_pedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Precio_total = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Direccion_envio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Nombre_envio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Id_Producto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id_pedido);
                    table.ForeignKey(
                        name: "FK_Pedido_Productos_Id_Producto",
                        column: x => x.Id_Producto,
                        principalTable: "Productos",
                        principalColumn: "Id_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    Id_Venta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Pedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.Id_Venta);
                    table.ForeignKey(
                        name: "FK_Venta_Pedido_Id_Pedido",
                        column: x => x.Id_Pedido,
                        principalTable: "Pedido",
                        principalColumn: "Id_pedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boleta",
                columns: table => new
                {
                    Id_Boleta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Venta = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boleta", x => x.Id_Boleta);
                    table.ForeignKey(
                        name: "FK_Boleta_Venta_Id_Venta",
                        column: x => x.Id_Venta,
                        principalTable: "Venta",
                        principalColumn: "Id_Venta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boleta_Id_Venta",
                table: "Boleta",
                column: "Id_Venta");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_Id_Cargo",
                table: "Empleado",
                column: "Id_Cargo");

            migrationBuilder.CreateIndex(
                name: "IX_Materia_Prima_Id_Empleado",
                table: "Materia_Prima",
                column: "Id_Empleado");

            migrationBuilder.CreateIndex(
                name: "IX_Materia_Prima_Id_Medida",
                table: "Materia_Prima",
                column: "Id_Medida");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_Id_Producto",
                table: "Pedido",
                column: "Id_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Id_Categoria",
                table: "Productos",
                column: "Id_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_Id_MPrima",
                table: "Productos",
                column: "Id_MPrima");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_Id_Pedido",
                table: "Venta",
                column: "Id_Pedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boleta");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Materia_Prima");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Uni_Medida");

            migrationBuilder.DropTable(
                name: "Cargo");
        }
    }
}
