using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class _BlogDBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D4135A4-6F21-4833-81D1-128104AA12C0",
                column: "ConcurrencyStamp",
                value: "f7c0ecf7-a7fb-4ecc-b597-6c7a41bb7ab6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "f39e3968-e8da-41a3-a3fa-790eb5a8f8b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4133cb66-ebd7-44d7-bd02-ac7b77f5c23f", "AQAAAAEAACcQAAAAEKXbkKf45NhgNy5QbM1A8bj0wbGaAL38gGK7fIgEUPswzum4Y2kUQSHD2kLy3afd5w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5D4135A4-6F21-4833-81D1-128104AA12C0",
                column: "ConcurrencyStamp",
                value: "918fac3d-647c-4def-882b-dd760ffbc168");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "004d996c-5340-4270-bb80-85004996211b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f632d1d2-f937-4548-b640-85d78e4f7713", "AQAAAAEAACcQAAAAEOpULNY0gtiQzLuVW+kRn1HrLn4IuPeR1bzuWiXAUShzNFvbBAEoQjl/Rne9O5f3Jw==" });
        }
    }
}
