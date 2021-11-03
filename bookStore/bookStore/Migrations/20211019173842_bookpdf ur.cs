using Microsoft.EntityFrameworkCore.Migrations;

namespace bookStore.Migrations
{
    public partial class bookpdfur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookUrl",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookUrl",
                table: "Books");
        }
    }
}
