using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class datetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paytime",
                table: "Tbl_pays");

            migrationBuilder.DropColumn(
                name: "havesttime",
                table: "Tbl_pays");

            migrationBuilder.DropColumn(
                name: "iduser",
                table: "Tbl_pays");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Tbl_pays",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RequestId",
                table: "Tbl_pays",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Tbl_pays");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "Tbl_pays");

            migrationBuilder.AddColumn<DateTime>(
                name: "Paytime",
                table: "Tbl_pays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "havesttime",
                table: "Tbl_pays",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "iduser",
                table: "Tbl_pays",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
