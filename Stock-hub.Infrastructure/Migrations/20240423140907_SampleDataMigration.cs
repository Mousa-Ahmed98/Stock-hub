using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Stock_hub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SampleDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Symbol", "CurrentPrice", "TimeStamp" },
                values: new object[,]
                {
                    { "AAPL", 12.34m, new DateTime(2024, 4, 23, 16, 9, 5, 682, DateTimeKind.Local).AddTicks(9805) },
                    { "AMZN", 98.4m, new DateTime(2024, 4, 23, 16, 9, 5, 682, DateTimeKind.Local).AddTicks(9981) },
                    { "GOOGL", 15.19m, new DateTime(2024, 4, 23, 16, 9, 5, 682, DateTimeKind.Local).AddTicks(9962) },
                    { "MSFT", 102.11m, new DateTime(2024, 4, 23, 16, 9, 5, 682, DateTimeKind.Local).AddTicks(9973) },
                    { "TSLA", 211.02m, new DateTime(2024, 4, 23, 16, 9, 5, 682, DateTimeKind.Local).AddTicks(9988) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "AAPL");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "AMZN");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "GOOGL");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "MSFT");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "TSLA");
        }
    }
}
