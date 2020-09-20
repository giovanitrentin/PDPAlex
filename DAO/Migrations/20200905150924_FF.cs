using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class FF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "apelido",
                table: "usuarios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "apelido",
                table: "usuarios");
        }
    }
}
