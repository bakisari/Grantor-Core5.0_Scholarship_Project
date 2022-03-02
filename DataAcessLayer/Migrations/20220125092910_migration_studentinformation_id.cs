using Microsoft.EntityFrameworkCore.Migrations;


namespace DataAcessLayer.Migrations
{
    public partial class migration_studentinformation_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "StudentInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ID",
                table: "StudentInformations");
        }
    }
}
