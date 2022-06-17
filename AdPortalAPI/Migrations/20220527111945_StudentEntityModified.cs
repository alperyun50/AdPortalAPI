using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdPortalAPI.Migrations
{
    public partial class StudentEntityModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateofBirth",
                table: "Students",
                newName: "DateOfBirth");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Students",
                newName: "DateofBirth");
        }
    }
}
