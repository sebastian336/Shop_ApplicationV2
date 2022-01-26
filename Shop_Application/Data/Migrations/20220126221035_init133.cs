using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop_Application.Data.Migrations
{
    public partial class init133 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceOfOrder",
                table: "Order");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriceOfOrder",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
