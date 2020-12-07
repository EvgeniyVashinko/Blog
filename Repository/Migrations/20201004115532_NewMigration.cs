using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Like_amount",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Articles",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "ArticleLike",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ArticleId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    PublishDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleLike", x => new { x.ArticleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ArticleLike_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleLike_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profile_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    ArticleId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    Text = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => new { x.ArticleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Report_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Report_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TagName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleTag",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(nullable: false),
                    TagId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTag", x => new { x.ArticleId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ArticleTag_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "c2bc5334-49eb-4f6f-94d9-6d267179e5b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "982436a0-719b-4270-bf77-da20aa910f25", "AQAAAAEAACcQAAAAEEsY+6GLtkBurOuoFZlu2RAAnwGKsTSG5hup6Zehm9+ao2o6dQmkUpoetgXxvZIsfw==" });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleLike_UserId",
                table: "ArticleLike",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTag_TagId",
                table: "ArticleTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserId",
                table: "Profile",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Report_UserId",
                table: "Report",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleLike");

            migrationBuilder.DropTable(
                name: "ArticleTag");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.AddColumn<int>(
                name: "Like_amount",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "77fbe92a-5e54-4128-9c1a-0cda1da79b91");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a4f7d10-1850-48cf-b182-3e24a39b3f69", "AQAAAAEAACcQAAAAEIYAUZtv4yxAZVn5rbeALgsFWpWsU2ZcPLnS3T+DVm0/7u9Lj5G9CV4mGa10bVEBHw==" });
        }
    }
}
