using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class migration_studentinformation_addstu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentInformations_StudentInformationInformationID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentInformationInformationID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "InformationID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentInformationInformationID",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "StudentInformations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentInformations_ID",
                table: "StudentInformations",
                column: "ID",
                unique: true,
                filter: "[ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentInformations_Students_ID",
                table: "StudentInformations",
                column: "ID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentInformations_Students_ID",
                table: "StudentInformations");

            migrationBuilder.DropIndex(
                name: "IX_StudentInformations_ID",
                table: "StudentInformations");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "StudentInformations");

            migrationBuilder.AddColumn<int>(
                name: "InformationID",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentInformationInformationID",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentInformationInformationID",
                table: "Students",
                column: "StudentInformationInformationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentInformations_StudentInformationInformationID",
                table: "Students",
                column: "StudentInformationInformationID",
                principalTable: "StudentInformations",
                principalColumn: "InformationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
