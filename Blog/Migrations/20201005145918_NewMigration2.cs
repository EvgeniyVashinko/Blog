using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class NewMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleLike_Articles_ArticleId",
                table: "ArticleLike");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleLike_AspNetUsers_UserId",
                table: "ArticleLike");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleTag_Articles_ArticleId",
                table: "ArticleTag");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleTag_Tags_TagId",
                table: "ArticleTag");

            migrationBuilder.DropForeignKey(
                name: "FK_Profile_AspNetUsers_UserId",
                table: "Profile");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_Articles_ArticleId",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_AspNetUsers_UserId",
                table: "Report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Report",
                table: "Report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profile",
                table: "Profile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleTag",
                table: "ArticleTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleLike",
                table: "ArticleLike");

            migrationBuilder.RenameTable(
                name: "Report",
                newName: "Reports");

            migrationBuilder.RenameTable(
                name: "Profile",
                newName: "Profiles");

            migrationBuilder.RenameTable(
                name: "ArticleTag",
                newName: "ArticleTags");

            migrationBuilder.RenameTable(
                name: "ArticleLike",
                newName: "ArticleLikes");

            migrationBuilder.RenameIndex(
                name: "IX_Report_UserId",
                table: "Reports",
                newName: "IX_Reports_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Profile_UserId",
                table: "Profiles",
                newName: "IX_Profiles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleTag_TagId",
                table: "ArticleTags",
                newName: "IX_ArticleTags_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleLike_UserId",
                table: "ArticleLikes",
                newName: "IX_ArticleLikes_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports",
                table: "Reports",
                columns: new[] { "ArticleId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleTags",
                table: "ArticleTags",
                columns: new[] { "ArticleId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleLikes",
                table: "ArticleLikes",
                columns: new[] { "ArticleId", "UserId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "5c8a70f6-88c3-4b6c-9955-d41175d6fb39");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "555456d1-a0c9-40cd-9d62-ac481a7d0fdc", "AQAAAAEAACcQAAAAEPqQ/p32cpIWtxHmm2I/ilIZBOTxbaeEBoWhUjq0woHaG//7SYv2EjF+zmrooxriKQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleLikes_Articles_ArticleId",
                table: "ArticleLikes",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleLikes_AspNetUsers_UserId",
                table: "ArticleLikes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTags_Articles_ArticleId",
                table: "ArticleTags",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTags_Tags_TagId",
                table: "ArticleTags",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profiles_AspNetUsers_UserId",
                table: "Profiles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Articles_ArticleId",
                table: "Reports",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_AspNetUsers_UserId",
                table: "Reports",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleLikes_Articles_ArticleId",
                table: "ArticleLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleLikes_AspNetUsers_UserId",
                table: "ArticleLikes");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleTags_Articles_ArticleId",
                table: "ArticleTags");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleTags_Tags_TagId",
                table: "ArticleTags");

            migrationBuilder.DropForeignKey(
                name: "FK_Profiles_AspNetUsers_UserId",
                table: "Profiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Articles_ArticleId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_AspNetUsers_UserId",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleTags",
                table: "ArticleTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArticleLikes",
                table: "ArticleLikes");

            migrationBuilder.RenameTable(
                name: "Reports",
                newName: "Report");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "Profile");

            migrationBuilder.RenameTable(
                name: "ArticleTags",
                newName: "ArticleTag");

            migrationBuilder.RenameTable(
                name: "ArticleLikes",
                newName: "ArticleLike");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_UserId",
                table: "Report",
                newName: "IX_Report_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_UserId",
                table: "Profile",
                newName: "IX_Profile_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleTags_TagId",
                table: "ArticleTag",
                newName: "IX_ArticleTag_TagId");

            migrationBuilder.RenameIndex(
                name: "IX_ArticleLikes_UserId",
                table: "ArticleLike",
                newName: "IX_ArticleLike_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Report",
                table: "Report",
                columns: new[] { "ArticleId", "UserId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profile",
                table: "Profile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleTag",
                table: "ArticleTag",
                columns: new[] { "ArticleId", "TagId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArticleLike",
                table: "ArticleLike",
                columns: new[] { "ArticleId", "UserId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleLike_Articles_ArticleId",
                table: "ArticleLike",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleLike_AspNetUsers_UserId",
                table: "ArticleLike",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTag_Articles_ArticleId",
                table: "ArticleTag",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleTag_Tags_TagId",
                table: "ArticleTag",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_AspNetUsers_UserId",
                table: "Profile",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_Articles_ArticleId",
                table: "Report",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_AspNetUsers_UserId",
                table: "Report",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
