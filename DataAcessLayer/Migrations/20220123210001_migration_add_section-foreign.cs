using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class migration_add_sectionforeign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionID",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_SectionID",
                table: "Students",
                column: "SectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Section_SectionID",
                table: "Students",
                column: "SectionID",
                principalTable: "Section",
                principalColumn: "SectionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Section_SectionID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SectionID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SectionID",
                table: "Students");
        }
    }
}
