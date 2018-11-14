using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreContactos.Data.Migrations
{
    public partial class table_newClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Contacts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Contacts");
        }
    }
}
