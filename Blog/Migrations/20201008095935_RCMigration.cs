using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class RCMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Reports");

            migrationBuilder.AddColumn<Guid>(
                name: "ReportCategoryId",
                table: "Reports",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ReportCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportCategories", x => x.Id);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_ReportCategories_ReportCategoryId",
                table: "Reports",
                column: "ReportCategoryId",
                principalTable: "ReportCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_ReportCategories_ReportCategoryId",
                table: "Reports");

            migrationBuilder.DropTable(
                name: "ReportCategories");

            migrationBuilder.DropIndex(
                name: "IX_Reports_ReportCategoryId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ReportCategoryId",
                table: "Reports");

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "1ae1e5a4-6a43-406d-beeb-c93367666928");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec0b3908-9236-4b86-980c-f9f1f454c919", "AQAAAAEAACcQAAAAEIGTNMuSg6NPAtG0tR40zGK8KpZ5gC39zYqxOb9toRXE/Uy1abBMxJngU6zNeQZ9nw==" });
        }
    }
}
