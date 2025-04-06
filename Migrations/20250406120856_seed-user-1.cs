using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeOwners.Migrations
{
    /// <inheritdoc />
    public partial class seeduser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91cafc00-fa46-48f6-b151-e94d7430dc82", "AQAAAAIAAYagAAAAEEafFnh1fVmtU4akXH3bnpVG8I5PDWNvVpPIez51f3xn+LQF9lQvBXxLdAYVM2Fsrg==", "82c1962f-9ee6-4399-990b-343bf3319902" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MidInitial", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "test-admin-0001", 0, "123 User St.", "e7ff6dc3-4871-4a8e-bf8e-160ac1f0d444", "admin@email.com", false, "John", "Doe", false, null, "A", "ADMIN@EMAIL.COM", "ADMIN@EMAIL.COM", "AQAAAAIAAYagAAAAEP/RbxwUIy+GdPNCYcESqvvC9F8Hu3VNSKiSlUywKI3eF3T6FTPrEGqDnSl1a4XRPg==", null, false, "a279902e-b43f-4485-bcc5-1641bdd81d90", false, "admin@email.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "role-admin-0001", "test-admin-0001" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "role-admin-0001", "test-admin-0001" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-admin-0001");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "test-user-0001",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5cf0a1e-c579-4d6f-a285-cb83b4a98eb2", "AQAAAAIAAYagAAAAEK1ueo/uXjNyIIDU484G5bIdzgEtpaTBgZSgVjvHHs7ESQQnvbnPOC30lV4Uoyh1pw==", "4e056c83-efef-4be3-8862-b59463226719" });
        }
    }
}
