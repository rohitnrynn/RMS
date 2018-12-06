using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Retail.Migrations
{
    public partial class seven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buyer",
                columns: table => new
                {
                    BuyerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BuyerName = table.Column<string>(nullable: true),
                    BuyerAddress = table.Column<string>(nullable: true),
                    BuyerPhone = table.Column<string>(nullable: true),
                    BuyerEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyer", x => x.BuyerId);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    BillId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    TotalPayable = table.Column<double>(nullable: false),
                    PaymentMethod = table.Column<string>(nullable: true),
                    StaffId = table.Column<int>(nullable: false),
                    BuyerId = table.Column<int>(nullable: false),
                    TotalDiscount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_Bill_Buyer_BuyerId",
                        column: x => x.BuyerId,
                        principalTable: "Buyer",
                        principalColumn: "BuyerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bill_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    BillId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    GST = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BillDetails_Bill_BillId",
                        column: x => x.BillId,
                        principalTable: "Bill",
                        principalColumn: "BillId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetails_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_BuyerId",
                table: "Bill",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_StaffId",
                table: "Bill",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_BillId",
                table: "BillDetails",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_ProductId",
                table: "BillDetails",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillDetails");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Buyer");
        }
    }
}
