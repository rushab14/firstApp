using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TESTDAL.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ToManys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToManys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ManyToMany",
                columns: table => new
                {
                    manysId = table.Column<int>(type: "int", nullable: false),
                    toManiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManyToMany", x => new { x.manysId, x.toManiesId });
                    table.ForeignKey(
                        name: "FK_ManyToMany_Manys_manysId",
                        column: x => x.manysId,
                        principalTable: "Manys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManyToMany_ToManys_toManiesId",
                        column: x => x.toManiesId,
                        principalTable: "ToManys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ManyToMany_toManiesId",
                table: "ManyToMany",
                column: "toManiesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ManyToMany");

            migrationBuilder.DropTable(
                name: "Manys");

            migrationBuilder.DropTable(
                name: "ToManys");
        }
    }
}
