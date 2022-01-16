using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAcessLayer.Migrations
{
    public partial class mig_nullableclass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Cities_CityID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Universities_UniversityID",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "UniversityID",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CityID",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Cities_CityID",
                table: "Students",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Universities_UniversityID",
                table: "Students",
                column: "UniversityID",
                principalTable: "Universities",
                principalColumn: "UniversityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Cities_CityID",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Universities_UniversityID",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "UniversityID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Cities_CityID",
                table: "Students",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Universities_UniversityID",
                table: "Students",
                column: "UniversityID",
                principalTable: "Universities",
                principalColumn: "UniversityID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
