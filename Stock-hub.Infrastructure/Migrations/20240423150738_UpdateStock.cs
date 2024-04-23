using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_hub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StocksHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CurrentPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NewPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StocksHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StocksHistory_Stocks_Symbol",
                        column: x => x.Symbol,
                        principalTable: "Stocks",
                        principalColumn: "Symbol",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_StocksHistory_Symbol",
                table: "StocksHistory",
                column: "Symbol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StocksHistory");

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "AAPL",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 16, 9, 5, 682, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "AMZN",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 16, 9, 5, 682, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "GOOGL",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 16, 9, 5, 682, DateTimeKind.Local).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "MSFT",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 16, 9, 5, 682, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Symbol",
                keyValue: "TSLA",
                column: "TimeStamp",
                value: new DateTime(2024, 4, 23, 16, 9, 5, 682, DateTimeKind.Local).AddTicks(9988));
        }
    }
}
