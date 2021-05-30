using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class datetime2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameFamily",
                table: "Tbl_pays");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Tbl_pays");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Tbl_pays",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Tbl_pays");

            migrationBuilder.AddColumn<string>(
                name: "NameFamily",
                table: "Tbl_pays",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Tbl_pays",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
