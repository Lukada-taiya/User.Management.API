using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace User.Management.API.Migrations
{
    public partial class RolesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "109122d2-5786-4bce-9440-c29731087210", "1", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "54207f23-75f4-40c9-b29d-c298f21bb107", "2", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "efc7ea9f-9e40-4ecc-8ff6-45f035b68fce", "3", "Guest", "Guest" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "109122d2-5786-4bce-9440-c29731087210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54207f23-75f4-40c9-b29d-c298f21bb107");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efc7ea9f-9e40-4ecc-8ff6-45f035b68fce");
        }
    }
}
