using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock_Master_DataAccess.Migrations
{
    public partial class m2deletTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table_1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table_1",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    test = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                });
        }
    }
}
