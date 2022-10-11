using Microsoft.EntityFrameworkCore.Migrations;

namespace StarNoteWebAPICore.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Eposta",
                table: "tbl_company",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tckimlik",
                table: "tbl_company",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "tbl_company",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "İlçe",
                table: "tbl_company",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "İsim",
                table: "tbl_company",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Şehir",
                table: "tbl_company",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Eposta",
                table: "tbl_company");

            migrationBuilder.DropColumn(
                name: "Tckimlik",
                table: "tbl_company");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "tbl_company");

            migrationBuilder.DropColumn(
                name: "İlçe",
                table: "tbl_company");

            migrationBuilder.DropColumn(
                name: "İsim",
                table: "tbl_company");

            migrationBuilder.DropColumn(
                name: "Şehir",
                table: "tbl_company");
        }
    }
}
