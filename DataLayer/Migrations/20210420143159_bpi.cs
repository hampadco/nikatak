using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class bpi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_User",
                table: "Tbl_Requests");

            migrationBuilder.AddColumn<string>(
                name: "Bill_Id",
                table: "Tbl_Requests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pay_Id",
                table: "Tbl_Requests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Tbl_Requests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bill_Id",
                table: "Tbl_Requests");

            migrationBuilder.DropColumn(
                name: "Pay_Id",
                table: "Tbl_Requests");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Tbl_Requests");

            migrationBuilder.AddColumn<int>(
                name: "Id_User",
                table: "Tbl_Requests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
