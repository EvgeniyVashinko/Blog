using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class ArticleCommentUpdMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UserId1",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId1",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("636ead2c-df7b-4baa-b84f-7144a9bc6ca7"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("95ee7edd-0187-4efe-a4db-4c9fe3c655fc"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("9bef6af5-088d-4757-8770-d1818789ba2b"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("9c3bdcb3-74a4-42e2-b2be-343b440b9745"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("ba80a8d7-9da1-41a6-9e33-f189f4c6dd3e"));

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "1802311e-d917-47a9-b09c-9301eee669ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf5a14f1-f3da-4135-adcc-1165333c4d0f", "AQAAAAEAACcQAAAAEIpEmeyQXCEBPcsWcsVFJHHX3m7IADJEcuVRbavXEGajBFgmW7mhYxkgqkg2kqLAvQ==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3d8dfbfe-4ac7-4888-a983-56a51043e125"), "Пропаганда наркотиков" },
                    { new Guid("4c560ee6-4cbe-4c20-82a0-0695d0ae8483"), "Порнография" },
                    { new Guid("cef4d27d-836e-45c9-b072-d6b7d3d83959"), "Продажа оружия" },
                    { new Guid("2f765218-b157-4f91-b404-2f6d1cd2926e"), "Мошенничество" },
                    { new Guid("00cc763c-3708-4a04-9efd-7eeba27dd2ef"), "Призыв к суициду" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("00cc763c-3708-4a04-9efd-7eeba27dd2ef"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("2f765218-b157-4f91-b404-2f6d1cd2926e"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d8dfbfe-4ac7-4888-a983-56a51043e125"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("4c560ee6-4cbe-4c20-82a0-0695d0ae8483"));

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: new Guid("cef4d27d-836e-45c9-b072-d6b7d3d83959"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Comments",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "7af5ccbb-8ab7-4b32-a600-092951e952b3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e7c5f03-ac21-4fb4-8595-37b5cd787ae8", "AQAAAAEAACcQAAAAEGCBS96eVMue7QrjPw+Rv36UBM8ul7+pZ8kyZ8BWiYzt0C2BicTFAKundRKkXitsyQ==" });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9bef6af5-088d-4757-8770-d1818789ba2b"), "Пропаганда наркотиков" },
                    { new Guid("95ee7edd-0187-4efe-a4db-4c9fe3c655fc"), "Порнография" },
                    { new Guid("9c3bdcb3-74a4-42e2-b2be-343b440b9745"), "Продажа оружия" },
                    { new Guid("636ead2c-df7b-4baa-b84f-7144a9bc6ca7"), "Мошенничество" },
                    { new Guid("ba80a8d7-9da1-41a6-9e33-f189f4c6dd3e"), "Призыв к суициду" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId1",
                table: "Comments",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UserId1",
                table: "Comments",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
