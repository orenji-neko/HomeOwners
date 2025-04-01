using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeOwners.Migrations
{
    /// <inheritdoc />
    public partial class facilitydb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_facility",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__facility", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d35d550b-2105-481c-bca2-7e5f7aae45a1", "AQAAAAIAAYagAAAAEKPSrVC7g8KcwJGc2B5hfFo8ksRvdpn3Tr3kXazCrbq20DWigzZOsL1BfI1+80vVgw==", "125385c2-dd47-4ffc-b5a7-d4a2a4e36feb" });

            migrationBuilder.InsertData(
                table: "_facility",
                columns: new[] { "Id", "Address", "Description", "Name" },
                values: new object[,]
                {
                    { "test-facility-0001", "2578 Folsom Street, San Francisco, CA, 94110", "A pool where you can swim.", "Swimming Pool" },
                    { "test-facility-0002", "2578 Folsom Street, San Francisco, CA, 94110", "Park where you can play golf", "Golf Park" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_facility");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a216eeb-8b15-435b-8a84-6932dfd27553", "AQAAAAIAAYagAAAAEPYiFTyAwLLhZ/JI37uq6Ou6Q2+AMq59S7SfSexK0s6xMDVNzsTlX43xJ5USLIlEiQ==", "854aa33d-d736-4836-9224-4506a91a8ca4" });
        }
    }
}
