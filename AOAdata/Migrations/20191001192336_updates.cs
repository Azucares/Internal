using Microsoft.EntityFrameworkCore.Migrations;

namespace AOAdata.Migrations
{
    public partial class updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_PartsInventory_InventoryId",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_InventoryId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Parts");

            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "PartsInventory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PartsInventory_PartId",
                table: "PartsInventory",
                column: "PartId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PartsInventory_Parts_PartId",
                table: "PartsInventory",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartsInventory_Parts_PartId",
                table: "PartsInventory");

            migrationBuilder.DropIndex(
                name: "IX_PartsInventory_PartId",
                table: "PartsInventory");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "PartsInventory");

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Parts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parts_InventoryId",
                table: "Parts",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parts_PartsInventory_InventoryId",
                table: "Parts",
                column: "InventoryId",
                principalTable: "PartsInventory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
