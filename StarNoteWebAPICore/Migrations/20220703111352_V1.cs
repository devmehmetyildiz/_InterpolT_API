using Microsoft.EntityFrameworkCore.Migrations;

namespace StarNoteWebAPICore.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "Lowerid",
            //    table: "tbl_joborder",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddColumn<double>(
            //    name: "Notergideri",
            //    table: "tbl_customerorder",
            //    type: "double",
            //    nullable: false,
            //    defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Producthistory",
                table: "tbl_customerorder",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specialid",
                table: "tbl_customerorder",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lowerid",
                table: "tbl_joborder");

            migrationBuilder.DropColumn(
                name: "Notergideri",
                table: "tbl_customerorder");

            migrationBuilder.DropColumn(
                name: "Producthistory",
                table: "tbl_customerorder");

            migrationBuilder.DropColumn(
                name: "Specialid",
                table: "tbl_customerorder");
        }
    }
}
