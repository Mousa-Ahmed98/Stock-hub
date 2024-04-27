using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_hub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OrderTimeStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "AAPL",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 25, 23, 34, 19, 845, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "AMZN",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 25, 23, 34, 19, 845, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "GOOGL",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 25, 23, 34, 19, 845, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "MSFT",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 25, 23, 34, 19, 845, DateTimeKind.Local).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "TSLA",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 25, 23, 34, 19, 845, DateTimeKind.Local).AddTicks(1497));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "AAPL",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 22, 9, 29, 738, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "AMZN",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 22, 9, 29, 738, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "GOOGL",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 22, 9, 29, 738, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "MSFT",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 22, 9, 29, 738, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "TSLA",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 22, 9, 29, 738, DateTimeKind.Local).AddTicks(3049));
        }
    }
}
