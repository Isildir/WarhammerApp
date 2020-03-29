using Microsoft.EntityFrameworkCore.Migrations;

namespace WarhammerProfessionApp.Migrations
{
    public partial class StaticticsRework : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterStatistic_Statistics_StatisticId",
                table: "CharacterStatistic");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterStatistic",
                table: "CharacterStatistic");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStatistic_StatisticId",
                table: "CharacterStatistic");

            migrationBuilder.DropColumn(
                name: "StatisticId",
                table: "CharacterStatistic");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "CharacterStatistic",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "IsBasicValue",
                table: "CharacterStatistic",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CharacterStatistic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "Type",
                table: "CharacterStatistic",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterStatistic",
                table: "CharacterStatistic",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "Trait",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "Trait",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "Trait",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "Trait",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "Trait",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "Trait",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "Trait",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                column: "Trait",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                column: "Trait",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                column: "Trait",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                column: "Trait",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                column: "Trait",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31,
                column: "Trait",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32,
                column: "Trait",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37,
                column: "Trait",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 38,
                column: "Trait",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 39,
                column: "Trait",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 40,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 41,
                column: "Trait",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 42,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 43,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 44,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 45,
                column: "Trait",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 46,
                column: "Trait",
                value: (byte)1);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 47,
                column: "Trait",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 48,
                column: "Trait",
                value: (byte)2);

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStatistic_CharacterId",
                table: "CharacterStatistic",
                column: "CharacterId");
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterStatistic",
                table: "CharacterStatistic");

            migrationBuilder.DropIndex(
                name: "IX_CharacterStatistic_CharacterId",
                table: "CharacterStatistic");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CharacterStatistic");

            migrationBuilder.DropColumn(
                name: "IsBasicValue",
                table: "CharacterStatistic");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CharacterStatistic");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "CharacterStatistic");

            migrationBuilder.AddColumn<byte>(
                name: "StatisticId",
                table: "CharacterStatistic",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterStatistic",
                table: "CharacterStatistic",
                columns: new[] { "CharacterId", "StatisticId" });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<byte>(nullable: false),
                    Type = table.Column<byte>(nullable: false),
                    IsBasicValue = table.Column<bool>(nullable: false),
                    IsChangeFree = table.Column<bool>(nullable: false),
                    ValueIsCalculated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "Trait",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "Trait",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "Trait",
                value: (byte)4);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "Trait",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                column: "Trait",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                column: "Trait",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                column: "Trait",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                column: "Trait",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                column: "Trait",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                column: "Trait",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                column: "Trait",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                column: "Trait",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                column: "Trait",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                column: "Trait",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                column: "Trait",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 31,
                column: "Trait",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 32,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 34,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 35,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 36,
                column: "Trait",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 37,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 38,
                column: "Trait",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 39,
                column: "Trait",
                value: (byte)8);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 40,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 41,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 42,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 43,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 44,
                column: "Trait",
                value: (byte)7);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 45,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 46,
                column: "Trait",
                value: (byte)6);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 47,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 48,
                column: "Trait",
                value: (byte)5);

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "IsBasicValue", "IsChangeFree", "Type", "ValueIsCalculated" },
                values: new object[,]
                {
                    { (byte)15, false, true, (byte)15, false },
                    { (byte)14, false, false, (byte)14, false },
                    { (byte)13, false, false, (byte)13, false },
                    { (byte)12, false, false, (byte)12, true },
                    { (byte)11, false, false, (byte)11, true },
                    { (byte)10, false, false, (byte)10, false },
                    { (byte)9, false, false, (byte)9, false },
                    { (byte)8, true, false, (byte)8, false },
                    { (byte)7, true, false, (byte)7, false },
                    { (byte)6, true, false, (byte)6, false },
                    { (byte)5, true, false, (byte)5, false },
                    { (byte)4, true, false, (byte)4, false },
                    { (byte)3, true, false, (byte)3, false },
                    { (byte)2, true, false, (byte)2, false },
                    { (byte)16, false, true, (byte)16, false },
                    { (byte)1, true, false, (byte)1, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStatistic_StatisticId",
                table: "CharacterStatistic",
                column: "StatisticId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_Type",
                table: "Statistics",
                column: "Type",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterStatistic_Statistics_StatisticId",
                table: "CharacterStatistic",
                column: "StatisticId",
                principalTable: "Statistics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}