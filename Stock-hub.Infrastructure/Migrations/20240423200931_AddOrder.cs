using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_hub.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Stocks_Symbol",
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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Symbol",
                table: "Orders",
                column: "Symbol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

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
    }
}
