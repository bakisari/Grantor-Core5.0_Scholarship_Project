using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class migration_donor_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DonorPassword",
                table: "Donors",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "DonorMail",
                table: "Donors",
                newName: "Mail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Donors",
                newName: "DonorPassword");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Donors",
                newName: "DonorMail");
        }
    }
}
