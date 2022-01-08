using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Activties",
                table: "Activties");

            migrationBuilder.RenameTable(
                name: "Activties",
                newName: "Activities");

            migrationBuilder.RenameColumn(
                name: "Veune",
                table: "Activities",
                newName: "Venue");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activities",
                table: "Activities",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Activities",
                table: "Activities");

            migrationBuilder.RenameTable(
                name: "Activities",
                newName: "Activties");

            migrationBuilder.RenameColumn(
                name: "Venue",
                table: "Activties",
                newName: "Veune");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activties",
                table: "Activties",
                column: "Id");
        }
    }
}
