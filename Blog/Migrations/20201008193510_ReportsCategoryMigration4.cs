using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class ReportsCategoryMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reports_ReportCategoryId",
                table: "Reports");

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("2ea7e590-5d0f-40fa-ab6e-0b24ee13826f"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("71bf669f-548f-4997-b981-6304d6766929"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("99605e3d-262a-485a-81e8-7cd1fcc56c52"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("f67819b2-5260-45f4-b1fc-63f2360d9a3a"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("fde9843a-b59a-4595-a4bc-9b7d05cee742"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "ec2d88bb-4cab-41e0-b402-eac184a5396f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "448b5dcb-93b4-48c1-beb3-0df432bad85a", "AQAAAAEAACcQAAAAEKyFPdI4fsMFpMuFUH41Izy8jKgJIHb20UZODOCJnHX2WEWP6VLhyB144I0L/MYCew==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7aeb102f-b9ab-46a6-8100-fd06bf9d08b8"), "Пропаганда наркотиков" },
                    { new Guid("af264510-cab8-4ee0-9fc5-53bfd7b85160"), "Порнография" },
                    { new Guid("147bdf05-77a4-4061-868c-4509b48b4fbd"), "Продажа оружия" },
                    { new Guid("2c3c7ed0-7bc1-4898-9209-f571f3737a89"), "Мошенничество" },
                    { new Guid("89381d79-612b-4081-9597-e69527a59a87"), "Призыв к суициду" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportCategoryId",
                table: "Reports",
                column: "ReportCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reports_ReportCategoryId",
                table: "Reports");

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("147bdf05-77a4-4061-868c-4509b48b4fbd"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c3c7ed0-7bc1-4898-9209-f571f3737a89"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("7aeb102f-b9ab-46a6-8100-fd06bf9d08b8"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("89381d79-612b-4081-9597-e69527a59a87"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("af264510-cab8-4ee0-9fc5-53bfd7b85160"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "4e29ff6e-e39d-423c-9bb8-92cb9f3b83b9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f8f7f33-100c-44bc-a1a0-d73531c0ab2d", "AQAAAAEAACcQAAAAEIwqf8lKbatCp12nZkJXlvfb5tMftHmz5UBHsJZOYSMV+haYe1j0WDYUSY83oDLM1A==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f67819b2-5260-45f4-b1fc-63f2360d9a3a"), "Пропаганда наркотиков" },
                    { new Guid("2ea7e590-5d0f-40fa-ab6e-0b24ee13826f"), "Порнография" },
                    { new Guid("99605e3d-262a-485a-81e8-7cd1fcc56c52"), "Продажа оружия" },
                    { new Guid("fde9843a-b59a-4595-a4bc-9b7d05cee742"), "Мошенничество" },
                    { new Guid("71bf669f-548f-4997-b981-6304d6766929"), "Призыв к суициду" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportCategoryId",
                table: "Reports",
                column: "ReportCategoryId",
                unique: true);
        }
    }
}
