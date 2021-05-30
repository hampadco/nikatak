using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class frtb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_pays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(nullable: true),
                    NameFamily = table.Column<string>(nullable: true),
                    Pay = table.Column<int>(nullable: false),
                    Harvest = table.Column<int>(nullable: false),
                    Paytime = table.Column<DateTime>(nullable: false),
                    havesttime = table.Column<DateTime>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    iduser = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_pays", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_pays");
        }
    }
}
