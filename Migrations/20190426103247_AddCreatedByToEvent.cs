using Microsoft.EntityFrameworkCore.Migrations;

namespace authb2cweb.Migrations
{
    public partial class AddCreatedByToEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Event",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Event");
        }
    }
}
