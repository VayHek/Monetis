using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonetisV2.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedExpenses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "Id", "Amount", "Category", "Date", "Description" },
                values: new object[,]
                {
                    { 1, 4.50m, "Food", new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local), "Coffee" },
                    { 2, 30.00m, "Transport", new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local), "Gas" },
                    { 3, 80.75m, "Food", new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local), "Groceries" },
                    { 4, 12.99m, "Entertainment", new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), "Netflix" },
                    { 5, 25.00m, "Education", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local), "Books" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
