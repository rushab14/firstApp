using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TESTDAL.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildKEY",
                table: "Parents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChildKEY",
                table: "Parents",
                type: "int",
                nullable: true);
        }
    }
}
