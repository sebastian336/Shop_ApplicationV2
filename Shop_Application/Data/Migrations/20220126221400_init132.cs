using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop_Application.Data.Migrations
{
    public partial class init132 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PriceOfOrder",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceOfOrder",
                table: "Order");
        }
    }
}
