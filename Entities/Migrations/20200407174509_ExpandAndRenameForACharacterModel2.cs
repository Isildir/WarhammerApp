using Microsoft.EntityFrameworkCore.Migrations;

namespace WarhammerProfessionApp.Migrations
{
    public partial class ExpandAndRenameForACharacterModel2 : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalCharacterItem");

            migrationBuilder.DropTable(
                name: "AdditionalCharacterValue");
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalCharacterItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Weigth = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalCharacterItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalCharacterItem_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdditionalCharacterValue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdditionalCharacterValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdditionalCharacterValue_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalCharacterItem_CharacterId",
                table: "AdditionalCharacterItem",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalCharacterValue_CharacterId",
                table: "AdditionalCharacterValue",
                column: "CharacterId");
        }
    }
}