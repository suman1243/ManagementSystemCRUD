using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagementSystemCRUD.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Course = table.Column<string>(type: "varchar(200)", nullable: false),
                    Stream = table.Column<string>(type: "varchar(200)", nullable: false),
                    MobileNo = table.Column<string>(type: "varchar(50)", nullable: true),
                    Address = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
