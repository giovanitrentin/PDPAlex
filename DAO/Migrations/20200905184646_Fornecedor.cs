using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class Fornecedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "fornecedor",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nomeFantasia = table.Column<string>(nullable: true),
                    cNPJ = table.Column<string>(nullable: true),
                    endereço = table.Column<string>(nullable: true),
                    cidade = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true),
                    cricao = table.Column<DateTime>(nullable: false),
                    ultimaAlteracao = table.Column<DateTime>(nullable: false),
                    exclusao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "fornecedor");
        }
    }
}
