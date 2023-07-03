using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class mymr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "service",
                columns: table => new
                {
                    idOrder = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    price = table.Column<float>(type: "real", nullable: false),
                    nameofThearpy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nameofThearpist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    whereOf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateService = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_service", x => x.idOrder);
                });

            migrationBuilder.CreateTable(
                name: "details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutThearpist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productsidOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_details", x => x.id);
                    table.ForeignKey(
                        name: "FK_details_service_productsidOrder",
                        column: x => x.productsidOrder,
                        principalTable: "service",
                        principalColumn: "idOrder");
                });

            migrationBuilder.CreateIndex(
                name: "IX_details_productsidOrder",
                table: "details",
                column: "productsidOrder");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "details");

            migrationBuilder.DropTable(
                name: "service");
        }
    }
}
