using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.MVC.Migrations
{
    public partial class book5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Identity",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Identity",
                table: "Books");
        }
    }
}
