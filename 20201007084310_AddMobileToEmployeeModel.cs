using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeMgt.Migrations
{
    public partial class AddMobileToEmployeeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Mobile",
                table: "Employee",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Employee");
        }
    }
}
