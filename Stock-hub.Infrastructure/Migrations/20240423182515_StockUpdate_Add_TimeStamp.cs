using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_hub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class StockUpdate_Add_TimeStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "StocksHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "AAPL",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 20, 25, 14, 435, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "AMZN",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 20, 25, 14, 435, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "GOOGL",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 20, 25, 14, 435, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "MSFT",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 20, 25, 14, 435, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "TSLA",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 20, 25, 14, 435, DateTimeKind.Local).AddTicks(4762));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "StocksHistory");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "AAPL",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 17, 7, 37, 303, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "AMZN",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 17, 7, 37, 303, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "GOOGL",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 17, 7, 37, 303, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "MSFT",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 17, 7, 37, 303, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "TSLA",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 17, 7, 37, 303, DateTimeKind.Local).AddTicks(6234));
        }
    }
}
