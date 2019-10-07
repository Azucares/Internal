using Microsoft.EntityFrameworkCore.Migrations;

namespace AOAdata.Migrations
{
    public partial class oneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartsInventory_Parts_PartId",
                table: "PartsInventory");

            migrationBuilder.DropIndex(
                name: "IX_PartsInventory_PartId",
                table: "PartsInventory");

            migrationBuilder.AlterColumn<int>(
                name: "PartId",
                table: "PartsInventory",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_PartsInventory_PartId",
                table: "PartsInventory",
                column: "PartId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartsInventory_Parts_PartId",
                table: "PartsInventory",
                column: "PartId",
                principalTable: "Parts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartsInventory_Parts_PartId",
                table: "PartsInventory");

            migrationBuilder.DropIndex(
                name: "IX_PartsInventory_PartId",
                table: "PartsInventory");

            migrationBuilder.AlterColumn<int>(
                name: "PartId",
                table: "PartsInventory",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
    }
}
