using Microsoft.EntityFrameworkCore.Migrations;

namespace GaziWeb.Data.Migrations
{
    public partial class addedExp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Explanation",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Explanation",
                table: "Movies");
        }
    }
}
