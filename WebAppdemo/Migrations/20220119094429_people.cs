using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppdemo.Migrations
{
    public partial class people : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name", "Skills" },
                values: new object[] { 1, "Naruto", "Shadow Clones" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name", "Skills" },
                values: new object[] { 2, "Sasuke", "Fireball" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
