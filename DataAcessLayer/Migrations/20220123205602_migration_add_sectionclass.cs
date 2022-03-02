using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class migration_add_sectionclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacultyUniversity");

            migrationBuilder.AddColumn<int>(
                name: "UniversityID",
                table: "Faculties",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    SectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacultyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.SectionID);
                    table.ForeignKey(
                        name: "FK_Section_Faculties_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "Faculties",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faculties_UniversityID",
                table: "Faculties",
                column: "UniversityID");

            migrationBuilder.CreateIndex(
                name: "IX_Section_FacultyID",
                table: "Section",
                column: "FacultyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculties_Universities_UniversityID",
                table: "Faculties",
                column: "UniversityID",
                principalTable: "Universities",
                principalColumn: "UniversityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Faculties_Universities_UniversityID",
                table: "Faculties");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropIndex(
                name: "IX_Faculties_UniversityID",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "UniversityID",
                table: "Faculties");

            migrationBuilder.CreateTable(
                name: "FacultyUniversity",
                columns: table => new
                {
                    FacultiesFacultyID = table.Column<int>(type: "int", nullable: false),
                    UniversitiesUniversityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultyUniversity", x => new { x.FacultiesFacultyID, x.UniversitiesUniversityID });
                    table.ForeignKey(
                        name: "FK_FacultyUniversity_Faculties_FacultiesFacultyID",
                        column: x => x.FacultiesFacultyID,
                        principalTable: "Faculties",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacultyUniversity_Universities_UniversitiesUniversityID",
                        column: x => x.UniversitiesUniversityID,
                        principalTable: "Universities",
                        principalColumn: "UniversityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FacultyUniversity_UniversitiesUniversityID",
                table: "FacultyUniversity",
                column: "UniversitiesUniversityID");
        }
    }
}
