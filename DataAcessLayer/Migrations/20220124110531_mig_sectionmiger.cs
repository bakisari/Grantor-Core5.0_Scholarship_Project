using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class mig_sectionmiger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Faculties_FacultyID",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Section_SectionID",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section",
                table: "Section");

            migrationBuilder.RenameTable(
                name: "Section",
                newName: "Sections");

            migrationBuilder.RenameIndex(
                name: "IX_Section_FacultyID",
                table: "Sections",
                newName: "IX_Sections_FacultyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sections",
                table: "Sections",
                column: "SectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Faculties_FacultyID",
                table: "Sections",
                column: "FacultyID",
                principalTable: "Faculties",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Sections_SectionID",
                table: "Students",
                column: "SectionID",
                principalTable: "Sections",
                principalColumn: "SectionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Faculties_FacultyID",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Sections_SectionID",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sections",
                table: "Sections");

            migrationBuilder.RenameTable(
                name: "Sections",
                newName: "Section");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_FacultyID",
                table: "Section",
                newName: "IX_Section_FacultyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section",
                table: "Section",
                column: "SectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Faculties_FacultyID",
                table: "Section",
                column: "FacultyID",
                principalTable: "Faculties",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Section_SectionID",
                table: "Students",
                column: "SectionID",
                principalTable: "Section",
                principalColumn: "SectionID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
