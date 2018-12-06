using Microsoft.EntityFrameworkCore.Migrations;

namespace Retail.Migrations
{
    public partial class six : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Outlet",
                newName: "OutletId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OutletId",
                table: "Outlet",
                newName: "OutletId");
        }
    }
}
