using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateRegister",
                table: "Tbl_infos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Tbl_Bimehs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartMashin1 = table.Column<string>(nullable: true),
                    CartMashin2 = table.Column<string>(nullable: true),
                    BimehNameh = table.Column<string>(nullable: true),
                    GhovahiNameh1 = table.Column<string>(nullable: true),
                    GhovahiNameh2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Bimehs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Bimehs");

            migrationBuilder.DropColumn(
                name: "DateRegister",
                table: "Tbl_infos");
        }
    }
}
