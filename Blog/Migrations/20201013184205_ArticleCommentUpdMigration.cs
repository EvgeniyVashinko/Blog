using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class ArticleCommentUpdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Comments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Comments",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(Guid));

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
    }
}
