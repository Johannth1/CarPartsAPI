using Microsoft.EntityFrameworkCore.Migrations;

namespace CarPartsAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deler",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    DelerNummer = table.Column<int>(nullable: false),
                    Hylle = table.Column<char>(nullable: false),
                    Rad = table.Column<int>(nullable: false),
                    Antall = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deler", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deler");
        }
    }
}
