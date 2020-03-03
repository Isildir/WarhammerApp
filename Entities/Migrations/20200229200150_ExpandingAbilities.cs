using Microsoft.EntityFrameworkCore.Migrations;

namespace WarhammerProfessionApp.Migrations
{
    public partial class ExpandingAbilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasImpactOnStatictics",
                table: "Abilities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ImpactValue",
                table: "Abilities",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "ValueToAlter",
                table: "Abilities",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HasImpactOnStatictics", "ImpactValue", "ValueToAlter" },
                values: new object[] { true, 5, (byte)3 });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HasImpactOnStatictics", "ImpactValue", "ValueToAlter" },
                values: new object[] { true, 1, (byte)13 });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "HasImpactOnStatictics", "ImpactValue", "ValueToAlter" },
                values: new object[] { true, 5, (byte)6 });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "HasImpactOnStatictics", "ImpactValue", "ValueToAlter" },
                values: new object[] { true, 5, (byte)8 });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "HasImpactOnStatictics", "ImpactValue", "ValueToAlter" },
                values: new object[] { true, 5, (byte)4 });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "HasImpactOnStatictics", "ImpactValue", "ValueToAlter" },
                values: new object[] { true, 5, (byte)7 });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "HasImpactOnStatictics", "ImpactValue", "ValueToAlter" },
                values: new object[] { true, 5, (byte)2 });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "HasImpactOnStatictics", "ImpactValue", "ValueToAlter" },
                values: new object[] { true, 5, (byte)5 });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "HasImpactOnStatictics", "ImpactValue", "ValueToAlter" },
                values: new object[] { true, 1, (byte)10 });

            migrationBuilder.UpdateData(
                table: "Abilities",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "HasImpactOnStatictics", "ImpactValue", "ValueToAlter" },
                values: new object[] { true, 5, (byte)1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasImpactOnStatictics",
                table: "Abilities");

            migrationBuilder.DropColumn(
                name: "ImpactValue",
                table: "Abilities");

            migrationBuilder.DropColumn(
                name: "ValueToAlter",
                table: "Abilities");
        }
    }
}
