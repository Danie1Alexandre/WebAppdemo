using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppdemo.Migrations
{
    public partial class uppdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_City_CityId",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "City");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "City",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CountryID", "Name" },
                values: new object[] { 1, 1, "Konohagakure, Hidden In The Leaf" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CountryID", "Name" },
                values: new object[] { 2, 2, "Sunagakure, Hidden In The Sand" });

            migrationBuilder.AddForeignKey(
                name: "FK_People_City_CityId",
                table: "People",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_City_CityId",
                table: "People");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "City");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "City",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "CityId");

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CountryID", "Name" },
                values: new object[] { 1, 1, "Konohagakure, Hidden In The Leaf" });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CountryID", "Name" },
                values: new object[] { 2, 2, "Sunagakure, Hidden In The Sand" });

            migrationBuilder.AddForeignKey(
                name: "FK_People_City_CityId",
                table: "People",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
