using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class migation_add_roletables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "Donors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoleID",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_RoleID",
                table: "Students",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Donors_RoleID",
                table: "Donors",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_RoleID",
                table: "Admins",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Roles_RoleID",
                table: "Admins",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donors_Roles_RoleID",
                table: "Donors",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Roles_RoleID",
                table: "Students",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Roles_RoleID",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Donors_Roles_RoleID",
                table: "Donors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Roles_RoleID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_RoleID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Donors_RoleID",
                table: "Donors");

            migrationBuilder.DropIndex(
                name: "IX_Admins_RoleID",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Donors");

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "Admins");
        }
    }
}
