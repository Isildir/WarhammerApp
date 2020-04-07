using Microsoft.EntityFrameworkCore.Migrations;

namespace WarhammerProfessionApp.Migrations
{
    public partial class ExpandAndRenameForACharacterModel : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdditionalCharacterValue",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "ExperienceAdditionalCharacterValue",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceAdditionalCharacterValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperienceAdditionalCharacterValue_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalCharacterValue_CharacterId",
                table: "AdditionalCharacterValue",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceAdditionalCharacterValue_CharacterId",
                table: "ExperienceAdditionalCharacterValue",
                column: "CharacterId");
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalCharacterValue");

            migrationBuilder.DropTable(
                name: "ExperienceAdditionalCharacterValue");
        }
    }
}