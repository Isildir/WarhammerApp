using Microsoft.EntityFrameworkCore.Migrations;

namespace WarhammerProfessionApp.Migrations
{
    public partial class SchemaInitialization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<byte[]>(nullable: true),
                    MimeType = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemType = table.Column<byte>(nullable: false),
                    MoneyType = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Rarity = table.Column<byte>(nullable: false),
                    Weigth = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SkillLevel = table.Column<byte>(nullable: false),
                    Trait = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalInformations = table.Column<string>(maxLength: 150, nullable: true),
                    Agility = table.Column<byte>(nullable: false),
                    Attacks = table.Column<byte>(nullable: false),
                    CloseCombat = table.Column<byte>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    Hitpoints = table.Column<byte>(nullable: false),
                    ImageId = table.Column<int>(nullable: true),
                    Inteligence = table.Column<byte>(nullable: false),
                    Magic = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Polish = table.Column<byte>(nullable: false),
                    ProfessionLevel = table.Column<byte>(nullable: false),
                    ProfessionRaceAllowed = table.Column<byte>(nullable: false),
                    Resistance = table.Column<byte>(nullable: false),
                    Shooting = table.Column<byte>(nullable: false),
                    Speed = table.Column<byte>(nullable: false),
                    Stamina = table.Column<byte>(nullable: false),
                    Willpower = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professions_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionId = table.Column<int>(nullable: false),
                    Quantity = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionAbilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionAbilities_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionId = table.Column<int>(nullable: false),
                    Quantity = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionItems_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionProfession",
                columns: table => new
                {
                    EntranceProfessionId = table.Column<int>(nullable: false),
                    OutputProfessionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionProfession", x => new { x.EntranceProfessionId, x.OutputProfessionId });
                    table.ForeignKey(
                        name: "FK_ProfessionProfession_Professions_EntranceProfessionId",
                        column: x => x.EntranceProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProfessionProfession_Professions_OutputProfessionId",
                        column: x => x.OutputProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionSkills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionId = table.Column<int>(nullable: false),
                    Quantity = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionSkills_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionAbility",
                columns: table => new
                {
                    AbilityId = table.Column<int>(nullable: false),
                    ProfessionAbilitiesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionAbility", x => new { x.ProfessionAbilitiesId, x.AbilityId });
                    table.ForeignKey(
                        name: "FK_ProfessionAbility_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionAbility_ProfessionAbilities_ProfessionAbilitiesId",
                        column: x => x.ProfessionAbilitiesId,
                        principalTable: "ProfessionAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionItem",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    ProfessionsItemId = table.Column<int>(nullable: false),
                    Quality = table.Column<byte>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionItem", x => new { x.ProfessionsItemId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_ProfessionItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionItem_ProfessionItems_ProfessionsItemId",
                        column: x => x.ProfessionsItemId,
                        principalTable: "ProfessionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionSkill",
                columns: table => new
                {
                    ProfessionSkillsId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionSkill", x => new { x.ProfessionSkillsId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_ProfessionSkill_ProfessionSkills_ProfessionSkillsId",
                        column: x => x.ProfessionSkillsId,
                        principalTable: "ProfessionSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionSkill_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionAbilities_ProfessionId",
                table: "ProfessionAbilities",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionAbility_AbilityId",
                table: "ProfessionAbility",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionItem_ItemId",
                table: "ProfessionItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionItems_ProfessionId",
                table: "ProfessionItems",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionProfession_OutputProfessionId",
                table: "ProfessionProfession",
                column: "OutputProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Professions_ImageId",
                table: "Professions",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionSkill_SkillId",
                table: "ProfessionSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionSkills_ProfessionId",
                table: "ProfessionSkills",
                column: "ProfessionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProfessionAbility");

            migrationBuilder.DropTable(
                name: "ProfessionItem");

            migrationBuilder.DropTable(
                name: "ProfessionProfession");

            migrationBuilder.DropTable(
                name: "ProfessionSkill");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "ProfessionAbilities");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ProfessionItems");

            migrationBuilder.DropTable(
                name: "ProfessionSkills");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}