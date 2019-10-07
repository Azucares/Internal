using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AOAdata.Migrations
{
    public partial class expandpartsobject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parts",
                table: "Parts");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Parts",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNumber",
                table: "Parts",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Parts",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Parts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Parts",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parts",
                table: "Parts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PartsInventory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(nullable: false),
                    CostCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartsInventory", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parts_PartsInventory_InventoryId",
                table: "Parts");

            migrationBuilder.DropTable(
                name: "PartsInventory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parts",
                table: "Parts");

            migrationBuilder.DropIndex(
                name: "IX_Parts_InventoryId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Parts");

            migrationBuilder.AlterColumn<string>(
                name: "PartNumber",
                table: "Parts",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Parts",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parts",
                table: "Parts",
                column: "PartNumber");
        }
    }
}
