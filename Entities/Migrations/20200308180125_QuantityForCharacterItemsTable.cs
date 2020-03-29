using Microsoft.EntityFrameworkCore.Migrations;

namespace WarhammerProfessionApp.Migrations
{
    public partial class QuantityForCharacterItemsTable : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CharacterItem");
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CharacterItem",
                nullable: false,
                defaultValue: 0);
        }
    }
}