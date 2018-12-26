using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectColectiv.Data.Migrations
{
    public partial class MockDataAndJobsProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Jobs",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "AvailableUntil",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PostedOn",
                table: "Jobs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "AvailableUntil", "Description", "PostedOn", "Title" },
                values: new object[] { 1, new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Se doreste un astronaut part-time.Program flexibil si cina inclusa(cereale dezhidratate)", new DateTime(2018, 11, 8, 22, 10, 26, 580, DateTimeKind.Local), "Astronaut" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "AvailableUntil", "Description", "PostedOn", "Title" },
                values: new object[] { 2, new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Se doreste un pitic pentru eschibitii pe Piezisa. Program flexibil si bere inclusa(de la Infinity)", new DateTime(2018, 11, 8, 22, 10, 26, 580, DateTimeKind.Local), "Pitic" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "AvailableUntil", "Description", "PostedOn", "Title" },
                values: new object[] { 3, new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Program flexibil si masa inclusa(skittles)", new DateTime(2018, 11, 8, 22, 10, 26, 580, DateTimeKind.Local), "Crescatpr de unicorni" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "AvailableUntil",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "PostedOn",
                table: "Jobs");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Jobs",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
