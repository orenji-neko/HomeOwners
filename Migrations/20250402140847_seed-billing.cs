using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeOwners.Migrations
{
    /// <inheritdoc />
    public partial class seedbilling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6e11039-f2db-4953-80a7-9bf93e43135a", "AQAAAAIAAYagAAAAEOHLu3gBe0rVEPgfXYUW7D5HD/AqBRORU0h4WEjmyU4wxO+UMP6J8Bqx6DqRdBaJ8g==", "03433448-c8bd-4099-a6ab-364819e5ad0e" });

            migrationBuilder.InsertData(
                table: "Billing",
                columns: new[] { "Id", "Amount", "IsPaid", "Name", "UserId" },
                values: new object[] { "test-billing-0001", 2000.0, false, "Rent", "test-user-0001" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Billing",
                keyColumn: "Id",
                keyValue: "test-billing-0001");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af80ba14-78af-4eff-a7ea-124f1bfe1bad", "AQAAAAIAAYagAAAAEKBzaA4VdL997HxmNOWTH2sHIrHS5uP/jb0HKskp2dsYW/+0/CkW8/mK0Y4hsnHVbg==", "d7ffc6c4-9766-42c0-a182-6680df6b80c0" });
        }
    }
}
