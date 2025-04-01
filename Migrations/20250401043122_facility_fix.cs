using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeOwners.Migrations
{
    /// <inheritdoc />
    public partial class facility_fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK__facility",
                table: "_facility");

            migrationBuilder.RenameTable(
                name: "_facility",
                newName: "facility");

            migrationBuilder.AddPrimaryKey(
                name: "PK_facility",
                table: "facility",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3812a19c-7040-4812-95f0-660e6e35ca0e", "AQAAAAIAAYagAAAAEA2W/kGAfoqgL6RweZFFaxZDwAhCUyO2224NiHgLx14ActTgfGFwSoVJywaiF6srUQ==", "751c34a7-2be9-436b-b6bc-ac05100ff0a8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_facility",
                table: "facility");

            migrationBuilder.RenameTable(
                name: "facility",
                newName: "_facility");

            migrationBuilder.AddPrimaryKey(
                name: "PK__facility",
                table: "_facility",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d35d550b-2105-481c-bca2-7e5f7aae45a1", "AQAAAAIAAYagAAAAEKPSrVC7g8KcwJGc2B5hfFo8ksRvdpn3Tr3kXazCrbq20DWigzZOsL1BfI1+80vVgw==", "125385c2-dd47-4ffc-b5a7-d4a2a4e36feb" });
        }
    }
}
