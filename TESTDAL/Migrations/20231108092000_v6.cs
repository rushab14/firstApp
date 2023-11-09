using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TESTDAL.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToOne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelatedToOneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToOne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToOne_Ones_RelatedToOneId",
                        column: x => x.RelatedToOneId,
                        principalTable: "Ones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToOne_RelatedToOneId",
                table: "ToOne",
                column: "RelatedToOneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToOne");

            migrationBuilder.DropTable(
                name: "Ones");
        }
    }
}
