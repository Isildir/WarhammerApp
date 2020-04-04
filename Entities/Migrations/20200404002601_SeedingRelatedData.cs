using Microsoft.EntityFrameworkCore.Migrations;

namespace WarhammerProfessionApp.Migrations
{
    public partial class SeedingRelatedData : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 1, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 2, 75 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 3, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 4, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 4, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 5, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 5, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 6, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 7, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 8, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 9, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 10, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 10, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 11, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 11, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 13, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 13, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 14, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 14, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 15, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 15, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 16, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 16, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 16, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 16, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 16, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 16, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 16, 78 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 16, 82 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 17, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 17, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 18, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 19, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 19, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 20, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 21, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 21, 54 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 22, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 23, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 23, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 24, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 25, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 26, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 27, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 28, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 29, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 29, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 30, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 31, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 32, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 33, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 33, 82 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 34, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 35, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 35, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 36, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 36, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 37, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 37, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 38, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 39, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 40, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 41, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 41, 75 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 42, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 43, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 44, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 45, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 46, 68 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 46, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 47, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 47, 80 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 48, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 48, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 49, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 50, 68 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 50, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 51, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 52, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 53, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 53, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 54, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 55, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 56, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 57, 66 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 57, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 58, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 58, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 59, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 59, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 60, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 61, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 61, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 62, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 62, 66 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 63, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 64, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 64, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 65, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 66, 66 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 66, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 67, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 67, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 68, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 68, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 69, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 69, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 70, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 70, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 71, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 72, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 73, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 74, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 75, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 76, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 77, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 77, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 78, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 78, 82 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 79, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 79, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 80, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 81, 54 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 81, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 82, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 83, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 84, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 84, 54 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 85, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 85, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 86, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 87, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 87, 54 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 88, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 89, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 90, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 90, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 91, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 92, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 93, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 94, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 94, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 95, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 96, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 96, 54 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 97, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 98, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 98, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 99, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 99, 66 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 100, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 100, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 101, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 101, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 102, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 102, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 103, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 103, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 104, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 105, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 105, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 106, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 107, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 108, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 108, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 109, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 110, 57 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 111, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 111, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 112, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 112, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 113, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 113, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 114, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 115, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 115, 54 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 116, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 116, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 117, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 118, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 119, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 119, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 120, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 120, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 121, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 121, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 122, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 122, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 123, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 124, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 125, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 126, 82 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 127, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 128, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 129, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 130, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 131, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 131, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 132, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 133, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 134, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 134, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 135, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 135, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 136, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 136, 25 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 137, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 138, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 138, 68 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 139, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 139, 54 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 140, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 140, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 141, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 141, 54 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 142, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 143, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 144, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 145, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 146, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 146, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 147, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 148, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 148, 84 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 149, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 149, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 150, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 151, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 151, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 152, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 153, 66 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 153, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 154, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 154, 75 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 155, 66 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 155, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 156, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 157, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 157, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 158, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 159, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 160, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 160, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 161, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 162, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 162, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 163, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 164, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 164, 21 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 165, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 166, 21 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 166, 80 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 167, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 167, 74 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 168, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 168, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 169, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 169, 57 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 170, 21 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 170, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 171, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 172, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 172, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 173, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 173, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 174, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 175, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 175, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 176, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 176, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 177, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 177, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 178, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 178, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 179, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 180, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 180, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 181, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 182, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 182, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 183, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 184, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 185, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 186, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 186, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 187, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 187, 84 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 188, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 188, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 189, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 189, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 190, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 191, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 192, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 192, 84 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 193, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 194, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 195, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 196, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 197, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 198, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 199, 42 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 200, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 201, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 202, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 203, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 204, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 205, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 205, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 206, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 207, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 208, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 208, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 209, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 209, 25 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 210, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 211, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 211, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 212, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 213, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 213, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 214, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 215, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 216, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 217, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 218, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 219, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 220, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 221, 82 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 222, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 223, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 224, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 225, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 226, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 227, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 228, 65 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 229, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 230, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 231, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 232, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 232, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 233, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 234, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 235, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 236, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 237, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 238, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 238, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 239, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 239, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 240, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 240, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 241, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 242, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 242, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 243, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 244, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 245, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 246, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 247, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 248, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 249, 25 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 249, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 250, 21 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 251, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 251, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 252, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 253, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 254, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 255, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 256, 65 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 257, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 258, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 258, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 259, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 260, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 261, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 262, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 263, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 264, 52 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 265, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 266, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 267, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 268, 66 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 268, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 269, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 270, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 271, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 272, 52 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 273, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 274, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 274, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 275, 21 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 276, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 277, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 278, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 279, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 280, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 280, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 281, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 282, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 283, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 284, 80 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 285, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 286, 57 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 287, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 288, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 288, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 289, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 289, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 290, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 291, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 292, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 292, 84 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 293, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 293, 72 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 294, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 295, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 296, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 297, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 298, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 299, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 300, 52 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 301, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 302, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 303, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 304, 57 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 304, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 305, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 306, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 307, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 308, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 308, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 309, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 310, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 311, 82 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 312, 21 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 313, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 314, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 314, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 315, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 316, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 317, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 318, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 319, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 320, 65 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 321, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 322, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 323, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 324, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 325, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 326, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 327, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 328, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 329, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 330, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 331, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 332, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 333, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 334, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 335, 78 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 336, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 337, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 338, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 339, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 340, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 340, 82 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 341, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 341, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 342, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 343, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 344, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 345, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 346, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 347, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 348, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 349, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 350, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 351, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 352, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 353, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 354, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 355, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 356, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 357, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 358, 65 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 359, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 360, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 361, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 362, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 363, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 364, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 365, 25 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 365, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 366, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 367, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 368, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 369, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 369, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 370, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 371, 25 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 372, 57 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 373, 57 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 374, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 374, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 375, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 376, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 377, 25 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 377, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 378, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 378, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 379, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 380, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 381, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 381, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 382, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 382, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 383, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 383, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 384, 32 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 384, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 385, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 386, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 387, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 387, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 388, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 388, 84 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 389, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 390, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 391, 74 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 392, 80 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 393, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 394, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 395, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 396, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 396, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 397, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 397, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 398, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 398, 84 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 399, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 400, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 401, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 402, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 403, 42 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 404, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 405, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 406, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 407, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 408, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 409, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 410, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 411, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 412, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 413, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 413, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 414, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 415, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 416, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 417, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 418, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 419, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 420, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 420, 65 });

            migrationBuilder.DeleteData(
                table: "ProfessionAbility",
                keyColumns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                keyValues: new object[] { 421, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 1, 66 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 2, 135 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 3, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 4, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 7, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 8, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 9, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 9, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 10, 93 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 11, 154 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 11, 201 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 12, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 13, 131 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 14, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 15, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 15, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 16, 120 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 17, 154 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 18, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 18, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 19, 154 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 20, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 21, 90 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 22, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 23, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 24, 165 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 25, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 26, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 27, 49 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 28, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 29, 169 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 30, 171 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 31, 172 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 32, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 32, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 33, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 34, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 35, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 36, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 36, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 37, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 38, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 39, 187 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 40, 201 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 41, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 42, 144 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 43, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 44, 152 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 45, 108 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 46, 109 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 47, 187 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 48, 72 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 49, 75 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 50, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 51, 151 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 52, 107 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 53, 109 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 54, 128 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 55, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 56, 65 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 56, 139 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 57, 114 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 58, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 59, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 60, 52 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 61, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 62, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 63, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 64, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 65, 199 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 66, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 67, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 68, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 69, 155 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 69, 158 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 70, 199 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 71, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 72, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 73, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 74, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 75, 143 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 76, 128 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 77, 143 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 78, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 79, 149 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 80, 107 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 81, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 82, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 83, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 84, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 85, 114 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 86, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 87, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 88, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 89, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 90, 187 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 91, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 91, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 92, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 93, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 94, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 94, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 95, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 96, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 97, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 98, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 99, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 100, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 101, 65 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 102, 133 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 103, 99 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 104, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 105, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 106, 107 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 107, 109 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 108, 144 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 109, 152 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 110, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 111, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 112, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 113, 169 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 114, 171 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 115, 172 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 116, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 117, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 118, 176 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 119, 162 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 119, 165 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 120, 110 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 120, 162 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 121, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 121, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 122, 17 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 122, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 123, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 124, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 125, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 126, 169 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 127, 171 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 128, 172 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 129, 128 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 130, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 130, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 131, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 132, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 133, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 134, 146 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 135, 128 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 136, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 137, 65 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 138, 156 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 139, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 140, 114 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 141, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 142, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 143, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 144, 169 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 145, 171 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 146, 172 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 147, 112 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 148, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 149, 148 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 150, 156 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 151, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 152, 98 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 153, 118 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 154, 108 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 155, 109 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 156, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 157, 109 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 158, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 159, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 160, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 161, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 162, 168 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 163, 171 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 164, 172 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 165, 128 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 166, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 167, 170 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 168, 171 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 169, 172 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 170, 107 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 171, 109 });

            migrationBuilder.DeleteData(
                table: "ProfessionItem",
                keyColumns: new[] { "ProfessionsItemId", "ItemId" },
                keyValues: new object[] { 172, 152 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 1, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 1, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 1, 74 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 1, 111 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 2, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 2, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 2, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 2, 95 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 2, 105 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 3, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 3, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 3, 105 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 4, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 4, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 4, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 4, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 4, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 4, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 4, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 5, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 5, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 5, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 5, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 5, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 5, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 5, 102 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 6, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 6, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 6, 64 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 6, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 7, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 7, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 7, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 7, 82 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 7, 91 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 8, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 8, 65 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 8, 111 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 9, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 9, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 9, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 9, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 9, 88 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 10, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 10, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 10, 96 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 10, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 10, 105 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 11, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 11, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 11, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 11, 54 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 11, 105 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 12, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 12, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 12, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 12, 105 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 12, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 13, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 13, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 13, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 13, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 13, 72 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 13, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 14, 49 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 14, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 14, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 15, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 15, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 15, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 15, 80 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 15, 92 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 16, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 16, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 16, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 16, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 16, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 17, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 17, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 17, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 17, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 17, 105 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 18, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 18, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 18, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 18, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 18, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 19, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 19, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 19, 42 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 19, 50 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 19, 52 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 19, 59 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 19, 99 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 19, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 20, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 20, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 20, 80 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 20, 99 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 20, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 21, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 21, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 21, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 21, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 21, 75 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 21, 77 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 21, 92 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 22, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 22, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 22, 42 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 22, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 22, 59 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 22, 95 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 22, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 23, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 23, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 23, 25 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 23, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 23, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 23, 105 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 24, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 24, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 24, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 24, 42 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 24, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 24, 86 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 24, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 25, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 25, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 25, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 25, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 25, 55 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 25, 91 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 25, 94 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 26, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 26, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 26, 25 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 26, 91 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 26, 94 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 27, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 27, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 27, 57 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 27, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 27, 81 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 28, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 28, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 28, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 28, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 28, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 28, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 29, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 29, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 29, 57 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 29, 92 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 29, 107 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 30, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 30, 52 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 30, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 30, 59 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 30, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 30, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 31, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 31, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 31, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 31, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 31, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 31, 92 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 31, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 32, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 32, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 32, 53 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 32, 95 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 32, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 33, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 33, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 33, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 33, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 33, 95 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 34, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 34, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 34, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 34, 77 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 34, 88 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 35, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 35, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 35, 57 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 35, 58 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 35, 77 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 35, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 36, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 36, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 36, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 36, 72 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 36, 77 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 36, 86 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 37, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 37, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 37, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 37, 94 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 37, 112 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 38, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 38, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 38, 49 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 38, 88 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 38, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 39, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 39, 21 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 39, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 39, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 39, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 39, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 39, 75 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 39, 102 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 40, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 40, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 40, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 40, 59 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 40, 94 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 40, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 41, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 41, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 41, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 41, 32 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 41, 95 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 41, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 41, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 42, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 42, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 42, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 42, 80 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 42, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 43, 25 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 43, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 43, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 43, 55 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 43, 91 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 44, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 44, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 44, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 44, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 44, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 44, 107 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 45, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 45, 25 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 45, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 45, 95 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 45, 112 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 46, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 46, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 46, 57 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 46, 68 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 46, 93 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 46, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 47, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 47, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 47, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 47, 92 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 47, 107 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 48, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 48, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 48, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 48, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 48, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 48, 105 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 49, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 49, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 49, 106 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 50, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 50, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 50, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 50, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 50, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 51, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 51, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 51, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 51, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 51, 111 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 51, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 52, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 52, 32 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 52, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 52, 105 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 52, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 53, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 53, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 53, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 53, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 53, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 53, 95 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 53, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 54, 110 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 55, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 55, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 55, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 55, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 55, 94 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 55, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 56, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 56, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 56, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 56, 92 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 56, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 56, 107 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 57, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 57, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 57, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 57, 49 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 57, 72 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 57, 82 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 57, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 58, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 58, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 58, 60 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 58, 66 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 58, 88 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 59, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 59, 32 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 59, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 59, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 59, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 59, 105 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 60, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 60, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 60, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 60, 66 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 60, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 61, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 61, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 61, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 62, 84 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 62, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 63, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 63, 90 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 63, 96 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 63, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 64, 57 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 64, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 64, 95 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 64, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 64, 102 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 65, 59 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 65, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 65, 74 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 65, 91 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 65, 105 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 66, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 66, 77 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 66, 88 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 66, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 67, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 67, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 67, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 67, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 67, 111 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 68, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 68, 81 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 68, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 68, 102 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 68, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 68, 112 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 69, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 69, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 69, 98 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 69, 113 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 70, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 70, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 70, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 70, 68 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 70, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 70, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 71, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 71, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 71, 90 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 71, 98 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 72, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 72, 84 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 72, 86 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 72, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 72, 93 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 73, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 73, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 73, 102 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 73, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 74, 65 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 74, 81 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 74, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 74, 108 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 75, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 75, 21 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 75, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 75, 77 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 75, 92 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 76, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 76, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 76, 83 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 76, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 77, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 77, 84 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 77, 94 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 77, 102 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 77, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 78, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 78, 80 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 78, 90 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 78, 99 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 79, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 79, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 79, 87 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 79, 90 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 80, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 80, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 80, 96 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 80, 99 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 81, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 81, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 81, 77 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 81, 92 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 82, 84 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 82, 102 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 82, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 82, 111 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 83, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 83, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 83, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 83, 99 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 84, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 84, 94 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 84, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 85, 62 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 85, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 85, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 86, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 86, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 86, 72 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 86, 77 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 86, 84 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 87, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 87, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 87, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 87, 90 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 88, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 88, 86 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 88, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 88, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 89, 73 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 89, 77 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 89, 90 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 89, 102 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 90, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 90, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 90, 77 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 90, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 90, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 91, 56 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 91, 82 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 91, 94 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 92, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 92, 83 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 92, 94 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 92, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 93, 68 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 93, 96 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 93, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 93, 105 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 93, 112 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 94, 70 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 94, 83 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 94, 92 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 94, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 95, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 95, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 95, 83 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 95, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 95, 112 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 96, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 96, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 96, 80 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 96, 87 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 96, 90 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 97, 90 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 97, 96 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 97, 100 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 97, 112 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 98, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 98, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 98, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 98, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 98, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 99, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 99, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 99, 98 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 99, 112 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 100, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 100, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 100, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 100, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 100, 98 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 101, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 101, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 101, 102 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 101, 104 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 101, 107 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 102, 83 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 102, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 102, 94 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 102, 98 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 103, 49 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 103, 77 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 103, 81 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 103, 82 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 103, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 103, 111 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 104, 63 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 104, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 104, 68 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 104, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 104, 81 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 104, 94 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 105, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 105, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 105, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 105, 99 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 105, 100 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 106, 85 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 106, 101 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 106, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 107, 51 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 107, 76 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 107, 83 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 107, 92 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 107, 94 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 108, 61 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 108, 65 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 108, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 108, 79 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 108, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 110, 109 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 111, 65 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 111, 67 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 111, 74 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 111, 103 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 112, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 112, 69 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 112, 95 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 112, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 112, 98 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 113, 71 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 113, 78 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 113, 80 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 113, 89 });

            migrationBuilder.DeleteData(
                table: "ProfessionProfession",
                keyColumns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                keyValues: new object[] { 113, 97 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 2, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 3, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 4, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 7, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 8, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 9, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 10, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 10, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 11, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 11, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 14, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 15, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 16, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 17, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 17, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 18, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 19, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 21, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 22, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 23, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 24, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 24, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 25, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 25, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 26, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 26, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 27, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 27, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 28, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 28, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 29, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 29, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 30, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 31, 17 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 31, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 32, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 32, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 33, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 33, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 35, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 35, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 36, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 37, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 38, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 39, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 40, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 41, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 42, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 43, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 43, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 44, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 45, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 46, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 47, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 47, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 48, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 49, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 49, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 49, 21 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 49, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 49, 25 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 49, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 49, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 49, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 50, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 51, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 52, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 52, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 53, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 54, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 55, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 56, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 57, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 58, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 59, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 60, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 61, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 62, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 63, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 63, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 64, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 65, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 66, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 66, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 67, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 68, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 69, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 70, 17 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 71, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 72, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 73, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 73, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 74, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 75, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 75, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 76, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 77, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 78, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 79, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 80, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 81, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 82, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 83, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 84, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 85, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 86, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 87, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 88, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 89, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 90, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 91, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 91, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 92, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 93, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 93, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 94, 25 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 94, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 95, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 95, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 96, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 96, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 97, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 97, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 98, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 99, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 100, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 101, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 102, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 103, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 103, 32 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 104, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 105, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 106, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 106, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 107, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 107, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 108, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 109, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 110, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 111, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 112, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 112, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 113, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 114, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 114, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 115, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 116, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 116, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 117, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 118, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 119, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 120, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 120, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 121, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 122, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 123, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 124, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 125, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 126, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 127, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 128, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 129, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 130, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 131, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 132, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 132, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 133, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 134, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 135, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 135, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 136, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 137, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 137, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 138, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 139, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 140, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 141, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 142, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 143, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 144, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 145, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 146, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 147, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 148, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 149, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 149, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 150, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 151, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 152, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 153, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 154, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 154, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 155, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 156, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 157, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 158, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 159, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 159, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 160, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 161, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 162, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 163, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 164, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 165, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 165, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 166, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 166, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 167, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 167, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 168, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 169, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 169, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 170, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 171, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 172, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 172, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 173, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 173, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 174, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 175, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 175, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 176, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 177, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 178, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 179, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 180, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 181, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 182, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 183, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 184, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 185, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 186, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 187, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 188, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 189, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 190, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 191, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 192, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 193, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 193, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 194, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 195, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 196, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 197, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 198, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 199, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 199, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 200, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 200, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 201, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 202, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 203, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 204, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 205, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 206, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 206, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 207, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 208, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 209, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 210, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 211, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 212, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 213, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 214, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 215, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 216, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 217, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 218, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 219, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 220, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 220, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 221, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 222, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 222, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 223, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 224, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 225, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 226, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 227, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 228, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 229, 17 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 230, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 231, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 231, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 232, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 233, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 234, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 235, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 236, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 237, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 238, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 239, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 240, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 240, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 241, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 242, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 243, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 244, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 245, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 246, 17 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 247, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 247, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 248, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 248, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 249, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 249, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 250, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 251, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 252, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 253, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 254, 17 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 255, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 256, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 257, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 258, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 259, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 260, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 261, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 262, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 263, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 264, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 265, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 266, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 267, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 268, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 268, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 269, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 270, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 271, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 272, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 273, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 274, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 275, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 276, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 276, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 277, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 278, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 279, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 280, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 281, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 282, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 283, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 284, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 284, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 285, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 286, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 287, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 288, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 288, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 289, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 290, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 290, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 291, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 292, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 292, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 293, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 294, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 294, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 295, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 296, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 297, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 298, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 299, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 300, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 301, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 302, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 303, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 304, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 305, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 306, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 307, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 308, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 309, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 310, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 310, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 311, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 311, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 312, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 312, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 313, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 314, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 315, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 316, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 317, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 318, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 319, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 320, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 320, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 321, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 322, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 323, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 324, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 325, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 326, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 327, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 328, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 329, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 330, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 331, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 332, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 333, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 334, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 335, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 336, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 337, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 338, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 339, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 339, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 340, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 340, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 341, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 342, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 342, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 343, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 344, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 345, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 346, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 347, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 348, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 348, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 349, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 350, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 351, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 352, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 353, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 354, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 355, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 356, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 357, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 358, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 359, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 360, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 361, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 362, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 363, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 364, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 365, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 366, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 367, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 367, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 368, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 369, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 370, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 371, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 372, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 373, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 373, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 374, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 375, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 375, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 376, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 376, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 377, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 378, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 378, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 379, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 380, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 381, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 381, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 382, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 383, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 383, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 384, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 385, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 386, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 387, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 388, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 389, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 390, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 391, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 391, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 392, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 393, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 394, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 394, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 395, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 396, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 397, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 398, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 399, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 400, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 401, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 402, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 403, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 403, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 404, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 405, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 406, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 406, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 407, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 408, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 409, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 409, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 410, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 410, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 411, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 411, 32 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 412, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 412, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 413, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 414, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 414, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 415, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 416, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 417, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 418, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 418, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 419, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 420, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 420, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 421, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 422, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 422, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 423, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 423, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 424, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 425, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 426, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 427, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 427, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 428, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 429, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 430, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 431, 17 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 432, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 433, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 434, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 435, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 435, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 436, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 436, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 437, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 437, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 438, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 439, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 439, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 440, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 441, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 442, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 442, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 443, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 444, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 445, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 445, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 446, 17 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 447, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 448, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 448, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 449, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 450, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 451, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 452, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 453, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 454, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 455, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 456, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 457, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 458, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 459, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 460, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 461, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 462, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 463, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 464, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 465, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 466, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 467, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 467, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 468, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 469, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 470, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 471, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 472, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 473, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 474, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 475, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 476, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 477, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 478, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 479, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 480, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 481, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 482, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 483, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 484, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 485, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 486, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 487, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 488, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 489, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 490, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 491, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 492, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 493, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 494, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 495, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 496, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 497, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 498, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 499, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 500, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 501, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 502, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 503, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 504, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 505, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 506, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 507, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 508, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 509, 17 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 510, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 511, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 512, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 513, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 514, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 515, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 516, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 517, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 518, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 519, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 520, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 521, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 522, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 523, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 524, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 525, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 526, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 527, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 527, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 528, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 529, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 530, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 530, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 531, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 532, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 533, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 534, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 535, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 536, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 537, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 538, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 539, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 540, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 541, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 542, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 543, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 544, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 545, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 546, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 547, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 548, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 549, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 550, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 551, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 552, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 553, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 554, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 555, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 556, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 557, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 558, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 559, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 560, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 561, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 562, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 563, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 564, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 565, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 566, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 567, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 568, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 569, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 570, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 570, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 571, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 572, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 573, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 574, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 575, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 576, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 577, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 578, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 579, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 580, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 581, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 582, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 583, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 584, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 585, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 586, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 587, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 588, 48 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 589, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 590, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 590, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 591, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 592, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 593, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 594, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 595, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 596, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 597, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 598, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 599, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 600, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 601, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 602, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 603, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 604, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 604, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 605, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 605, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 606, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 607, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 608, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 609, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 610, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 611, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 612, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 613, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 614, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 615, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 616, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 617, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 618, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 619, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 620, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 621, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 622, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 623, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 624, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 625, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 626, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 627, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 628, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 629, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 630, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 631, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 632, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 633, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 634, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 635, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 636, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 637, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 638, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 639, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 640, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 641, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 642, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 643, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 644, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 645, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 646, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 647, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 648, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 649, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 650, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 651, 45 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 652, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 653, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 654, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 655, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 656, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 657, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 658, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 659, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 660, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 661, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 662, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 663, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 664, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 665, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 666, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 667, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 668, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 669, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 670, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 671, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 672, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 673, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 674, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 675, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 676, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 677, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 678, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 679, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 680, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 681, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 682, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 683, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 684, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 685, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 686, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 687, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 688, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 689, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 690, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 691, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 692, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 693, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 694, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 695, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 696, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 697, 42 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 698, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 699, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 700, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 701, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 701, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 702, 32 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 703, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 704, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 705, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 706, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 707, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 708, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 709, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 710, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 711, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 712, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 713, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 714, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 715, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 716, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 717, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 718, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 719, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 720, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 721, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 722, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 723, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 724, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 725, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 726, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 727, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 728, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 729, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 730, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 731, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 732, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 733, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 734, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 734, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 735, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 735, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 736, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 737, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 738, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 739, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 740, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 741, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 742, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 743, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 744, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 745, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 746, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 747, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 748, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 749, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 750, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 751, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 752, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 753, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 754, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 755, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 756, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 757, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 758, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 759, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 760, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 761, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 762, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 763, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 764, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 765, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 766, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 767, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 768, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 769, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 770, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 771, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 772, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 773, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 774, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 775, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 776, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 777, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 778, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 779, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 780, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 781, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 782, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 783, 9 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 784, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 785, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 786, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 787, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 788, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 789, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 790, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 791, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 792, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 793, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 794, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 795, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 796, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 797, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 798, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 799, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 800, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 801, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 802, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 803, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 804, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 805, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 806, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 807, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 808, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 809, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 810, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 811, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 812, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 813, 38 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 814, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 815, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 816, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 817, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 818, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 819, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 820, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 821, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 822, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 823, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 824, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 825, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 826, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 827, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 827, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 828, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 829, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 830, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 831, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 832, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 833, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 834, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 835, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 836, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 837, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 838, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 839, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 840, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 841, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 842, 39 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 843, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 844, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 845, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 846, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 847, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 848, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 849, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 850, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 851, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 852, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 853, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 854, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 854, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 855, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 856, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 857, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 858, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 859, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 860, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 861, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 862, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 863, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 864, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 865, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 866, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 867, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 868, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 869, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 870, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 871, 42 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 872, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 873, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 874, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 875, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 876, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 877, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 878, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 879, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 880, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 881, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 882, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 883, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 884, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 885, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 886, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 887, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 888, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 889, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 890, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 891, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 892, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 893, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 894, 1 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 895, 23 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 896, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 897, 32 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 898, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 899, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 900, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 901, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 902, 37 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 903, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 904, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 905, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 906, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 907, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 908, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 909, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 910, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 911, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 912, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 913, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 914, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 915, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 916, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 917, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 918, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 918, 33 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 919, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 920, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 921, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 922, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 923, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 924, 2 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 925, 24 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 926, 27 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 927, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 928, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 929, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 930, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 931, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 932, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 933, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 934, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 935, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 936, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 937, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 938, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 939, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 940, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 941, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 942, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 943, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 944, 22 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 945, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 945, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 946, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 947, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 948, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 949, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 950, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 950, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 951, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 952, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 953, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 954, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 955, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 956, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 957, 32 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 958, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 959, 11 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 960, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 961, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 962, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 963, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 964, 15 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 965, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 966, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 967, 19 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 968, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 968, 8 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 969, 26 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 970, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 971, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 972, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 973, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 974, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 975, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 976, 36 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 977, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 978, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 979, 44 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 980, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 981, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 982, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 983, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 984, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 985, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 986, 18 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 987, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 988, 5 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 989, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 990, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 991, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 992, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 993, 28 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 994, 29 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 995, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 996, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 997, 14 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 998, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 999, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1000, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1001, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1002, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1003, 3 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1004, 7 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1005, 10 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1006, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1007, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1008, 20 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1009, 47 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1010, 4 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1011, 30 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1012, 6 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1013, 31 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1014, 34 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1015, 35 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1016, 12 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1017, 13 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1018, 40 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1019, 16 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1020, 41 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1021, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1022, 43 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1023, 46 });

            migrationBuilder.DeleteData(
                table: "ProfessionSkill",
                keyColumns: new[] { "ProfessionSkillsId", "SkillId" },
                keyValues: new object[] { 1024, 46 });

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)3);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)4);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)5);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)6);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)7);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)8);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)9);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)10);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)11);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)12);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)13);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)14);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)15);

            migrationBuilder.DeleteData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)16);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ProfessionAbilities",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProfessionItems",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "ProfessionSkills",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Wino pospolite", 12, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Wino szlacheckie", 120, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ItemType", "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { (byte)7, "Bukłak", 96, (byte)6, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Flaszka", 48, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Juki", 480, (byte)4, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Kuferek", 1200, 40 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Manierka metalowa", 480, (byte)3, 15 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Manierska skórzana", 180, (byte)4, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Mieszek", 24, (byte)6, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Plecak", 360, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Sakiewka", 60, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Tobołek", 480, (byte)4, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Tuba na mapy/pergaminy", 240, (byte)3, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Worek", 60, (byte)6, 7 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ItemType", "Name", "Price", "Weigth" },
                values: new object[] { (byte)8, "Drewno na opał", 24, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Kaganek", 60, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Latarnia", 240, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Latarnia sztormowa", 2880, (byte)3, 30 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Olej do latarni", 60, (byte)6, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Pochodnia", 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Świeczka łojowa", 36 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Świeczka woskowa", 72, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Zapałka", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ItemType", "Name", "Price", "Rarity" },
                values: new object[] { (byte)9, "Zlota korona", 240, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Pens", 1, (byte)7 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Szyling", 12, (byte)6 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Drabina", 120, (byte)5, 50 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Hubka i krzesiwo", 360, (byte)6, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Name", "Weigth" },
                values: new object[] { "Imbryk", 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Instrument muzyczny", 1200, (byte)5, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Kłódka dobrej jakości", 2400, (byte)1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Kłódka zwykłej jakości", 240, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Koc", 300, (byte)6, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Kociołek", 240, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Kości do gry", 72, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Kufel drewniany", 120, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Kufel ze szkła barwionego", 240 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Name", "Rarity", "Weigth" },
                values: new object[] { "Lina", (byte)5, 50 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Luneta", 24000, (byte)2, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Lustro", 2400 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Namiot", 180, (byte)5, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Papier", 12, (byte)1, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Perfumy", 240, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Pergamin", 60, (byte)2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Symbol religijny", 240, (byte)5, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Sztućce drewniane", 60, (byte)6, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Sztućce metalowe", 720, (byte)5, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Sztućce srebrne", 3600, (byte)3, 3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Talia kart", 240, (byte)6, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ItemType", "Name", "Price", "Weigth" },
                values: new object[] { (byte)10, "Drąg, cena za metr", 12, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Drewniany klin", 8, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Haczyk na ryby i żyłka", 36, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Kajdany", 1200, (byte)4, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Kilof", 300 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Kołki", 60, (byte)5, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Kotwiczka do wspinaczki", 960, (byte)4, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Książka drukowana", 24000, (byte)1, 35 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Książka ilustrowana", 84000, 50 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Liczydło", 2400, (byte)2, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Łańcuch, cena za metr", 360 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Łom", 120, (byte)5, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Łopata", 300, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Młot", 240, 40 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Narzędzia", 12000, (byte)4, 50 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Potrzask", 12, (byte)5, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Przybory do pisania", 2400, (byte)4, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Sztabka metalu", 300, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Wnyki", 480, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Wytrychy", 2400, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Zestaw do charakteryzacji", 1200, (byte)3, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ItemType", "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { (byte)11, "Wózek", 12000, (byte)5, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Wóz", 21600 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Powóz", 120000, (byte)2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Łódź rzeczna", 144000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Łódź wiosłowa", 21600, (byte)4, 900 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Statek", 2880000, (byte)3, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Rumak", 120000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Lekki koń bojowy", 72000, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Koń", 19200 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Kuc", 12000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Siodło", 1200, 50 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Uprząż", 240, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ItemType", "Name", "Rarity", "Weigth" },
                values: new object[] { (byte)12, "Gołąb pocztowy", (byte)4, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Jastrząb", 19200, (byte)2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Koń juczny", 9600, (byte)6 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Koń pociągowy lub muł", 6000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Kot", 12 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Koza", 480 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Krowa", 2400 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Kurczak", 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Owca", 480 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Pies (rasowy)", 720 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Pies bojowy", 7200, (byte)2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Świnia", 720, (byte)6 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Wół", 7200 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ItemType", "Name", "Rarity" },
                values: new object[] { (byte)13, "Dar Grety", (byte)1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Mikstura lecznicza", 1200, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Piwo Bugmana", 12000, (byte)1, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Czarny Jad", 7200, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Czarny lotos", 4800 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Grzybki Szalonego Kapelusznika", 7200 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Jad mantikory", 15600 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Korzeń mandragory", 6000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Sercobój", 192000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Szkarłatny Cień", 8400 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Ślina chimery", 36000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Księga wiedzy tajemnej", 120000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Napar kojący", 1200, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Odtrutki", 720, (byte)3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Relikwia", 1200 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Talizman szczęścia", 3600, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Woda święcona", 2400, (byte)3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Dłoń weterana", 14400, (byte)2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Drewniane zęby", 36, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Kolczyk", 12, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Opaska na oko", 6 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Płytka czaszkowa", 12, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Pozłacany nos", 72, (byte)3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Szklane oko", 12, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Sztuczna noga", 72 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Tatuaż", 36 });
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Butelka gorzałki dobrej jakości", 36, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Wino pospolite", 12, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "ItemType", "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { (byte)6, "Wino szlacheckie", 120, (byte)4, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Bukłak", 96, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Flaszka", 48, (byte)6, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Juki", 480, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Kuferek", 1200, (byte)4, 40 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Manierka metalowa", 480, (byte)3, 15 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Manierska skórzana", 180, (byte)4, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Mieszek", 24, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Plecak", 360, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Sakiewka", 60, (byte)6, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Tobołek", 480, (byte)4, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Tuba na mapy/pergaminy", 240, (byte)3, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "ItemType", "Name", "Price", "Weigth" },
                values: new object[] { (byte)7, "Worek", 60, 7 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Drewno na opał", 24, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Kaganek", 60, (byte)6 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Latarnia", 240, (byte)4, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Latarnia sztormowa", 2880, (byte)3, 30 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Olej do latarni", 60 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Pochodnia", 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Świeczka łojowa", 36, (byte)6 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Świeczka woskowa", 72, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "ItemType", "Name", "Price", "Rarity" },
                values: new object[] { (byte)8, "Zapałka", 1, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Zlota korona", 240, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Pens", 1, (byte)7 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Szyling", 12, (byte)6, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Drabina", 120, (byte)5, 50 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Name", "Weigth" },
                values: new object[] { "Hubka i krzesiwo", 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Imbryk", 360, (byte)6, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Instrument muzyczny", 1200, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Kłódka dobrej jakości", 2400, (byte)1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Kłódka zwykłej jakości", 240, (byte)5, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Koc", 300, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Kociołek", 240, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Kości do gry", 72, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Kufel drewniany", 120 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Name", "Rarity", "Weigth" },
                values: new object[] { "Kufel ze szkła barwionego", (byte)6, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Lina", 240, (byte)5, 50 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Luneta", 24000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Lustro", 2400, (byte)2, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Namiot", 180, (byte)5, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Papier", 12, (byte)1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Perfumy", 240, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Pergamin", 60, (byte)2, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Symbol religijny", 240, (byte)5, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Sztućce drewniane", 60, (byte)6, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Sztućce metalowe", 720, (byte)5, 4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Sztućce srebrne", 3600, (byte)3, 3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "ItemType", "Name", "Price", "Weigth" },
                values: new object[] { (byte)9, "Talia kart", 240, 1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Drąg, cena za metr", 12, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Drewniany klin", 8, (byte)6 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Haczyk na ryby i żyłka", 36, (byte)5, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Kajdany", 1200 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Kilof", 300, (byte)4, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Kołki", 60, (byte)5, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Kotwiczka do wspinaczki", 960, (byte)4, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Książka drukowana", 24000, 35 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Książka ilustrowana", 84000, (byte)1, 50 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Liczydło", 2400 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Łańcuch, cena za metr", 360, (byte)2, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Łom", 120, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Łopata", 300, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Młot", 240, (byte)5, 40 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Narzędzia", 12000, (byte)4, 50 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Potrzask", 12, (byte)5, 2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Przybory do pisania", 2400, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Sztabka metalu", 300, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Wnyki", 480, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Wytrychy", 2400, (byte)4, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "ItemType", "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { (byte)10, "Zestaw do charakteryzacji", 1200, (byte)3, 10 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Wózek", 12000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Wóz", 21600, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Powóz", 120000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Łódź rzeczna", 144000, (byte)2, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Łódź wiosłowa", 21600, (byte)4, 900 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Statek", 2880000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Rumak", 120000, (byte)3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Lekki koń bojowy", 72000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Koń", 19200 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Kuc", 12000, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Siodło", 1200, 50 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "ItemType", "Name", "Rarity", "Weigth" },
                values: new object[] { (byte)11, "Uprząż", (byte)5, 20 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Gołąb pocztowy", 240, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Jastrząb", 19200, (byte)2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Koń juczny", 9600 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Koń pociągowy lub muł", 6000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Kot", 12 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Koza", 480 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Krowa", 2400 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Kurczak", 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Owca", 480 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Pies (rasowy)", 720, (byte)6 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Pies bojowy", 7200, (byte)2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Świnia", 720 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "ItemType", "Name", "Rarity" },
                values: new object[] { (byte)12, "Wół", (byte)6 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Dar Grety", 7200, (byte)1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { "Mikstura lecznicza", 1200, (byte)4, 0 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Name", "Price", "Weigth" },
                values: new object[] { "Piwo Bugmana", 12000, 5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Czarny Jad", 7200 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Czarny lotos", 4800 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Grzybki Szalonego Kapelusznika", 7200 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Jad mantikory", 15600 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Korzeń mandragory", 6000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Sercobój", 192000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Szkarłatny Cień", 8400 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Ślina chimery", 36000 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Księga wiedzy tajemnej", 120000, (byte)1 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Napar kojący", 1200, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Odtrutki", 720 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Relikwia", 1200, (byte)3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Talizman szczęścia", 3600, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Woda święcona", 2400, (byte)3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Dłoń weterana", 14400, (byte)2 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Drewniane zęby", 36, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Kolczyk", 12 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Opaska na oko", 6, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Płytka czaszkowa", 12, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Name", "Price", "Rarity" },
                values: new object[] { "Pozłacany nos", 72, (byte)3 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Szklane oko", 12 });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Sztuczna noga", 72 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Description", "ItemType", "Name", "Price", "Rarity", "Weigth" },
                values: new object[] { 211, null, (byte)13, "Tatuaż", 36, (byte)4, 0 });

            migrationBuilder.InsertData(
                table: "ProfessionAbilities",
                columns: new[] { "Id", "ProfessionId", "Quantity" },
                values: new object[,]
                {
                    { 122, 42, (byte)1 },
                    { 410, 112, (byte)1 },
                    { 409, 112, (byte)1 },
                    { 408, 112, (byte)1 },
                    { 407, 112, (byte)1 },
                    { 406, 112, (byte)1 },
                    { 405, 111, (byte)1 },
                    { 404, 110, (byte)1 },
                    { 403, 110, (byte)1 },
                    { 402, 110, (byte)1 },
                    { 401, 110, (byte)1 },
                    { 411, 112, (byte)1 },
                    { 400, 109, (byte)1 },
                    { 398, 108, (byte)1 },
                    { 397, 108, (byte)1 },
                    { 396, 108, (byte)1 },
                    { 395, 108, (byte)1 },
                    { 394, 108, (byte)1 },
                    { 393, 108, (byte)1 },
                    { 392, 107, (byte)1 },
                    { 391, 107, (byte)1 },
                    { 390, 107, (byte)1 },
                    { 389, 107, (byte)1 },
                    { 399, 109, (byte)1 },
                    { 388, 106, (byte)1 },
                    { 412, 112, (byte)1 },
                    { 414, 112, (byte)1 },
                    { 14, 5, (byte)1 },
                    { 13, 5, (byte)1 },
                    { 12, 5, (byte)1 },
                    { 11, 4, (byte)1 },
                    { 10, 4, (byte)1 },
                    { 9, 3, (byte)1 },
                    { 8, 3, (byte)1 },
                    { 7, 3, (byte)1 },
                    { 6, 3, (byte)1 },
                    { 5, 2, (byte)1 },
                    { 413, 112, (byte)1 },
                    { 4, 2, (byte)1 },
                    { 2, 1, (byte)1 },
                    { 1, 1, (byte)1 },
                    { 120, 42, (byte)1 },
                    { 421, 113, (byte)1 },
                    { 420, 113, (byte)1 },
                    { 419, 113, (byte)1 },
                    { 418, 113, (byte)1 },
                    { 417, 112, (byte)1 },
                    { 416, 112, (byte)1 },
                    { 415, 112, (byte)1 },
                    { 3, 1, (byte)1 },
                    { 387, 106, (byte)1 },
                    { 386, 106, (byte)1 },
                    { 385, 106, (byte)1 },
                    { 357, 99, (byte)1 },
                    { 356, 99, (byte)1 },
                    { 355, 99, (byte)1 },
                    { 354, 99, (byte)1 },
                    { 353, 99, (byte)1 },
                    { 352, 98, (byte)1 },
                    { 351, 98, (byte)1 },
                    { 350, 98, (byte)1 },
                    { 349, 98, (byte)1 },
                    { 348, 98, (byte)1 },
                    { 358, 99, (byte)1 },
                    { 347, 98, (byte)1 },
                    { 345, 98, (byte)1 },
                    { 343, 97, (byte)1 },
                    { 342, 97, (byte)1 },
                    { 341, 97, (byte)1 },
                    { 340, 97, (byte)1 },
                    { 339, 96, (byte)1 },
                    { 338, 96, (byte)1 },
                    { 337, 96, (byte)1 },
                    { 336, 96, (byte)1 },
                    { 335, 95, (byte)1 },
                    { 346, 98, (byte)1 },
                    { 359, 100, (byte)1 },
                    { 360, 100, (byte)1 },
                    { 361, 100, (byte)1 },
                    { 384, 106, (byte)1 },
                    { 383, 106, (byte)1 },
                    { 382, 105, (byte)1 },
                    { 381, 105, (byte)1 },
                    { 380, 105, (byte)1 },
                    { 379, 105, (byte)1 },
                    { 378, 105, (byte)1 },
                    { 377, 104, (byte)1 },
                    { 376, 104, (byte)1 },
                    { 375, 104, (byte)1 },
                    { 374, 104, (byte)1 },
                    { 373, 103, (byte)1 },
                    { 372, 102, (byte)1 },
                    { 371, 102, (byte)1 },
                    { 370, 102, (byte)1 },
                    { 369, 102, (byte)1 },
                    { 368, 101, (byte)1 },
                    { 367, 101, (byte)1 },
                    { 366, 101, (byte)1 },
                    { 365, 101, (byte)1 },
                    { 364, 101, (byte)1 },
                    { 363, 100, (byte)1 },
                    { 362, 100, (byte)1 },
                    { 15, 5, (byte)1 },
                    { 16, 6, (byte)2 },
                    { 17, 7, (byte)1 },
                    { 18, 7, (byte)1 },
                    { 92, 30, (byte)1 },
                    { 91, 29, (byte)1 },
                    { 90, 29, (byte)1 },
                    { 89, 29, (byte)1 },
                    { 88, 28, (byte)1 },
                    { 87, 28, (byte)1 },
                    { 86, 28, (byte)1 },
                    { 85, 27, (byte)1 },
                    { 84, 27, (byte)1 },
                    { 83, 27, (byte)1 },
                    { 93, 30, (byte)1 },
                    { 82, 26, (byte)1 },
                    { 80, 26, (byte)1 },
                    { 79, 26, (byte)1 },
                    { 78, 26, (byte)1 },
                    { 77, 25, (byte)1 },
                    { 76, 25, (byte)1 },
                    { 75, 25, (byte)1 },
                    { 74, 25, (byte)1 },
                    { 73, 25, (byte)1 },
                    { 72, 25, (byte)1 },
                    { 71, 24, (byte)1 },
                    { 81, 26, (byte)1 },
                    { 94, 31, (byte)1 },
                    { 95, 32, (byte)1 },
                    { 96, 32, (byte)1 },
                    { 119, 41, (byte)1 },
                    { 118, 41, (byte)1 },
                    { 117, 40, (byte)1 },
                    { 116, 40, (byte)1 },
                    { 115, 40, (byte)1 },
                    { 114, 40, (byte)1 },
                    { 113, 39, (byte)1 },
                    { 112, 39, (byte)1 },
                    { 111, 39, (byte)1 },
                    { 110, 38, (byte)1 },
                    { 109, 37, (byte)1 },
                    { 108, 37, (byte)1 },
                    { 107, 37, (byte)1 },
                    { 106, 37, (byte)1 },
                    { 105, 37, (byte)1 },
                    { 104, 37, (byte)1 },
                    { 103, 36, (byte)1 },
                    { 102, 35, (byte)1 },
                    { 101, 34, (byte)1 },
                    { 100, 34, (byte)1 },
                    { 99, 33, (byte)1 },
                    { 98, 33, (byte)1 },
                    { 97, 32, (byte)1 },
                    { 70, 24, (byte)1 },
                    { 334, 95, (byte)1 },
                    { 69, 23, (byte)1 },
                    { 67, 23, (byte)1 },
                    { 40, 12, (byte)1 },
                    { 39, 12, (byte)1 },
                    { 38, 12, (byte)1 },
                    { 37, 12, (byte)1 },
                    { 36, 12, (byte)1 },
                    { 35, 11, (byte)1 },
                    { 34, 11, (byte)1 },
                    { 33, 11, (byte)1 },
                    { 32, 11, (byte)1 },
                    { 31, 11, (byte)1 },
                    { 41, 13, (byte)1 },
                    { 30, 11, (byte)1 },
                    { 28, 10, (byte)1 },
                    { 27, 10, (byte)1 },
                    { 26, 10, (byte)1 },
                    { 25, 9, (byte)1 },
                    { 24, 9, (byte)1 },
                    { 23, 8, (byte)1 },
                    { 22, 8, (byte)1 },
                    { 21, 8, (byte)1 },
                    { 20, 8, (byte)1 },
                    { 19, 7, (byte)1 },
                    { 29, 11, (byte)1 },
                    { 42, 13, (byte)1 },
                    { 43, 13, (byte)1 },
                    { 44, 14, (byte)1 },
                    { 66, 22, (byte)1 },
                    { 65, 21, (byte)1 },
                    { 64, 21, (byte)1 },
                    { 63, 20, (byte)1 },
                    { 62, 20, (byte)1 },
                    { 61, 20, (byte)1 },
                    { 121, 42, (byte)1 },
                    { 60, 20, (byte)1 },
                    { 59, 19, (byte)1 },
                    { 58, 19, (byte)1 },
                    { 57, 19, (byte)1 },
                    { 56, 19, (byte)1 },
                    { 55, 18, (byte)1 },
                    { 54, 18, (byte)1 },
                    { 53, 18, (byte)1 },
                    { 52, 17, (byte)1 },
                    { 51, 17, (byte)1 },
                    { 50, 16, (byte)1 },
                    { 49, 16, (byte)1 },
                    { 48, 16, (byte)1 },
                    { 47, 15, (byte)1 },
                    { 46, 15, (byte)1 },
                    { 45, 14, (byte)1 },
                    { 68, 23, (byte)1 },
                    { 333, 95, (byte)1 },
                    { 344, 98, (byte)1 },
                    { 331, 95, (byte)1 },
                    { 197, 64, (byte)1 },
                    { 196, 64, (byte)1 },
                    { 195, 63, (byte)1 },
                    { 194, 63, (byte)1 },
                    { 193, 63, (byte)1 },
                    { 192, 62, (byte)1 },
                    { 191, 62, (byte)1 },
                    { 190, 62, (byte)1 },
                    { 189, 62, (byte)1 },
                    { 188, 62, (byte)1 },
                    { 198, 65, (byte)1 },
                    { 187, 61, (byte)1 },
                    { 185, 61, (byte)1 },
                    { 184, 61, (byte)1 },
                    { 183, 61, (byte)1 },
                    { 182, 61, (byte)1 },
                    { 181, 60, (byte)1 },
                    { 180, 60, (byte)1 },
                    { 179, 60, (byte)1 },
                    { 178, 59, (byte)1 },
                    { 177, 59, (byte)1 },
                    { 176, 59, (byte)1 },
                    { 186, 61, (byte)1 },
                    { 199, 65, (byte)1 },
                    { 200, 65, (byte)1 },
                    { 201, 66, (byte)1 },
                    { 224, 70, (byte)1 },
                    { 223, 70, (byte)1 },
                    { 222, 70, (byte)1 },
                    { 221, 69, (byte)1 },
                    { 220, 69, (byte)1 },
                    { 219, 69, (byte)1 },
                    { 218, 69, (byte)1 },
                    { 217, 69, (byte)1 },
                    { 216, 69, (byte)1 },
                    { 332, 95, (byte)1 },
                    { 214, 69, (byte)1 },
                    { 213, 69, (byte)1 },
                    { 212, 69, (byte)1 },
                    { 211, 68, (byte)1 },
                    { 210, 68, (byte)1 },
                    { 209, 68, (byte)1 },
                    { 208, 68, (byte)1 },
                    { 207, 67, (byte)1 },
                    { 206, 67, (byte)1 },
                    { 205, 67, (byte)1 },
                    { 204, 67, (byte)1 },
                    { 203, 66, (byte)1 },
                    { 202, 66, (byte)1 },
                    { 175, 59, (byte)1 },
                    { 225, 71, (byte)1 },
                    { 174, 59, (byte)1 },
                    { 172, 58, (byte)1 },
                    { 144, 48, (byte)1 },
                    { 143, 48, (byte)1 },
                    { 142, 48, (byte)1 },
                    { 141, 48, (byte)1 },
                    { 140, 47, (byte)1 },
                    { 139, 47, (byte)1 },
                    { 138, 46, (byte)1 },
                    { 137, 46, (byte)1 },
                    { 136, 46, (byte)1 },
                    { 135, 46, (byte)1 },
                    { 145, 48, (byte)1 },
                    { 134, 45, (byte)1 },
                    { 132, 45, (byte)1 },
                    { 131, 45, (byte)1 },
                    { 130, 44, (byte)1 },
                    { 129, 44, (byte)1 },
                    { 128, 44, (byte)1 },
                    { 127, 44, (byte)1 },
                    { 126, 43, (byte)1 },
                    { 125, 43, (byte)1 },
                    { 124, 43, (byte)1 },
                    { 123, 43, (byte)1 },
                    { 133, 45, (byte)1 },
                    { 146, 49, (byte)1 },
                    { 147, 49, (byte)1 },
                    { 148, 49, (byte)1 },
                    { 171, 58, (byte)1 },
                    { 170, 57, (byte)1 },
                    { 169, 57, (byte)1 },
                    { 168, 57, (byte)1 },
                    { 167, 56, (byte)1 },
                    { 166, 56, (byte)1 },
                    { 165, 55, (byte)1 },
                    { 164, 55, (byte)1 },
                    { 163, 54, (byte)1 },
                    { 162, 54, (byte)1 },
                    { 161, 54, (byte)1 },
                    { 160, 54, (byte)1 },
                    { 159, 54, (byte)1 },
                    { 158, 54, (byte)1 },
                    { 157, 53, (byte)1 },
                    { 156, 53, (byte)1 },
                    { 155, 52, (byte)1 },
                    { 154, 52, (byte)1 },
                    { 153, 51, (byte)1 },
                    { 152, 51, (byte)1 },
                    { 151, 51, (byte)1 },
                    { 150, 50, (byte)1 },
                    { 149, 50, (byte)1 },
                    { 173, 58, (byte)1 },
                    { 226, 71, (byte)1 },
                    { 215, 69, (byte)1 },
                    { 228, 71, (byte)1 },
                    { 303, 89, (byte)1 },
                    { 302, 88, (byte)1 },
                    { 301, 87, (byte)1 },
                    { 300, 87, (byte)1 },
                    { 299, 87, (byte)1 },
                    { 298, 87, (byte)1 },
                    { 297, 87, (byte)1 },
                    { 296, 87, (byte)1 },
                    { 295, 87, (byte)1 },
                    { 294, 87, (byte)1 },
                    { 304, 89, (byte)1 },
                    { 293, 86, (byte)1 },
                    { 291, 85, (byte)1 },
                    { 290, 85, (byte)1 },
                    { 289, 85, (byte)1 },
                    { 288, 85, (byte)1 },
                    { 287, 84, (byte)1 },
                    { 286, 84, (byte)1 },
                    { 285, 84, (byte)1 },
                    { 284, 83, (byte)1 },
                    { 283, 83, (byte)1 },
                    { 282, 83, (byte)1 },
                    { 227, 71, (byte)1 },
                    { 305, 90, (byte)1 },
                    { 306, 90, (byte)1 },
                    { 307, 90, (byte)1 },
                    { 330, 95, (byte)1 },
                    { 329, 95, (byte)1 },
                    { 328, 95, (byte)1 },
                    { 327, 95, (byte)1 },
                    { 326, 94, (byte)1 },
                    { 325, 94, (byte)1 },
                    { 324, 94, (byte)1 },
                    { 323, 94, (byte)1 },
                    { 322, 94, (byte)1 },
                    { 321, 93, (byte)1 },
                    { 320, 93, (byte)1 },
                    { 319, 93, (byte)1 },
                    { 318, 93, (byte)1 },
                    { 317, 93, (byte)1 },
                    { 316, 93, (byte)1 },
                    { 315, 93, (byte)1 },
                    { 314, 92, (byte)1 },
                    { 313, 92, (byte)1 },
                    { 312, 92, (byte)1 },
                    { 311, 91, (byte)1 },
                    { 310, 91, (byte)1 },
                    { 309, 91, (byte)1 },
                    { 308, 90, (byte)1 },
                    { 281, 83, (byte)1 },
                    { 280, 83, (byte)1 },
                    { 292, 85, (byte)1 },
                    { 278, 82, (byte)1 },
                    { 250, 77, (byte)1 },
                    { 249, 76, (byte)1 },
                    { 248, 76, (byte)1 },
                    { 247, 76, (byte)1 },
                    { 246, 76, (byte)1 },
                    { 245, 76, (byte)1 },
                    { 244, 76, (byte)1 },
                    { 243, 76, (byte)1 },
                    { 242, 75, (byte)1 },
                    { 279, 82, (byte)1 },
                    { 251, 77, (byte)1 },
                    { 240, 75, (byte)1 },
                    { 238, 74, (byte)1 },
                    { 237, 74, (byte)1 },
                    { 236, 73, (byte)1 },
                    { 235, 73, (byte)1 },
                    { 234, 73, (byte)1 },
                    { 233, 73, (byte)1 },
                    { 232, 73, (byte)1 },
                    { 231, 72, (byte)1 },
                    { 230, 72, (byte)1 },
                    { 229, 71, (byte)1 },
                    { 239, 74, (byte)1 },
                    { 252, 78, (byte)1 },
                    { 241, 75, (byte)1 },
                    { 254, 78, (byte)1 },
                    { 253, 78, (byte)1 },
                    { 276, 81, (byte)1 },
                    { 275, 81, (byte)1 },
                    { 274, 80, (byte)1 },
                    { 273, 80, (byte)1 },
                    { 272, 80, (byte)1 },
                    { 271, 80, (byte)1 },
                    { 270, 80, (byte)1 },
                    { 269, 80, (byte)1 },
                    { 268, 79, (byte)1 },
                    { 267, 79, (byte)1 },
                    { 277, 82, (byte)1 },
                    { 265, 79, (byte)1 },
                    { 266, 79, (byte)1 },
                    { 256, 78, (byte)1 },
                    { 257, 78, (byte)1 },
                    { 258, 78, (byte)1 },
                    { 259, 79, (byte)1 },
                    { 255, 78, (byte)1 },
                    { 261, 79, (byte)1 },
                    { 262, 79, (byte)1 },
                    { 263, 79, (byte)1 },
                    { 264, 79, (byte)1 },
                    { 260, 79, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "ProfessionItems",
                columns: new[] { "Id", "ProfessionId", "Quantity" },
                values: new object[,]
                {
                    { 159, 41, (byte)1 },
                    { 151, 39, (byte)1 },
                    { 152, 39, (byte)1 },
                    { 153, 39, (byte)1 },
                    { 154, 39, (byte)1 },
                    { 155, 39, (byte)1 },
                    { 156, 40, (byte)1 },
                    { 150, 38, (byte)1 },
                    { 157, 40, (byte)1 },
                    { 158, 41, (byte)1 },
                    { 160, 41, (byte)1 },
                    { 166, 42, (byte)1 },
                    { 162, 41, (byte)1 },
                    { 163, 41, (byte)1 },
                    { 164, 41, (byte)1 },
                    { 165, 41, (byte)1 },
                    { 167, 42, (byte)1 },
                    { 168, 42, (byte)1 },
                    { 169, 42, (byte)1 },
                    { 170, 42, (byte)1 },
                    { 171, 42, (byte)1 },
                    { 172, 42, (byte)1 },
                    { 149, 38, (byte)1 },
                    { 161, 41, (byte)1 },
                    { 148, 38, (byte)1 },
                    { 108, 29, (byte)1 },
                    { 146, 37, (byte)1 },
                    { 51, 15, (byte)1 },
                    { 50, 15, (byte)1 },
                    { 49, 14, (byte)1 },
                    { 48, 14, (byte)1 },
                    { 47, 14, (byte)1 },
                    { 46, 13, (byte)1 },
                    { 52, 15, (byte)1 },
                    { 45, 13, (byte)1 },
                    { 43, 13, (byte)1 },
                    { 42, 13, (byte)1 },
                    { 41, 13, (byte)1 },
                    { 40, 12, (byte)1 },
                    { 39, 12, (byte)1 },
                    { 38, 12, (byte)1 },
                    { 44, 13, (byte)1 },
                    { 53, 15, (byte)1 },
                    { 54, 15, (byte)1 },
                    { 55, 15, (byte)1 },
                    { 70, 19, (byte)1 },
                    { 69, 19, (byte)1 },
                    { 68, 19, (byte)1 },
                    { 67, 19, (byte)1 },
                    { 66, 19, (byte)1 },
                    { 65, 18, (byte)1 },
                    { 64, 18, (byte)1 },
                    { 63, 18, (byte)1 },
                    { 62, 17, (byte)1 },
                    { 61, 17, (byte)1 },
                    { 60, 17, (byte)1 },
                    { 59, 17, (byte)1 },
                    { 58, 17, (byte)1 },
                    { 57, 16, (byte)1 },
                    { 56, 16, (byte)1 },
                    { 37, 12, (byte)1 },
                    { 71, 19, (byte)1 },
                    { 36, 11, (byte)1 },
                    { 34, 11, (byte)1 },
                    { 13, 5, (byte)1 },
                    { 12, 5, (byte)1 },
                    { 11, 5, (byte)1 },
                    { 10, 4, (byte)1 },
                    { 9, 4, (byte)1 },
                    { 8, 3, (byte)1 },
                    { 14, 6, (byte)1 },
                    { 7, 3, (byte)1 },
                    { 5, 2, (byte)1 },
                    { 4, 2, (byte)1 },
                    { 3, 2, (byte)1 },
                    { 2, 1, (byte)1 },
                    { 1, 1, (byte)1 },
                    { 147, 38, (byte)1 },
                    { 6, 3, (byte)1 },
                    { 15, 6, (byte)1 },
                    { 16, 6, (byte)1 },
                    { 17, 6, (byte)1 },
                    { 33, 11, (byte)1 },
                    { 32, 11, (byte)1 },
                    { 31, 10, (byte)1 },
                    { 30, 10, (byte)1 },
                    { 29, 10, (byte)1 },
                    { 28, 10, (byte)1 },
                    { 27, 10, (byte)1 },
                    { 26, 10, (byte)1 },
                    { 25, 10, (byte)1 },
                    { 24, 9, (byte)1 },
                    { 23, 9, (byte)1 },
                    { 22, 8, (byte)1 },
                    { 21, 8, (byte)1 },
                    { 20, 8, (byte)1 },
                    { 18, 6, (byte)1 },
                    { 35, 11, (byte)1 },
                    { 72, 20, (byte)1 },
                    { 19, 7, (byte)1 },
                    { 74, 20, (byte)1 },
                    { 126, 32, (byte)1 },
                    { 125, 32, (byte)1 },
                    { 124, 32, (byte)1 },
                    { 123, 32, (byte)1 },
                    { 122, 32, (byte)1 },
                    { 121, 32, (byte)1 },
                    { 127, 32, (byte)1 },
                    { 120, 31, (byte)1 },
                    { 118, 31, (byte)1 },
                    { 117, 31, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "ProfessionItems",
                columns: new[] { "Id", "ProfessionId", "Quantity" },
                values: new object[,]
                {
                    { 116, 30, (byte)1 },
                    { 115, 30, (byte)1 },
                    { 114, 30, (byte)1 },
                    { 113, 30, (byte)1 },
                    { 119, 31, (byte)1 },
                    { 128, 32, (byte)1 },
                    { 129, 32, (byte)1 },
                    { 130, 33, (byte)1 },
                    { 145, 37, (byte)1 },
                    { 73, 20, (byte)1 },
                    { 144, 37, (byte)1 },
                    { 143, 37, (byte)1 },
                    { 142, 37, (byte)1 },
                    { 141, 37, (byte)1 },
                    { 140, 36, (byte)1 },
                    { 139, 36, (byte)1 },
                    { 138, 35, (byte)1 },
                    { 137, 35, (byte)1 },
                    { 136, 35, (byte)1 },
                    { 134, 34, (byte)1 },
                    { 133, 34, (byte)1 },
                    { 132, 34, (byte)1 },
                    { 131, 33, (byte)1 },
                    { 112, 30, (byte)1 },
                    { 111, 30, (byte)1 },
                    { 135, 34, (byte)1 },
                    { 109, 29, (byte)1 },
                    { 89, 23, (byte)1 },
                    { 88, 23, (byte)1 },
                    { 87, 23, (byte)1 },
                    { 86, 23, (byte)1 },
                    { 85, 22, (byte)1 },
                    { 84, 22, (byte)1 },
                    { 83, 22, (byte)1 },
                    { 81, 22, (byte)1 },
                    { 80, 21, (byte)1 },
                    { 79, 21, (byte)1 },
                    { 78, 21, (byte)1 },
                    { 77, 20, (byte)1 },
                    { 110, 29, (byte)1 },
                    { 75, 20, (byte)1 },
                    { 76, 20, (byte)1 },
                    { 90, 23, (byte)1 },
                    { 91, 24, (byte)1 },
                    { 82, 22, (byte)1 },
                    { 93, 24, (byte)1 },
                    { 107, 29, (byte)1 },
                    { 92, 24, (byte)1 },
                    { 105, 28, (byte)1 },
                    { 104, 28, (byte)1 },
                    { 106, 29, (byte)1 },
                    { 102, 27, (byte)1 },
                    { 101, 27, (byte)1 },
                    { 100, 26, (byte)1 },
                    { 103, 27, (byte)1 },
                    { 98, 26, (byte)1 },
                    { 97, 25, (byte)1 },
                    { 96, 25, (byte)1 },
                    { 95, 25, (byte)1 },
                    { 99, 26, (byte)1 },
                    { 94, 25, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "ProfessionProfession",
                columns: new[] { "EntranceProfessionId", "OutputProfessionId" },
                values: new object[,]
                {
                    { 79, 90 },
                    { 80, 67 },
                    { 78, 90 },
                    { 78, 99 },
                    { 79, 1 },
                    { 79, 69 },
                    { 75, 21 },
                    { 79, 87 },
                    { 80, 1 },
                    { 79, 67 },
                    { 78, 80 },
                    { 77, 84 },
                    { 77, 104 },
                    { 77, 102 },
                    { 77, 94 },
                    { 77, 24 },
                    { 76, 104 },
                    { 76, 83 },
                    { 76, 71 },
                    { 76, 67 },
                    { 80, 79 },
                    { 75, 31 },
                    { 75, 92 },
                    { 78, 71 },
                    { 80, 96 },
                    { 84, 104 },
                    { 81, 76 },
                    { 87, 79 },
                    { 87, 69 },
                    { 75, 77 },
                    { 87, 63 },
                    { 86, 24 },
                    { 86, 84 },
                    { 86, 77 },
                    { 86, 72 },
                    { 86, 67 },
                    { 85, 103 },
                    { 85, 89 },
                    { 85, 62 },
                    { 84, 94 },
                    { 84, 76 },
                    { 83, 99 },
                    { 83, 89 },
                    { 83, 76 },
                    { 83, 71 },
                    { 82, 111 },
                    { 82, 103 },
                    { 82, 102 },
                    { 82, 84 },
                    { 81, 46 },
                    { 81, 92 },
                    { 81, 77 },
                    { 80, 99 },
                    { 75, 2 },
                    { 67, 104 },
                    { 74, 103 },
                    { 68, 101 },
                    { 68, 81 },
                    { 68, 63 },
                    { 67, 111 },
                    { 67, 23 },
                    { 67, 76 },
                    { 67, 71 },
                    { 66, 89 },
                    { 66, 88 },
                    { 66, 77 },
                    { 66, 73 },
                    { 68, 102 },
                    { 65, 59 },
                    { 65, 91 },
                    { 65, 74 },
                    { 65, 67 },
                    { 64, 57 },
                    { 64, 102 },
                    { 64, 101 },
                    { 64, 95 },
                    { 64, 67 },
                    { 63, 103 },
                    { 87, 90 },
                    { 63, 96 },
                    { 65, 105 },
                    { 74, 108 },
                    { 68, 104 },
                    { 69, 79 },
                    { 74, 81 },
                    { 74, 65 },
                    { 73, 103 },
                    { 73, 102 },
                    { 73, 89 },
                    { 73, 63 },
                    { 72, 93 },
                    { 72, 31 },
                    { 72, 89 },
                    { 72, 86 },
                    { 72, 84 },
                    { 68, 112 },
                    { 71, 98 },
                    { 71, 76 },
                    { 71, 67 },
                    { 70, 104 },
                    { 70, 28 },
                    { 70, 89 },
                    { 70, 10 },
                    { 70, 68 },
                    { 70, 6 },
                    { 69, 113 },
                    { 69, 98 },
                    { 69, 97 },
                    { 71, 90 },
                    { 88, 73 },
                    { 104, 67 },
                    { 88, 89 },
                    { 106, 85 },
                    { 105, 100 },
                    { 105, 99 },
                    { 105, 97 },
                    { 105, 71 },
                    { 105, 69 },
                    { 104, 94 },
                    { 104, 81 },
                    { 104, 76 },
                    { 104, 68 },
                    { 104, 63 },
                    { 106, 101 },
                    { 103, 111 },
                    { 103, 89 },
                    { 103, 82 },
                    { 103, 81 },
                    { 103, 77 },
                    { 102, 98 },
                    { 102, 94 },
                    { 102, 89 },
                    { 102, 83 },
                    { 101, 107 },
                    { 101, 104 },
                    { 101, 102 },
                    { 103, 49 },
                    { 101, 67 },
                    { 106, 103 },
                    { 107, 83 },
                    { 63, 90 },
                    { 113, 97 },
                    { 113, 89 },
                    { 113, 80 },
                    { 113, 78 },
                    { 113, 71 },
                    { 112, 98 },
                    { 112, 97 },
                    { 112, 95 },
                    { 112, 16 },
                    { 112, 69 },
                    { 107, 76 },
                    { 111, 103 },
                    { 111, 67 },
                    { 111, 65 },
                    { 110, 109 },
                    { 108, 103 },
                    { 108, 79 },
                    { 108, 67 },
                    { 108, 65 },
                    { 108, 61 },
                    { 107, 51 },
                    { 107, 94 },
                    { 107, 92 },
                    { 111, 74 },
                    { 88, 86 },
                    { 101, 2 },
                    { 100, 97 },
                    { 94, 83 },
                    { 94, 70 },
                    { 93, 112 },
                    { 93, 105 },
                    { 93, 97 },
                    { 93, 96 },
                    { 93, 68 },
                    { 92, 101 },
                    { 92, 94 },
                    { 92, 83 },
                    { 92, 76 },
                    { 94, 92 },
                    { 91, 56 },
                    { 91, 82 },
                    { 90, 104 },
                    { 90, 28 },
                    { 90, 89 },
                    { 90, 77 },
                    { 90, 71 },
                    { 89, 102 },
                    { 89, 90 },
                    { 89, 77 },
                    { 89, 73 },
                    { 88, 103 },
                    { 91, 94 },
                    { 100, 98 },
                    { 94, 104 },
                    { 95, 83 },
                    { 100, 79 },
                    { 100, 69 },
                    { 100, 8 },
                    { 99, 112 },
                    { 99, 98 },
                    { 99, 97 },
                    { 99, 69 },
                    { 98, 97 },
                    { 98, 16 },
                    { 98, 79 },
                    { 98, 71 },
                    { 95, 71 },
                    { 98, 69 },
                    { 97, 100 },
                    { 97, 96 },
                    { 97, 90 },
                    { 96, 90 },
                    { 96, 87 },
                    { 96, 80 },
                    { 96, 63 },
                    { 96, 1 },
                    { 95, 112 },
                    { 95, 97 },
                    { 95, 28 },
                    { 97, 112 },
                    { 63, 73 },
                    { 59, 105 },
                    { 62, 84 },
                    { 20, 37 },
                    { 20, 99 },
                    { 20, 113 },
                    { 21, 75 },
                    { 21, 77 },
                    { 21, 24 },
                    { 21, 92 },
                    { 21, 27 },
                    { 21, 28 },
                    { 21, 36 },
                    { 22, 2 },
                    { 22, 33 },
                    { 22, 95 },
                    { 22, 42 },
                    { 22, 104 },
                    { 22, 56 },
                    { 22, 59 },
                    { 20, 23 },
                    { 20, 80 },
                    { 19, 59 },
                    { 19, 113 },
                    { 16, 101 },
                    { 16, 56 },
                    { 17, 20 },
                    { 17, 23 },
                    { 17, 97 },
                    { 17, 48 },
                    { 17, 105 },
                    { 18, 2 },
                    { 23, 2 },
                    { 18, 19 },
                    { 18, 51 },
                    { 18, 113 },
                    { 19, 13 },
                    { 19, 20 },
                    { 19, 42 },
                    { 19, 99 },
                    { 19, 50 },
                    { 19, 52 },
                    { 18, 24 },
                    { 16, 39 },
                    { 23, 20 },
                    { 23, 97 },
                    { 27, 70 },
                    { 27, 16 },
                    { 27, 81 },
                    { 27, 57 },
                    { 28, 2 },
                    { 28, 67 },
                    { 28, 8 },
                    { 28, 16 },
                    { 28, 101 },
                    { 28, 104 },
                    { 29, 92 },
                    { 29, 44 },
                    { 29, 107 },
                    { 29, 56 },
                    { 29, 57 },
                    { 30, 70 },
                    { 30, 41 },
                    { 27, 10 },
                    { 26, 94 },
                    { 26, 91 },
                    { 26, 25 },
                    { 23, 48 },
                    { 23, 105 },
                    { 24, 2 },
                    { 24, 86 },
                    { 24, 23 },
                    { 24, 30 },
                    { 24, 97 },
                    { 24, 42 },
                    { 23, 25 },
                    { 24, 56 },
                    { 25, 23 },
                    { 25, 91 },
                    { 25, 94 },
                    { 25, 37 },
                    { 25, 43 },
                    { 25, 55 },
                    { 26, 11 },
                    { 26, 23 },
                    { 25, 20 },
                    { 16, 67 },
                    { 16, 6 },
                    { 16, 2 },
                    { 4, 39 },
                    { 4, 47 },
                    { 4, 104 },
                    { 4, 50 },
                    { 5, 31 },
                    { 5, 36 },
                    { 5, 39 },
                    { 5, 101 },
                    { 5, 102 },
                    { 5, 50 },
                    { 5, 51 },
                    { 6, 64 },
                    { 6, 16 },
                    { 6, 101 },
                    { 6, 51 },
                    { 6, 56 },
                    { 7, 82 },
                    { 4, 36 },
                    { 4, 34 },
                    { 4, 24 },
                    { 4, 8 },
                    { 62, 89 },
                    { 1, 7 },
                    { 1, 67 },
                    { 1, 8 },
                    { 1, 74 },
                    { 1, 38 },
                    { 1, 111 },
                    { 2, 67 },
                    { 7, 91 },
                    { 2, 95 },
                    { 2, 51 },
                    { 2, 56 },
                    { 3, 11 },
                    { 3, 23 },
                    { 3, 97 },
                    { 3, 105 },
                    { 3, 58 },
                    { 4, 2 },
                    { 2, 105 },
                    { 7, 29 },
                    { 7, 36 },
                    { 7, 51 },
                    { 12, 105 },
                    { 12, 113 },
                    { 13, 72 },
                    { 13, 23 },
                    { 13, 31 },
                    { 13, 48 },
                    { 13, 50 },
                    { 13, 113 },
                    { 12, 48 },
                    { 14, 1 },
                    { 14, 101 },
                    { 14, 49 },
                    { 14, 51 },
                    { 15, 80 },
                    { 15, 92 },
                    { 15, 44 },
                    { 15, 48 },
                    { 15, 56 },
                    { 14, 2 },
                    { 30, 52 },
                    { 12, 44 },
                    { 11, 54 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 65 },
                    { 8, 28 },
                    { 8, 111 },
                    { 9, 88 },
                    { 9, 31 },
                    { 9, 34 },
                    { 12, 15 },
                    { 9, 58 },
                    { 10, 2 },
                    { 10, 96 },
                    { 10, 97 },
                    { 10, 46 },
                    { 10, 105 },
                    { 11, 20 },
                    { 11, 23 },
                    { 11, 105 },
                    { 9, 60 },
                    { 30, 53 },
                    { 11, 37 },
                    { 30, 59 },
                    { 50, 19 },
                    { 50, 51 },
                    { 50, 113 },
                    { 51, 6 },
                    { 51, 18 },
                    { 51, 47 },
                    { 51, 111 },
                    { 51, 56 },
                    { 51, 113 },
                    { 52, 19 },
                    { 52, 32 },
                    { 52, 105 },
                    { 52, 51 },
                    { 52, 113 },
                    { 53, 2 },
                    { 53, 22 },
                    { 53, 31 },
                    { 50, 18 },
                    { 50, 13 },
                    { 49, 106 },
                    { 49, 103 },
                    { 46, 68 },
                    { 46, 10 },
                    { 46, 16 },
                    { 46, 93 },
                    { 46, 104 },
                    { 46, 57 },
                    { 47, 5 },
                    { 47, 92 },
                    { 53, 33 },
                    { 47, 29 },
                    { 47, 107 },
                    { 48, 11 },
                    { 48, 12 },
                    { 48, 15 },
                    { 48, 31 },
                    { 48, 97 },
                    { 48, 105 },
                    { 49, 38 },
                    { 47, 31 },
                    { 45, 112 },
                    { 53, 95 },
                    { 53, 113 },
                    { 58, 88 },
                    { 58, 31 },
                    { 58, 60 },
                    { 59, 23 },
                    { 59, 32 },
                    { 59, 97 },
                    { 59, 40 },
                    { 59, 51 },
                    { 60, 2 },
                    { 60, 66 },
                    { 60, 26 },
                    { 60, 31 },
                    { 60, 97 },
                    { 61, 79 },
                    { 61, 103 },
                    { 30, 113 },
                    { 61, 104 },
                    { 58, 16 },
                    { 58, 66 },
                    { 57, 103 },
                    { 57, 49 },
                    { 54, 110 },
                    { 55, 22 },
                    { 55, 24 },
                    { 55, 31 },
                    { 55, 94 },
                    { 55, 37 },
                    { 55, 104 },
                    { 56, 6 },
                    { 53, 41 },
                    { 56, 15 },
                    { 56, 101 },
                    { 56, 107 },
                    { 57, 1 },
                    { 57, 7 },
                    { 57, 72 },
                    { 57, 82 },
                    { 57, 28 },
                    { 57, 35 },
                    { 56, 92 },
                    { 45, 37 },
                    { 56, 16 },
                    { 45, 25 },
                    { 35, 77 },
                    { 35, 101 },
                    { 35, 51 },
                    { 35, 58 },
                    { 35, 57 },
                    { 36, 8 },
                    { 36, 72 },
                    { 36, 77 },
                    { 36, 86 },
                    { 36, 24 },
                    { 36, 35 },
                    { 37, 11 },
                    { 37, 26 },
                    { 37, 94 },
                    { 37, 56 },
                    { 37, 112 },
                    { 38, 1 },
                    { 35, 16 },
                    { 34, 60 },
                    { 34, 58 },
                    { 34, 24 },
                    { 31, 92 },
                    { 45, 95 },
                    { 31, 33 },
                    { 31, 101 },
                    { 31, 48 },
                    { 31, 56 },
                    { 31, 58 },
                    { 32, 23 },
                    { 38, 88 },
                    { 32, 95 },
                    { 32, 53 },
                    { 32, 113 },
                    { 33, 9 },
                    { 33, 31 },
                    { 33, 95 },
                    { 33, 41 },
                    { 34, 77 },
                    { 34, 88 },
                    { 32, 41 },
                    { 38, 28 },
                    { 33, 58 },
                    { 38, 103 },
                    { 42, 20 },
                    { 42, 80 },
                    { 42, 23 },
                    { 42, 51 },
                    { 42, 113 },
                    { 43, 25 },
                    { 43, 91 },
                    { 43, 40 },
                    { 41, 113 },
                    { 43, 44 },
                    { 44, 29 },
                    { 44, 43 },
                    { 44, 47 },
                    { 44, 48 },
                    { 44, 107 },
                    { 38, 49 },
                    { 44, 56 },
                    { 45, 16 },
                    { 43, 55 },
                    { 41, 97 },
                    { 31, 9 },
                    { 41, 32 },
                    { 41, 95 },
                    { 39, 75 },
                    { 39, 21 },
                    { 39, 27 },
                    { 39, 28 },
                    { 39, 30 },
                    { 39, 102 },
                    { 39, 56 },
                    { 40, 23 },
                    { 40, 94 },
                    { 39, 5 },
                    { 40, 36 },
                    { 40, 97 },
                    { 40, 41 },
                    { 40, 59 },
                    { 41, 2 },
                    { 41, 22 },
                    { 41, 30 }
                });

            migrationBuilder.InsertData(
                table: "ProfessionSkills",
                columns: new[] { "Id", "ProfessionId", "Quantity" },
                values: new object[,]
                {
                    { 739, 85, (byte)1 },
                    { 725, 84, (byte)1 },
                    { 724, 84, (byte)1 },
                    { 723, 84, (byte)1 },
                    { 720, 84, (byte)1 },
                    { 721, 84, (byte)1 },
                    { 726, 84, (byte)1 },
                    { 719, 84, (byte)1 },
                    { 718, 84, (byte)1 },
                    { 722, 84, (byte)1 },
                    { 727, 84, (byte)1 },
                    { 730, 85, (byte)1 },
                    { 729, 85, (byte)1 },
                    { 738, 85, (byte)1 },
                    { 731, 85, (byte)1 },
                    { 741, 85, (byte)1 },
                    { 732, 85, (byte)1 },
                    { 733, 85, (byte)1 },
                    { 734, 85, (byte)1 },
                    { 717, 84, (byte)1 },
                    { 736, 85, (byte)1 },
                    { 737, 85, (byte)1 },
                    { 740, 85, (byte)1 },
                    { 728, 84, (byte)1 },
                    { 735, 85, (byte)1 },
                    { 708, 83, (byte)1 },
                    { 715, 83, (byte)1 },
                    { 742, 85, (byte)1 },
                    { 689, 81, (byte)1 },
                    { 691, 82, (byte)1 },
                    { 690, 81, (byte)1 },
                    { 692, 82, (byte)1 },
                    { 693, 82, (byte)1 },
                    { 694, 82, (byte)1 },
                    { 695, 82, (byte)1 },
                    { 696, 82, (byte)1 },
                    { 697, 82, (byte)1 },
                    { 699, 83, (byte)1 },
                    { 700, 83, (byte)1 },
                    { 701, 83, (byte)1 },
                    { 702, 83, (byte)1 },
                    { 703, 83, (byte)1 },
                    { 704, 83, (byte)1 },
                    { 705, 83, (byte)1 },
                    { 706, 83, (byte)1 },
                    { 707, 83, (byte)1 },
                    { 709, 83, (byte)1 },
                    { 710, 83, (byte)1 },
                    { 711, 83, (byte)1 },
                    { 712, 83, (byte)1 },
                    { 713, 83, (byte)1 },
                    { 714, 83, (byte)1 },
                    { 716, 84, (byte)1 },
                    { 698, 82, (byte)1 },
                    { 782, 89, (byte)1 },
                    { 744, 86, (byte)1 },
                    { 774, 88, (byte)1 },
                    { 775, 88, (byte)1 },
                    { 776, 88, (byte)1 },
                    { 777, 89, (byte)1 },
                    { 778, 89, (byte)1 },
                    { 779, 89, (byte)1 },
                    { 780, 89, (byte)1 },
                    { 781, 89, (byte)1 },
                    { 783, 89, (byte)1 },
                    { 784, 89, (byte)1 },
                    { 785, 89, (byte)1 },
                    { 773, 88, (byte)1 },
                    { 786, 89, (byte)1 },
                    { 788, 89, (byte)1 },
                    { 789, 89, (byte)1 },
                    { 790, 89, (byte)1 },
                    { 791, 89, (byte)1 },
                    { 792, 89, (byte)1 },
                    { 793, 89, (byte)1 },
                    { 794, 89, (byte)1 },
                    { 795, 89, (byte)1 },
                    { 796, 89, (byte)1 },
                    { 688, 81, (byte)1 },
                    { 797, 89, (byte)1 },
                    { 787, 89, (byte)1 },
                    { 772, 88, (byte)1 },
                    { 771, 88, (byte)1 },
                    { 770, 88, (byte)1 },
                    { 745, 86, (byte)1 },
                    { 746, 86, (byte)1 },
                    { 747, 86, (byte)1 },
                    { 748, 86, (byte)1 },
                    { 749, 86, (byte)1 },
                    { 750, 86, (byte)1 },
                    { 751, 86, (byte)1 },
                    { 752, 86, (byte)1 },
                    { 753, 87, (byte)1 },
                    { 754, 87, (byte)1 },
                    { 755, 87, (byte)1 },
                    { 756, 87, (byte)1 },
                    { 757, 87, (byte)1 },
                    { 758, 87, (byte)1 },
                    { 759, 87, (byte)1 },
                    { 760, 87, (byte)1 },
                    { 761, 87, (byte)1 },
                    { 762, 87, (byte)1 },
                    { 763, 87, (byte)1 },
                    { 764, 87, (byte)1 },
                    { 765, 87, (byte)1 },
                    { 766, 87, (byte)1 },
                    { 767, 87, (byte)1 },
                    { 768, 88, (byte)1 },
                    { 769, 88, (byte)1 },
                    { 743, 86, (byte)1 },
                    { 687, 81, (byte)1 },
                    { 603, 74, (byte)1 },
                    { 685, 81, (byte)1 },
                    { 604, 75, (byte)1 },
                    { 605, 75, (byte)1 },
                    { 606, 75, (byte)1 },
                    { 607, 75, (byte)1 },
                    { 608, 75, (byte)1 },
                    { 609, 75, (byte)1 },
                    { 610, 75, (byte)1 },
                    { 611, 75, (byte)1 },
                    { 612, 75, (byte)1 },
                    { 613, 75, (byte)1 },
                    { 614, 75, (byte)1 },
                    { 602, 74, (byte)1 },
                    { 615, 76, (byte)1 },
                    { 617, 76, (byte)1 },
                    { 618, 76, (byte)1 },
                    { 619, 76, (byte)1 },
                    { 620, 76, (byte)1 },
                    { 621, 76, (byte)1 },
                    { 622, 76, (byte)1 },
                    { 623, 76, (byte)1 },
                    { 624, 76, (byte)1 },
                    { 625, 76, (byte)1 },
                    { 626, 76, (byte)1 },
                    { 627, 77, (byte)1 },
                    { 616, 76, (byte)1 },
                    { 628, 77, (byte)1 },
                    { 601, 74, (byte)1 },
                    { 599, 74, (byte)1 },
                    { 798, 90, (byte)1 },
                    { 576, 73, (byte)1 },
                    { 577, 73, (byte)1 },
                    { 578, 73, (byte)1 },
                    { 579, 73, (byte)1 },
                    { 580, 73, (byte)1 },
                    { 581, 73, (byte)1 },
                    { 582, 73, (byte)1 },
                    { 583, 73, (byte)1 },
                    { 584, 73, (byte)1 },
                    { 585, 73, (byte)1 },
                    { 600, 74, (byte)1 },
                    { 586, 73, (byte)1 },
                    { 588, 73, (byte)1 },
                    { 589, 74, (byte)1 },
                    { 590, 74, (byte)1 },
                    { 591, 74, (byte)1 },
                    { 592, 74, (byte)1 },
                    { 593, 74, (byte)1 },
                    { 594, 74, (byte)1 },
                    { 595, 74, (byte)1 },
                    { 596, 74, (byte)1 },
                    { 597, 74, (byte)1 },
                    { 598, 74, (byte)1 },
                    { 587, 73, (byte)1 },
                    { 629, 77, (byte)1 },
                    { 630, 77, (byte)1 },
                    { 631, 77, (byte)1 },
                    { 661, 79, (byte)1 },
                    { 662, 79, (byte)1 },
                    { 663, 79, (byte)1 },
                    { 664, 79, (byte)1 },
                    { 665, 79, (byte)1 },
                    { 666, 80, (byte)1 },
                    { 667, 80, (byte)1 },
                    { 668, 80, (byte)1 },
                    { 669, 80, (byte)1 },
                    { 670, 80, (byte)1 },
                    { 671, 80, (byte)1 },
                    { 660, 79, (byte)1 },
                    { 672, 80, (byte)1 },
                    { 674, 80, (byte)1 },
                    { 675, 80, (byte)1 },
                    { 676, 80, (byte)1 },
                    { 677, 81, (byte)1 },
                    { 678, 81, (byte)1 },
                    { 679, 81, (byte)1 },
                    { 680, 81, (byte)1 },
                    { 681, 81, (byte)1 },
                    { 682, 81, (byte)1 },
                    { 683, 81, (byte)1 },
                    { 684, 81, (byte)1 },
                    { 673, 80, (byte)1 },
                    { 659, 79, (byte)1 },
                    { 658, 79, (byte)1 },
                    { 657, 79, (byte)1 },
                    { 632, 77, (byte)1 },
                    { 633, 77, (byte)1 },
                    { 634, 77, (byte)1 },
                    { 635, 77, (byte)1 },
                    { 636, 77, (byte)1 },
                    { 637, 77, (byte)1 },
                    { 638, 77, (byte)1 },
                    { 639, 77, (byte)1 },
                    { 640, 78, (byte)1 },
                    { 641, 78, (byte)1 },
                    { 642, 78, (byte)1 },
                    { 643, 78, (byte)1 },
                    { 644, 78, (byte)1 },
                    { 645, 78, (byte)1 },
                    { 646, 78, (byte)1 },
                    { 647, 78, (byte)1 },
                    { 648, 78, (byte)1 },
                    { 649, 78, (byte)1 },
                    { 650, 78, (byte)1 },
                    { 651, 78, (byte)1 },
                    { 652, 78, (byte)1 },
                    { 653, 79, (byte)1 },
                    { 654, 79, (byte)1 },
                    { 655, 79, (byte)1 },
                    { 656, 79, (byte)1 },
                    { 686, 81, (byte)1 },
                    { 799, 90, (byte)1 },
                    { 971, 108, (byte)1 },
                    { 801, 90, (byte)1 },
                    { 944, 106, (byte)1 },
                    { 945, 106, (byte)1 },
                    { 946, 106, (byte)1 },
                    { 947, 106, (byte)1 },
                    { 948, 106, (byte)1 },
                    { 949, 106, (byte)1 },
                    { 950, 106, (byte)1 },
                    { 951, 106, (byte)1 },
                    { 952, 106, (byte)1 },
                    { 953, 106, (byte)1 },
                    { 954, 106, (byte)1 },
                    { 943, 105, (byte)1 },
                    { 955, 106, (byte)1 },
                    { 957, 107, (byte)1 },
                    { 958, 107, (byte)1 },
                    { 959, 107, (byte)1 },
                    { 960, 107, (byte)1 },
                    { 961, 107, (byte)1 },
                    { 962, 107, (byte)1 },
                    { 963, 107, (byte)1 },
                    { 964, 107, (byte)1 },
                    { 965, 107, (byte)1 },
                    { 966, 107, (byte)1 },
                    { 967, 107, (byte)1 },
                    { 956, 106, (byte)1 },
                    { 968, 108, (byte)1 },
                    { 942, 105, (byte)1 },
                    { 940, 105, (byte)1 },
                    { 916, 103, (byte)1 },
                    { 917, 103, (byte)1 },
                    { 918, 103, (byte)1 },
                    { 919, 103, (byte)1 },
                    { 920, 103, (byte)1 },
                    { 921, 103, (byte)1 },
                    { 922, 103, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "ProfessionSkills",
                columns: new[] { "Id", "ProfessionId", "Quantity" },
                values: new object[,]
                {
                    { 923, 104, (byte)1 },
                    { 924, 104, (byte)1 },
                    { 925, 104, (byte)1 },
                    { 926, 104, (byte)1 },
                    { 941, 105, (byte)1 },
                    { 927, 104, (byte)1 },
                    { 929, 104, (byte)1 },
                    { 930, 104, (byte)1 },
                    { 931, 104, (byte)1 },
                    { 932, 104, (byte)1 },
                    { 933, 104, (byte)1 },
                    { 934, 104, (byte)1 },
                    { 935, 104, (byte)1 },
                    { 936, 105, (byte)1 },
                    { 937, 105, (byte)1 },
                    { 938, 105, (byte)1 },
                    { 939, 105, (byte)1 },
                    { 928, 104, (byte)1 },
                    { 969, 108, (byte)1 },
                    { 970, 108, (byte)1 },
                    { 972, 108, (byte)1 },
                    { 1002, 111, (byte)1 },
                    { 1003, 112, (byte)1 },
                    { 1004, 112, (byte)1 },
                    { 1005, 112, (byte)1 },
                    { 1006, 112, (byte)1 },
                    { 1007, 112, (byte)1 },
                    { 1008, 112, (byte)1 },
                    { 1009, 112, (byte)1 },
                    { 1010, 113, (byte)1 },
                    { 1011, 113, (byte)1 },
                    { 1012, 113, (byte)1 },
                    { 1001, 111, (byte)1 },
                    { 1013, 113, (byte)1 },
                    { 1015, 113, (byte)1 },
                    { 1016, 113, (byte)1 },
                    { 1017, 113, (byte)1 },
                    { 1018, 113, (byte)1 },
                    { 1019, 113, (byte)1 },
                    { 1020, 113, (byte)1 },
                    { 1021, 113, (byte)1 },
                    { 1022, 113, (byte)1 },
                    { 1023, 113, (byte)1 },
                    { 1024, 113, (byte)1 },
                    { 575, 73, (byte)1 },
                    { 1014, 113, (byte)1 },
                    { 1000, 111, (byte)1 },
                    { 999, 111, (byte)1 },
                    { 998, 111, (byte)1 },
                    { 973, 108, (byte)1 },
                    { 974, 108, (byte)1 },
                    { 975, 108, (byte)1 },
                    { 976, 108, (byte)1 },
                    { 977, 108, (byte)1 },
                    { 978, 108, (byte)1 },
                    { 979, 108, (byte)1 },
                    { 980, 108, (byte)1 },
                    { 981, 108, (byte)1 },
                    { 982, 109, (byte)1 },
                    { 983, 109, (byte)1 },
                    { 984, 109, (byte)1 },
                    { 985, 109, (byte)1 },
                    { 986, 109, (byte)1 },
                    { 987, 109, (byte)1 },
                    { 988, 110, (byte)1 },
                    { 989, 110, (byte)1 },
                    { 990, 110, (byte)1 },
                    { 991, 110, (byte)1 },
                    { 992, 110, (byte)1 },
                    { 993, 111, (byte)1 },
                    { 994, 111, (byte)1 },
                    { 995, 111, (byte)1 },
                    { 996, 111, (byte)1 },
                    { 997, 111, (byte)1 },
                    { 915, 103, (byte)1 },
                    { 914, 103, (byte)1 },
                    { 913, 103, (byte)1 },
                    { 912, 103, (byte)1 },
                    { 831, 94, (byte)1 },
                    { 832, 94, (byte)1 },
                    { 833, 94, (byte)1 },
                    { 834, 94, (byte)1 },
                    { 835, 94, (byte)1 },
                    { 836, 94, (byte)1 },
                    { 837, 95, (byte)1 },
                    { 838, 95, (byte)1 },
                    { 839, 95, (byte)1 },
                    { 840, 95, (byte)1 },
                    { 841, 95, (byte)1 },
                    { 830, 94, (byte)1 },
                    { 842, 95, (byte)1 },
                    { 844, 95, (byte)1 },
                    { 845, 96, (byte)1 },
                    { 846, 96, (byte)1 },
                    { 847, 96, (byte)1 },
                    { 848, 96, (byte)1 },
                    { 849, 96, (byte)1 },
                    { 850, 96, (byte)1 },
                    { 851, 96, (byte)1 },
                    { 852, 96, (byte)1 },
                    { 853, 97, (byte)1 },
                    { 854, 97, (byte)1 },
                    { 843, 95, (byte)1 },
                    { 829, 94, (byte)1 },
                    { 828, 94, (byte)1 },
                    { 827, 93, (byte)1 },
                    { 802, 90, (byte)1 },
                    { 803, 90, (byte)1 },
                    { 804, 90, (byte)1 },
                    { 805, 90, (byte)1 },
                    { 806, 90, (byte)1 },
                    { 807, 90, (byte)1 },
                    { 808, 90, (byte)1 },
                    { 809, 90, (byte)1 },
                    { 810, 91, (byte)1 },
                    { 811, 91, (byte)1 },
                    { 812, 91, (byte)1 },
                    { 813, 91, (byte)1 },
                    { 814, 91, (byte)1 },
                    { 815, 92, (byte)1 },
                    { 816, 92, (byte)1 },
                    { 817, 92, (byte)1 },
                    { 818, 92, (byte)1 },
                    { 819, 92, (byte)1 },
                    { 820, 92, (byte)1 },
                    { 821, 92, (byte)1 },
                    { 822, 93, (byte)1 },
                    { 823, 93, (byte)1 },
                    { 824, 93, (byte)1 },
                    { 825, 93, (byte)1 },
                    { 826, 93, (byte)1 },
                    { 855, 97, (byte)1 },
                    { 800, 90, (byte)1 },
                    { 856, 97, (byte)1 },
                    { 858, 97, (byte)1 },
                    { 888, 101, (byte)1 },
                    { 889, 101, (byte)1 },
                    { 890, 101, (byte)1 },
                    { 891, 101, (byte)1 },
                    { 892, 101, (byte)1 },
                    { 893, 101, (byte)1 },
                    { 894, 102, (byte)1 },
                    { 895, 102, (byte)1 },
                    { 896, 102, (byte)1 },
                    { 897, 102, (byte)1 },
                    { 898, 102, (byte)1 },
                    { 887, 101, (byte)1 },
                    { 899, 102, (byte)1 },
                    { 901, 102, (byte)1 },
                    { 902, 102, (byte)1 },
                    { 903, 102, (byte)1 },
                    { 904, 102, (byte)1 },
                    { 905, 102, (byte)1 },
                    { 906, 102, (byte)1 },
                    { 907, 102, (byte)1 },
                    { 908, 102, (byte)1 },
                    { 909, 102, (byte)1 },
                    { 910, 103, (byte)1 },
                    { 911, 103, (byte)1 },
                    { 900, 102, (byte)1 },
                    { 886, 101, (byte)1 },
                    { 885, 101, (byte)1 },
                    { 884, 101, (byte)1 },
                    { 859, 97, (byte)1 },
                    { 860, 97, (byte)1 },
                    { 861, 97, (byte)1 },
                    { 862, 97, (byte)1 },
                    { 863, 97, (byte)1 },
                    { 864, 98, (byte)1 },
                    { 865, 98, (byte)1 },
                    { 866, 98, (byte)1 },
                    { 867, 98, (byte)1 },
                    { 868, 98, (byte)1 },
                    { 869, 98, (byte)1 },
                    { 870, 98, (byte)1 },
                    { 871, 98, (byte)1 },
                    { 872, 98, (byte)1 },
                    { 873, 99, (byte)1 },
                    { 874, 99, (byte)1 },
                    { 875, 99, (byte)1 },
                    { 876, 99, (byte)1 },
                    { 877, 99, (byte)1 },
                    { 878, 99, (byte)1 },
                    { 879, 100, (byte)1 },
                    { 880, 100, (byte)1 },
                    { 881, 101, (byte)1 },
                    { 882, 101, (byte)1 },
                    { 883, 101, (byte)1 },
                    { 857, 97, (byte)1 },
                    { 574, 72, (byte)1 },
                    { 62, 8, (byte)1 },
                    { 572, 72, (byte)1 },
                    { 182, 25, (byte)1 },
                    { 183, 25, (byte)1 },
                    { 184, 25, (byte)1 },
                    { 185, 26, (byte)1 },
                    { 186, 26, (byte)1 },
                    { 187, 26, (byte)1 },
                    { 188, 26, (byte)1 },
                    { 189, 26, (byte)1 },
                    { 190, 27, (byte)1 },
                    { 191, 27, (byte)1 },
                    { 192, 27, (byte)1 },
                    { 193, 27, (byte)1 },
                    { 194, 27, (byte)1 },
                    { 195, 27, (byte)1 },
                    { 196, 27, (byte)1 },
                    { 197, 27, (byte)1 },
                    { 198, 28, (byte)1 },
                    { 212, 29, (byte)1 },
                    { 211, 29, (byte)1 },
                    { 210, 29, (byte)1 },
                    { 209, 29, (byte)1 },
                    { 208, 29, (byte)1 },
                    { 207, 29, (byte)1 },
                    { 181, 25, (byte)1 },
                    { 206, 29, (byte)1 },
                    { 204, 28, (byte)1 },
                    { 203, 28, (byte)1 },
                    { 202, 28, (byte)1 },
                    { 201, 28, (byte)1 },
                    { 200, 28, (byte)1 },
                    { 199, 28, (byte)1 },
                    { 205, 28, (byte)1 },
                    { 180, 24, (byte)1 },
                    { 179, 24, (byte)1 },
                    { 178, 24, (byte)1 },
                    { 159, 22, (byte)1 },
                    { 158, 22, (byte)1 },
                    { 157, 21, (byte)1 },
                    { 156, 21, (byte)1 },
                    { 155, 21, (byte)1 },
                    { 154, 21, (byte)1 },
                    { 160, 22, (byte)1 },
                    { 153, 21, (byte)1 },
                    { 151, 21, (byte)1 },
                    { 150, 21, (byte)1 },
                    { 149, 21, (byte)1 },
                    { 148, 20, (byte)1 },
                    { 147, 20, (byte)1 },
                    { 146, 20, (byte)1 },
                    { 152, 21, (byte)1 },
                    { 213, 30, (byte)1 },
                    { 161, 22, (byte)1 },
                    { 163, 22, (byte)1 },
                    { 177, 24, (byte)1 },
                    { 176, 24, (byte)1 },
                    { 175, 24, (byte)1 },
                    { 174, 24, (byte)1 },
                    { 173, 24, (byte)1 },
                    { 172, 23, (byte)1 },
                    { 162, 22, (byte)1 },
                    { 171, 23, (byte)1 },
                    { 169, 23, (byte)1 },
                    { 168, 23, (byte)1 },
                    { 167, 23, (byte)1 },
                    { 166, 23, (byte)1 },
                    { 165, 23, (byte)1 },
                    { 164, 22, (byte)1 },
                    { 170, 23, (byte)1 },
                    { 214, 30, (byte)1 },
                    { 215, 30, (byte)1 },
                    { 216, 30, (byte)1 },
                    { 266, 35, (byte)1 },
                    { 265, 35, (byte)1 },
                    { 264, 35, (byte)1 },
                    { 263, 35, (byte)1 },
                    { 262, 35, (byte)1 },
                    { 261, 35, (byte)1 },
                    { 267, 36, (byte)1 },
                    { 260, 35, (byte)1 },
                    { 258, 35, (byte)1 },
                    { 257, 35, (byte)1 },
                    { 256, 34, (byte)1 },
                    { 255, 34, (byte)1 },
                    { 254, 34, (byte)1 },
                    { 253, 34, (byte)1 },
                    { 259, 35, (byte)1 },
                    { 252, 34, (byte)1 },
                    { 268, 36, (byte)1 },
                    { 270, 36, (byte)1 },
                    { 284, 38, (byte)1 },
                    { 283, 38, (byte)1 },
                    { 282, 38, (byte)1 },
                    { 281, 38, (byte)1 },
                    { 280, 38, (byte)1 },
                    { 573, 72, (byte)1 },
                    { 269, 36, (byte)1 },
                    { 278, 37, (byte)1 },
                    { 276, 37, (byte)1 },
                    { 275, 37, (byte)1 },
                    { 274, 36, (byte)1 },
                    { 273, 36, (byte)1 },
                    { 272, 36, (byte)1 },
                    { 271, 36, (byte)1 },
                    { 277, 37, (byte)1 },
                    { 145, 20, (byte)1 },
                    { 251, 34, (byte)1 },
                    { 249, 34, (byte)1 },
                    { 230, 31, (byte)1 },
                    { 229, 31, (byte)1 },
                    { 228, 31, (byte)1 },
                    { 227, 31, (byte)1 },
                    { 226, 31, (byte)1 },
                    { 225, 31, (byte)1 },
                    { 231, 31, (byte)1 },
                    { 224, 31, (byte)1 },
                    { 222, 31, (byte)1 },
                    { 221, 30, (byte)1 },
                    { 220, 30, (byte)1 },
                    { 219, 30, (byte)1 },
                    { 218, 30, (byte)1 },
                    { 217, 30, (byte)1 },
                    { 223, 31, (byte)1 },
                    { 250, 34, (byte)1 },
                    { 232, 32, (byte)1 },
                    { 234, 32, (byte)1 },
                    { 248, 34, (byte)1 },
                    { 247, 33, (byte)1 },
                    { 246, 33, (byte)1 },
                    { 245, 33, (byte)1 },
                    { 244, 33, (byte)1 },
                    { 243, 33, (byte)1 },
                    { 233, 32, (byte)1 },
                    { 242, 33, (byte)1 },
                    { 240, 33, (byte)1 },
                    { 239, 32, (byte)1 },
                    { 238, 32, (byte)1 },
                    { 237, 32, (byte)1 },
                    { 236, 32, (byte)1 },
                    { 235, 32, (byte)1 },
                    { 241, 33, (byte)1 },
                    { 285, 38, (byte)1 },
                    { 144, 20, (byte)1 },
                    { 142, 20, (byte)1 },
                    { 38, 5, (byte)1 },
                    { 39, 5, (byte)1 },
                    { 40, 5, (byte)1 },
                    { 41, 5, (byte)1 },
                    { 42, 6, (byte)1 },
                    { 43, 6, (byte)1 },
                    { 44, 6, (byte)1 },
                    { 45, 6, (byte)1 },
                    { 46, 6, (byte)1 },
                    { 47, 6, (byte)1 },
                    { 48, 6, (byte)1 },
                    { 49, 6, (byte)2 },
                    { 50, 7, (byte)1 },
                    { 51, 7, (byte)1 },
                    { 52, 7, (byte)1 },
                    { 53, 7, (byte)1 },
                    { 54, 7, (byte)1 },
                    { 69, 9, (byte)1 },
                    { 68, 9, (byte)1 },
                    { 67, 9, (byte)1 },
                    { 66, 9, (byte)1 },
                    { 65, 9, (byte)1 },
                    { 64, 9, (byte)1 },
                    { 37, 5, (byte)1 },
                    { 63, 9, (byte)1 },
                    { 60, 8, (byte)1 },
                    { 59, 8, (byte)1 },
                    { 58, 8, (byte)1 },
                    { 57, 7, (byte)1 },
                    { 56, 7, (byte)1 },
                    { 55, 7, (byte)1 },
                    { 61, 8, (byte)1 },
                    { 36, 5, (byte)1 },
                    { 35, 5, (byte)1 },
                    { 34, 5, (byte)1 },
                    { 15, 2, (byte)1 },
                    { 14, 2, (byte)1 },
                    { 13, 2, (byte)1 },
                    { 12, 2, (byte)1 },
                    { 11, 2, (byte)1 },
                    { 10, 2, (byte)1 },
                    { 16, 2, (byte)1 },
                    { 9, 2, (byte)1 },
                    { 7, 1, (byte)1 },
                    { 6, 1, (byte)1 },
                    { 5, 1, (byte)1 },
                    { 4, 1, (byte)1 },
                    { 3, 1, (byte)1 },
                    { 2, 1, (byte)1 },
                    { 8, 1, (byte)1 },
                    { 70, 9, (byte)1 },
                    { 17, 2, (byte)1 },
                    { 19, 3, (byte)1 },
                    { 33, 5, (byte)1 },
                    { 32, 4, (byte)1 },
                    { 31, 4, (byte)1 },
                    { 30, 4, (byte)1 },
                    { 29, 4, (byte)1 },
                    { 28, 4, (byte)1 },
                    { 18, 3, (byte)1 },
                    { 27, 4, (byte)1 },
                    { 25, 4, (byte)1 },
                    { 24, 4, (byte)1 },
                    { 23, 3, (byte)1 },
                    { 22, 3, (byte)1 },
                    { 21, 3, (byte)1 },
                    { 20, 3, (byte)1 },
                    { 26, 4, (byte)1 },
                    { 71, 9, (byte)1 },
                    { 72, 10, (byte)1 },
                    { 73, 10, (byte)1 },
                    { 123, 17, (byte)1 },
                    { 122, 17, (byte)1 },
                    { 121, 17, (byte)1 },
                    { 120, 17, (byte)1 },
                    { 119, 16, (byte)1 },
                    { 118, 16, (byte)1 },
                    { 124, 17, (byte)1 },
                    { 117, 16, (byte)1 },
                    { 115, 16, (byte)1 },
                    { 114, 16, (byte)1 },
                    { 113, 16, (byte)1 },
                    { 112, 16, (byte)1 },
                    { 111, 16, (byte)1 },
                    { 110, 15, (byte)1 },
                    { 116, 16, (byte)1 },
                    { 109, 15, (byte)1 },
                    { 125, 17, (byte)1 },
                    { 127, 17, (byte)1 },
                    { 141, 19, (byte)1 },
                    { 140, 19, (byte)1 },
                    { 139, 19, (byte)1 },
                    { 138, 19, (byte)1 },
                    { 137, 19, (byte)1 },
                    { 136, 19, (byte)1 },
                    { 126, 17, (byte)1 },
                    { 135, 19, (byte)1 },
                    { 133, 18, (byte)1 },
                    { 132, 18, (byte)1 },
                    { 131, 18, (byte)1 },
                    { 130, 18, (byte)1 },
                    { 129, 18, (byte)1 },
                    { 128, 18, (byte)1 },
                    { 134, 18, (byte)1 },
                    { 143, 20, (byte)1 },
                    { 108, 15, (byte)1 },
                    { 106, 15, (byte)1 },
                    { 87, 13, (byte)1 },
                    { 86, 12, (byte)1 },
                    { 85, 12, (byte)1 },
                    { 84, 12, (byte)1 },
                    { 83, 12, (byte)1 },
                    { 82, 12, (byte)1 },
                    { 88, 13, (byte)1 },
                    { 81, 12, (byte)1 },
                    { 79, 11, (byte)1 },
                    { 78, 10, (byte)1 },
                    { 77, 10, (byte)1 },
                    { 76, 10, (byte)1 },
                    { 75, 10, (byte)1 },
                    { 74, 10, (byte)1 },
                    { 80, 11, (byte)1 },
                    { 107, 15, (byte)1 },
                    { 89, 13, (byte)1 },
                    { 91, 13, (byte)1 },
                    { 105, 15, (byte)1 },
                    { 104, 15, (byte)1 },
                    { 103, 15, (byte)1 },
                    { 102, 15, (byte)1 },
                    { 101, 14, (byte)1 },
                    { 100, 14, (byte)1 },
                    { 90, 13, (byte)1 },
                    { 99, 14, (byte)1 },
                    { 97, 14, (byte)1 },
                    { 96, 14, (byte)1 },
                    { 95, 14, (byte)1 },
                    { 94, 14, (byte)1 },
                    { 93, 13, (byte)1 },
                    { 92, 13, (byte)1 },
                    { 98, 14, (byte)1 },
                    { 286, 38, (byte)1 },
                    { 279, 38, (byte)1 },
                    { 288, 39, (byte)1 },
                    { 469, 62, (byte)1 },
                    { 470, 62, (byte)1 },
                    { 471, 62, (byte)1 },
                    { 472, 62, (byte)1 },
                    { 473, 62, (byte)1 },
                    { 474, 63, (byte)1 },
                    { 475, 63, (byte)1 },
                    { 476, 63, (byte)1 },
                    { 477, 63, (byte)1 },
                    { 478, 63, (byte)1 },
                    { 479, 63, (byte)1 },
                    { 480, 63, (byte)1 },
                    { 481, 63, (byte)1 },
                    { 482, 63, (byte)1 },
                    { 483, 63, (byte)1 },
                    { 484, 63, (byte)1 },
                    { 485, 63, (byte)1 },
                    { 499, 65, (byte)1 },
                    { 498, 65, (byte)1 },
                    { 497, 65, (byte)1 },
                    { 496, 65, (byte)1 },
                    { 495, 65, (byte)1 },
                    { 494, 64, (byte)1 },
                    { 468, 62, (byte)1 },
                    { 493, 64, (byte)1 },
                    { 491, 64, (byte)1 },
                    { 490, 64, (byte)1 },
                    { 489, 64, (byte)1 },
                    { 488, 64, (byte)1 },
                    { 487, 64, (byte)1 },
                    { 486, 64, (byte)1 },
                    { 492, 64, (byte)1 },
                    { 467, 62, (byte)1 },
                    { 466, 62, (byte)1 },
                    { 465, 62, (byte)1 },
                    { 446, 60, (byte)1 },
                    { 445, 60, (byte)1 },
                    { 444, 60, (byte)1 },
                    { 443, 60, (byte)1 },
                    { 442, 60, (byte)1 },
                    { 441, 60, (byte)1 },
                    { 447, 60, (byte)1 },
                    { 440, 59, (byte)1 },
                    { 287, 38, (byte)1 },
                    { 437, 59, (byte)1 },
                    { 436, 59, (byte)1 },
                    { 435, 59, (byte)1 },
                    { 434, 58, (byte)1 },
                    { 433, 58, (byte)1 },
                    { 439, 59, (byte)1 },
                    { 500, 66, (byte)1 },
                    { 448, 61, (byte)1 },
                    { 450, 61, (byte)1 },
                    { 464, 62, (byte)1 },
                    { 463, 62, (byte)1 },
                    { 462, 62, (byte)1 },
                    { 461, 62, (byte)1 },
                    { 460, 62, (byte)1 },
                    { 459, 61, (byte)1 },
                    { 449, 61, (byte)1 },
                    { 458, 61, (byte)1 },
                    { 456, 61, (byte)1 },
                    { 455, 61, (byte)1 },
                    { 454, 61, (byte)1 },
                    { 453, 61, (byte)1 },
                    { 452, 61, (byte)1 },
                    { 451, 61, (byte)1 },
                    { 457, 61, (byte)1 },
                    { 501, 66, (byte)1 },
                    { 502, 66, (byte)1 },
                    { 503, 66, (byte)1 },
                    { 553, 70, (byte)1 },
                    { 552, 70, (byte)1 },
                    { 551, 70, (byte)1 },
                    { 550, 70, (byte)1 },
                    { 549, 70, (byte)1 },
                    { 548, 70, (byte)1 },
                    { 554, 70, (byte)1 },
                    { 547, 70, (byte)1 },
                    { 545, 70, (byte)1 },
                    { 544, 70, (byte)1 },
                    { 543, 70, (byte)1 },
                    { 542, 70, (byte)1 },
                    { 541, 69, (byte)1 },
                    { 540, 69, (byte)1 },
                    { 546, 70, (byte)1 },
                    { 539, 69, (byte)1 },
                    { 555, 70, (byte)1 },
                    { 557, 71, (byte)1 },
                    { 571, 72, (byte)1 },
                    { 570, 72, (byte)1 },
                    { 569, 72, (byte)1 },
                    { 568, 72, (byte)1 },
                    { 567, 72, (byte)1 },
                    { 566, 71, (byte)1 },
                    { 556, 71, (byte)1 },
                    { 565, 71, (byte)1 },
                    { 563, 71, (byte)1 },
                    { 562, 71, (byte)1 },
                    { 561, 71, (byte)1 },
                    { 560, 71, (byte)1 },
                    { 559, 71, (byte)1 },
                    { 558, 71, (byte)1 },
                    { 564, 71, (byte)1 },
                    { 432, 58, (byte)1 },
                    { 538, 69, (byte)1 },
                    { 536, 68, (byte)1 },
                    { 517, 67, (byte)1 },
                    { 516, 67, (byte)1 },
                    { 515, 67, (byte)1 },
                    { 514, 67, (byte)1 },
                    { 513, 67, (byte)1 },
                    { 512, 66, (byte)1 },
                    { 518, 67, (byte)1 },
                    { 511, 66, (byte)1 },
                    { 509, 66, (byte)1 },
                    { 508, 66, (byte)1 },
                    { 507, 66, (byte)1 },
                    { 506, 66, (byte)1 },
                    { 505, 66, (byte)1 },
                    { 504, 66, (byte)1 },
                    { 510, 66, (byte)1 },
                    { 537, 68, (byte)1 },
                    { 519, 67, (byte)1 },
                    { 521, 67, (byte)1 },
                    { 535, 68, (byte)1 },
                    { 534, 68, (byte)1 },
                    { 533, 68, (byte)1 },
                    { 532, 68, (byte)1 },
                    { 531, 68, (byte)1 },
                    { 530, 68, (byte)1 },
                    { 520, 67, (byte)1 },
                    { 529, 68, (byte)1 },
                    { 527, 68, (byte)1 },
                    { 526, 68, (byte)1 },
                    { 525, 67, (byte)1 },
                    { 524, 67, (byte)1 },
                    { 523, 67, (byte)1 },
                    { 522, 67, (byte)1 },
                    { 528, 68, (byte)1 },
                    { 431, 58, (byte)1 },
                    { 438, 59, (byte)1 },
                    { 429, 58, (byte)1 },
                    { 344, 46, (byte)1 },
                    { 343, 46, (byte)1 },
                    { 342, 46, (byte)1 },
                    { 341, 46, (byte)1 },
                    { 340, 46, (byte)1 },
                    { 339, 46, (byte)1 },
                    { 338, 46, (byte)1 },
                    { 345, 46, (byte)1 },
                    { 337, 45, (byte)1 },
                    { 335, 45, (byte)1 },
                    { 334, 45, (byte)1 },
                    { 333, 45, (byte)1 },
                    { 332, 44, (byte)1 },
                    { 331, 44, (byte)1 },
                    { 330, 44, (byte)1 },
                    { 329, 44, (byte)1 },
                    { 336, 45, (byte)1 },
                    { 328, 44, (byte)1 },
                    { 346, 47, (byte)1 },
                    { 348, 47, (byte)1 },
                    { 364, 49, (byte)1 },
                    { 363, 49, (byte)1 },
                    { 362, 49, (byte)1 },
                    { 361, 49, (byte)1 },
                    { 360, 49, (byte)1 },
                    { 359, 49, (byte)1 },
                    { 358, 48, (byte)1 },
                    { 347, 47, (byte)1 },
                    { 357, 48, (byte)1 },
                    { 355, 48, (byte)1 },
                    { 354, 48, (byte)1 },
                    { 353, 47, (byte)1 },
                    { 352, 47, (byte)1 },
                    { 351, 47, (byte)1 },
                    { 350, 47, (byte)1 },
                    { 349, 47, (byte)1 },
                    { 356, 48, (byte)1 },
                    { 365, 49, (byte)1 },
                    { 327, 44, (byte)1 },
                    { 325, 43, (byte)1 },
                    { 304, 41, (byte)1 },
                    { 303, 41, (byte)1 },
                    { 302, 40, (byte)1 },
                    { 301, 40, (byte)1 },
                    { 300, 40, (byte)1 },
                    { 299, 40, (byte)1 },
                    { 298, 40, (byte)1 },
                    { 305, 41, (byte)1 },
                    { 297, 40, (byte)1 },
                    { 295, 39, (byte)1 },
                    { 294, 39, (byte)1 },
                    { 293, 39, (byte)1 },
                    { 292, 39, (byte)1 },
                    { 291, 39, (byte)1 },
                    { 290, 39, (byte)1 },
                    { 289, 39, (byte)1 },
                    { 296, 40, (byte)1 },
                    { 326, 44, (byte)1 },
                    { 306, 41, (byte)1 },
                    { 308, 41, (byte)1 },
                    { 324, 43, (byte)1 },
                    { 323, 43, (byte)1 },
                    { 322, 43, (byte)1 },
                    { 321, 43, (byte)1 },
                    { 320, 43, (byte)1 },
                    { 319, 43, (byte)1 },
                    { 318, 42, (byte)1 },
                    { 307, 41, (byte)1 },
                    { 317, 42, (byte)1 },
                    { 315, 42, (byte)1 },
                    { 314, 42, (byte)1 },
                    { 313, 42, (byte)1 },
                    { 312, 42, (byte)1 },
                    { 311, 41, (byte)1 },
                    { 310, 41, (byte)1 },
                    { 309, 41, (byte)1 },
                    { 316, 42, (byte)1 },
                    { 430, 58, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "ProfessionSkills",
                columns: new[] { "Id", "ProfessionId", "Quantity" },
                values: new object[,]
                {
                    { 366, 49, (byte)1 },
                    { 368, 50, (byte)1 },
                    { 401, 54, (byte)1 },
                    { 402, 55, (byte)1 },
                    { 403, 55, (byte)1 },
                    { 404, 55, (byte)1 },
                    { 405, 55, (byte)1 },
                    { 406, 55, (byte)1 },
                    { 367, 50, (byte)1 },
                    { 408, 55, (byte)1 },
                    { 409, 55, (byte)1 },
                    { 410, 56, (byte)1 },
                    { 411, 56, (byte)1 },
                    { 412, 56, (byte)1 },
                    { 413, 56, (byte)1 },
                    { 400, 54, (byte)1 },
                    { 414, 56, (byte)1 },
                    { 416, 56, (byte)1 },
                    { 417, 56, (byte)1 },
                    { 418, 56, (byte)1 },
                    { 419, 57, (byte)1 },
                    { 420, 57, (byte)1 },
                    { 421, 57, (byte)1 },
                    { 422, 57, (byte)1 },
                    { 423, 57, (byte)1 },
                    { 424, 57, (byte)1 },
                    { 425, 57, (byte)1 },
                    { 426, 57, (byte)1 },
                    { 427, 58, (byte)1 },
                    { 428, 58, (byte)1 },
                    { 415, 56, (byte)1 },
                    { 399, 54, (byte)1 },
                    { 407, 55, (byte)1 },
                    { 397, 53, (byte)1 },
                    { 388, 52, (byte)1 },
                    { 387, 52, (byte)1 },
                    { 386, 52, (byte)1 },
                    { 385, 52, (byte)1 },
                    { 384, 52, (byte)1 },
                    { 383, 52, (byte)1 },
                    { 382, 51, (byte)1 },
                    { 381, 51, (byte)1 },
                    { 380, 51, (byte)1 },
                    { 389, 52, (byte)1 },
                    { 379, 51, (byte)1 },
                    { 377, 51, (byte)1 },
                    { 376, 51, (byte)1 },
                    { 375, 51, (byte)1 },
                    { 374, 50, (byte)1 },
                    { 373, 50, (byte)1 },
                    { 372, 50, (byte)1 },
                    { 371, 50, (byte)1 },
                    { 370, 50, (byte)1 },
                    { 369, 50, (byte)1 },
                    { 378, 51, (byte)1 },
                    { 398, 53, (byte)1 },
                    { 1, 1, (byte)1 },
                    { 396, 53, (byte)1 },
                    { 395, 53, (byte)1 },
                    { 394, 53, (byte)1 },
                    { 393, 53, (byte)1 },
                    { 392, 53, (byte)1 },
                    { 391, 53, (byte)1 },
                    { 390, 52, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "IsBasicValue", "IsCalculatedValue", "IsReadOnly", "Type" },
                values: new object[,]
                {
                    { (byte)3, true, false, false, (byte)3 },
                    { (byte)16, false, true, false, (byte)16 },
                    { (byte)15, false, true, false, (byte)15 },
                    { (byte)2, true, false, false, (byte)2 },
                    { (byte)14, false, false, true, (byte)14 },
                    { (byte)12, false, true, true, (byte)12 },
                    { (byte)11, false, true, true, (byte)11 },
                    { (byte)10, false, false, false, (byte)10 },
                    { (byte)9, false, false, false, (byte)9 },
                    { (byte)8, true, false, false, (byte)8 },
                    { (byte)7, true, false, false, (byte)7 },
                    { (byte)6, true, false, false, (byte)6 },
                    { (byte)5, true, false, false, (byte)5 },
                    { (byte)4, true, false, false, (byte)4 },
                    { (byte)13, false, false, true, (byte)13 },
                    { (byte)1, true, false, false, (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "ProfessionAbility",
                columns: new[] { "ProfessionAbilitiesId", "AbilityId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 269, 11 },
                    { 268, 66 },
                    { 268, 70 },
                    { 267, 69 },
                    { 266, 61 },
                    { 265, 58 },
                    { 264, 52 },
                    { 263, 23 },
                    { 262, 11 },
                    { 261, 11 },
                    { 260, 11 },
                    { 259, 7 },
                    { 258, 3 },
                    { 258, 73 },
                    { 257, 71 },
                    { 256, 65 },
                    { 255, 64 },
                    { 243, 11 },
                    { 244, 23 },
                    { 245, 31 },
                    { 246, 50 },
                    { 247, 58 },
                    { 248, 69 },
                    { 270, 22 },
                    { 249, 85 },
                    { 250, 21 },
                    { 251, 85 },
                    { 251, 31 },
                    { 252, 6 },
                    { 253, 7 },
                    { 254, 7 },
                    { 249, 25 },
                    { 271, 38 },
                    { 272, 52 },
                    { 273, 61 },
                    { 289, 19 },
                    { 289, 39 },
                    { 290, 34 },
                    { 291, 34 },
                    { 292, 84 },
                    { 292, 37 },
                    { 288, 51 },
                    { 293, 72 },
                    { 294, 7 },
                    { 295, 11 },
                    { 296, 11 },
                    { 297, 20 },
                    { 298, 38 },
                    { 299, 44 },
                    { 293, 20 },
                    { 242, 5 },
                    { 288, 16 },
                    { 286, 57 },
                    { 274, 64 },
                    { 274, 6 },
                    { 275, 21 },
                    { 276, 58 },
                    { 277, 14 },
                    { 278, 48 },
                    { 287, 85 },
                    { 279, 53 },
                    { 280, 9 },
                    { 281, 11 },
                    { 282, 11 },
                    { 283, 31 },
                    { 284, 80 },
                    { 285, 20 },
                    { 280, 5 },
                    { 242, 85 },
                    { 241, 53 },
                    { 240, 31 },
                    { 198, 11 },
                    { 199, 42 },
                    { 200, 61 },
                    { 201, 5 },
                    { 202, 44 },
                    { 203, 48 },
                    { 197, 58 },
                    { 204, 5 },
                    { 205, 31 },
                    { 206, 27 },
                    { 207, 58 },
                    { 208, 8 },
                    { 208, 13 },
                    { 209, 25 },
                    { 205, 20 },
                    { 209, 11 },
                    { 196, 20 },
                    { 194, 27 },
                    { 185, 34 },
                    { 186, 56 },
                    { 186, 39 },
                    { 187, 84 },
                    { 187, 37 },
                    { 188, 16 },
                    { 195, 58 },
                    { 188, 37 },
                    { 189, 73 },
                    { 190, 34 },
                    { 191, 34 },
                    { 192, 84 },
                    { 192, 39 },
                    { 193, 11 },
                    { 189, 19 },
                    { 300, 52 },
                    { 210, 58 },
                    { 211, 20 },
                    { 230, 1 },
                    { 231, 11 },
                    { 232, 7 },
                    { 232, 9 },
                    { 233, 11 },
                    { 234, 44 },
                    { 229, 71 },
                    { 235, 60 },
                    { 237, 35 },
                    { 238, 38 },
                    { 238, 53 },
                    { 239, 56 },
                    { 239, 27 },
                    { 240, 20 },
                    { 236, 61 },
                    { 211, 85 },
                    { 228, 65 },
                    { 226, 7 },
                    { 212, 1 },
                    { 213, 3 },
                    { 213, 70 },
                    { 214, 6 },
                    { 215, 7 },
                    { 216, 11 },
                    { 227, 64 },
                    { 217, 11 },
                    { 220, 71 },
                    { 221, 82 },
                    { 222, 20 },
                    { 223, 27 },
                    { 224, 58 },
                    { 225, 6 },
                    { 218, 11 },
                    { 184, 34 },
                    { 301, 53 },
                    { 303, 44 },
                    { 390, 31 },
                    { 389, 5 },
                    { 388, 16 },
                    { 388, 84 },
                    { 387, 39 },
                    { 387, 37 },
                    { 386, 34 },
                    { 385, 34 },
                    { 384, 32 },
                    { 384, 36 },
                    { 383, 43 },
                    { 383, 19 },
                    { 382, 61 },
                    { 382, 64 },
                    { 381, 2 },
                    { 381, 43 },
                    { 380, 11 },
                    { 369, 69 },
                    { 370, 15 },
                    { 371, 25 },
                    { 372, 57 },
                    { 373, 57 },
                    { 374, 20 },
                    { 391, 74 },
                    { 374, 31 },
                    { 376, 58 },
                    { 377, 85 },
                    { 377, 25 },
                    { 378, 6 },
                    { 378, 38 },
                    { 379, 11 },
                    { 375, 27 },
                    { 392, 80 },
                    { 393, 33 },
                    { 394, 34 },
                    { 410, 11 },
                    { 411, 20 },
                    { 412, 38 },
                    { 413, 45 },
                    { 413, 60 },
                    { 414, 61 },
                    { 409, 11 },
                    { 415, 63 },
                    { 417, 71 },
                    { 418, 6 },
                    { 419, 11 },
                    { 420, 64 },
                    { 420, 65 },
                    { 421, 79 },
                    { 416, 64 },
                    { 369, 13 },
                    { 408, 11 },
                    { 406, 1 },
                    { 395, 34 },
                    { 396, 44 },
                    { 396, 61 },
                    { 397, 56 },
                    { 397, 19 },
                    { 398, 84 },
                    { 407, 9 },
                    { 398, 37 },
                    { 400, 41 },
                    { 401, 11 },
                    { 402, 38 },
                    { 403, 42 },
                    { 404, 50 },
                    { 405, 44 },
                    { 399, 7 },
                    { 368, 58 },
                    { 367, 44 },
                    { 366, 40 },
                    { 319, 63 },
                    { 320, 65 },
                    { 321, 71 },
                    { 322, 5 },
                    { 323, 23 },
                    { 324, 31 },
                    { 318, 61 },
                    { 325, 53 },
                    { 327, 1 },
                    { 328, 9 },
                    { 329, 11 },
                    { 330, 11 },
                    { 331, 20 },
                    { 332, 45 },
                    { 326, 61 },
                    { 333, 63 },
                    { 317, 11 },
                    { 315, 1 },
                    { 304, 79 },
                    { 304, 57 },
                    { 305, 7 },
                    { 306, 11 },
                    { 307, 11 },
                    { 308, 60 },
                    { 316, 6 },
                    { 308, 71 },
                    { 310, 23 },
                    { 311, 82 },
                    { 312, 21 },
                    { 313, 53 },
                    { 314, 85 },
                    { 314, 31 },
                    { 309, 11 },
                    { 302, 79 },
                    { 334, 64 },
                    { 336, 11 },
                    { 353, 6 },
                    { 354, 11 },
                    { 355, 11 },
                    { 356, 63 },
                    { 357, 64 },
                    { 358, 65 },
                    { 352, 71 },
                    { 359, 7 },
                    { 361, 11 },
                    { 362, 11 },
                    { 363, 11 },
                    { 364, 15 },
                    { 365, 25 },
                    { 365, 31 },
                    { 360, 11 },
                    { 335, 78 },
                    { 351, 63 },
                    { 349, 11 },
                    { 337, 11 },
                    { 338, 11 },
                    { 339, 61 },
                    { 340, 5 },
                    { 340, 82 },
                    { 341, 23 },
                    { 350, 31 },
                    { 341, 44 },
                    { 343, 61 },
                    { 344, 5 },
                    { 345, 7 },
                    { 346, 9 },
                    { 347, 11 },
                    { 348, 11 },
                    { 342, 53 },
                    { 183, 20 },
                    { 219, 64 },
                    { 182, 19 },
                    { 66, 70 },
                    { 65, 85 },
                    { 64, 13 },
                    { 64, 8 },
                    { 63, 76 },
                    { 62, 53 },
                    { 62, 66 },
                    { 182, 46 },
                    { 61, 63 },
                    { 60, 11 },
                    { 59, 11 },
                    { 59, 73 },
                    { 58, 43 },
                    { 58, 70 },
                    { 57, 76 },
                    { 57, 66 },
                    { 56, 6 },
                    { 46, 69 },
                    { 47, 80 },
                    { 47, 22 },
                    { 48, 15 },
                    { 48, 31 },
                    { 49, 58 },
                    { 66, 66 },
                    { 50, 68 },
                    { 51, 11 },
                    { 52, 38 },
                    { 53, 3 },
                    { 53, 43 },
                    { 54, 11 },
                    { 55, 76 },
                    { 50, 69 },
                    { 67, 6 },
                    { 67, 61 },
                    { 68, 60 },
                    { 80, 53 },
                    { 81, 54 },
                    { 81, 70 },
                    { 82, 60 },
                    { 83, 20 },
                    { 84, 54 },
                    { 79, 71 },
                    { 84, 13 },
                    { 85, 44 },
                    { 86, 15 },
                    { 87, 54 },
                    { 87, 5 },
                    { 88, 58 },
                    { 89, 15 },
                    { 85, 85 },
                    { 46, 68 },
                    { 79, 50 },
                    { 78, 38 },
                    { 68, 71 },
                    { 69, 63 },
                    { 69, 53 },
                    { 70, 11 },
                    { 70, 6 },
                    { 71, 61 },
                    { 78, 82 },
                    { 72, 2 },
                    { 73, 5 },
                    { 74, 11 },
                    { 75, 11 },
                    { 76, 53 },
                    { 77, 60 },
                    { 77, 71 },
                    { 72, 43 },
                    { 45, 35 },
                    { 44, 24 },
                    { 43, 79 },
                    { 13, 44 },
                    { 14, 73 },
                    { 14, 13 },
                    { 15, 85 },
                    { 15, 5 },
                    { 16, 2 },
                    { 13, 48 },
                    { 16, 11 },
                    { 16, 58 },
                    { 16, 63 },
                    { 16, 70 },
                    { 16, 71 },
                    { 16, 78 },
                    { 16, 82 },
                    { 16, 40 },
                    { 17, 13 },
                    { 12, 15 },
                    { 11, 73 },
                    { 1, 70 },
                    { 2, 13 },
                    { 2, 75 },
                    { 3, 58 },
                    { 4, 63 },
                    { 4, 53 },
                    { 11, 76 },
                    { 5, 76 },
                    { 6, 11 },
                    { 7, 23 },
                    { 8, 67 },
                    { 9, 71 },
                    { 10, 15 },
                    { 10, 11 },
                    { 5, 31 },
                    { 90, 31 },
                    { 17, 43 },
                    { 19, 48 },
                    { 33, 82 },
                    { 34, 61 },
                    { 35, 71 },
                    { 35, 38 },
                    { 36, 3 },
                    { 36, 69 },
                    { 33, 60 },
                    { 37, 4 },
                    { 38, 6 },
                    { 39, 15 },
                    { 40, 79 },
                    { 41, 4 },
                    { 41, 75 },
                    { 42, 11 },
                    { 37, 2 },
                    { 18, 14 },
                    { 32, 11 },
                    { 30, 11 },
                    { 19, 8 },
                    { 20, 11 },
                    { 21, 54 },
                    { 21, 2 },
                    { 22, 58 },
                    { 23, 73 },
                    { 31, 11 },
                    { 23, 13 },
                    { 25, 79 },
                    { 26, 11 },
                    { 27, 20 },
                    { 28, 61 },
                    { 29, 2 },
                    { 29, 51 },
                    { 24, 44 },
                    { 90, 51 },
                    { 61, 61 },
                    { 92, 44 },
                    { 160, 60 },
                    { 159, 11 },
                    { 158, 5 },
                    { 157, 44 },
                    { 157, 71 },
                    { 156, 11 },
                    { 155, 76 },
                    { 155, 66 },
                    { 154, 75 },
                    { 154, 6 },
                    { 153, 79 },
                    { 153, 66 },
                    { 152, 44 },
                    { 151, 76 },
                    { 151, 2 },
                    { 150, 15 },
                    { 149, 2 },
                    { 140, 73 },
                    { 140, 48 },
                    { 141, 18 },
                    { 141, 54 },
                    { 142, 38 },
                    { 143, 53 },
                    { 160, 71 },
                    { 144, 61 },
                    { 146, 8 },
                    { 146, 43 },
                    { 147, 35 },
                    { 148, 84 },
                    { 148, 19 },
                    { 149, 8 },
                    { 145, 79 },
                    { 161, 61 },
                    { 162, 70 },
                    { 162, 43 },
                    { 173, 5 },
                    { 174, 11 },
                    { 175, 38 },
                    { 175, 6 },
                    { 176, 53 },
                    { 176, 64 },
                    { 173, 73 },
                    { 177, 60 },
                    { 178, 63 },
                    { 178, 61 },
                    { 179, 53 },
                    { 180, 60 },
                    { 180, 71 },
                    { 181, 61 },
                    { 177, 71 },
                    { 139, 31 },
                    { 172, 9 },
                    { 171, 44 },
                    { 163, 73 },
                    { 164, 20 },
                    { 164, 21 },
                    { 165, 58 },
                    { 166, 21 },
                    { 166, 80 },
                    { 172, 61 },
                    { 167, 74 },
                    { 91, 48 },
                    { 168, 13 },
                    { 169, 20 },
                    { 169, 57 },
                    { 170, 44 },
                    { 170, 21 },
                    { 167, 31 },
                    { 139, 54 },
                    { 168, 8 },
                    { 138, 68 },
                    { 103, 8 },
                    { 104, 5 },
                    { 105, 23 },
                    { 105, 13 },
                    { 106, 38 },
                    { 107, 53 },
                    { 103, 85 },
                    { 108, 60 },
                    { 109, 61 },
                    { 110, 57 },
                    { 111, 4 },
                    { 111, 70 },
                    { 112, 18 },
                    { 112, 15 },
                    { 108, 71 },
                    { 113, 20 },
                    { 102, 85 },
                    { 101, 5 },
                    { 138, 58 },
                    { 93, 79 },
                    { 94, 85 },
                    { 94, 31 },
                    { 95, 11 },
                    { 96, 54 },
                    { 102, 44 },
                    { 96, 2 },
                    { 98, 11 },
                    { 98, 5 },
                    { 99, 66 },
                    { 99, 13 },
                    { 100, 73 },
                    { 101, 79 },
                    { 97, 79 },
                    { 113, 73 },
                    { 100, 8 },
                    { 115, 54 },
                    { 128, 22 },
                    { 129, 48 },
                    { 130, 50 },
                    { 131, 9 },
                    { 131, 70 },
                    { 132, 11 },
                    { 127, 11 },
                    { 134, 71 },
                    { 135, 8 },
                    { 135, 11 },
                    { 136, 11 },
                    { 136, 25 },
                    { 114, 53 },
                    { 137, 20 },
                    { 134, 38 },
                    { 126, 82 },
                    { 133, 61 },
                    { 124, 48 },
                    { 116, 60 },
                    { 125, 50 },
                    { 116, 5 },
                    { 117, 61 },
                    { 118, 11 },
                    { 115, 8 },
                    { 119, 6 },
                    { 120, 3 },
                    { 119, 71 },
                    { 120, 8 },
                    { 121, 64 },
                    { 121, 6 },
                    { 122, 76 },
                    { 122, 71 },
                    { 123, 11 }
                });

            migrationBuilder.InsertData(
                table: "ProfessionItem",
                columns: new[] { "ProfessionsItemId", "ItemId", "Quantity" },
                values: new object[,]
                {
                    { 111, 46, 1 },
                    { 110, 104, 1 },
                    { 113, 169, 1 },
                    { 114, 171, 1 },
                    { 115, 172, 1 },
                    { 116, 103, 1 },
                    { 117, 46, 1 },
                    { 112, 14, 1 },
                    { 118, 176, 1 },
                    { 122, 18, 1 },
                    { 119, 165, 1 },
                    { 120, 162, 1 },
                    { 120, 110, 2 },
                    { 121, 27, 1 },
                    { 121, 26, 1 },
                    { 122, 17, 1 },
                    { 123, 37, 1 },
                    { 109, 152, 1 },
                    { 125, 14, 1 },
                    { 124, 46, 1 },
                    { 119, 162, 1 },
                    { 108, 144, 1 },
                    { 93, 44, 1 },
                    { 106, 107, 1 },
                    { 88, 46, 1 },
                    { 126, 169, 1 },
                    { 89, 14, 1 },
                    { 90, 187, 1 },
                    { 91, 1, 1 },
                    { 91, 27, 1 },
                    { 92, 46, 1 },
                    { 94, 38, 2 },
                    { 94, 29, 2 },
                    { 107, 109, 1 },
                    { 95, 11, 1 },
                    { 97, 9, 1 },
                    { 98, 11, 1 },
                    { 99, 50, 1 },
                    { 100, 45, 1 },
                    { 101, 65, 2 },
                    { 102, 133, 1 },
                    { 103, 99, 1 },
                    { 104, 46, 1 },
                    { 105, 64, 1 },
                    { 96, 46, 1 },
                    { 127, 171, 1 },
                    { 161, 14, 1 },
                    { 129, 128, 1 },
                    { 153, 118, 1 },
                    { 154, 108, 1 },
                    { 155, 109, 1 },
                    { 156, 46, 1 },
                    { 157, 109, 1 },
                    { 158, 31, 1 },
                    { 159, 50, 1 },
                    { 160, 46, 1 },
                    { 162, 168, 1 },
                    { 152, 98, 1 },
                    { 163, 171, 1 },
                    { 165, 128, 1 },
                    { 166, 33, 1 },
                    { 167, 170, 1 },
                    { 168, 171, 1 },
                    { 169, 172, 1 },
                    { 170, 107, 1 },
                    { 171, 109, 1 },
                    { 172, 152, 1 },
                    { 87, 50, 1 },
                    { 164, 172, 1 },
                    { 128, 172, 1 },
                    { 151, 64, 1 },
                    { 149, 148, 1 },
                    { 130, 26, 1 },
                    { 130, 22, 1 },
                    { 131, 46, 1 },
                    { 132, 15, 1 },
                    { 133, 37, 1 },
                    { 134, 146, 1 },
                    { 135, 128, 1 },
                    { 136, 46, 1 },
                    { 137, 65, 2 },
                    { 150, 156, 1 },
                    { 138, 156, 1 },
                    { 140, 114, 50 },
                    { 141, 50, 1 },
                    { 142, 46, 1 },
                    { 143, 14, 1 },
                    { 144, 169, 1 },
                    { 145, 171, 1 },
                    { 146, 172, 1 },
                    { 147, 112, 2 },
                    { 148, 113, 5 },
                    { 139, 45, 1 },
                    { 85, 114, 50 },
                    { 86, 26, 1 },
                    { 11, 201, 1 },
                    { 20, 4, 1 },
                    { 20, 8, 1 },
                    { 21, 90, 1 },
                    { 22, 46, 1 },
                    { 23, 46, 1 },
                    { 24, 165, 1 },
                    { 26, 50, 1 },
                    { 27, 49, 1 },
                    { 28, 46, 1 },
                    { 19, 154, 1 },
                    { 29, 169, 1 },
                    { 31, 172, 1 },
                    { 32, 4, 1 },
                    { 32, 16, 1 },
                    { 33, 11, 1 },
                    { 34, 50, 1 },
                    { 35, 46, 1 },
                    { 36, 14, 1 },
                    { 36, 9, 1 },
                    { 37, 26, 1 },
                    { 30, 171, 1 },
                    { 38, 46, 1 },
                    { 18, 64, 1 },
                    { 17, 154, 1 },
                    { 84, 14, 1 },
                    { 1, 66, 1 },
                    { 2, 135, 1 },
                    { 3, 45, 1 },
                    { 4, 27, 1 },
                    { 5, 14, 1 },
                    { 6, 16, 1 },
                    { 6, 14, 1 },
                    { 7, 45, 1 },
                    { 18, 67, 1 },
                    { 8, 89, 1 },
                    { 9, 2, 1 },
                    { 10, 93, 1 },
                    { 11, 154, 1 },
                    { 12, 101, 1 },
                    { 13, 131, 1 },
                    { 14, 45, 1 },
                    { 15, 29, 3 },
                    { 15, 38, 2 },
                    { 16, 120, 1 },
                    { 9, 33, 1 },
                    { 39, 187, 1 },
                    { 25, 5, 1 },
                    { 41, 16, 1 },
                    { 65, 199, 1 },
                    { 66, 40, 10 },
                    { 67, 20, 1 },
                    { 68, 40, 10 },
                    { 69, 155, 2 },
                    { 69, 158, 1 },
                    { 70, 199, 1 },
                    { 71, 41, 10 },
                    { 72, 26, 1 },
                    { 64, 46, 1 },
                    { 73, 45, 1 },
                    { 75, 143, 1 },
                    { 40, 201, 1 },
                    { 77, 143, 1 },
                    { 78, 64, 1 },
                    { 79, 149, 1 },
                    { 80, 107, 1 },
                    { 81, 26, 1 },
                    { 82, 50, 1 },
                    { 83, 45, 1 },
                    { 74, 44, 1 },
                    { 63, 16, 1 },
                    { 76, 128, 1 },
                    { 61, 46, 1 },
                    { 42, 144, 1 },
                    { 62, 47, 1 },
                    { 43, 46, 1 },
                    { 44, 152, 1 },
                    { 45, 108, 1 },
                    { 47, 187, 1 },
                    { 48, 72, 1 },
                    { 49, 75, 1 },
                    { 50, 46, 1 },
                    { 51, 151, 1 },
                    { 52, 107, 1 },
                    { 46, 109, 1 },
                    { 54, 128, 1 },
                    { 55, 104, 2 },
                    { 56, 65, 1 },
                    { 56, 139, 1 },
                    { 57, 114, 50 },
                    { 58, 27, 1 },
                    { 53, 109, 1 },
                    { 60, 52, 1 },
                    { 59, 16, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProfessionSkill",
                columns: new[] { "ProfessionSkillsId", "SkillId" },
                values: new object[,]
                {
                    { 653, 2 },
                    { 652, 20 },
                    { 651, 45 },
                    { 650, 41 },
                    { 649, 16 },
                    { 648, 40 },
                    { 645, 13 },
                    { 646, 14 },
                    { 644, 12 },
                    { 643, 35 },
                    { 654, 4 },
                    { 641, 30 },
                    { 642, 34 },
                    { 647, 37 },
                    { 655, 29 },
                    { 665, 46 },
                    { 657, 29 },
                    { 640, 23 },
                    { 671, 40 },
                    { 670, 37 },
                    { 669, 13 },
                    { 668, 12 },
                    { 667, 11 },
                    { 656, 29 },
                    { 666, 29 },
                    { 663, 43 },
                    { 662, 13 },
                    { 661, 12 },
                    { 660, 11 },
                    { 659, 10 },
                    { 658, 7 },
                    { 664, 20 },
                    { 639, 46 },
                    { 467, 10 },
                    { 637, 19 },
                    { 617, 10 },
                    { 616, 7 },
                    { 615, 2 },
                    { 614, 46 },
                    { 613, 19 },
                    { 612, 43 },
                    { 618, 34 },
                    { 611, 15 },
                    { 609, 33 },
                    { 608, 10 },
                    { 607, 7 },
                    { 606, 5 },
                    { 605, 23 },
                    { 672, 16 },
                    { 610, 13 },
                    { 619, 35 },
                    { 620, 13 },
                    { 621, 15 },
                    { 636, 43 },
                    { 635, 43 },
                    { 634, 15 },
                    { 633, 35 },
                    { 632, 33 },
                    { 631, 10 },
                    { 630, 9 },
                    { 629, 7 },
                    { 628, 4 },
                    { 627, 22 },
                    { 626, 20 },
                    { 625, 19 },
                    { 624, 43 },
                    { 623, 41 },
                    { 622, 38 },
                    { 638, 46 },
                    { 673, 41 },
                    { 719, 10 },
                    { 675, 18 },
                    { 724, 15 },
                    { 723, 13 },
                    { 722, 35 },
                    { 721, 33 },
                    { 720, 33 },
                    { 605, 24 },
                    { 725, 43 },
                    { 718, 7 },
                    { 716, 2 },
                    { 715, 47 },
                    { 714, 19 },
                    { 713, 18 },
                    { 712, 41 },
                    { 711, 16 },
                    { 717, 29 },
                    { 710, 13 },
                    { 726, 19 },
                    { 728, 46 },
                    { 740, 46 },
                    { 739, 44 },
                    { 738, 43 },
                    { 737, 43 },
                    { 736, 36 },
                    { 735, 20 },
                    { 727, 46 },
                    { 735, 10 },
                    { 734, 7 },
                    { 733, 29 },
                    { 732, 29 },
                    { 731, 26 },
                    { 730, 26 },
                    { 729, 22 },
                    { 734, 4 },
                    { 674, 43 },
                    { 709, 12 },
                    { 707, 34 },
                    { 689, 20 },
                    { 688, 19 },
                    { 687, 43 },
                    { 686, 15 },
                    { 685, 13 },
                    { 684, 33 },
                    { 690, 46 },
                    { 683, 11 },
                    { 681, 7 },
                    { 680, 29 },
                    { 679, 4 },
                    { 678, 2 },
                    { 677, 22 },
                    { 676, 46 },
                    { 682, 10 },
                    { 708, 35 },
                    { 691, 22 },
                    { 693, 29 },
                    { 706, 11 },
                    { 705, 10 },
                    { 704, 8 },
                    { 703, 7 },
                    { 702, 32 },
                    { 701, 23 },
                    { 692, 28 },
                    { 701, 3 },
                    { 699, 1 },
                    { 698, 46 },
                    { 697, 42 },
                    { 696, 13 },
                    { 695, 33 },
                    { 694, 7 },
                    { 700, 22 },
                    { 604, 47 },
                    { 560, 35 },
                    { 603, 46 },
                    { 516, 29 },
                    { 515, 24 },
                    { 514, 2 },
                    { 513, 1 },
                    { 512, 48 },
                    { 511, 46 },
                    { 517, 29 },
                    { 510, 20 },
                    { 508, 43 },
                    { 507, 43 },
                    { 506, 41 },
                    { 505, 33 },
                    { 504, 8 },
                    { 503, 7 },
                    { 509, 17 },
                    { 502, 5 },
                    { 518, 7 },
                    { 520, 13 },
                    { 532, 10 },
                    { 531, 7 },
                    { 530, 3 },
                    { 530, 29 },
                    { 529, 4 },
                    { 528, 24 },
                    { 519, 10 },
                    { 527, 27 },
                    { 526, 22 },
                    { 525, 46 },
                    { 524, 20 },
                    { 523, 43 },
                    { 522, 41 },
                    { 521, 16 },
                    { 527, 2 },
                    { 533, 13 },
                    { 501, 3 },
                    { 499, 46 },
                    { 480, 10 },
                    { 479, 7 },
                    { 478, 29 },
                    { 477, 29 },
                    { 476, 4 },
                    { 475, 2 },
                    { 481, 13 },
                    { 474, 22 },
                    { 472, 44 },
                    { 471, 43 },
                    { 470, 43 },
                    { 469, 43 },
                    { 468, 36 },
                    { 467, 20 },
                    { 473, 46 }
                });

            migrationBuilder.InsertData(
                table: "ProfessionSkill",
                columns: new[] { "ProfessionSkillsId", "SkillId" },
                values: new object[,]
                {
                    { 500, 2 },
                    { 482, 43 },
                    { 484, 46 },
                    { 498, 20 },
                    { 497, 10 },
                    { 496, 29 },
                    { 495, 28 },
                    { 494, 46 },
                    { 493, 43 },
                    { 483, 19 },
                    { 492, 43 },
                    { 490, 10 },
                    { 489, 7 },
                    { 488, 27 },
                    { 487, 27 },
                    { 486, 22 },
                    { 485, 46 },
                    { 491, 13 },
                    { 604, 22 },
                    { 534, 43 },
                    { 536, 46 },
                    { 585, 46 },
                    { 584, 43 },
                    { 583, 43 },
                    { 582, 43 },
                    { 581, 41 },
                    { 580, 39 },
                    { 586, 46 },
                    { 579, 13 },
                    { 577, 8 },
                    { 576, 29 },
                    { 575, 2 },
                    { 574, 46 },
                    { 573, 43 },
                    { 572, 13 },
                    { 578, 33 },
                    { 571, 33 },
                    { 587, 46 },
                    { 589, 22 },
                    { 602, 46 },
                    { 601, 44 },
                    { 600, 43 },
                    { 599, 43 },
                    { 598, 13 },
                    { 597, 36 },
                    { 588, 48 },
                    { 596, 10 },
                    { 594, 29 },
                    { 593, 29 },
                    { 592, 28 },
                    { 591, 26 },
                    { 590, 8 },
                    { 590, 4 },
                    { 595, 7 },
                    { 535, 19 },
                    { 570, 4 },
                    { 569, 29 },
                    { 550, 15 },
                    { 549, 13 },
                    { 548, 10 },
                    { 547, 7 },
                    { 546, 29 },
                    { 545, 29 },
                    { 551, 43 },
                    { 544, 4 },
                    { 542, 22 },
                    { 541, 20 },
                    { 540, 19 },
                    { 539, 41 },
                    { 538, 13 },
                    { 537, 46 },
                    { 543, 24 },
                    { 570, 9 },
                    { 552, 43 },
                    { 554, 46 },
                    { 568, 29 },
                    { 567, 22 },
                    { 566, 18 },
                    { 565, 43 },
                    { 564, 16 },
                    { 563, 40 },
                    { 553, 19 },
                    { 562, 13 },
                    { 741, 46 },
                    { 559, 34 },
                    { 558, 29 },
                    { 557, 4 },
                    { 556, 2 },
                    { 555, 46 },
                    { 561, 12 },
                    { 742, 46 },
                    { 789, 40 },
                    { 744, 9 },
                    { 923, 22 },
                    { 924, 2 },
                    { 925, 24 },
                    { 926, 27 },
                    { 927, 29 },
                    { 928, 29 },
                    { 929, 7 },
                    { 930, 10 },
                    { 931, 13 },
                    { 932, 15 },
                    { 933, 43 },
                    { 934, 19 },
                    { 935, 46 },
                    { 936, 3 },
                    { 937, 5 },
                    { 938, 7 },
                    { 939, 35 },
                    { 951, 36 },
                    { 950, 20 },
                    { 950, 10 },
                    { 949, 7 },
                    { 948, 29 },
                    { 947, 29 },
                    { 922, 46 },
                    { 946, 26 },
                    { 945, 4 },
                    { 944, 22 },
                    { 943, 20 },
                    { 942, 43 },
                    { 941, 41 },
                    { 940, 13 },
                    { 945, 8 },
                    { 921, 46 },
                    { 920, 46 },
                    { 919, 46 },
                    { 901, 12 },
                    { 900, 35 },
                    { 899, 10 },
                    { 898, 7 },
                    { 897, 32 },
                    { 896, 27 },
                    { 902, 37 },
                    { 895, 23 },
                    { 893, 47 },
                    { 892, 46 },
                    { 891, 46 },
                    { 890, 19 },
                    { 889, 43 },
                    { 888, 15 },
                    { 894, 1 },
                    { 952, 43 },
                    { 903, 16 },
                    { 905, 43 },
                    { 918, 33 },
                    { 918, 19 },
                    { 917, 43 },
                    { 916, 43 },
                    { 915, 43 },
                    { 914, 13 },
                    { 904, 43 },
                    { 913, 29 },
                    { 911, 29 },
                    { 910, 22 },
                    { 909, 47 },
                    { 908, 46 },
                    { 907, 46 },
                    { 906, 46 },
                    { 912, 29 },
                    { 953, 43 },
                    { 954, 44 },
                    { 955, 46 },
                    { 1004, 7 },
                    { 1003, 3 },
                    { 1002, 46 },
                    { 1001, 46 },
                    { 1000, 46 },
                    { 999, 43 },
                    { 1005, 10 },
                    { 998, 43 },
                    { 996, 13 },
                    { 995, 6 },
                    { 994, 29 },
                    { 993, 28 },
                    { 992, 20 },
                    { 991, 43 },
                    { 997, 14 },
                    { 990, 41 },
                    { 1006, 13 },
                    { 1008, 20 },
                    { 1022, 43 },
                    { 1021, 43 },
                    { 1020, 41 },
                    { 1019, 16 },
                    { 1018, 40 },
                    { 1017, 13 },
                    { 1007, 41 },
                    { 1016, 12 },
                    { 1014, 34 },
                    { 1013, 31 },
                    { 1012, 6 },
                    { 1011, 30 },
                    { 1010, 4 },
                    { 1009, 47 },
                    { 1015, 35 },
                    { 887, 13 },
                    { 989, 13 },
                    { 987, 20 },
                    { 968, 8 },
                    { 968, 4 },
                    { 967, 19 },
                    { 966, 18 },
                    { 965, 16 },
                    { 964, 15 },
                    { 969, 26 },
                    { 963, 13 },
                    { 961, 35 },
                    { 960, 34 },
                    { 959, 11 },
                    { 958, 7 },
                    { 957, 32 },
                    { 956, 46 },
                    { 962, 12 },
                    { 988, 5 },
                    { 970, 28 },
                    { 972, 29 },
                    { 986, 18 },
                    { 985, 43 },
                    { 984, 43 },
                    { 983, 41 },
                    { 982, 5 },
                    { 981, 46 },
                    { 971, 29 },
                    { 980, 46 },
                    { 978, 43 },
                    { 977, 43 },
                    { 976, 36 },
                    { 975, 10 },
                    { 974, 7 },
                    { 973, 29 },
                    { 979, 44 },
                    { 886, 35 },
                    { 885, 10 },
                    { 884, 7 },
                    { 795, 46 },
                    { 794, 19 },
                    { 793, 18 },
                    { 792, 43 },
                    { 791, 43 },
                    { 790, 43 },
                    { 796, 46 },
                    { 788, 14 },
                    { 786, 35 },
                    { 785, 34 },
                    { 784, 33 },
                    { 783, 9 },
                    { 782, 8 },
                    { 781, 30 },
                    { 787, 13 },
                    { 780, 29 },
                    { 797, 46 },
                    { 799, 2 },
                    { 813, 38 },
                    { 812, 13 },
                    { 811, 10 },
                    { 810, 28 },
                    { 809, 46 },
                    { 808, 43 },
                    { 798, 22 },
                    { 807, 43 },
                    { 805, 41 },
                    { 804, 35 },
                    { 803, 7 },
                    { 802, 6 },
                    { 801, 29 },
                    { 800, 4 },
                    { 806, 43 },
                    { 814, 20 },
                    { 779, 4 },
                    { 777, 22 },
                    { 758, 10 },
                    { 757, 29 },
                    { 756, 29 },
                    { 755, 4 },
                    { 754, 2 },
                    { 753, 22 },
                    { 759, 34 },
                    { 752, 46 },
                    { 750, 15 },
                    { 749, 13 },
                    { 748, 35 },
                    { 747, 33 },
                    { 746, 33 },
                    { 745, 33 },
                    { 751, 19 },
                    { 778, 2 },
                    { 760, 35 },
                    { 762, 39 },
                    { 776, 46 },
                    { 775, 43 },
                    { 774, 43 },
                    { 773, 13 },
                    { 772, 33 },
                    { 771, 8 },
                    { 761, 13 },
                    { 770, 30 },
                    { 768, 22 },
                    { 767, 46 },
                    { 766, 43 },
                    { 765, 43 },
                    { 764, 43 },
                    { 763, 41 },
                    { 769, 29 },
                    { 743, 7 },
                    { 815, 3 },
                    { 817, 13 },
                    { 865, 7 },
                    { 864, 1 },
                    { 863, 46 },
                    { 862, 20 },
                    { 861, 43 },
                    { 860, 43 },
                    { 866, 34 },
                    { 859, 41 },
                    { 857, 35 },
                    { 856, 7 },
                    { 855, 29 },
                    { 854, 8 },
                    { 854, 4 },
                    { 853, 2 },
                    { 858, 13 },
                    { 852, 46 },
                    { 867, 12 },
                    { 869, 37 },
                    { 883, 3 },
                    { 882, 24 },
                    { 881, 1 },
                    { 880, 41 },
                    { 879, 13 },
                    { 878, 47 },
                    { 868, 13 },
                    { 877, 43 },
                    { 875, 13 },
                    { 874, 11 },
                    { 873, 7 },
                    { 872, 18 },
                    { 871, 42 },
                    { 870, 16 },
                    { 876, 14 },
                    { 816, 7 },
                    { 851, 46 },
                    { 849, 13 },
                    { 830, 13 },
                    { 829, 7 },
                    { 828, 2 },
                    { 827, 7 },
                    { 827, 19 },
                    { 826, 41 },
                    { 831, 37 },
                    { 825, 13 },
                    { 823, 6 },
                    { 822, 4 },
                    { 821, 47 },
                    { 820, 20 },
                    { 819, 19 },
                    { 818, 15 },
                    { 824, 34 },
                    { 850, 41 },
                    { 832, 15 },
                    { 834, 43 },
                    { 848, 35 },
                    { 847, 29 },
                    { 846, 29 },
                    { 845, 4 },
                    { 844, 19 },
                    { 843, 43 },
                    { 833, 41 },
                    { 842, 39 },
                    { 840, 10 },
                    { 839, 7 },
                    { 838, 6 },
                    { 837, 4 },
                    { 836, 20 },
                    { 835, 19 },
                    { 841, 12 },
                    { 466, 29 },
                    { 150, 9 },
                    { 464, 29 },
                    { 137, 45 },
                    { 138, 13 },
                    { 139, 14 },
                    { 140, 40 },
                    { 141, 16 },
                    { 142, 11 },
                    { 143, 12 },
                    { 144, 13 },
                    { 145, 14 },
                    { 146, 37 },
                    { 147, 40 },
                    { 148, 20 },
                    { 149, 7 },
                    { 149, 22 },
                    { 1023, 46 },
                    { 151, 11 },
                    { 152, 13 },
                    { 164, 46 },
                    { 163, 19 },
                    { 162, 41 },
                    { 161, 13 },
                    { 160, 11 },
                    { 159, 15 },
                    { 137, 12 },
                    { 159, 7 },
                    { 157, 46 },
                    { 156, 46 },
                    { 155, 19 },
                    { 154, 5 },
                    { 154, 43 },
                    { 153, 15 },
                    { 158, 22 },
                    { 136, 34 },
                    { 135, 8 },
                    { 135, 11 },
                    { 118, 19 },
                    { 117, 13 },
                    { 116, 35 },
                    { 116, 11 },
                    { 115, 10 },
                    { 114, 15 },
                    { 119, 46 },
                    { 114, 7 },
                    { 112, 34 },
                    { 112, 3 },
                    { 111, 24 },
                    { 110, 46 },
                    { 109, 19 },
                    { 108, 18 },
                    { 113, 27 },
                    { 165, 6 },
                    { 120, 3 },
                    { 121, 5 },
                    { 134, 18 },
                    { 133, 16 },
                    { 132, 45 },
                    { 132, 40 },
                    { 131, 13 },
                    { 130, 12 },
                    { 120, 15 },
                    { 129, 35 },
                    { 127, 46 },
                    { 126, 43 },
                    { 125, 41 },
                    { 124, 14 },
                    { 123, 13 },
                    { 122, 11 },
                    { 128, 34 },
                    { 165, 3 },
                    { 166, 7 },
                    { 166, 15 },
                    { 207, 9 },
                    { 206, 15 },
                    { 206, 7 },
                    { 205, 46 },
                    { 204, 46 },
                    { 203, 16 },
                    { 208, 11 },
                    { 202, 13 },
                    { 200, 43 },
                    { 200, 29 },
                    { 199, 7 },
                    { 199, 29 },
                    { 198, 22 },
                    { 197, 19 },
                    { 201, 10 },
                    { 196, 15 },
                    { 209, 34 },
                    { 211, 13 },
                    { 223, 8 },
                    { 222, 35 },
                    { 222, 7 },
                    { 221, 46 },
                    { 220, 7 },
                    { 220, 43 },
                    { 210, 12 },
                    { 219, 14 },
                    { 217, 34 },
                    { 216, 8 },
                    { 215, 6 },
                    { 214, 30 },
                    { 213, 4 },
                    { 212, 18 },
                    { 218, 13 },
                    { 107, 34 },
                    { 195, 13 },
                    { 193, 46 },
                    { 175, 8 },
                    { 175, 9 },
                    { 174, 6 },
                    { 173, 7 },
                    { 173, 3 },
                    { 172, 8 },
                    { 176, 11 },
                    { 172, 46 },
                    { 170, 41 },
                    { 169, 11 },
                    { 169, 13 },
                    { 168, 35 },
                    { 167, 4 },
                    { 167, 9 },
                    { 171, 43 },
                    { 194, 11 },
                    { 177, 33 },
                    { 179, 14 },
                    { 193, 7 },
                    { 192, 29 },
                    { 191, 24 },
                    { 190, 22 },
                    { 189, 20 },
                    { 188, 41 },
                    { 178, 13 },
                    { 187, 35 },
                    { 185, 3 },
                    { 184, 20 },
                    { 183, 41 },
                    { 182, 13 },
                    { 181, 28 },
                    { 180, 41 },
                    { 186, 5 },
                    { 107, 43 },
                    { 106, 14 },
                    { 106, 16 },
                    { 36, 11 },
                    { 35, 19 },
                    { 35, 10 },
                    { 34, 7 },
                    { 33, 9 },
                    { 33, 6 },
                    { 37, 33 },
                    { 32, 12 },
                    { 31, 45 },
                    { 31, 17 },
                    { 30, 16 },
                    { 29, 8 },
                    { 29, 39 },
                    { 28, 33 },
                    { 32, 18 },
                    { 28, 14 },
                    { 38, 13 },
                    { 40, 46 },
                    { 49, 4 },
                    { 49, 25 },
                    { 49, 24 },
                    { 49, 21 },
                    { 48, 46 },
                    { 47, 7 },
                    { 39, 15 },
                    { 47, 19 },
                    { 45, 13 },
                    { 44, 10 },
                    { 43, 8 },
                    { 43, 6 },
                    { 42, 27 },
                    { 41, 47 },
                    { 46, 43 },
                    { 49, 31 },
                    { 27, 33 },
                    { 26, 33 },
                    { 11, 4 },
                    { 11, 9 },
                    { 10, 34 },
                    { 10, 7 },
                    { 9, 43 },
                    { 9, 6 },
                    { 12, 12 },
                    { 8, 46 },
                    { 6, 13 },
                    { 5, 10 },
                    { 4, 29 },
                    { 3, 29 },
                    { 2, 28 },
                    { 1, 22 },
                    { 7, 46 },
                    { 27, 9 },
                    { 13, 13 },
                    { 15, 41 },
                    { 26, 31 },
                    { 25, 10 },
                    { 25, 6 },
                    { 24, 27 },
                    { 24, 3 },
                    { 23, 46 },
                    { 14, 16 },
                    { 22, 20 },
                    { 20, 8 },
                    { 19, 5 },
                    { 18, 27 },
                    { 17, 8 },
                    { 17, 45 },
                    { 16, 18 },
                    { 21, 43 },
                    { 224, 9 },
                    { 49, 39 },
                    { 49, 47 },
                    { 93, 19 },
                    { 92, 18 },
                    { 91, 9 },
                    { 91, 16 },
                    { 90, 13 },
                    { 89, 33 },
                    { 93, 14 },
                    { 88, 6 },
                    { 86, 41 },
                    { 85, 14 },
                    { 84, 13 },
                    { 83, 34 },
                    { 82, 8 },
                    { 81, 30 },
                    { 87, 30 },
                    { 80, 20 },
                    { 94, 28 },
                    { 95, 6 },
                    { 105, 13 },
                    { 104, 11 },
                    { 103, 12 },
                    { 103, 32 },
                    { 102, 22 },
                    { 101, 44 },
                    { 94, 25 },
                    { 100, 13 },
                    { 98, 11 },
                    { 97, 20 },
                    { 97, 10 },
                    { 96, 33 },
                    { 96, 31 },
                    { 95, 15 },
                    { 99, 36 },
                    { 49, 18 },
                    { 79, 41 },
                    { 77, 41 },
                    { 62, 20 },
                    { 61, 43 },
                    { 60, 10 },
                    { 59, 29 },
                    { 58, 22 },
                    { 57, 46 },
                    { 63, 5 },
                    { 56, 15 },
                    { 54, 33 },
                    { 53, 10 },
                    { 52, 8 },
                    { 52, 9 },
                    { 51, 28 },
                    { 50, 22 },
                    { 55, 13 },
                    { 78, 46 },
                    { 63, 7 },
                    { 65, 8 },
                    { 76, 39 },
                    { 75, 7 },
                    { 75, 10 },
                    { 74, 6 },
                    { 73, 43 },
                    { 73, 29 },
                    { 64, 30 },
                    { 72, 4 },
                    { 70, 17 },
                    { 69, 43 },
                    { 68, 14 },
                    { 67, 13 },
                    { 66, 46 },
                    { 66, 35 },
                    { 71, 48 },
                    { 225, 11 },
                    { 226, 12 },
                    { 227, 13 },
                    { 393, 6 },
                    { 392, 30 },
                    { 391, 4 },
                    { 391, 28 },
                    { 390, 18 },
                    { 389, 41 },
                    { 394, 7 },
                    { 388, 16 },
                    { 386, 14 },
                    { 385, 13 },
                    { 384, 12 },
                    { 383, 11 },
                    { 383, 28 },
                    { 382, 43 },
                    { 387, 40 },
                    { 381, 8 },
                    { 394, 15 },
                    { 396, 34 },
                    { 408, 13 },
                    { 407, 10 },
                    { 406, 7 },
                    { 406, 6 },
                    { 405, 29 },
                    { 404, 4 },
                    { 395, 9 },
                    { 403, 30 },
                    { 402, 22 },
                    { 401, 20 },
                    { 400, 41 },
                    { 399, 5 },
                    { 398, 46 },
                    { 397, 13 },
                    { 403, 2 },
                    { 409, 20 },
                    { 381, 15 },
                    { 379, 12 },
                    { 365, 44 },
                    { 364, 13 },
                    { 363, 36 },
                    { 362, 11 },
                    { 361, 29 },
                    { 360, 46 },
                    { 366, 46 },
                    { 359, 22 },
                    { 357, 41 },
                    { 356, 37 },
                    { 355, 13 },
                    { 354, 30 },
                    { 353, 19 },
                    { 352, 43 },
                    { 358, 18 },
                    { 380, 14 },
                    { 367, 9 },
                    { 368, 11 },
                    { 378, 35 },
                    { 378, 7 },
                    { 377, 30 },
                    { 376, 13 },
                    { 376, 28 },
                    { 375, 34 },
                    { 367, 7 },
                    { 375, 27 },
                    { 373, 16 },
                    { 373, 43 },
                    { 372, 15 },
                    { 371, 14 },
                    { 370, 13 },
                    { 369, 34 },
                    { 374, 18 },
                    { 351, 15 },
                    { 409, 43 },
                    { 410, 47 },
                    { 446, 17 },
                    { 445, 3 },
                    { 445, 43 },
                    { 444, 41 },
                    { 443, 8 },
                    { 442, 35 },
                    { 447, 20 },
                    { 442, 7 },
                    { 440, 20 },
                    { 439, 13 },
                    { 439, 43 },
                    { 438, 41 },
                    { 437, 4 },
                    { 437, 9 },
                    { 441, 5 },
                    { 436, 28 },
                    { 448, 4 },
                    { 449, 46 },
                    { 463, 29 },
                    { 462, 46 },
                    { 461, 46 },
                    { 460, 22 },
                    { 459, 46 },
                    { 458, 20 },
                    { 448, 8 },
                    { 457, 44 },
                    { 455, 36 },
                    { 454, 10 },
                    { 453, 7 },
                    { 452, 29 },
                    { 451, 29 },
                    { 450, 28 },
                    { 456, 43 },
                    { 410, 22 },
                    { 436, 6 },
                    { 435, 3 },
                    { 420, 28 },
                    { 419, 22 },
                    { 418, 1 },
                    { 418, 19 },
                    { 417, 16 },
                    { 416, 13 },
                    { 420, 11 },
                    { 415, 12 },
                    { 414, 35 },
                    { 413, 11 },
                    { 412, 18 },
                    { 412, 10 },
                    { 411, 32 },
                    { 411, 3 },
                    { 414, 34 },
                    { 435, 7 },
                    { 421, 29 },
                    { 422, 7 },
                    { 434, 48 },
                    { 433, 46 },
                    { 432, 18 },
                    { 431, 17 },
                    { 430, 43 },
                    { 429, 41 },
                    { 422, 29 },
                    { 428, 8 },
                    { 427, 5 },
                    { 426, 46 },
                    { 425, 46 },
                    { 424, 13 },
                    { 423, 5 },
                    { 423, 10 },
                    { 427, 13 },
                    { 465, 29 },
                    { 350, 13 },
                    { 348, 7 },
                    { 271, 35 },
                    { 270, 33 },
                    { 269, 9 },
                    { 268, 7 },
                    { 268, 6 },
                    { 267, 22 },
                    { 272, 13 },
                    { 266, 19 },
                    { 264, 15 },
                    { 263, 13 },
                    { 262, 35 },
                    { 261, 33 },
                    { 260, 10 },
                    { 259, 8 },
                    { 265, 43 },
                    { 258, 7 },
                    { 273, 15 },
                    { 275, 4 },
                    { 287, 46 },
                    { 286, 46 },
                    { 285, 46 },
                    { 284, 7 },
                    { 284, 43 },
                    { 283, 13 },
                    { 274, 19 },
                    { 282, 35 },
                    { 280, 29 },
                    { 279, 22 },
                    { 278, 20 },
                    { 277, 41 },
                    { 276, 15 },
                    { 276, 7 },
                    { 281, 33 },
                    { 288, 22 },
                    { 257, 22 },
                    { 255, 46 },
                    { 240, 7 },
                    { 239, 40 },
                    { 238, 14 },
                    { 237, 13 },
                    { 236, 12 },
                    { 235, 11 },
                    { 240, 20 },
                    { 234, 6 },
                    { 232, 4 },
                    { 231, 34 },
                    { 231, 46 },
                    { 230, 19 },
                    { 229, 17 },
                    { 228, 15 },
                    { 233, 30 },
                    { 256, 48 },
                    { 241, 8 },
                    { 243, 13 },
                    { 254, 17 },
                    { 253, 43 },
                    { 252, 14 },
                    { 251, 13 },
                    { 250, 8 },
                    { 249, 33 },
                    { 242, 10 },
                    { 249, 30 },
                    { 248, 5 },
                    { 247, 35 },
                    { 247, 19 },
                    { 246, 17 },
                    { 245, 43 },
                    { 244, 15 },
                    { 248, 15 },
                    { 349, 11 },
                    { 288, 47 },
                    { 290, 6 },
                    { 333, 22 },
                    { 332, 45 },
                    { 331, 16 },
                    { 330, 39 },
                    { 329, 13 },
                    { 328, 12 },
                    { 334, 29 },
                    { 327, 11 },
                    { 325, 20 },
                    { 324, 41 },
                    { 323, 13 },
                    { 322, 11 },
                    { 321, 5 },
                    { 320, 47 },
                    { 326, 6 },
                    { 320, 28 },
                    { 335, 41 },
                    { 337, 46 },
                    { 348, 10 },
                    { 347, 9 },
                    { 346, 6 },
                    { 345, 46 },
                    { 344, 43 },
                    { 343, 10 },
                    { 336, 43 },
                    { 342, 27 },
                    { 341, 4 },
                    { 340, 7 },
                    { 340, 3 },
                    { 339, 2 },
                    { 339, 24 },
                    { 338, 22 },
                    { 342, 5 },
                    { 289, 24 },
                    { 319, 2 },
                    { 317, 40 },
                    { 301, 41 },
                    { 300, 40 },
                    { 299, 13 },
                    { 298, 11 },
                    { 297, 7 },
                    { 296, 29 },
                    { 302, 20 },
                    { 295, 41 },
                    { 294, 15 },
                    { 293, 13 },
                    { 292, 11 },
                    { 292, 9 },
                    { 291, 7 },
                    { 290, 33 },
                    { 294, 19 },
                    { 318, 16 },
                    { 303, 4 },
                    { 305, 6 },
                    { 316, 14 },
                    { 315, 13 },
                    { 314, 12 },
                    { 313, 11 },
                    { 312, 43 },
                    { 312, 29 },
                    { 304, 30 },
                    { 311, 7 },
                    { 310, 34 },
                    { 310, 40 },
                    { 309, 14 },
                    { 308, 13 },
                    { 307, 11 },
                    { 306, 9 },
                    { 311, 43 },
                    { 1024, 46 }
                });
        }
    }
}