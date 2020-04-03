using Microsoft.EntityFrameworkCore.Migrations;

namespace WarhammerProfessionApp.Migrations
{
    public partial class StatisticConfigurationChange : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCalculatedValue",
                table: "Statistics");

            migrationBuilder.DropColumn(
                name: "IsReadOnly",
                table: "Statistics");

            migrationBuilder.DropColumn(
                name: "CurrentLoad",
                table: "Characters");

            migrationBuilder.AddColumn<bool>(
                name: "IsChangeFree",
                table: "Statistics",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ValueIsCalculated",
                table: "Statistics",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)11,
                column: "ValueIsCalculated",
                value: true);

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)12,
                column: "ValueIsCalculated",
                value: true);

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)15,
                column: "IsChangeFree",
                value: true);

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)16,
                column: "IsChangeFree",
                value: true);
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsChangeFree",
                table: "Statistics");

            migrationBuilder.DropColumn(
                name: "ValueIsCalculated",
                table: "Statistics");

            migrationBuilder.AddColumn<bool>(
                name: "IsCalculatedValue",
                table: "Statistics",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsReadOnly",
                table: "Statistics",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CurrentLoad",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)11,
                columns: new[] { "IsCalculatedValue", "IsReadOnly" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)12,
                columns: new[] { "IsCalculatedValue", "IsReadOnly" },
                values: new object[] { true, true });

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)13,
                column: "IsReadOnly",
                value: true);

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)14,
                column: "IsReadOnly",
                value: true);

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)15,
                column: "IsCalculatedValue",
                value: true);

            migrationBuilder.UpdateData(
                table: "Statistics",
                keyColumn: "Id",
                keyValue: (byte)16,
                column: "IsCalculatedValue",
                value: true);
        }
    }
}