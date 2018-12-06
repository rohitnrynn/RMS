using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Retail.Migrations
{
    public partial class five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalInventory",
                columns: table => new
                {
                    LocalInventoryId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProductId = table.Column<int>(nullable: false),
                    ReorderLevel = table.Column<int>(nullable: false),
                    SafetyLevel = table.Column<int>(nullable: false),
                    CurrentStock = table.Column<int>(nullable: false),
                    OutletId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalInventory", x => x.LocalInventoryId);
                    table.ForeignKey(
                        name: "FK_LocalInventory_Outlet_OutletId",
                        column: x => x.OutletId,
                        principalTable: "Outlet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocalInventory_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocalInventory_OutletId",
                table: "LocalInventory",
                column: "OutletId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalInventory_ProductId",
                table: "LocalInventory",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalInventory");
        }
    }
}
