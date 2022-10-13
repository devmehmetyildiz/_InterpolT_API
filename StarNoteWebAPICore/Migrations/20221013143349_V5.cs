using Microsoft.EntityFrameworkCore.Migrations;

namespace StarNoteWebAPICore.Migrations
{
    public partial class V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mailusers",
                table: "tbl_reportsettings",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mailusers",
                table: "tbl_reportsettings");
        }
    }
}
