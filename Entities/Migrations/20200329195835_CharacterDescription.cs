using Microsoft.EntityFrameworkCore.Migrations;

namespace WarhammerProfessionApp.Migrations
{
    public partial class CharacterDescription : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "MaximumValue",
                table: "CharacterStatistic",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<byte>(
                name: "Race",
                table: "Characters",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldNullable: true);
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaximumValue",
                table: "CharacterStatistic");

            migrationBuilder.AlterColumn<byte>(
                name: "Race",
                table: "Characters",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Characters",
                nullable: true);
        }
    }
}