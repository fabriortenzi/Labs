using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "especialidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_especialidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "planes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Anio = table.Column<int>(type: "INTEGER", nullable: false),
                    EspecialidadId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_planes_especialidades_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "especialidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "materias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    HsSemanales = table.Column<int>(type: "INTEGER", nullable: false),
                    HsTotales = table.Column<int>(type: "INTEGER", nullable: false),
                    PlanId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_materias_planes_PlanId",
                        column: x => x.PlanId,
                        principalTable: "planes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_materias_PlanId",
                table: "materias",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_planes_EspecialidadId",
                table: "planes",
                column: "EspecialidadId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "materias");

            migrationBuilder.DropTable(
                name: "planes");

            migrationBuilder.DropTable(
                name: "especialidades");
        }
    }
}
