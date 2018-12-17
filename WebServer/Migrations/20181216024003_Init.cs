using Microsoft.EntityFrameworkCore.Migrations;

namespace WebServer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
