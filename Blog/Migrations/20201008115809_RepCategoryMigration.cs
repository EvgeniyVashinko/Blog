using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class RepCategoryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reports_ReportCategoryId",
                table: "Reports");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "6d30133d-ba10-4db8-b5f3-f5797155bbe3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "223b2772-2d74-4677-b330-6e2c8660c6ca", "AQAAAAEAACcQAAAAECQzlcGoLDbg1510vDBwNvY0EW3hCVboXUrYFeX6VszhTl82XL0LQYQ2OutTU2s09A==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4f7e78f2-f037-41ee-8182-91be8adfce8a"), "Пропаганда наркотиков" },
                    { new Guid("2b553100-7dd9-4194-861e-ac05801552b8"), "Порнография" },
                    { new Guid("2174feb6-8e67-43f2-b5a1-9af6b9312be4"), "Продажа оружия" },
                    { new Guid("3e4fa7f9-d92a-45bb-9ca9-63aab28daa6a"), "Мошенничество" },
                    { new Guid("a8f421a2-eb45-4251-a361-38b3c1b66def"), "Призыв к суициду" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportCategoryId",
                table: "Reports",
                column: "ReportCategoryId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reports_ReportCategoryId",
                table: "Reports");

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("2174feb6-8e67-43f2-b5a1-9af6b9312be4"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("2b553100-7dd9-4194-861e-ac05801552b8"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e4fa7f9-d92a-45bb-9ca9-63aab28daa6a"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("4f7e78f2-f037-41ee-8182-91be8adfce8a"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("a8f421a2-eb45-4251-a361-38b3c1b66def"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "1d91c729-c79e-4a34-a987-5945002c1804");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6abc76f2-958a-432f-beec-2de7a455bf24", "AQAAAAEAACcQAAAAEKa9afXfYw5HXWbrmBdK7wzEYwCpvzrIlyA+SXmsSEjcUn6PQjMxDTi4s2pYPNHZ6g==" });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportCategoryId",
                table: "Reports",
                column: "ReportCategoryId");
        }
    }
}
