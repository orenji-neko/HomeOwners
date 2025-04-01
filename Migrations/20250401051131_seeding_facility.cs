using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeOwners.Migrations
{
    /// <inheritdoc />
    public partial class seeding_facility : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c7fe4bf-5f70-4e62-95ff-7bccb376b3ff", "AQAAAAIAAYagAAAAEBoGJx591ufk5g86QDboBQEs55JAJ5E3yJh7L9lzFNYl66YeIYOGHjnUq7CkGlZLNw==", "ff12a9a6-dff8-4bc9-bc60-78eea57f6c77" });

            migrationBuilder.UpdateData(
                table: "facility",
                keyColumn: "Id",
                keyValue: "test-facility-0001",
                columns: new[] { "Address", "Description", "Name" },
                values: new object[] { "Somewhere, i don't really know.", "Tell me about this facility", "Facility Name" });

            migrationBuilder.UpdateData(
                table: "facility",
                keyColumn: "Id",
                keyValue: "test-facility-0002",
                columns: new[] { "Address", "Description", "Name" },
                values: new object[] { "Somewhere, i don't really know.", "Tell me about this facility", "Facility Name" });

            migrationBuilder.InsertData(
                table: "facility",
                columns: new[] { "Id", "Address", "Description", "Name" },
                values: new object[,]
                {
                    { "test-facility-0003", "Somewhere, i don't really know.", "Tell me about this facility", "Facility Name" },
                    { "test-facility-0004", "Somewhere, i don't really know.", "Tell me about this facility", "Facility Name" },
                    { "test-facility-0005", "Somewhere, i don't really know.", "Tell me about this facility", "Facility Name" },
                    { "test-facility-0006", "Somewhere, i don't really know.", "Tell me about this facility", "Facility Name" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "facility",
                keyColumn: "Id",
                keyValue: "test-facility-0003");

            migrationBuilder.DeleteData(
                table: "facility",
                keyColumn: "Id",
                keyValue: "test-facility-0004");

            migrationBuilder.DeleteData(
                table: "facility",
                keyColumn: "Id",
                keyValue: "test-facility-0005");

            migrationBuilder.DeleteData(
                table: "facility",
                keyColumn: "Id",
                keyValue: "test-facility-0006");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04390667-5e0a-4247-a2f7-011500514731", "AQAAAAIAAYagAAAAEGGAd+utqqOpqNmCvm5TxruuLbLHtoPjb2Z+nqrsbokpUBtevo9pgXB/88hPSTGT0Q==", "7912a8c9-74d5-4f8c-9a34-743550c89c6a" });

            migrationBuilder.UpdateData(
                table: "facility",
                keyColumn: "Id",
                keyValue: "test-facility-0001",
                columns: new[] { "Address", "Description", "Name" },
                values: new object[] { "2578 Folsom Street, San Francisco, CA, 94110", "A pool where you can swim.", "Swimming Pool" });

            migrationBuilder.UpdateData(
                table: "facility",
                keyColumn: "Id",
                keyValue: "test-facility-0002",
                columns: new[] { "Address", "Description", "Name" },
                values: new object[] { "2578 Folsom Street, San Francisco, CA, 94110", "Park where you can play golf", "Golf Park" });
        }
    }
}
