using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class new56 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Addressshow",
                table: "Tbl_Inforeps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Clerkshow",
                table: "Tbl_Inforeps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneHomeshow",
                table: "Tbl_Inforeps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Phoneshow",
                table: "Tbl_Inforeps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Postalcodeshow",
                table: "Tbl_Inforeps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "codshow",
                table: "Tbl_Inforeps",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "photosshow",
                table: "Tbl_Inforeps",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Addressshow",
                table: "Tbl_Inforeps");

            migrationBuilder.DropColumn(
                name: "Clerkshow",
                table: "Tbl_Inforeps");

            migrationBuilder.DropColumn(
                name: "PhoneHomeshow",
                table: "Tbl_Inforeps");

            migrationBuilder.DropColumn(
                name: "Phoneshow",
                table: "Tbl_Inforeps");

            migrationBuilder.DropColumn(
                name: "Postalcodeshow",
                table: "Tbl_Inforeps");

            migrationBuilder.DropColumn(
                name: "codshow",
                table: "Tbl_Inforeps");

            migrationBuilder.DropColumn(
                name: "photosshow",
                table: "Tbl_Inforeps");
        }
    }
}
