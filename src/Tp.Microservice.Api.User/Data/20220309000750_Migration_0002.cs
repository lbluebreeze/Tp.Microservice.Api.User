using Microsoft.EntityFrameworkCore.Migrations;

namespace Tp.Microservice.Api.User.Data
{
    public partial class Migration_0002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Usuario",
                type: "varchar(32)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Usuario");
        }
    }
}
