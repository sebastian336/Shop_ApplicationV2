using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop_Application.Data.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlacementOfOrder_Car_CarId",
                table: "PlacementOfOrder");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "PlacementOfOrder");

            migrationBuilder.DropColumn(
                name: "NameFileIcon",
                table: "Category");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "PlacementOfOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Order_CarId",
                table: "Order",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Car_CarId",
                table: "Order",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlacementOfOrder_Car_CarId",
                table: "PlacementOfOrder",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Car_CarId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_PlacementOfOrder_Car_CarId",
                table: "PlacementOfOrder");

            migrationBuilder.DropIndex(
                name: "IX_Order_CarId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Order");

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "PlacementOfOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "PlacementOfOrder",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NameFileIcon",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_PlacementOfOrder_Car_CarId",
                table: "PlacementOfOrder",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
