using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace StarNoteWebAPICore.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_reportsettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    Reportname = table.Column<string>(type: "text", nullable: true),
                    Reportid = table.Column<int>(type: "int", nullable: false),
                    Reporttypename = table.Column<string>(type: "text", nullable: true),
                    Reporttype = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Lastsendtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedUser = table.Column<string>(type: "text", nullable: true),
                    UpdatedUser = table.Column<string>(type: "text", nullable: true),
                    DeleteUser = table.Column<string>(type: "text", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Updatetime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deletetime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_reportsettings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_reportsettings");
        }
    }
}
