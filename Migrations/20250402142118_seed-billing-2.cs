using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeOwners.Migrations
{
    /// <inheritdoc />
    public partial class seedbilling2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "IssuedAt",
                table: "Billing",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ad654c4-c810-49f3-8cc3-6677f0a6a01f", "AQAAAAIAAYagAAAAEHDhlYMANcxZ8YQUCGLA8Qlj5xI5o9caPRTv+tJGGA46eWNNipeMsYBujvA081WPxg==", "16da81be-b014-445c-8667-25f26ec9f46f" });

            migrationBuilder.UpdateData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0001",
                column: "IssuedAt",
                value: new DateOnly(2025, 4, 2));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IssuedAt",
                table: "Billing");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6e11039-f2db-4953-80a7-9bf93e43135a", "AQAAAAIAAYagAAAAEOHLu3gBe0rVEPgfXYUW7D5HD/AqBRORU0h4WEjmyU4wxO+UMP6J8Bqx6DqRdBaJ8g==", "03433448-c8bd-4099-a6ab-364819e5ad0e" });
        }
    }
}
