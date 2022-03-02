using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class migration_studentinformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "StudentInformations",
                columns: table => new
                {
                    InformationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FamilyMaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyDeathStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyWorkStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhyscialDisability = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInformations", x => x.InformationID);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentInformations_StudentInformationInformationID",
                table: "Students");

            migrationBuilder.DropTable(
                name: "StudentInformations");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentInformationInformationID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "InformationID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentInformationInformationID",
                table: "Students");
        }
    }
}
