using Microsoft.EntityFrameworkCore.Migrations;

namespace WarhammerProfessionApp.Migrations
{
    public partial class InitialSchemaMigration : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdditionalCharacterItem");

            migrationBuilder.DropTable(
                name: "AdditionalCharacterValue");

            migrationBuilder.DropTable(
                name: "CharacterAbility");

            migrationBuilder.DropTable(
                name: "CharacterItem");

            migrationBuilder.DropTable(
                name: "CharacterProfession");

            migrationBuilder.DropTable(
                name: "CharacterSkill");

            migrationBuilder.DropTable(
                name: "CharacterStatistic");

            migrationBuilder.DropTable(
                name: "DictionaryValueProfessionAbility");

            migrationBuilder.DropTable(
                name: "DictionaryValueProfessionSkill");

            migrationBuilder.DropTable(
                name: "ProfessionItem");

            migrationBuilder.DropTable(
                name: "ProfessionProfession");

            migrationBuilder.DropTable(
                name: "ProfessionStatistic");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "ProfessionAbility");

            migrationBuilder.DropTable(
                name: "DictionaryValues");

            migrationBuilder.DropTable(
                name: "ProfessionSkill");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ProfessionItems");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "ProfessionAbilities");

            migrationBuilder.DropTable(
                name: "ProfessionSkills");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Dictionaries");

            migrationBuilder.DropTable(
                name: "Images");
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    HasImpactOnStatictics = table.Column<bool>(nullable: false),
                    ImpactValue = table.Column<int>(nullable: true),
                    IsStartingValue = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Type = table.Column<byte>(nullable: true),
                    ValueToAlter = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dictionaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanBeDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dictionaries", x => x.Id);
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
                    Description = table.Column<string>(nullable: true),
                    ItemType = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Rarity = table.Column<byte>(nullable: false),
                    Weight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsBasicValue = table.Column<bool>(nullable: false),
                    IsCalculatedValue = table.Column<bool>(nullable: false),
                    IsReadOnly = table.Column<bool>(nullable: false),
                    Type = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(nullable: false),
                    PasswordSalt = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DictionaryValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanBeDeleted = table.Column<bool>(nullable: false),
                    DefinitionId = table.Column<int>(nullable: false),
                    Type = table.Column<byte>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictionaryValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictionaryValues_Dictionaries_DefinitionId",
                        column: x => x.DefinitionId,
                        principalTable: "Dictionaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    DictionaryId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SkillLevel = table.Column<byte>(nullable: false),
                    Trait = table.Column<byte>(nullable: false),
                    Type = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skills_Dictionaries_DictionaryId",
                        column: x => x.DictionaryId,
                        principalTable: "Dictionaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalInformations = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    ImageId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ProfessionLevel = table.Column<byte>(nullable: false),
                    ProfessionRaceAllowed = table.Column<byte>(nullable: false)
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
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentProfessionId = table.Column<int>(nullable: true),
                    ExperienceSummary = table.Column<int>(nullable: false),
                    ExperienceUsed = table.Column<int>(nullable: false),
                    Money = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Race = table.Column<byte>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Professions_CurrentProfessionId",
                        column: x => x.CurrentProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionAbilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfessionId = table.Column<int>(nullable: false)
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
                    ProfessionId = table.Column<int>(nullable: false)
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
                    ProfessionId = table.Column<int>(nullable: false)
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
                name: "ProfessionStatistic",
                columns: table => new
                {
                    ProfessionId = table.Column<int>(nullable: false),
                    StatisticId = table.Column<short>(nullable: false),
                    Value = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionStatistic", x => new { x.ProfessionId, x.StatisticId });
                    table.ForeignKey(
                        name: "FK_ProfessionStatistic_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfessionStatistic_Statistics_StatisticId",
                        column: x => x.StatisticId,
                        principalTable: "Statistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    Weight = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "CharacterItem",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterItem", x => new { x.CharacterId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_CharacterItem_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterProfession",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false),
                    ProfessionId = table.Column<int>(nullable: false),
                    Order = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterProfession", x => new { x.CharacterId, x.ProfessionId });
                    table.ForeignKey(
                        name: "FK_CharacterProfession_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterProfession_Professions_ProfessionId",
                        column: x => x.ProfessionId,
                        principalTable: "Professions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterStatistic",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false),
                    StatisticId = table.Column<short>(nullable: false),
                    BaseValue = table.Column<int>(nullable: false),
                    CurrentValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterStatistic", x => new { x.CharacterId, x.StatisticId });
                    table.ForeignKey(
                        name: "FK_CharacterStatistic_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStatistic_Statistics_StatisticId",
                        column: x => x.StatisticId,
                        principalTable: "Statistics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterAbility",
                columns: table => new
                {
                    AbilityId = table.Column<int>(nullable: false),
                    CharacterId = table.Column<int>(nullable: false),
                    DictionaryValueId = table.Column<int>(nullable: true),
                    IsAdditionalValue = table.Column<bool>(nullable: false),
                    ProfessionAbilitiesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAbility", x => new { x.CharacterId, x.AbilityId });
                    table.ForeignKey(
                        name: "FK_CharacterAbility_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterAbility_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterAbility_DictionaryValues_DictionaryValueId",
                        column: x => x.DictionaryValueId,
                        principalTable: "DictionaryValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterAbility_ProfessionAbilities_ProfessionAbilitiesId",
                        column: x => x.ProfessionAbilitiesId,
                        principalTable: "ProfessionAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionAbility",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbilityId = table.Column<int>(nullable: false),
                    AllowAllValues = table.Column<bool>(nullable: true),
                    ProfessionAbilitiesId = table.Column<int>(nullable: false),
                    ProfessionAbilitiesId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionAbility", x => x.Id);
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
                    table.ForeignKey(
                        name: "FK_ProfessionAbility_ProfessionAbilities_ProfessionAbilitiesId1",
                        column: x => x.ProfessionAbilitiesId1,
                        principalTable: "ProfessionAbilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionItem",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    ProfessionsItemId = table.Column<int>(nullable: false),
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
                name: "CharacterSkill",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false),
                    DictionaryValueId = table.Column<int>(nullable: true),
                    IsAdditionalValue = table.Column<bool>(nullable: false),
                    ProfessionSkillsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkill", x => new { x.CharacterId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CharacterSkill_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSkill_DictionaryValues_DictionaryValueId",
                        column: x => x.DictionaryValueId,
                        principalTable: "DictionaryValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterSkill_ProfessionSkills_ProfessionSkillsId",
                        column: x => x.ProfessionSkillsId,
                        principalTable: "ProfessionSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterSkill_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionSkill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowAllValues = table.Column<bool>(nullable: true),
                    ProfessionSkillsId = table.Column<int>(nullable: false),
                    SkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionSkill", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "DictionaryValueProfessionAbility",
                columns: table => new
                {
                    DictionaryValueId = table.Column<int>(nullable: false),
                    ProfessionAbilityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictionaryValueProfessionAbility", x => new { x.DictionaryValueId, x.ProfessionAbilityId });
                    table.ForeignKey(
                        name: "FK_DictionaryValueProfessionAbility_DictionaryValues_DictionaryValueId",
                        column: x => x.DictionaryValueId,
                        principalTable: "DictionaryValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DictionaryValueProfessionAbility_ProfessionAbility_ProfessionAbilityId",
                        column: x => x.ProfessionAbilityId,
                        principalTable: "ProfessionAbility",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DictionaryValueProfessionSkill",
                columns: table => new
                {
                    DictionaryValueId = table.Column<int>(nullable: false),
                    ProfessionSkillId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictionaryValueProfessionSkill", x => new { x.DictionaryValueId, x.ProfessionSkillId });
                    table.ForeignKey(
                        name: "FK_DictionaryValueProfessionSkill_DictionaryValues_DictionaryValueId",
                        column: x => x.DictionaryValueId,
                        principalTable: "DictionaryValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DictionaryValueProfessionSkill_ProfessionSkill_ProfessionSkillId",
                        column: x => x.ProfessionSkillId,
                        principalTable: "ProfessionSkill",
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

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbility_AbilityId",
                table: "CharacterAbility",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbility_DictionaryValueId",
                table: "CharacterAbility",
                column: "DictionaryValueId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAbility_ProfessionAbilitiesId",
                table: "CharacterAbility",
                column: "ProfessionAbilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterItem_ItemId",
                table: "CharacterItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterProfession_ProfessionId",
                table: "CharacterProfession",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CurrentProfessionId",
                table: "Characters",
                column: "CurrentProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkill_DictionaryValueId",
                table: "CharacterSkill",
                column: "DictionaryValueId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkill_ProfessionSkillsId",
                table: "CharacterSkill",
                column: "ProfessionSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkill_SkillId",
                table: "CharacterSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStatistic_StatisticId",
                table: "CharacterStatistic",
                column: "StatisticId");

            migrationBuilder.CreateIndex(
                name: "IX_DictionaryValueProfessionAbility_ProfessionAbilityId",
                table: "DictionaryValueProfessionAbility",
                column: "ProfessionAbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_DictionaryValueProfessionSkill_ProfessionSkillId",
                table: "DictionaryValueProfessionSkill",
                column: "ProfessionSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_DictionaryValues_DefinitionId",
                table: "DictionaryValues",
                column: "DefinitionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionAbilities_ProfessionId",
                table: "ProfessionAbilities",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionAbility_AbilityId",
                table: "ProfessionAbility",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionAbility_ProfessionAbilitiesId",
                table: "ProfessionAbility",
                column: "ProfessionAbilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionAbility_ProfessionAbilitiesId1",
                table: "ProfessionAbility",
                column: "ProfessionAbilitiesId1");

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
                name: "IX_ProfessionSkill_ProfessionSkillsId",
                table: "ProfessionSkill",
                column: "ProfessionSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionSkill_SkillId",
                table: "ProfessionSkill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionSkills_ProfessionId",
                table: "ProfessionSkills",
                column: "ProfessionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionStatistic_StatisticId",
                table: "ProfessionStatistic",
                column: "StatisticId");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_DictionaryId",
                table: "Skills",
                column: "DictionaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_Type",
                table: "Statistics",
                column: "Type",
                unique: true);
        }
    }
}