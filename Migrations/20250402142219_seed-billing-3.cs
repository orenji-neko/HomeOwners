using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeOwners.Migrations
{
    /// <inheritdoc />
    public partial class seedbilling3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5cf0a1e-c579-4d6f-a285-cb83b4a98eb2", "AQAAAAIAAYagAAAAEK1ueo/uXjNyIIDU484G5bIdzgEtpaTBgZSgVjvHHs7ESQQnvbnPOC30lV4Uoyh1pw==", "4e056c83-efef-4be3-8862-b59463226719" });

            migrationBuilder.InsertData(
                table: "Billing",
                columns: new[] { "Id", "Amount", "IsPaid", "IssuedAt", "Name", "UserId" },
                values: new object[] { "test-billing-0002", 150.0, false, new DateOnly(2025, 4, 2), "Electricity", "test-user-0001" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0002");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ad654c4-c810-49f3-8cc3-6677f0a6a01f", "AQAAAAIAAYagAAAAEHDhlYMANcxZ8YQUCGLA8Qlj5xI5o9caPRTv+tJGGA46eWNNipeMsYBujvA081WPxg==", "16da81be-b014-445c-8667-25f26ec9f46f" });
        }
    }
}
