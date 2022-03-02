using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class mig_delete_information : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentInformations");

            migrationBuilder.AddColumn<string>(
                name: "FamilyDeathStatus",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyMaritalStatus",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FamilyWorkStatus",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhyscialDisability",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FamilyDeathStatus",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FamilyMaritalStatus",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FamilyWorkStatus",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PhyscialDisability",
                table: "Students");

            migrationBuilder.CreateTable(
                name: "StudentInformations",
                columns: table => new
                {
                    InformationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FamilyDeathStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyMaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FamilyWorkStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true),
                    PhyscialDisability = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentInformations", x => x.InformationID);
                    table.ForeignKey(
                        name: "FK_StudentInformations_Students_ID",
                        column: x => x.ID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentInformations_ID",
                table: "StudentInformations",
                column: "ID",
                unique: true,
                filter: "[ID] IS NOT NULL");
        }
    }
}
