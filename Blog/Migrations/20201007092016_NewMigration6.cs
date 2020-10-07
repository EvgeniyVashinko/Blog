using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class NewMigration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Categories",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ED70FD60-DE76-4497-9FBB-822F7759DBAE",
                column: "ConcurrencyStamp",
                value: "fd2c50e3-f5f6-4133-8bf1-b5f82a0954dc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DD20FD22-4350-4D1C-98C4-E82F21C1F414",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e13db17b-0891-4d1c-b57e-a2b59bedd3d4", "AQAAAAEAACcQAAAAEBJ27b2Zqf/YTL5M3cOwFAb45L4eRK6wEAGWCin2THLbElTXADkH8ZA+hILfBjVGYQ==" });
        }
    }
}
